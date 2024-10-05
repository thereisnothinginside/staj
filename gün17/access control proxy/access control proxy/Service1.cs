using System;
using System.Diagnostics;
using System.ServiceProcess;

namespace access_control_proxy
{
    public partial class Service1 : ServiceBase
    {
        private EventLog eventLog1;

        public Service1()
        {
            InitializeComponent();

            
            eventLog1 = new EventLog();

            if (!EventLog.SourceExists("MyServiceSource"))
            {
                EventLog.CreateEventSource("MyServiceSource", "MyServiceLog");
            }
            eventLog1.Source = "MyServiceSource";
            eventLog1.Log = "MyServiceLog";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("Hizmet başlatıldı.");
            StartPerkotec();
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("Hizmet durduruldu.");
        }

        private void StartPerkotec()
        {
            try
            {
                
                string perkotecPath = @"C:\Program Files\Microsoft Office\root\Office16\WINWORD.EXE";

                ProcessStartInfo startInfo = new ProcessStartInfo(perkotecPath)
                {
                    UseShellExecute = true,
                    Verb = "runas" 
                };

                Process.Start(startInfo);
                eventLog1.WriteEntry("Perkotec başlatıldı.");
            }
            catch (Exception ex)
            {
                
                eventLog1.WriteEntry("Perkotec başlatılamadı: " + ex.Message);
            }
        }
    }
}
