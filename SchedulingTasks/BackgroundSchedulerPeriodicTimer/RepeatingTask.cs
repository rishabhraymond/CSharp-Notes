namespace BackgroundSchedulerPeriodicTimer
{
    public class RepeatingTask : BackgroundService
    {
        private readonly PeriodicTimer _timer = new(TimeSpan.FromMilliseconds(1000));
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while(await _timer.WaitForNextTickAsync(stoppingToken)
                && !stoppingToken.IsCancellationRequested)
            {
                await DoWork();
            }
        }

        public async Task DoWork()
        {
            Console.WriteLine(DateTime.Now.ToString("o"));
            await Task.Delay(500);
        }
    }
}
