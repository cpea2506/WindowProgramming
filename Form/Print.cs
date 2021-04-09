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
            PrintDocument prdo = new PrintDocument();
            prdo.DocumentName = "Print Document";
            prdi.Document = prdo;
            prdi.AllowSelection = true;
            prdi.AllowSomePages = true;
            if(prdi.ShowDialog() == DialogResult.OK)
            {
                prdo.Print();
            }
        }

        private void SaveToTextBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Documents (*.docx)|*.docx";
            sfd.FileName = "ListofStudent.docx";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                ExportDataToWord(TableOfStd, sfd.FileName);
            }
        }

        public void ExportDataToWord(DataGridView DGV, string filename)
        {
            if(DGV.Rows.Count > 0)
            {
                int RowCount = DGV.RowCount;
                int ColumnCount = DGV.ColumnCount;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                // add row
                int r = 0;
                for (int c = 0; c < ColumnCount; c++)
                {
                    for (r = 0; r < RowCount; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    }
                }

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";

                for (r = 0; r < RowCount; r++)
                {
                    for (int c = 0; c < ColumnCount; c++)
                    {
                        oTemp += DataArray[r, c] + "\t";
                    }
                }

                oRange.Text = oTemp;
                object Seperator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Seperator, ref RowCount, ref ColumnCount,                          
                                      Type.Missing, Type.Missing, ref ApplyBorders, 
                                     Type.Missing, Type.Missing, Type.Missing,
                                     Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();
                
                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add heeader row
                for(int c = 0; c < ColumnCount; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //table style
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "Your header text";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                //save image
                for (r = 0; r < RowCount; r++)
                {
                    byte[] imgByte = (byte[])DGV.Rows[r].Cells[7].Value;
                    MemoryStream ms = new MemoryStream(imgByte);
                    Image finalPic = (Image)(new Bitmap(Image.FromStream(ms), new Size(70, 70)));
                    Clipboard.SetDataObject(finalPic);
                    oDoc.Application.Selection.Tables[1].Cell(r + 2, 8).Range.Paste();
                    oDoc.Application.Selection.Tables[1].Cell(r + 2, 8).Range.InsertParagraph();
                }

                oDoc.SaveAs(filename);
            }
        }
    }
}
