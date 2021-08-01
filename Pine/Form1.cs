using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pine
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task t = new Task("test ", new Vector2(0, 60), false);
            foreach (Control c in t.FormsElements)
            {
                this.Controls.Add(c);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
