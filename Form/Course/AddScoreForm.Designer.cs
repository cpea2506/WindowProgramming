
namespace QLSV
{
    partial class AddScoreForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddScoreBtn = new System.Windows.Forms.Button();
            this.StudentIdTextBox = new System.Windows.Forms.TextBox();
            this.ScoreGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ScoreTextBox = new System.Windows.Forms.TextBox();
            this.SelectCourseComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DesTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // AddScoreBtn
            // 
            this.AddScoreBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.AddScoreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddScoreBtn.Location = new System.Drawing.Point(16, 354);
            this.AddScoreBtn.Name = "AddScoreBtn";
            this.AddScoreBtn.Size = new System.Drawing.Size(365, 63);
            this.AddScoreBtn.TabIndex = 1;
            this.AddScoreBtn.Text = "Add";
            this.AddScoreBtn.UseVisualStyleBackColor = false;
            // 
            // StudentIdTextBox
            // 
            this.StudentIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIdTextBox.Location = new System.Drawing.Point(149, 47);
            this.StudentIdTextBox.Name = "StudentIdTextBox";
            this.StudentIdTextBox.Size = new System.Drawing.Size(232, 26);
            this.StudentIdTextBox.TabIndex = 2;
            // 
            // ScoreGridView
            // 
            this.ScoreGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScoreGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScoreGridView.Location = new System.Drawing.Point(411, 12);
            this.ScoreGridView.Name = "ScoreGridView";
            this.ScoreGridView.Size = new System.Drawing.Size(377, 405);
            this.ScoreGridView.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Score";
            // 
            // ScoreTextBox
            // 
            this.ScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreTextBox.Location = new System.Drawing.Point(149, 164);
            this.ScoreTextBox.Name = "ScoreTextBox";
            this.ScoreTextBox.Size = new System.Drawing.Size(232, 26);
            this.ScoreTextBox.TabIndex = 7;
            // 
            // SelectCourseComboBox
            // 
            this.SelectCourseComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectCourseComboBox.FormattingEnabled = true;
            this.SelectCourseComboBox.Location = new System.Drawing.Point(149, 107);
            this.SelectCourseComboBox.Name = "SelectCourseComboBox";
            this.SelectCourseComboBox.Size = new System.Drawing.Size(232, 28);
            this.SelectCourseComboBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description";
            // 
            // DesTextBox
            // 
            this.DesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesTextBox.Location = new System.Drawing.Point(149, 220);
            this.DesTextBox.Multiline = true;
            this.DesTextBox.Name = "DesTextBox";
            this.DesTextBox.Size = new System.Drawing.Size(232, 119);
            this.DesTextBox.TabIndex = 10;
            // 
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.DesTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SelectCourseComboBox);
            this.Controls.Add(this.ScoreTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ScoreGridView);
            this.Controls.Add(this.StudentIdTextBox);
            this.Controls.Add(this.AddScoreBtn);
            this.Controls.Add(this.label1);
            this.Name = "AddScoreForm";
            this.Text = "AddScoreForm";
            this.Load += new System.EventHandler(this.AddScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScoreGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddScoreBtn;
        private System.Windows.Forms.TextBox StudentIdTextBox;
        private System.Windows.Forms.DataGridView ScoreGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ScoreTextBox;
        private System.Windows.Forms.ComboBox SelectCourseComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DesTextBox;
    }
}