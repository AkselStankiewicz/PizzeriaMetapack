namespace Pizzeria2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.menu = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ingrediences = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.order = new System.Windows.Forms.ListView();
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Extras = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.adds = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.namebox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pricebox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.ingrediences,
            this.price});
            this.menu.FullRowSelect = true;
            this.menu.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.menu.HideSelection = false;
            this.menu.Location = new System.Drawing.Point(12, 12);
            this.menu.MultiSelect = false;
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(548, 426);
            this.menu.TabIndex = 0;
            this.menu.UseCompatibleStateImageBehavior = false;
            this.menu.View = System.Windows.Forms.View.Details;
            this.menu.SelectedIndexChanged += menu_SelectedIndexChanged;
            // 
            // name
            // 
            this.name.Text = "Danie";
            this.name.Width = 67;
            // 
            // ingrediences
            // 
            this.ingrediences.Text = "Składniki";
            this.ingrediences.Width = 419;
            // 
            // price
            // 
            this.price.Text = "Cena";
            this.price.Width = 51;
            // 
            // order
            // 
            this.order.AutoArrange = false;
            this.order.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Quantity,
            this.Dish,
            this.Extras});
            this.order.FullRowSelect = true;
            this.order.HideSelection = false;
            this.order.Location = new System.Drawing.Point(566, 12);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(533, 239);
            this.order.TabIndex = 0;
            this.order.UseCompatibleStateImageBehavior = false;
            this.order.View = System.Windows.Forms.View.Details;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Danie";
            this.Quantity.Width = 100;
            // 
            // Dish
            // 
            this.Dish.Text = "Cena";
            this.Dish.Width = 102;
            // 
            // Extras
            // 
            this.Extras.Text = "Dodatki";
            this.Extras.Width = 325;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(877, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Zamów";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(566, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cena: ";
            // 
            // adds
            // 
            this.adds.Location = new System.Drawing.Point(566, 319);
            this.adds.MinimumSize = new System.Drawing.Size(222, 50);
            this.adds.Multiline = true;
            this.adds.Name = "adds";
            this.adds.Size = new System.Drawing.Size(533, 76);
            this.adds.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Uwagi do zamówienia:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(956, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 56);
            this.button2.TabIndex = 5;
            this.button2.Text = "Odśwież Zamówienie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(572, 276);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(198, 20);
            this.namebox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adres email:";
            // 
            // pricebox
            // 
            this.pricebox.Location = new System.Drawing.Point(653, 411);
            this.pricebox.Name = "pricebox";
            this.pricebox.ReadOnly = true;
            this.pricebox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pricebox.Size = new System.Drawing.Size(55, 20);
            this.pricebox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(714, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "zł";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pricebox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.order);
            this.Controls.Add(this.menu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView menu;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader ingrediences;
        private System.Windows.Forms.ColumnHeader price;
        public System.Windows.Forms.ListView order;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adds;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Dish;
        private System.Windows.Forms.ColumnHeader Extras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pricebox;
        private System.Windows.Forms.Label label4;
    }
}

