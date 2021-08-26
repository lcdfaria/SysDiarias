using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace SysDiarias
{
    [RunInstaller(true)]
    public partial class SysDiarias : System.Configuration.Install.Installer
    {
        public SysDiarias()
        {
            InitializeComponent();
        }
    }
}
