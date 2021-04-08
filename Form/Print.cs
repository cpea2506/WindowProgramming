using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Ubiety.Dns.Core;

namespace QLSV
{
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();
        MY_DB db = new MY_DB();
        
        private void getTable(SqlCommand command)
        {
            TableOfStd.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            TableOfStd.RowTemplate.Height = 80;
            TableOfStd.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)TableOfStd.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            TableOfStd.AllowUserToAddRows = false;
        }
        private void Print_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std", db.getConnection);
            getTable(command);
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        { 
            SqlCommand command = new SqlCommand();
            if (AllRadioBtn.Checked)
            {   if(YesRadioBtn.Checked) {
                    command = new SqlCommand("SELECT * FROM std WHERE bdate BETWEEN @fday AND @lday",db.getConnection);
                    command.Parameters.Add("@fday", SqlDbType.DateTime).Value = FirstDay.Value;
                    command.Parameters.Add("@lday", SqlDbType.DateTime).Value = LastDay.Value;

                    getTable(command);
                } else {
                    command = new SqlCommand("SELECT * FROM std", db.getConnection);
                    getTable(command);
                }

            } else {
                string gender = "Female"; // default gender

                //male radio button clicked
                if (MaleRadioBtn.Checked)
                {
                    //change gender
                    gender = "Male";
                }
                
                if (YesRadioBtn.Checked)
                {
                    command = new SqlCommand("SELECT * FROM std WHERE gender = @gdr AND bdate BETWEEN @fday AND @lday", db.getConnection);
                    command.Parameters.Add("@fday", SqlDbType.DateTime).Value = FirstDay.Value;
                    command.Parameters.Add("@lday", SqlDbType.DateTime).Value = LastDay.Value;
                    command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
                    getTable(command);
                }
                else
                {
                    command = new SqlCommand("SELECT * FROM std WHERE gender = @gdr", db.getConnection);
                    command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
                    getTable(command);
                }
            }
        }

        private void ToPrinterBtn_Click(object sender, EventArgs e)
        {
            PrintDialog prdi = new PrintDialog();
            prdi.ShowDialog();
            PrintDocument prdo = new PrintDocument();
            prdo.DocumentName = "Print Document";
            prdi.Document = prdo;
            if(prdi.ShowDialog() == DialogResult.OK)
            {
                prdo.Print();
            }
        }

        public byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                Bitmap bmp = new Bitmap(imageIn);
                bmp.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void SaveToTextBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
