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
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            SCTManagment obj = new SCTManagment();
            obj.Show();
            this.Hide();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            FlyingHoursManagment obj = new FlyingHoursManagment();
            obj.Show();
            this.Hide();
        }
    }
}
