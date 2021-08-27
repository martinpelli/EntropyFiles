using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Practico1_Ejercicio3_TDI
{
    public partial class Form1 : Form
    {
        double entropy1 = 0;
        double entropy2 = 0;
        double redundancy1 = 1;
        double redundancy2 = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void loadFile1Button_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string path = openFile.FileName;
                if (File.Exists(path))
                {
                    FileInfo file = new FileInfo(path);
                    entropy1 = CalculateEntropy(file);
                    redundancy1 = (1 - entropy1) / 1;
                    MessageBox.Show("Archivo Cargado Correctamente");
                }
            }
        }

        private void loadFile2Button_Click(object sender, EventArgs e)
        {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    string path = openFile.FileName;
                    if (File.Exists(path))
                    {
                        FileInfo file = new FileInfo(path);
                        entropy2 = CalculateEntropy(file);
                        redundancy2 = (1 - entropy2) / 1;
                        MessageBox.Show("Archivo Cargado Correctamente");
                        MessageBox.Show("La entropía del primer archivo es: " + entropy1.ToString() + " y la del segundo es: " + entropy2.ToString());
                        MessageBox.Show("La redundancia del primer archivo es: " + redundancy1.ToString() + " y la del segundo es: " + redundancy2.ToString());

                }

                }
        }

        private double CalculateEntropy(FileInfo file)
        {
            int range = byte.MaxValue + 1; // 0 -> 256
            byte[] values = File.ReadAllBytes(file.FullName);

            long[] counts = new long[range];
            foreach (byte value in values)
            {
                counts[value]++;
            }

            double entropy = 0;
            foreach (long count in counts)
            {
                if (count != 0)
                {
                    double probability = (double)count / values.LongLength;
                    entropy -= probability * Math.Log(probability, range);
                }
            }
            return entropy;
        }
    }
}
