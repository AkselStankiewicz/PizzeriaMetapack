namespace Pizzeria2
{
    partial class Form2
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components2 = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components2 != null))
            {
                components2.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemname = new System.Windows.Forms.Label();
            this.ser = new System.Windows.Forms.CheckBox();
            this.salami = new System.Windows.Forms.CheckBox();
            this.szynka = new System.Windows.Forms.CheckBox();
            this.pieczarki = new System.Windows.Forms.CheckBox();
            this.price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ingrediences = new System.Windows.Forms.TextBox();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.bar = new System.Windows.Forms.CheckBox();
            this.sosy = new System.Windows.Forms.CheckBox();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemname
            // 
            this.itemname.AutoSize = true;
            this.itemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.itemname.Location = new System.Drawing.Point(9, 9);
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(86, 31);
            this.itemname.TabIndex = 0;
            this.itemname.Text = "label1";
            // 
            // ser
            // 
            this.ser.AutoSize = true;
            this.ser.Location = new System.Drawing.Point(138, 69);
            this.ser.Name = "ser";
            this.ser.Size = new System.Drawing.Size(88, 17);
            this.ser.TabIndex = 1;
            this.ser.Text = "podwójny ser";
            this.ser.UseVisualStyleBackColor = true;
            this.ser.CheckedChanged += new System.EventHandler(this.ser_CheckedChanged);
            // 
            // salami
            // 
            this.salami.AutoSize = true;
            this.salami.Location = new System.Drawing.Point(138, 92);
            this.salami.Name = "salami";
            this.salami.Size = new System.Drawing.Size(61, 17);
            this.salami.TabIndex = 1;
            this.salami.Text = "+salami";
            this.salami.UseVisualStyleBackColor = true;
            this.salami.CheckedChanged += new System.EventHandler(this.salami_CheckedChanged);
            // 
            // szynka
            // 
            this.szynka.AutoSize = true;
            this.szynka.Location = new System.Drawing.Point(228, 69);
            this.szynka.Name = "szynka";
            this.szynka.Size = new System.Drawing.Size(65, 17);
            this.szynka.TabIndex = 1;
            this.szynka.Text = "+szynka";
            this.szynka.UseVisualStyleBackColor = true;
            this.szynka.CheckedChanged += new System.EventHandler(this.szynka_CheckedChanged);
            // 
            // pieczarki
            // 
            this.pieczarki.AutoSize = true;
            this.pieczarki.Location = new System.Drawing.Point(228, 92);
            this.pieczarki.Name = "pieczarki";
            this.pieczarki.Size = new System.Drawing.Size(74, 17);
            this.pieczarki.TabIndex = 1;
            this.pieczarki.Text = "+pieczarki";
            this.pieczarki.UseVisualStyleBackColor = true;
            this.pieczarki.CheckedChanged += new System.EventHandler(this.pieczarki_CheckedChanged);
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.price.HideSelection = false;
            this.price.Location = new System.Drawing.Point(12, 134);
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.price.Size = new System.Drawing.Size(61, 30);
            this.price.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(79, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "zł";
            // 
            // ingrediences
            // 
            this.ingrediences.Location = new System.Drawing.Point(12, 46);
            this.ingrediences.Multiline = true;
            this.ingrediences.Name = "ingrediences";
            this.ingrediences.ReadOnly = true;
            this.ingrediences.Size = new System.Drawing.Size(120, 82);
            this.ingrediences.TabIndex = 4;
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(116, 141);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(18, 23);
            this.minus.TabIndex = 5;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(175, 141);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(18, 23);
            this.plus.TabIndex = 5;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ilość";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(138, 144);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(32, 20);
            this.quantity.TabIndex = 7;
            this.quantity.Text = "1";
            // 
            // bar
            // 
            this.bar.AutoSize = true;
            this.bar.Location = new System.Drawing.Point(299, 69);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(93, 17);
            this.bar.TabIndex = 1;
            this.bar.Text = "bar sałatkowy";
            this.bar.UseVisualStyleBackColor = true;
            this.bar.CheckedChanged += new System.EventHandler(this.bar_CheckedChanged);
            // 
            // sosy
            // 
            this.sosy.AutoSize = true;
            this.sosy.Location = new System.Drawing.Point(299, 92);
            this.sosy.Name = "sosy";
            this.sosy.Size = new System.Drawing.Size(92, 17);
            this.sosy.TabIndex = 1;
            this.sosy.Text = "zestaw sosów";
            this.sosy.UseVisualStyleBackColor = true;
            this.sosy.CheckedChanged += new System.EventHandler(this.sosy_CheckedChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(316, 144);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 8;
            this.add.Text = "Dodaj";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(404, 173);
            this.Controls.Add(this.add);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.ingrediences);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.price);
            this.Controls.Add(this.sosy);
            this.Controls.Add(this.pieczarki);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.szynka);
            this.Controls.Add(this.salami);
            this.Controls.Add(this.ser);
            this.Controls.Add(this.itemname);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label itemname;
        private System.Windows.Forms.CheckBox ser;
        private System.Windows.Forms.CheckBox salami;
        private System.Windows.Forms.CheckBox szynka;
        private System.Windows.Forms.CheckBox pieczarki;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ingrediences;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.CheckBox bar;
        private System.Windows.Forms.CheckBox sosy;
        private System.Windows.Forms.Button add;
    }
}

