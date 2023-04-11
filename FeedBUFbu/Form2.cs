using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedBUFapplicatie
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            panel_taak.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button_weekdoelen_Click(object sender, EventArgs e)
        {
            panel_weekdoelen.Visible = true;
            panel_logboek.Visible = false;
            panel_feedbuf.Visible = false;
            panel_overzicht.Visible = false;
            Text = "Weekdoelen";
        }

        private void button_logboek_Click(object sender, EventArgs e)
        {
            panel_weekdoelen.Visible = false;
            panel_logboek.Visible = true;
            panel_feedbuf.Visible = false;
            panel_overzicht.Visible = false;
            Text = "Logboek";
        }

        private void button_feedbuf_Click(object sender, EventArgs e)
        {
            panel_weekdoelen.Visible = false;
            panel_logboek.Visible = false;
            panel_feedbuf.Visible = true;
            panel_overzicht.Visible = false;
            Text = "FeedBUF";
        }

        private void button_overzicht_Click(object sender, EventArgs e)
        {
            panel_weekdoelen.Visible = false;
            panel_logboek.Visible = false;
            panel_feedbuf.Visible = false;
            panel_overzicht.Visible = true;
            Text = "Overzicht";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel_taak.Visible = true;
        }
    }
}
