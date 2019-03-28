using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorQueue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Colors = new Queue<Color>();
            Colors.Enqueue(Color.Red);
            Colors.Enqueue(Color.Blue);
            Colors.Enqueue(Color.Pink);
            Colors.Enqueue(Color.Purple);
            Colors.Enqueue(Color.Green);
            Colors.Enqueue(Color.Yellow);
        }
        public Queue<Color> Colors { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            var c = Colors.Dequeue();
            Colors.Enqueue(c);
            Form1_Load(null, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var index = 0;
            foreach (var ctrl in this.Controls)
            {
                if (ctrl is Panel)
                {
                    (ctrl as Panel).BackColor = Colors.ToList()[index]; // Tüm IEnumerable nesneler temelde list olabilir.
                    index++;
                }
            }
        }
    }
    
}

