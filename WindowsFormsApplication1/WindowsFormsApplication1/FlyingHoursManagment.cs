using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FlyingHoursManagment  : MetroFramework.Forms.MetroForm
    {
        public FlyingHoursManagment()
        {
            InitializeComponent();
        }

        private void FlyingHoursManagment_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Home obj = new Home();
            obj.Show();
        }
    }
}
