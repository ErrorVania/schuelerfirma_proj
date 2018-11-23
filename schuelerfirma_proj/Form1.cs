using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Threading;

namespace schuelerfirma_proj
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            data.download_pricelist();
            data.processpricelist();
            for (int i = 0; i < data.products.Length; i++)
            {
                if (data.products != null) { comboBox1.Items.Add(data.products[i]); }
            }
            DateTime dateTime = DateTime.Today;
            textBoxDate.Text = dateTime.ToString("dd/MM/yyyy");
            if (File.Exists(data.xmlpath)) { xml_listview.write(listView1, data.xmlpath); }
            listView1.View = View.Details;
            listView1.Columns.Add("Datum", 105);
            listView1.Columns.Add("Produkt", 105);
            listView1.Columns.Add("Preis", 105);
            listView1.Columns.Add("Anzahl", 105);
            listView1.Columns.Add("Einnahmen", 105);
            comboBox1.MaxDropDownItems = data.products.Length;

            textBoxeintrag.ReadOnly = true;
            textBoxgesamt.ReadOnly = true;
            anzahl.Maximum = 100;
            Refr(textBoxeintrag,textBoxgesamt);

        }

        private void Refr(TextBox textBoxeintrag, TextBox textBoxgesamt)
        {
            textBoxeintrag.Text = listView1.Items.Count.ToString();

            double aaaaa = 0;
            foreach (ListViewItem lstItem in listView1.Items)
            {
                string a = lstItem.SubItems[4].Text.Replace('€', ' ');
                double a1 = double.Parse(a);
                aaaaa = aaaaa + a1;
            }
            textBoxgesamt.Text = aaaaa.ToString() + "€";
        }

        private void button1fertig_Click(object sender, EventArgs e)
        {
            string[] A = { textBoxDate.Text, data.products[comboBox1.SelectedIndex], textBox1price.Text, anzahl.Value.ToString(), textBox1einnahmen.Text };
            var listViewItem = new ListViewItem(A);
            listView1.Items.Add(listViewItem);
            xml_listview.Save(listView1, data.xmlpath);
            listView1.Items.Clear();
            xml_listview.write(listView1, data.xmlpath);
            listView1.Items[listView1.Items.Count - 1].EnsureVisible();
            Refr(textBoxeintrag, textBoxgesamt);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try { listView1.SelectedItems[0].Remove(); } catch (Exception ex) { ex.ToString(); } 
            xml_listview.Save(listView1, data.xmlpath);
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectAll();
            textBox1price.Text = data.prices[comboBox1.SelectedIndex].ToString() + "€";
            Refr(textBoxeintrag, textBoxgesamt); //just in case
        }
        private void anzahl_ValueChanged(object sender, EventArgs e)
        {
            var price = (double)anzahl.Value * data.prices[comboBox1.SelectedIndex];
            textBox1einnahmen.Text = price.ToString() + "€";
        }
        private void TextBox1price_TextChanged(object sender, EventArgs e)
        {
            var price = (double)anzahl.Value * data.prices[comboBox1.SelectedIndex];
            textBox1einnahmen.Text = price.ToString() + "€";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bist du dir sicher?", "Alles löschen", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                listView1.Clear();
                File.Delete(data.xmlpath);
            }
        }

        private void resizeend(object sender, EventArgs e)
        {
            this.Size = new Size(534, 635);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}