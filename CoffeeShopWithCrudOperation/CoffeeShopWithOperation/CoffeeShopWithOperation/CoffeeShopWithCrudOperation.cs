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
    public partial class CoffeeShopWithCrudOperation : Form
    {
        public CoffeeShopWithCrudOperation()
        {
            InitializeComponent();
        }

         

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            addorder();
           
        }
        private void addorder()
        {
            try
            {
                string connectserver = @"Server=DESKTOP-Q5FQUO6;Database=CoffeeShop;Integrated Security=True";
                SqlConnection sqlItems = new SqlConnection(connectserver);

                string itemsqurey = @" INSERT INTO  Customer (Name,Address,Contract) VALUES('" + nameCustomerTextBox.Text + "','" + addressCustomerTextBox.Text + "',"+contractCustomerTextBox.Text+")";
                SqlCommand sqlCommand = new SqlCommand(itemsqurey, sqlItems);
                sqlItems.Open();
                if (!isexitename(nameCustomerTextBox.Text))
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
                    MessageBox.Show(nameCustomerTextBox.Text + "   already exited  ");

                }

                sqlItems.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void showCustomerButton_Click(object sender, EventArgs e)
        {
            show();
            
        }
        private void show()
        {
            try
            {
                string sqlserverconnection = @"Server=DESKTOP-Q5FQUO6;Database=CoffeeShop;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(sqlserverconnection);

                string sqlvalues = @"select * from Customer";
                SqlCommand sqlCommand = new SqlCommand(sqlvalues, sqlConnection);

                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                int isExcuted = sqlCommand.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                showCustomerDataGridView.DataSource = dataTable;
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    showCustomerDataGridView.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("no data founded");
                }

                sqlConnection.Close();

            }
            catch(Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            delete();

        }
        private void delete()
        {
            try
            {
                string sqlserverconnection = @"Server=DESKTOP-Q5FQUO6;Database=CoffeeShop;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(sqlserverconnection);

                string sqlvalues = @"DELETE FROM Customer WHERE ID=" + idCustomerTextBox.Text + "";
                SqlCommand sqlCommand = new SqlCommand(sqlvalues, sqlConnection);
                sqlConnection.Open();
                int isexcuted=sqlCommand.ExecuteNonQuery();
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
            catch(Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }

        private void updaCustomerButton_Click(object sender, EventArgs e)
        {
            update();
            
        }
        private void update()
        {
            try
            {
                string sqlserverconnection = @"Server=DESKTOP-Q5FQUO6;Database=CoffeeShop;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(sqlserverconnection);

                string sqlvalues = @"UPDATE Customer SET Name='" + nameCustomerTextBox.Text + "',Address='" + addressCustomerTextBox.Text + "',Contract=" + contractCustomerTextBox.Text + " WHERE ID=" + idCustomerTextBox.Text + "";
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
            catch(Exception obj1)
            {
                MessageBox.Show(obj1.Message);
            }
        }

        private void searchCustomerButton_Click(object sender, EventArgs e)
        {
            search();
        }
        private void search()
        {
            try
            {
                string sqlserverconnection = @"Server=DESKTOP-Q5FQUO6;Database=CoffeeShop;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(sqlserverconnection);

                string sqlvalues = @"select*from Customer where name='"+nameCustomerTextBox.Text+"'";
                SqlCommand sqlCommand = new SqlCommand(sqlvalues, sqlConnection);

                sqlConnection.Open();
               
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                int isExcuted = sqlCommand.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                showCustomerDataGridView.DataSource = dataTable;
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    showCustomerDataGridView.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("no data founded");

                }

                sqlConnection.Close();

            }
            catch(Exception obj)
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
                showCustomerDataGridView.DataSource = dataTable;
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                  exites= true; 

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

