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
            Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = xcelApp.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "List of student";

            for(int i = 1; i < TableOfStd.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = TableOfStd.Columns[i - 1].HeaderText;
            }


            for (int i = 0; i < TableOfStd.Rows.Count; i++)
            {
                for (int j = 0; j < TableOfStd.Columns.Count; j++)
                    worksheet.Cells[i + 2, j + 1] = TableOfStd.Rows[i].Cells[j].Value.ToString();
            }


            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "output";
            saveFileDialoge.DefaultExt = "xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            xcelApp.Quit();
        }
    }
}
