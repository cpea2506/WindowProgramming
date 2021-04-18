
namespace QLSV
{
    partial class ManageScoreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddBtn = new System.Windows.Forms.Button();
            this.ShowStdBtn = new System.Windows.Forms.Button();
            this.ShowScoreBtn = new System.Windows.Forms.Button();
            this.AvgScoreBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StudentIdTextBox = new System.Windows.Forms.TextBox();
            this.DesTextBox = new System.Windows.Forms.TextBox();
            this.ScoreTextBox = new System.Windows.Forms.TextBox();
            this.CourseComboBox = new System.Windows.Forms.ComboBox();
            this.GridViewByOption = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewByOption)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(46, 325);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(122, 39);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ShowStdBtn
            // 
            this.ShowStdBtn.BackColor = System.Drawing.Color.LightGray;
            this.ShowStdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowStdBtn.ForeColor = System.Drawing.Color.Black;
            this.ShowStdBtn.Location = new System.Drawing.Point(398, 12);
            this.ShowStdBtn.Name = "ShowStdBtn";
            this.ShowStdBtn.Size = new System.Drawing.Size(172, 26);
            this.ShowStdBtn.TabIndex = 1;
            this.ShowStdBtn.Text = "Show Students";
            this.ShowStdBtn.UseVisualStyleBackColor = false;
            this.ShowStdBtn.Click += new System.EventHandler(this.ShowStdBtn_Click);
            // 
            // ShowScoreBtn
            // 
            this.ShowScoreBtn.BackColor = System.Drawing.Color.LightGray;
            this.ShowScoreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowScoreBtn.ForeColor = System.Drawing.Color.Black;
            this.ShowScoreBtn.Location = new System.Drawing.Point(593, 12);
            this.ShowScoreBtn.Name = "ShowScoreBtn";
            this.ShowScoreBtn.Size = new System.Drawing.Size(172, 26);
            this.ShowScoreBtn.TabIndex = 2;
            this.ShowScoreBtn.Text = "Show Scores";
            this.ShowScoreBtn.UseVisualStyleBackColor = false;
            this.ShowScoreBtn.Click += new System.EventHandler(this.ShowScoreBtn_Click);
            // 
            // AvgScoreBtn
            // 
            this.AvgScoreBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AvgScoreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvgScoreBtn.Location = new System.Drawing.Point(69, 383);
            this.AvgScoreBtn.Name = "AvgScoreBtn";
            this.AvgScoreBtn.Size = new System.Drawing.Size(231, 39);
            this.AvgScoreBtn.TabIndex = 3;
            this.AvgScoreBtn.Text = "Average Score By Course";
            this.AvgScoreBtn.UseVisualStyleBackColor = false;
            this.AvgScoreBtn.Click += new System.EventHandler(this.AvgScoreBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.BackColor = System.Drawing.Color.Red;
            this.RemoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RemoveBtn.Location = new System.Drawing.Point(208, 325);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(122, 39);
            this.RemoveBtn.TabIndex = 4;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = false;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(38, 33);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(97, 20);
            this.label.TabIndex = 5;
            this.label.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "SelectCourse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description";
            // 
            // StudentIdTextBox
            // 
            this.StudentIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIdTextBox.Location = new System.Drawing.Point(141, 30);
            this.StudentIdTextBox.Name = "StudentIdTextBox";
            this.StudentIdTextBox.Size = new System.Drawing.Size(224, 26);
            this.StudentIdTextBox.TabIndex = 9;
            // 
            // DesTextBox
            // 
            this.DesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesTextBox.Location = new System.Drawing.Point(144, 189);
            this.DesTextBox.Multiline = true;
            this.DesTextBox.Name = "DesTextBox";
            this.DesTextBox.Size = new System.Drawing.Size(221, 108);
            this.DesTextBox.TabIndex = 10;
            // 
            // ScoreTextBox
            // 
            this.ScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreTextBox.Location = new System.Drawing.Point(141, 137);
            this.ScoreTextBox.Name = "ScoreTextBox";
            this.ScoreTextBox.Size = new System.Drawing.Size(224, 26);
            this.ScoreTextBox.TabIndex = 11;
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.Location = new System.Drawing.Point(141, 84);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(224, 28);
            this.CourseComboBox.TabIndex = 12;
            // 
            // GridViewByOption
            // 
            this.GridViewByOption.BackgroundColor = System.Drawing.SystemColors.Info;
            this.GridViewByOption.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewByOption.Location = new System.Drawing.Point(398, 44);
            this.GridViewByOption.Name = "GridViewByOption";
            this.GridViewByOption.Size = new System.Drawing.Size(367, 378);
            this.GridViewByOption.TabIndex = 13;
            this.GridViewByOption.Click += new System.EventHandler(this.GridViewByOption_Click);
            // 
            // ManageScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.GridViewByOption);
            this.Controls.Add(this.CourseComboBox);
            this.Controls.Add(this.ScoreTextBox);
            this.Controls.Add(this.DesTextBox);
            this.Controls.Add(this.StudentIdTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.AvgScoreBtn);
            this.Controls.Add(this.ShowScoreBtn);
            this.Controls.Add(this.ShowStdBtn);
            this.Controls.Add(this.AddBtn);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ManageScoreForm";
            this.Text = "ManageScoreForm";
            this.Load += new System.EventHandler(this.ManageScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewByOption)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ShowStdBtn;
        private System.Windows.Forms.Button ShowScoreBtn;
        private System.Windows.Forms.Button AvgScoreBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StudentIdTextBox;
        private System.Windows.Forms.TextBox DesTextBox;
        private System.Windows.Forms.TextBox ScoreTextBox;
        private System.Windows.Forms.ComboBox CourseComboBox;
        private System.Windows.Forms.DataGridView GridViewByOption;
    }
}