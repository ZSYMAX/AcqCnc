using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;


namespace Jqs
{
    [RunInstaller(true)]
    public class ServiceInstaller : Installer
    {

        private System.ComponentModel.IContainer components = null;

        private System.ServiceProcess.ServiceProcessInstaller spi;

        private System.ServiceProcess.ServiceInstaller si;

        public ServiceInstaller()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.spi = new System.ServiceProcess.ServiceProcessInstaller();
            this.si = new System.ServiceProcess.ServiceInstaller();
            // 
            // spi
            // 
            this.spi.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.spi.Password = null;
            this.spi.Username = null;
            // 
            // si
            // 
            this.si.ServiceName = "CNC Acquisition SService";
            this.si.Description = "����֧��focasЭ���CNC���������ݲɼ�����";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
                this.spi,
                this.si}
            );

        }
    }
}