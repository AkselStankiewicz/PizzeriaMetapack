using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pizzeria2
{
    public partial class Form2 : Form
    {
        public Form2(string itempos, int orderid)
        {
            InitializeComponent();
            Console.WriteLine(itempos);
            this.itemname.Text = pobierzDane(itempos, "name");
            this.ingrediences.Text = pobierzDane(itempos, "ingrediences");
            this.price.Text = (int.Parse(pobierzDane(itempos, "price"))/100).ToString();
            this.itemprice = int.Parse(pobierzDane(itempos, "price"));
            if(pobierzDane(itempos, "typ") == "pizza")
            {
                this.bar.Enabled = false;
                this.sosy.Enabled = false;
            } else if (pobierzDane(itempos, "typ") == "obiad")
            {
                this.ser.Enabled = false;
                this.pieczarki.Enabled = false;
                this.szynka.Enabled = false;
                this.salami.Enabled = false;
            } else if (pobierzDane(itempos, "typ") == "napój")
            {
                this.ser.Enabled = false;
                this.pieczarki.Enabled = false;
                this.szynka.Enabled = false;
                this.salami.Enabled = false;
                this.bar.Enabled = false;
                this.sosy.Enabled = false;
            }
            else if (pobierzDane(itempos, "typ") == "zupa")
            {
                this.ser.Enabled = false;
                this.pieczarki.Enabled = false;
                this.szynka.Enabled = false;
                this.salami.Enabled = false;
                this.bar.Enabled = false;
                this.sosy.Enabled = false;
            }
            this.orderid = orderid;
        }

        int itemprice;
        int itemquantiy = 1;
        int orderid;

        private static string pobierzDane(string name, string column)
        {
            var pos = "";
            try
            {
                string server = @"SERVER=localhost;PORT=3306;DATABASE=pizzeria;UID=pizzeria;";
                using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(server))
                {
                    MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand("SELECT "+column+" FROM Menu WHERE name LIKE '"+name+"'", connection);
                    connection.Open();
                    using (MySqlDataReader read = command.ExecuteReader())
                    {
                        while (read.Read()) {
                            pos = read[column].ToString(); 
                        }
                        connection.Close();

                    }
                }
            } 
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Błąd."+ex, ex.ToString());
            }
            return pos;
        }


        public string wyslijDane(string adds)
        {
            var pos = "";
            try
            {
                string server = @"SERVER=localhost;PORT=3306;DATABASE=pizzeria;UID=pizzeria;";
                using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(server))
                {
                    MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand("INSERT INTO history (dishes, price, adnotations, order_id) VALUES ('" + this.itemquantiy + "x " + this.itemname.Text + "', '" +this.price.Text + "', '" + adds + "', '"+ this.orderid +"')", connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Błąd." + ex, ex.ToString());
            }
            return pos;
        }

        private void ser_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.ser.Checked)
            {
                this.itemprice -= 200;
                this.price.Text = (this.itemprice * this.itemquantiy / 100).ToString();
            } 
            else
            {
                this.itemprice += 200;
                this.price.Text = (this.itemprice * this.itemquantiy / 100).ToString();
            }
        }

        private void salami_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.salami.Checked)
            {
                this.itemprice -= 200;
                this.price.Text = (this.itemprice * this.itemquantiy / 100).ToString();
            }
            else
            {
                this.itemprice += 200;
                this.price.Text = (this.itemprice * this.itemquantiy / 100).ToString();
            }
        }

        private void szynka_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.szynka.Checked)
            {
                this.itemprice -= 200;
                this.price.Text = (this.itemprice * this.itemquantiy / 100).ToString();
            }
            else
            {
                this.itemprice += 200;
                this.price.Text = (this.itemprice * this.itemquantiy / 100).ToString();
            }
        }

        private void pieczarki_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.pieczarki.Checked)
            {
                this.itemprice -= 200;
                this.price.Text = (this.itemprice * this.itemquantiy / 100).ToString();
            }
            else
            {
                this.itemprice += 200;
                this.price.Text = (this.itemprice * this.itemquantiy / 100).ToString();
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (this.itemquantiy >= 1)
            {
                this.itemquantiy -= 1;
            }
            this.quantity.Text = itemquantiy.ToString();
            this.price.Text = (this.itemprice * this.itemquantiy / 100).ToString();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            this.itemquantiy += 1;
            this.quantity.Text = this.itemquantiy.ToString();
            this.price.Text = (this.itemprice * this.itemquantiy / 100).ToString();
        }

        private void bar_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.bar.Checked)
            {
                this.itemprice -= 500;
                this.price.Text = (this.itemprice * this.itemquantiy / 100).ToString();
            }
            else
            {
                this.itemprice += 500;
                this.price.Text = (this.itemprice * this.itemquantiy / 100).ToString();
            }
        }

        private void sosy_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.sosy.Checked)
            {
                this.itemprice -= 600;
                this.price.Text = (this.itemprice * this.itemquantiy / 100).ToString();
            }
            else
            {
                this.itemprice += 600;
                this.price.Text = (this.itemprice * this.itemquantiy / 100).ToString();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            string adds = "";
            if (this.ser.Checked)
            {
                adds = adds + "podwójny ser, ";
            }
            if (this.pieczarki.Checked)
            {
                adds = adds + "pieczarki, ";
            }
            if (this.salami.Checked)
            {
                adds = adds + "salami, ";
            }
            if (this.szynka.Checked)
            {
                adds = adds + "szynka,";
            }
            if (this.sosy.Checked)
            {
                adds = adds + "zestaw sosów, ";
            }
            if (this.bar.Checked)
            {
                adds = adds + "bar sałatkowy,";
            }
            wyslijDane(adds);
            this.Close();
        }
    }
}
