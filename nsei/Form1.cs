using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nsei
{
    public partial class Somar : Form
    {
        Somando s = new Somando();
        public Somar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s.numero1 = int.Parse(textValor1.Text);
            s.numero2 = int.Parse(textValor2.Text);
            textResultado.Text = s.Calculo().ToString();
        }
    }
}
