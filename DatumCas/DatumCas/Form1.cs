using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatumCas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int nejstarsi = 0;               
                DateTime Dnes = DateTime.Today;
               
                string name = "";
                                
                for (int i = 0; i < textBox1.Lines.Length; i++) 
                {
                    string[] osoba = textBox1.Lines[i].Split(';');
                    string[] datum = osoba[2].Split('.');

                    DateTime date = new DateTime(int.Parse(datum[2]), int.Parse(datum[1]), int.Parse(datum[0]));
                    TimeSpan interval = Dnes - date;

                    int intrvl = (int)interval.TotalMinutes;

                    if (intrvl == nejstarsi)
                    {
                        name += " a " + osoba[0] + " " + osoba[1];
                        nejstarsi = intrvl;
                    }

                    if (intrvl > nejstarsi)
                    {                       
                        name = osoba[0] + " " + osoba[1];
                        nejstarsi = intrvl;
                    }
                    
                }

                
                label1.Text = "Nejstarší osoba/y: " + name;
            }
            catch(Exception)
            {
                MessageBox.Show("Nezadal jsi správně hodnoty!!!!!!!!!!");
            }

          

        }
    }
}
