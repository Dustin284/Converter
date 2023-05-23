using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter_Umrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear_text();
            if (textBox1.TextLength == 0) { MessageBox.Show("Bitte gebe eine Zahlen an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else if (double.TryParse(textBox1.Text, out double result)) { CheckSelectedElement();  }
            else { MessageBox.Show("Bitte gebe eine Zahlen an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void CheckSelectedElement()
        {
            // Überprüfe, ob ein Element ausgewählt ist
            if (comboBox1.SelectedIndex != -1)
            {
                // Hole das ausgewählte Element
                string selectedElement = comboBox1.SelectedItem.ToString();
                double num1 = Convert.ToDouble(textBox1.Text);

                if (selectedElement == "mp/h") { 
                    String str1 = textBox1.Text + " mp/h";
                    richTextBox1.AppendText(str1); 

                    double mp_h_to_ft_s = (double)1.467; 
                    double mp_h_to_ft_s_result = (double)num1 * mp_h_to_ft_s;
                    String str2 = Math.Round(mp_h_to_ft_s_result, 2) + " ft/s";
                    richTextBox2.AppendText(str2);


                    double mp_h_to_m_s = (double)2.237;
                    double mp_h_to_m_s_result = (double)num1 / mp_h_to_m_s;
                    String str3 = Math.Round(mp_h_to_m_s_result, 2) + " m/s";
                    richTextBox3.AppendText(str3);

                    double mp_h_to_km_h = (double)1.609;
                    double mp_h_to_km_h_result = (double)num1 * mp_h_to_km_h;
                    String str4 = Math.Round(mp_h_to_km_h_result, 3) + " km/h";
                    richTextBox4.AppendText(str4);

                    double mp_h_to_knoten = (double)1.151;
                    double mp_h_to_knoten_result = (double)num1 / mp_h_to_knoten;
                    String str5 = Math.Round(mp_h_to_knoten_result, 3) + " kn";
                    richTextBox5.AppendText(str5);



                }
                else if (selectedElement == "ft/s") {
                    
                    double ft_s_to_m_ph = (double)1.467;
                    double ft_s_to_m_ph_result = (double)num1 / ft_s_to_m_ph;
                    String str1 = Math.Round(ft_s_to_m_ph_result, 2) + " ft/s";
                    richTextBox1.AppendText(str1);

             
                    String str2 = textBox1.Text + " ft/s";
                    richTextBox2.AppendText(str2);


                    double ft_s_to_m_s = (double)3.281;
                    double ft_s_to_m_s_result = (double)num1 / ft_s_to_m_s;
                    String str3 = Math.Round(ft_s_to_m_s_result, 2) + " m/s";
                    richTextBox3.AppendText(str3);

                    double ft_s_to_km_h = (double)1.097;
                    double ft_s_to_km_h_result = (double)num1 * ft_s_to_km_h;
                    String str4 = Math.Round(ft_s_to_km_h_result, 3) + " km/h";
                    richTextBox4.AppendText(str4);

                    double ft_s_to_knoten = (double)1.688;
                    double ft_s_to_knoten_result = (double)num1 / ft_s_to_knoten;
                    String str5 = Math.Round(ft_s_to_knoten_result, 3) + " kn";
                    richTextBox5.AppendText(str5);


                }
                else if (selectedElement == "m/s") {
                   cooming_soon();
                }
                else if (selectedElement == "km/h") { 
                    cooming_soon();
                }
                else if (selectedElement == "kn") { 
                    cooming_soon();
                }
            }
            else
            {
                // Kein Element ausgewählt
                MessageBox.Show("Kein Element ausgewählt.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clear_text()
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();
            richTextBox4.Clear();
            richTextBox5.Clear();
        }

        private void cooming_soon()
        {
            MessageBox.Show("Dieses Feature ist noch nicht verfügbar.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
