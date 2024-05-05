using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Spotify
{
    public partial class Form1 : Form
    {
        const string connectionString = "Server=WINDOWS-TPN1V5P\\SQLEXPRESS;Database=Spotify;Trusted_Connection=True;";
        public Form1()
        {
            InitializeComponent();
            GetDatas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        void ResetTable()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }
        void GetDatas()
        {
            ResetTable();
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            using SqlCommand command = new SqlCommand("SELECT * FROM Musics", conn);
            using SqlDataReader datas = command.ExecuteReader();
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Surname", "Duration");
            dataGridView1.Columns.Add("Category", "Category id");
            while (datas.Read())
            {
                dataGridView1.Rows.Add(datas[0], datas[1], datas[2], datas[3]);
            }

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            string duration = durationInput.Text;
            int category = GetSelectedCategory();
            InsertData(name, duration, category);
            nameInput.Text = "";
            durationInput.Text = "";
            GetDatas();
        }

        private int GetSelectedCategory()
        {
            if (radioButton1.Checked)
            {
                return 1;
            }
            else if (radioButton2.Checked)
            {
                return 2;
            }
            else if (radioButton3.Checked)
            {
                return 3;
            }
            else
            {
                return 0;
            }
        }

        bool InsertData(string name, string duration, int category)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            using SqlCommand command = new SqlCommand("INSERT INTO Musics (Name, Duration, CategoryId) VALUES (@Name, @Duration, @CategoryId)", conn);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Duration", duration);
            command.Parameters.AddWithValue("@CategoryId", category);

            int count = command.ExecuteNonQuery();
            if (count > 0)
            {
                return true;
            }
            return false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void getId_Click(object sender, EventArgs e)
        {
            string id = getById.Text;
            int musicId;
            getById.Text = "";
            if (int.TryParse(id, out musicId))
            {
                GetById(musicId);
            }
            else
            {
                MessageBox.Show("Wrong Id.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        void GetById(int id)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                using SqlCommand command = new SqlCommand($"SELECT * FROM Musics WHERE Id = @Id", conn);
                command.Parameters.AddWithValue("@Id", id);
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add(reader["Id"], reader["Name"], reader["Duration"], reader["CategoryId"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something happend unexpected " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string id = deleteById.Text;

            bool success = DeleteById(Convert.ToInt32(id));

            if (success)
            {
                MessageBox.Show("Music deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetDatas();
            }
            else
            {
                MessageBox.Show("Something happend unexpected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        bool DeleteById(int id)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            using SqlCommand command = new SqlCommand("DELETE FROM Musics WHERE Id = @Id", conn);
            command.Parameters.AddWithValue("@Id", id);
            int rowsAffected = command.ExecuteNonQuery();
            return rowsAffected > 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetDatas();
        }

        private void update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idUpdate.Text);
            string name = updateName.Text;
            string newduration = updateDuration.Text;
            UpdateMusic(id, name, newduration);
        }
        bool UpdateMusic (int id, string newName, string newDuration)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string selectQuery = $"SELECT Name, Duration FROM Musics WHERE Id = @Id";
            using SqlCommand selectCommand = new SqlCommand(selectQuery, conn);
            selectCommand.Parameters.AddWithValue("@Id", id);
            using SqlDataReader reader = selectCommand.ExecuteReader();
            //int count = command.ExecuteNonQuery();
            //if (count > 0)
            //{
            //    return true;
            //}
            //return false;



        }

    }
}
