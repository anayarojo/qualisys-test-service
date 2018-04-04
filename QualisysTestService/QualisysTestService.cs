using QualisysLog;
using System;
using System.ServiceProcess;

namespace QualisysTestService
{
    partial class QualisysTestService : ServiceBase
    {
        public QualisysTestService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                QsLog.WriteInfo("Servicio Iniciado.");
            }
            catch (Exception lObjException)
            {
                QsLog.WriteException(lObjException);
                base.Stop();
            }
        }

        protected override void OnStop()
        {
            try
            {
                QsLog.WriteInfo("Servicio Detenido.");
            }
            catch (Exception lObjException)
            {
                QsLog.WriteException(lObjException);
            }
        }
    }
}
