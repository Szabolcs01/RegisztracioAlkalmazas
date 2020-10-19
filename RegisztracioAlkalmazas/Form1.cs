using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztracioAlkalmazas
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
   
private void btnHozzaad_Click(object sender, EventArgs e)
        {
            string hobbi = textBoxHobbi.Text;
            if (String.IsNullOrWhiteSpace(hobbi))
            {
                MessageBox.Show("Nincs semmi meg adva");
                textBoxHobbi.Text = " ";
                textBoxHobbi.Focus();
                return;
            }
            if (listBoxLista.Items.Contains(hobbi))
            {
                MessageBox.Show("Ez már szerepel!");
                textBoxHobbi.Text = "";
                textBoxHobbi.Focus();
                return;
            }
           listBoxLista.Items.Add(hobbi.TrimStart().TrimEnd());
            textBoxHobbi.Text = " ";
            textBoxHobbi.Focus();
        }

        private void btnBetoltes_Click(object sender, EventArgs e)
        {
            List<string> toltLista = new List<string>();
            try
            {
                var result = openFileDialog1.ShowDialog();
                if (result != DialogResult.OK)
                {
                    return;
                }
                string fileName = openFileDialog1.FileName;

               
                rbtnFerfi.Checked = true;
                StreamReader sr = new StreamReader(fileName);
                textBoxNev.Text = sr.ReadLine();
                dateTimePicker1.Value = DateTime.Parse(sr.ReadLine());
                if (sr.ReadLine() == "Férfi")
                {
                    rbtnFerfi.Checked = true;
                }
                else
                {
                    rbtnNo.Checked = true;
                }
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    if (sor.StartsWith("Kedvenc: "))
                    {
                        string torolt = sor.Remove(0, 9);
                        listBoxLista.Items.Add(torolt);
                        listBoxLista.SelectedItem = torolt;
                    }
                    else
                    {
                        listBoxLista.Items.Add(sor);
                    }
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba a beolvasás során");
            }
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            try
            {
                var result = saveFileDialog1.ShowDialog();
                if (result != DialogResult.OK)
                {
                    return;
                }
                string fileName = saveFileDialog1.FileName;
                using (var sw = new StreamWriter(fileName))
                {
                    if (!String.IsNullOrWhiteSpace(textBoxNev.Text))
                    {
                        sw.WriteLine(textBoxNev.Text);
                    }
                    else
                    {
                        MessageBox.Show("A név vagy üres vagy csak szóközöket tartalmaz!");
                        textBoxNev.Focus();
                        return;
                    }
                    if (dateTimePicker1.Value < DateTime.Now)
                    {
                        sw.WriteLine(dateTimePicker1.Value.ToString("yyyy/MM/dd"));
                    }
                    else
                    {
                        MessageBox.Show("A születési dátum nem lehet nagyobb a jelenlegi dátumnál!");
                        dateTimePicker1.Focus();
                        return;
                    }
                    if (rbtnFerfi.Checked)
                    {
                        sw.WriteLine("Férfi");
                    }
                    if (rbtnNo.Checked)
                    {
                        sw.WriteLine("Nő");
                    }
                    if (listBoxLista.SelectedIndex >= 0)
                    {
                        int db = 0;
                        foreach (var item in listBoxLista.Items)
                        {
                            if (db == listBoxLista.SelectedIndex)
                            {
                                sw.WriteLine("Kedvenc: " + item);
                                db++;
                            }
                            else
                            {
                                sw.WriteLine(item);
                                db++;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Válasszon ki egy kedvenc hobbit.");
                        listBoxLista.Focus();
                        return;
                    }
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba a mentés során");
            }
        }
    }
    }
