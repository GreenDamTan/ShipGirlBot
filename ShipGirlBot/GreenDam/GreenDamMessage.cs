using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShipGirlBot.GreenDam
{
    public partial class GreenDamMessage : Form
    {
        public static string GreenDam_pvpdaylog = "";
        public GreenDamMessage()
        {
            InitializeComponent();
        }

        private void GreenDamMessage_Load(object sender, EventArgs e)
        {
            GreenDam_Messages.Text = GreenDam_pvpdaylog;
        }

        private void GreenDamMessage_close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
