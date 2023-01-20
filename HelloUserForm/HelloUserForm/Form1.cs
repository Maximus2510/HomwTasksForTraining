using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibForFramework;

namespace HelloUserForm
{
    public partial class Form1 : Form
    {

        public string name = "";
        DateTime currentTime = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string resultStr = Concatenation.Concatenate($"{currentTime.ToString()}: ", "Hello, ", $"{name}");
            MessageBox.Show($"Hello, {name}");
            MessageBox.Show(resultStr);
        }
    }
}
