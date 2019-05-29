using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SosigCounter
{
    public partial class Form1 : Form
    {
        int sosigs;
        int hobbys;

        public Form1()
        {
            InitializeComponent();
            sosigs = Properties.Settings.Default.sosig;
            hobbys = Properties.Settings.Default.hobbys;
            updateLabels();
        }

            private void btnAdd_Click(object sender, EventArgs e)
        {
            sosigs = sosigs + 1;
            updateLabels();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            sosigs = sosigs - 1;
            updateLabels();
        }

        private void updateLabels()
        {
            lblSosigCoutner.Text = Convert.ToString(sosigs);
            lblHobbyCounter.Text = Convert.ToString(hobbys);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.hobbys = hobbys;
            Properties.Settings.Default.sosig = sosigs;
            Properties.Settings.Default.Save();
        }

        private void btnSubtractHobby_Click(object sender, EventArgs e)
        {
            hobbys = hobbys - 1;
            updateLabels();
        }

        private void btnAddHobby_Click(object sender, EventArgs e)
        {
            hobbys = hobbys + 1;
            updateLabels();
        }
    }
}
