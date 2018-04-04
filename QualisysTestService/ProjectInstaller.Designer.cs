namespace QualisysTestService
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.QualisysTestProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.QualisysServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // QualisysTestProcessInstaller
            // 
            this.QualisysTestProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.QualisysTestProcessInstaller.Password = null;
            this.QualisysTestProcessInstaller.Username = null;
            // 
            // QualisysServiceInstaller
            // 
            this.QualisysServiceInstaller.Description = "Qualisys Test Service";
            this.QualisysServiceInstaller.DisplayName = "QualisysTestService";
            this.QualisysServiceInstaller.ServiceName = "QualisysTestService";
            this.QualisysServiceInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.QualisysTestProcessInstaller,
            this.QualisysServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller QualisysTestProcessInstaller;
        private System.ServiceProcess.ServiceInstaller QualisysServiceInstaller;
    }
}