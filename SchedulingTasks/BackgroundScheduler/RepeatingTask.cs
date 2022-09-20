namespace BackgroundScheduler
{
    public class RepeatingTask : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while(!stoppingToken.IsCancellationRequested)
            {
                await DoWork();
                await Task.Delay(1000, stoppingToken);
            }
        }

        public async Task DoWork()
        {
            Console.WriteLine(DateTime.Now.ToString("o"));
            await Task.Delay(500);
        }
    }
}
