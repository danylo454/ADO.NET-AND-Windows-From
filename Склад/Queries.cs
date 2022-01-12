using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Склад
{
    public class Queries
    {
        public static string ShowAllInfo(SqlConnection connection,TextBox textBox)
        {
            textBox.Text = "";
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select * from Store";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    textBox.Text += reader.GetName(i) + " : " + reader[i]  + Environment.NewLine;
                }
                textBox.Text += (new string('_', 30));
                textBox.Text += Environment.NewLine;
            }
            reader.Close();
            return textBox.Text;
        }
        public static string ShowAllTypeStaff(SqlConnection connection, TextBox textBox)
        {
            textBox.Text = "";
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select [TypeStuff] from Store";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    textBox.Text += reader.GetName(i) + " : " + reader[i] + Environment.NewLine;
                }
                textBox.Text += (new string('_', 30));
                textBox.Text += Environment.NewLine;
            }
            reader.Close();
            return textBox.Text;
        }
        public static string ShowAllTypeSupplier(SqlConnection connection, TextBox textBox)
        {
            textBox.Text = "";
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select [Supplier] from Store";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    textBox.Text += reader.GetName(i) + " : " + reader[i] + Environment.NewLine;
                }
                textBox.Text += (new string('_', 30));
                textBox.Text += Environment.NewLine;
            }
            reader.Close();
            return textBox.Text;
        }
        public static string ShowMaxCountStaff(SqlConnection connection, TextBox textBox)
        {
            textBox.Text = "";
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Store WHERE CountStuff = (SELECT MAX(CountStuff) FROM Store)";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    textBox.Text += reader.GetName(i) + " : " + reader[i] + Environment.NewLine;
                }
                textBox.Text += (new string('_', 30));
                textBox.Text += Environment.NewLine;
            }
            reader.Close();
            return textBox.Text;
        }
        public static string ShowMinCountStaff(SqlConnection connection, TextBox textBox)
        {
            textBox.Text = "";
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Store WHERE CountStuff = (SELECT MIN(CountStuff) FROM Store)";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    textBox.Text += reader.GetName(i) + " : " + reader[i] + Environment.NewLine;
                }
                textBox.Text += (new string('_', 30));
                textBox.Text += Environment.NewLine;
            }
            reader.Close();
            return textBox.Text;
        }
        public static string ShowMinCost(SqlConnection connection, TextBox textBox)
        {
            textBox.Text = "";
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Store WHERE CostPrice = (SELECT MIN(CostPrice) FROM Store)";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    textBox.Text += reader.GetName(i) + " : " + reader[i] + Environment.NewLine;
                }
                textBox.Text += (new string('_', 30));
                textBox.Text += Environment.NewLine;
            }
            reader.Close();
            return textBox.Text;
        }
        public static string ShowMaxCost(SqlConnection connection, TextBox textBox)
        {
            textBox.Text = "";
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Store WHERE CostPrice = (SELECT Max(CostPrice) FROM Store)";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    textBox.Text += reader.GetName(i) + " : " + reader[i] + Environment.NewLine;
                }
                textBox.Text += (new string('_', 30));
                textBox.Text += Environment.NewLine;
            }
            reader.Close();
            return textBox.Text;
        }
        public static string SearchStaffBytype(SqlConnection connection, TextBox textBox,string type)
        {
            textBox.Text = "";
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"SELECT * FROM Store WHERE TypeStuff = '{type}'";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    textBox.Text += reader.GetName(i) + " : " + reader[i] + Environment.NewLine;
                }
                textBox.Text += (new string('_', 30));
                textBox.Text += Environment.NewLine;
            }
            reader.Close();
            return textBox.Text;
        }
        public static string SearchStaffBySupplier(SqlConnection connection, TextBox textBox, string type)
        {
            textBox.Text = "";
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"SELECT * FROM Store WHERE Supplier = '{type}'";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    textBox.Text += reader.GetName(i) + " : " + reader[i] + Environment.NewLine;
                }
                textBox.Text += (new string('_', 30));
                textBox.Text += Environment.NewLine;
            }
            reader.Close();
            return textBox.Text;
        }
        public static string SearchOldStaff(SqlConnection connection, TextBox textBox)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"SELECT * FROM Store WHERE DateSupply = (Select Min(DateSupply) from Store)";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    textBox.Text += reader.GetName(i) + " : " + reader[i] + Environment.NewLine;
                }
                textBox.Text += (new string('_', 30));
                textBox.Text += Environment.NewLine;
            }
            reader.Close();
            return textBox.Text;
        }
        public static string ShowAvgStaffCount(SqlConnection connection, TextBox textBox)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"select TypeStuff, Avg(CountStuff) as [AVG] from Store group by TypeStuff,CountStuff";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    textBox.Text += reader.GetName(i) + " : " + reader[i] + Environment.NewLine;
                }
                textBox.Text += (new string('_', 30));
                textBox.Text += Environment.NewLine;
            }
            reader.Close();
            return textBox.Text;
        }
    }
}

