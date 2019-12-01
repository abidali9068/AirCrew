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
    public partial class SCTManagment : MetroFramework.Forms.MetroForm
    {
        public SCTManagment()
        {
            InitializeComponent();
        }

        private void SCTManagment_Load(object sender, EventArgs e)
        {

        }
        private void SCTManagment_FormClosing(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Home obj = new Home();
            obj.Show();
        }

      
    }
}
