using System;
using System.Diagnostics;
using System.ServiceProcess;

namespace access_uac_pass
{
    public partial class Service1 : ServiceBase
    {
        private Process proxyProcess;
        private EventLog eventLog;

        public Service1()
        {
            InitializeComponent();
            // EventLog nesnesini oluştur
            eventLog = new EventLog();
            if (!EventLog.SourceExists("AccessUACPassSource"))
            {
                EventLog.CreateEventSource("AccessUACPassSource", "AccessUACPassLog");
            }
            eventLog.Source = "AccessUACPassSource";
            eventLog.Log = "AccessUACPassLog";
        }

        protected override void OnStart(string[] args)
        {
            eventLog.WriteEntry("Service is starting.");
            StartProxyApplication();
        }

        protected override void OnStop()
        {
            eventLog.WriteEntry("Service is stopping.");
            StopProxyApplication();
        }

        private void StartProxyApplication()
        {
            try
            {
                proxyProcess = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = @"C:\Program Files\Microsoft Office\root\Office16\WINWORD.EXE",
                        UseShellExecute = true, // GUI uygulamaları için true olarak ayarlanmalı
                        Verb = "runas" // Yönetici haklarıyla çalıştırmak için
                    }
                };
                proxyProcess.Start();
                eventLog.WriteEntry("Proxy application started successfully.");
            }
            catch (Exception ex)
            {
                // Hata durumunda loglama yap
                eventLog.WriteEntry("Error starting proxy application: " + ex.Message, EventLogEntryType.Error);
            }
        }

        private void StopProxyApplication()
        {
            if (proxyProcess != null && !proxyProcess.HasExited)
            {
                proxyProcess.Kill();
                proxyProcess.Dispose();
                eventLog.WriteEntry("Proxy application stopped.");
            }
        }
    }
}
