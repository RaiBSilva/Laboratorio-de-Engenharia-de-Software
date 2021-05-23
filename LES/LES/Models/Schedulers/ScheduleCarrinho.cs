﻿using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LES.Models.Schedulers
{
    public class ScheduleCarrinho : IAgendarJob
    {
        private static StdSchedulerFactory schedulerFactory = new StdSchedulerFactory();
        private static IScheduler scheduler { get; set; }

        public ScheduleCarrinho(){
            CriarScheduler();
        }

        private async void CriarScheduler()
        {
            scheduler = await schedulerFactory.GetScheduler();
        }

        public async void CancelaJob(string keyStr)
        {
            IList<string> parametros = keyStr.Split(".");

            JobKey chave = new JobKey(parametros[0], parametros[1]);

            await scheduler.DeleteJob(chave);
        }

        public async void AgendarJob(DateTime dataExecucao, int idCarrinho, string emailCliente)
        {
            IJobDetail job = JobBuilder.Create<ApagaCarrinhoJob>()
                .WithIdentity(idCarrinho.ToString(), emailCliente)
                .Build();

            ISimpleTrigger trigger = (ISimpleTrigger)TriggerBuilder.Create()
            .StartAt(dataExecucao)
            .Build();

            await scheduler.ScheduleJob(job, trigger);

            await scheduler.Start();
        }

    }


    public class ApagaCarrinhoJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            Console.WriteLine("Executou o job.");

            return Task.FromResult(0);
        }
    }

}