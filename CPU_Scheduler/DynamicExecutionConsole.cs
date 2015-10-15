using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_Scheduler
{
    public partial class DynamicExecutionConsole : Form
    {

        private Form1 _mainForm;

        public Form1 mainForm
        {
            set
            {
                _mainForm = value;
            }
        }

        public DynamicExecutionConsole()
        {
            InitializeComponent();
        }

       
        private void execTimeLabelVar_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void CPUclock_Tick(object sender, EventArgs e)
        {

        }


    }
}
