using System.ServiceProcess;

namespace NekoWinService
{
    public partial class NekoWinService : ServiceBase
    {
        const int interval = 1000;  //타이머 간격
        System.Timers.Timer t;      //타이머


        public NekoWinService()
        {
            InitializeComponent();

            t = new System.Timers.Timer(interval);
            t.Elapsed += T_Elapsed;
        }
        protected override void OnStart(string[] args)
        {
            t.Start();
        }

        protected override void OnStop()
        {
            t.Stop();
        }

        //Tic
        private void T_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //타이머 멈추고
            t.Stop();  

            //일처리하고
            DoWork();

            //타이머 재가동
            t.Start();
        }

        private void DoWork()
        {
            //Do anything...!
        }
    }
}
