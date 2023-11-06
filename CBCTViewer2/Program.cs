using System;
using System.Timers;
using System.Windows.Forms;

namespace CBCTLabeler
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var timer = GetTimer();
            timer.Start();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static System.Timers.Timer GetTimer()
        {
            var aTimer = new System.Timers.Timer(); //初始化定时器
            aTimer.Interval = 5000; // ms
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true; // repeat trigger
            return aTimer;
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            //清理内存
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
