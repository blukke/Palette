using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paleta_de_cores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
		void Button4Click(object sender, EventArgs e)
		{
			this.BackColor = Color.Blue;
		}
		void Button1Click(object sender, EventArgs e)
		{
			this.BackColor = Color.Navy;
		}
		void Button3Click(object sender, EventArgs e)
		{
            this.BackColor = Color.LightCyan;
        }
		void Button2Click(object sender, EventArgs e)
		{
            this.BackColor = Color.LightCoral;
        }
    }
}
