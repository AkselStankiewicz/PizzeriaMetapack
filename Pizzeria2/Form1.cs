using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pobierzDane("menu").ForEach(o =>
            {
                string[] pos = { o.name, o.ingrediences, (o.price / 100).ToString() };
                this.menu.Items.Add(new ListViewItem(pos));
            });
            this.namebox.Text = "test";
            wyslijDane();
            this.namebox.Text = "";
            orderid = 0;
            pobierzId("allorders").ForEach(o =>
            {
                if (orderid < o)
                {
                    orderid = o;
                }
            });
            orderid++;
        }

        private int orderid;
        private List<OrderEntity> pobierzDane(string table)
        {
            List<OrderEntity> pos = new List<OrderEntity>();
            try
            {
                string server = @"SERVER=localhost;PORT=3306;DATABASE=pizzeria;UID=pizzeria;";
                using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(server))
                {
                    MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM  " + table, connection);

                    connection.Open();
                    using (MySqlDataReader read = command.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            pos.Add(new OrderEntity(int.Parse(read["id"].ToString()), read["name"].ToString(), read["ingrediences"].ToString(),int.Parse(read["price"].ToString())));
                        }
                        connection.Close();

                    }
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Błąd." + ex, ex.ToString());
            }
            return pos;
        }

        private List<int> pobierzId(string table)
        {
            List<int> pos = new List<int>();
            try
            {
                string server = @"SERVER=localhost;PORT=3306;DATABASE=pizzeria;UID=pizzeria;";
                using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(server))
                {
                    MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM  " + table, connection);

                    connection.Open();
                    using (MySqlDataReader read = command.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            pos.Add(int.Parse(read["id"].ToString()));
                        }
                        connection.Close();

                    }
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Błąd." + ex, ex.ToString());
            }
            return pos;
        }

        private List<PosEntity> pobierzZamówienie()
        {
            List<PosEntity> pos = new List<PosEntity>();
            string server = @"SERVER=localhost;PORT=3306;DATABASE=pizzeria;UID=pizzeria;";
            using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(server))
            {
                MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM  history WHERE order_id = " + orderid.ToString(), connection);
                connection.Open();
                using (MySqlDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        pos.Add(new PosEntity(int.Parse(read["id"].ToString()), read["dishes"].ToString(), float.Parse(read["price"].ToString()), read["adnotations"].ToString(), int.Parse(read["order_id"].ToString())));
                    }
                    connection.Close();
                }
            }
            return pos;
        }

        public string wyslijDane()
        {
            var pos = "";
            try
            {
                string server = @"SERVER=localhost;PORT=3306;DATABASE=pizzeria;UID=pizzeria;";
                using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(server))
                {
                    MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand("INSERT INTO allorders (name) VALUES ('" + this.namebox.Text + "')", connection);
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

        private void menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.menu.SelectedItems.Count != 0)
            {
                string itemname = this.menu.SelectedItems[0].Text;
                var popup = new Form2(itemname, orderid);
                popup.Show(this);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            order.Items.Clear();
            int pricetext = 0;
            pobierzZamówienie().ForEach(o =>
            {
                string[] pos = { o.dishes, o.price.ToString(), o.adnotations, o.order_id.ToString() };
                order.Items.Add(new ListViewItem(pos));
                pricetext = int.Parse(pos[1]) + pricetext;
            });
            this.pricebox.Text = pricetext.ToString();
        }

        public System.Net.NetworkCredential smtpCreds = new System.Net.NetworkCredential("akselstankiewicz@gmail.com", "@Wsadeq123");

        private void mailSend()
        {
            string msgzamow = "";
            string msgtext = "";
            var odp = pobierzZamówienie();
            odp.ForEach(o =>
            {
                msgzamow += o.dishes + "(dodatki: " + o.adnotations + ")";
            });
            try
            {
                MailAddress from = new MailAddress("akselstankiewicz@gmail.com", "Pizzeria");
                MailAddress to = new MailAddress(this.namebox.Text);
                
                SmtpClient client = new SmtpClient();
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.UseDefaultCredentials = false;
                client.Credentials = smtpCreds;
                client.EnableSsl = true;
                MailMessage msg;
                msgtext = "Witaj " + this.namebox.Text + "\n Twoje zamówienie: \n" + msgzamow + " \n zostało przekazane do realizacji.";
                msg = new MailMessage();
                msg.From = from;
                msg.To.Add(to);
                msg.Subject = "Zamówienie w Pizzerii";
                msg.Body = msgtext;
                client.Send(msg);
                orderid++;
            }
            catch (Exception e)
            {
                MessageBox.Show( e.ToString() , "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.namebox == null || this.namebox.Text == "")
            {
                MessageBox.Show("Podaj adres email do zamówienia.", "Błąd.");
                return;
            }
            else
            {
                pobierzZamówienie().ForEach(o =>
                {
                    if (o.order_id == this.orderid)
                    {
                        wyslijDane();
                    }
                    mailSend();
                    namebox.Text = "";
                    order.Items.Clear();
                });
            }
        }
    }
}
