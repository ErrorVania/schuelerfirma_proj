using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace schuelerfirma_proj
{
    class xml_listview
    {
        public static void Save(ListView listView1, string path)
        {
            var doc = new XDocument(new XElement("Items"));
            foreach (var item in listView1.Items.OfType<ListViewItem>())
            {
                var el = new XElement("Kauf");
                el.SetAttributeValue("Datum", item.SubItems[0].Text);
                el.SetAttributeValue("Produkt", item.SubItems[1].Text);
                el.SetAttributeValue("Preis", item.SubItems[2].Text);
                el.SetAttributeValue("Anzahl", item.SubItems[3].Text);
                el.SetAttributeValue("Einnahmen", item.SubItems[4].Text);
                doc.Root.Add(el);
            }
            doc.Save(path);
        }
        public static void write(ListView listView1, string path)
        {
            try
            {
                foreach (var node in XDocument.Load(path).Root.Elements("Kauf"))
                {
                    var lvi = new ListViewItem(node.Attribute("Datum").Value);
                    lvi.SubItems.Add(node.Attribute("Produkt").Value);
                    lvi.SubItems.Add(node.Attribute("Preis").Value);
                    lvi.SubItems.Add(node.Attribute("Anzahl").Value);
                    lvi.SubItems.Add(node.Attribute("Einnahmen").Value);
                    listView1.Items.Add(lvi);
                }
            }
            catch (Exception ex) { ex.ToString(); }
        }
    }
}
