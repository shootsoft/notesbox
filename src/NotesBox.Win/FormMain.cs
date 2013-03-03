using NotesBox.Win.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotesBox.Win
{
    public partial class FormMain : Form
    {
        MainController controller;

        public FormMain()
        {
            InitializeComponent();
            
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Show();
            controller = new MainController(this);
        }

        public void Editor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timerInitialize_Tick(object sender, EventArgs e)
        {
            timerInitialize.Enabled = false;
            controller.Initialize();
            
        }

        private void buttonHideNav_Click(object sender, EventArgs e)
        {
            controller.HideNavigation();
        }
    }
}
