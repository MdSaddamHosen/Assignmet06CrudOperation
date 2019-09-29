using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopWithOperation
{
    public partial class ItemUi : Form
    {
        public ItemUi()
        {
            InitializeComponent();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            additems();
           
        }
        private void additems()
        {
            try
            {
                string connectserver = @"Server=DESKTOP-Q5FQUO6;Database=CoffeeShop;Integrated Security=True";
                SqlConnection sqlItems = new SqlConnection(connectserver);

                string itemsqurey = @" INSERT INTO  Items(Name,Price) VALUES('" + nameItemTextBox.Text + "'," + priceItemTextBox.Text + ")";
                SqlCommand sqlCommand = new SqlCommand(itemsqurey, sqlItems);
                sqlItems.Open();
                if (!isexitename(nameItemTextBox.Text))
                {

                    int isExcuted = sqlCommand.ExecuteNonQuery();
                    if (isExcuted > 0)
                    {
                        MessageBox.Show("successfully Data added");
                    }
                    else
                    {
                        MessageBox.Show("not added data");
                    }
                }
                else
                {
                    MessageBox.Show(nameItemTextBox.Text + "   already exited  ");

                }

                sqlItems.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void showItemButton_Click(object sender, EventArgs e)
        {
            showitems();

        }
        private void showitems()
        {
            try
            {
                string connectserver = @"Server=DESKTOP-Q5FQUO6;Database=CoffeeShop;Integrated Security=True";
                SqlConnection sqlItems = new SqlConnection(connectserver);

                string itemsqurey = @" select * from Items";
                SqlCommand sqlCommand = new SqlCommand(itemsqurey, sqlItems);
                sqlItems.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                showItemDataGridView.DataSource = dataTable;
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    showItemDataGridView.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("not data found");
                }
                //int isexcuted = sqlCommand.ExecuteNonQuery();
                //if (isexcuted > 0)
                //{
                //    MessageBox.Show("added successfully");

                //}
                //else
                //{
                //    MessageBox.Show("not added data");
                //}


                sqlItems.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void updateItemButton_Click(object sender, EventArgs e)
        {
            update();

        }
        private void update()
        {
            try
            {
                string sqlserverconnection = @"Server=DESKTOP-Q5FQUO6;Database=CoffeeShop;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(sqlserverconnection);

                string sqlvalues = @"UPDATE Items SET Name='" + nameItemTextBox.Text + "',Price="+priceItemTextBox.Text+ " WHERE ID=" + idItemTextBox.Text + "";
                SqlCommand sqlCommand = new SqlCommand(sqlvalues, sqlConnection);
                sqlConnection.Open();

                int isexcuted = sqlCommand.ExecuteNonQuery();
                if (isexcuted > 0)
                {
                    MessageBox.Show("successfully Data update");
                }
                else
                {
                    MessageBox.Show("not updated data");
                }

                sqlConnection.Close();


            }
            catch (Exception obj1)
            {
                MessageBox.Show(obj1.Message);
            }
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            delete();
        }
        private void delete()
        {
            try
            {
                string sqlserverconnection = @"Server=DESKTOP-Q5FQUO6;Database=CoffeeShop;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(sqlserverconnection);

                string sqlvalues = @"DELETE FROM Items WHERE ID=" + idItemTextBox.Text + "";
                SqlCommand sqlCommand = new SqlCommand(sqlvalues, sqlConnection);
                sqlConnection.Open();
                int isexcuted = sqlCommand.ExecuteNonQuery();
                if (isexcuted > 0)
                {
                    MessageBox.Show("successfully Data delete");
                }
                else
                {
                    MessageBox.Show("not delete data");
                }
                sqlConnection.Close();

            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }

        private void searchItemButton_Click(object sender, EventArgs e)
        {
            search();

        }
        private void search()
        {
            try
            {
                string sqlserverconnection = @"Server=DESKTOP-Q5FQUO6;Database=CoffeeShop;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(sqlserverconnection);

                string sqlvalues = @"select*from  Items  where name='" + nameItemTextBox.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(sqlvalues, sqlConnection);

                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                int isExcuted = sqlCommand.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                showItemDataGridView.DataSource = dataTable;
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    showItemDataGridView.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("no data founded");

                }

                sqlConnection.Close();

            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }
        private bool isexitename(string name)
        {
            bool exites = false;

            try
            {
                string sqlserverconnection = @"Server=DESKTOP-Q5FQUO6;Database=CoffeeShop;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(sqlserverconnection);

                string sqlvalues = @"select*from Customer where name='" + name + "'";
                SqlCommand sqlCommand = new SqlCommand(sqlvalues, sqlConnection);

                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                int isExcuted = sqlCommand.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                showItemDataGridView.DataSource = dataTable;
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    exites = true;

                }



                sqlConnection.Close();

            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }

            return exites;
        }
    }
    }

