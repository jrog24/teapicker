using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace TeaPicker
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RandomTea(string TeaType)
        {
            var teaList = new List<string>();


            using (var teaReader = new StreamReader(TeaType))
            {
                string line;

                while ((line = teaReader.ReadLine()) != null)
                {
                    teaList.Add(line);
                }
            }
            Random rnd = new Random();
            int herbata=rnd.Next(teaList.Count);
            richTextBox1.Text = teaList[herbata];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandomTea("Path to first kind of tea");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RandomTea("Path to second kind of tea");
        }
    }
}
