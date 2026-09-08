using Bank.shared;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace Bank
{
    public partial class Bank : Form
    {
        public Bank()
        {
            InitializeComponent();

            //TestDatabaseConnection();
        }

        //private void TestDatabaseConnection()
        //{
        //    try
        //    {
        //        Database database = new Database();

        //        using (SqlConnection connection = database.GetConnection())
        //        {
        //            connection.Open();

        //            MessageBox.Show("Database connection successful!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Database connection failed: " + ex.Message);
        //    }
        //}

        private bool ValidateAccountFields()
        {
            if (string.IsNullOrEmpty(txtAccountName.Text) ||
                string.IsNullOrWhiteSpace(txtAccountName.Text))
            {
                Alerts.WarningMessage("Account name is required");
                txtAccountName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtAccountNo.Text) || string.IsNullOrWhiteSpace(txtAccountNo.Text))
            {
                Alerts.WarningMessage("Account number is required");
                txtAccountNo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtBalance.Text) ||
                string.IsNullOrWhiteSpace(txtBalance.Text))
            {
                Alerts.WarningMessage("Balance is required");
                txtBalance.Focus();
                return false;
            }

            if (!decimal.TryParse(txtBalance.Text, out decimal balance))
            {
                Alerts.WarningMessage("Enter a valid balance");
                txtBalance.Focus();
                return false;
            }

            if (balance < 0)
            {
                Alerts.WarningMessage("Balance cannot be negative");
                txtBalance.Focus();
                return false;
            }

            return true;
        }

        private SqlConnection GetDatabaseConnection()
        {
            Database database = new Database();

            SqlConnection connection = database.GetConnection();
            connection.Open();

            return connection;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            LoadAccounts();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateAccountFields())
                {
                    return;
                }

                using (SqlConnection connection = GetDatabaseConnection())
                {
                    connection.Execute(
                        "ADD_ACCOUNT",
                        new
                        {
                            accountNo = txtAccountNo.Text.Trim(),
                            accountName = txtAccountName.Text.Trim(),
                            balance = decimal.Parse(txtBalance.Text)
                        },
                        commandType: CommandType.StoredProcedure
                    );
                }

                Alerts.InformationMessage("Account added successfully");

                LoadAccounts();
            }
            catch (Exception ex)
            {
                Alerts.ExceptionMessage(ex.Message);
            }
        }

        private void LoadAccounts()
        {
            try
            {
                using (SqlConnection connection = GetDatabaseConnection())
                {
                    var accounts = connection.Query(
                        "GET_ACCOUNTS",
                        commandType: CommandType.StoredProcedure
                    );

                    dgvAccounts.DataSource = accounts.ToList();
                }
            }
            catch (Exception ex)
            {
                Alerts.ExceptionMessage(ex.Message);
            }
        }

    }
}
