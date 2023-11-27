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

namespace ByteCare
{
    public partial class Form_Doctors : Form
    {
        DataBaseHelper dbhelper = new DataBaseHelper();
        string name, occupation, contact, availability;
        byte[] image;
        public Form_Doctors()
        {
            InitializeComponent();
            using (SqlConnection con = new SqlConnection(dbhelper.connection))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("Select * from MedicalStaff", con);
                SqlDataReader read = cmd.ExecuteReader();
                dataGridView1.Columns.Add("id", "No.");
                dataGridView1.Columns.Add("name", "Name");
                dataGridView1.Columns.Add("occ", "Occupation");
                dataGridView1.Columns.Add("contac", "Contact");
                dataGridView1.Columns.Add("avail", "Availability");

                while (read.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1,
                        read["Id"],
                        read["Name"],
                        read["Occupation"],
                        read["Contact"],
                        read["Availability"]
                        );
                    dataGridView1.Rows.Add(row);
                }
            }
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                using (SqlConnection con = new SqlConnection(dbhelper.connection))
                {
                    con.Open();
                    DataGridViewRow selected = dataGridView1.Rows[e.RowIndex];
                    int id = Convert.ToInt32(selected.Cells["id"].Value);
                    string query = "Select * from MedicalStaff Where Id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                name = reader.GetString(1);
                                occupation = reader.GetString(2);
                                contact = reader.GetString(3);
                                availability= reader.GetString(4);
                                image = reader.GetSqlBinary(5).Value;
                                DoctorDetails dt= new DoctorDetails(id, name, occupation,contact, availability, image);  
                                dt.Show();
                            }
                            else
                            {
                                MessageBox.Show("No data found for the selected patient.");
                            }
                        }
                    }
                }
            }
        }

        private void Form_Doctors_Load(object sender, EventArgs e)
        {

        }
    }
}
