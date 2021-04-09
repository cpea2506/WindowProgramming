
namespace QLSV
{
    partial class AddNewCourse
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddBtnCourse = new System.Windows.Forms.Button();
            this.CourseIdTxtb = new System.Windows.Forms.TextBox();
            this.LabelTxtb = new System.Windows.Forms.TextBox();
            this.PeriodTxtb = new System.Windows.Forms.TextBox();
            this.DesTxtb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Label";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Period";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // AddBtnCourse
            // 
            this.AddBtnCourse.BackColor = System.Drawing.Color.Turquoise;
            this.AddBtnCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtnCourse.Location = new System.Drawing.Point(25, 281);
            this.AddBtnCourse.Name = "AddBtnCourse";
            this.AddBtnCourse.Size = new System.Drawing.Size(398, 44);
            this.AddBtnCourse.TabIndex = 4;
            this.AddBtnCourse.Text = "Add";
            this.AddBtnCourse.UseVisualStyleBackColor = false;
            this.AddBtnCourse.Click += new System.EventHandler(this.AddBtnCourse_Click);
            // 
            // CourseIdTxtb
            // 
            this.CourseIdTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseIdTxtb.Location = new System.Drawing.Point(173, 23);
            this.CourseIdTxtb.Name = "CourseIdTxtb";
            this.CourseIdTxtb.Size = new System.Drawing.Size(250, 24);
            this.CourseIdTxtb.TabIndex = 5;
            // 
            // LabelTxtb
            // 
            this.LabelTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTxtb.Location = new System.Drawing.Point(173, 72);
            this.LabelTxtb.Name = "LabelTxtb";
            this.LabelTxtb.Size = new System.Drawing.Size(250, 24);
            this.LabelTxtb.TabIndex = 6;
            // 
            // PeriodTxtb
            // 
            this.PeriodTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeriodTxtb.Location = new System.Drawing.Point(173, 123);
            this.PeriodTxtb.Name = "PeriodTxtb";
            this.PeriodTxtb.Size = new System.Drawing.Size(250, 24);
            this.PeriodTxtb.TabIndex = 7;
            // 
            // DesTxtb
            // 
            this.DesTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesTxtb.Location = new System.Drawing.Point(173, 166);
            this.DesTxtb.Multiline = true;
            this.DesTxtb.Name = "DesTxtb";
            this.DesTxtb.Size = new System.Drawing.Size(250, 94);
            this.DesTxtb.TabIndex = 8;
            // 
            // AddNewCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(439, 337);
            this.Controls.Add(this.DesTxtb);
            this.Controls.Add(this.PeriodTxtb);
            this.Controls.Add(this.LabelTxtb);
            this.Controls.Add(this.CourseIdTxtb);
            this.Controls.Add(this.AddBtnCourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewCourse";
            this.Text = "AddNewCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddBtnCourse;
        public System.Windows.Forms.TextBox CourseIdTxtb;
        public System.Windows.Forms.TextBox LabelTxtb;
        public System.Windows.Forms.TextBox PeriodTxtb;
        public System.Windows.Forms.TextBox DesTxtb;
    }
}