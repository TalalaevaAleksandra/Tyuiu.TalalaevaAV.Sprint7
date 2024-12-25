using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.TalalaevaAV.Sprint7.Project.V8.Lib;
namespace Tyuiu.TalalaevaAV.Sprint7.Project.V8
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void buttonOK_TAV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
