namespace schuelerfirma_proj
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBox1price = new System.Windows.Forms.TextBox();
            this.anzahl = new System.Windows.Forms.NumericUpDown();
            this.textBox1einnahmen = new System.Windows.Forms.TextBox();
            this.button1fertig = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.anzahl)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Produkt";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(13, 12);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxDate.TabIndex = 1;
            this.textBoxDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1price
            // 
            this.textBox1price.Location = new System.Drawing.Point(246, 13);
            this.textBox1price.Name = "textBox1price";
            this.textBox1price.ReadOnly = true;
            this.textBox1price.Size = new System.Drawing.Size(100, 20);
            this.textBox1price.TabIndex = 2;
            this.textBox1price.Text = "Preis";
            this.textBox1price.TextChanged += new System.EventHandler(this.TextBox1price_TextChanged);
            // 
            // anzahl
            // 
            this.anzahl.Location = new System.Drawing.Point(352, 14);
            this.anzahl.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.anzahl.Name = "anzahl";
            this.anzahl.Size = new System.Drawing.Size(44, 20);
            this.anzahl.TabIndex = 3;
            this.anzahl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.anzahl.ValueChanged += new System.EventHandler(this.anzahl_ValueChanged);
            // 
            // textBox1einnahmen
            // 
            this.textBox1einnahmen.Location = new System.Drawing.Point(402, 14);
            this.textBox1einnahmen.Name = "textBox1einnahmen";
            this.textBox1einnahmen.ReadOnly = true;
            this.textBox1einnahmen.Size = new System.Drawing.Size(100, 20);
            this.textBox1einnahmen.TabIndex = 4;
            this.textBox1einnahmen.Text = "Einnahmen";
            // 
            // button1fertig
            // 
            this.button1fertig.Location = new System.Drawing.Point(12, 40);
            this.button1fertig.Name = "button1fertig";
            this.button1fertig.Size = new System.Drawing.Size(489, 23);
            this.button1fertig.TabIndex = 5;
            this.button1fertig.Text = "Fertig";
            this.button1fertig.UseVisualStyleBackColor = true;
            this.button1fertig.Click += new System.EventHandler(this.button1fertig_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(13, 69);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(489, 456);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 20);
            this.button1.TabIndex = 7;
            this.button1.Text = "Löschen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 531);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Alles löschen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 563);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1fertig);
            this.Controls.Add(this.textBox1einnahmen);
            this.Controls.Add(this.anzahl);
            this.Controls.Add(this.textBox1price);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Buchhaltung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.resizeend);
            ((System.ComponentModel.ISupportInitialize)(this.anzahl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBox1price;
        private System.Windows.Forms.NumericUpDown anzahl;
        private System.Windows.Forms.TextBox textBox1einnahmen;
        private System.Windows.Forms.Button button1fertig;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

