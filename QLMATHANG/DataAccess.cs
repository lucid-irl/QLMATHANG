using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMATHANG
{
    class DataAccess
    {
        SqlConnection con;
        String conStr;
        public DataAccess()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string path = projectDirectory + @"\Database.mdf";
            con = new SqlConnection();
            conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + @";Integrated Security=True";
        }

        public List<Item> getAllItems()
        {
            List<Item> result = new List<Item>();
            SqlDataReader reader = null;
            try
            {
                con.ConnectionString = conStr;
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "select * from MATHANG";
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result.Add(new Item(reader["MAHANG"].ToString(), reader["TENHANG"].ToString(), reader.GetDateTime(reader.GetOrdinal("NGAYNHAP")), Int64.Parse(reader["SOLUONG"].ToString()), reader["MANCC"].ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                con.Dispose();
            }
            return result;
        }
        public bool addItem(Item it)
        {
            bool success = false;
            try
            {
                con.ConnectionString = conStr;
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "insert into MATHANG (MAHANG, TENHANG, NGAYNHAP, SOLUONG, MANCC) values ('" + it.MAHANG + "', '" + it.TENHANG + "', '" + it.NGAYNHAP + "', '" + it.SOLUONG + "', '" + it.MANCC + "' )";

                int ret = command.ExecuteNonQuery();
                if (ret == 1)
                {
                    success = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Dispose();
            }
            return success;
        }
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string path = projectDirectory + @"\Database.mdf";
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";
            return con;
        }
        public void setData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Processed Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void fillDataToComboBox(string query)
        {
            try
            {
                SqlConnection con = getConnection();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "NCC");
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }
    }
}
