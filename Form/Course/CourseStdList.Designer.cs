
namespace QLSV
{
    partial class CourseStdList
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
            this.CourseLabelTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SelectedCourseGridView = new System.Windows.Forms.DataGridView();
            this.PrintBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedCourseGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course Label";
            // 
            // CourseLabelTextBox
            // 
            this.CourseLabelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseLabelTextBox.Location = new System.Drawing.Point(162, 28);
            this.CourseLabelTextBox.Name = "CourseLabelTextBox";
            this.CourseLabelTextBox.Size = new System.Drawing.Size(122, 24);
            this.CourseLabelTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(319, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Semester";
            // 
            // SelectedCourseGridView
            // 
            this.SelectedCourseGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SelectedCourseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedCourseGridView.Location = new System.Drawing.Point(12, 69);
            this.SelectedCourseGridView.Name = "SelectedCourseGridView";
            this.SelectedCourseGridView.Size = new System.Drawing.Size(448, 201);
            this.SelectedCourseGridView.TabIndex = 11;
            // 
            // PrintBtn
            // 
            this.PrintBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.PrintBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PrintBtn.Location = new System.Drawing.Point(165, 278);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(119, 49);
            this.PrintBtn.TabIndex = 12;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.UseVisualStyleBackColor = false;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // CourseStdList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(472, 339);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.SelectedCourseGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CourseLabelTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CourseStdList";
            this.Text = "CourseStdList";
            ((System.ComponentModel.ISupportInitialize)(this.SelectedCourseGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox CourseLabelTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button PrintBtn;
        public System.Windows.Forms.DataGridView SelectedCourseGridView;
    }
}