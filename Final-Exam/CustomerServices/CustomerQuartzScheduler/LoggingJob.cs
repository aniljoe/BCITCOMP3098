using Quartz;
using Quartz.Impl;
using System.Windows.Forms;
using System;
using System.Threading.Tasks;

namespace CustomerQuartzScheduler
{
    public class LoggingJob
    {
        IScheduler scheduler;
        public async void Execute(int minute)
        {
            ISchedulerFactory schedFact = new StdSchedulerFactory();
            scheduler = await schedFact.GetScheduler();

            if (scheduler.IsStarted)
            {
                MessageBox.Show("Scheduler already running");
                return;
            }
            IJobDetail job = JobBuilder.Create<DatabaseBackup>().Build();

            int seconds = minute* 60;

            ITrigger trigger = TriggerBuilder.Create().WithSimpleSchedule(s => s.WithIntervalInSeconds(seconds).RepeatForever())
                               .StartNow()
                               .Build();

            await scheduler.ScheduleJob(job, trigger);
            await scheduler.Start();
            

          


        }

        public void Destroy()
        {

            if (scheduler != null)
            {
                if (!scheduler.IsShutdown)
                {
                    MessageBox.Show("Scheduler is shutdown");
                    scheduler.Shutdown();
                }
                else
                {
                    MessageBox.Show("Scheduler is not started yet");
                }
           
            }




        }



        public class DatabaseBackup : IJob
        {
            public async Task Execute(IJobExecutionContext context)
            {
                MessageBox.Show("Scheduler Started");
                DataAccess dataAccess = new DataAccess();

              
                await Task.Run(() => dataAccess.DeleteCustomers());


            }

            //async Task <bool> IJob.Execute(IJobExecutionContext context)
            //{
            //    MessageBox.Show("Executed");
            //    DataAccess dataAccess = new DataAccess();
            //    await dataAccess.DeleteCustomers();

            //}
        }

    }
}