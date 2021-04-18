
namespace QLSV
{
    partial class PrintForm
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
            this.ScoreGridView = new System.Windows.Forms.DataGridView();
            this.ToFileBtn = new System.Windows.Forms.Button();
            this.PrintBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreGridView
            // 
            this.ScoreGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScoreGridView.Location = new System.Drawing.Point(12, 12);
            this.ScoreGridView.Name = "ScoreGridView";
            this.ScoreGridView.Size = new System.Drawing.Size(461, 268);
            this.ScoreGridView.TabIndex = 0;
            // 
            // ToFileBtn
            // 
            this.ToFileBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ToFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToFileBtn.Location = new System.Drawing.Point(74, 298);
            this.ToFileBtn.Name = "ToFileBtn";
            this.ToFileBtn.Size = new System.Drawing.Size(119, 49);
            this.ToFileBtn.TabIndex = 1;
            this.ToFileBtn.Text = "To File";
            this.ToFileBtn.UseVisualStyleBackColor = false;
            this.ToFileBtn.Click += new System.EventHandler(this.ToFileBtn_Click);
            // 
            // PrintBtn
            // 
            this.PrintBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.PrintBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PrintBtn.Location = new System.Drawing.Point(285, 298);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(119, 49);
            this.PrintBtn.TabIndex = 2;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.UseVisualStyleBackColor = false;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(485, 370);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.ToFileBtn);
            this.Controls.Add(this.ScoreGridView);
            this.Name = "PrintForm";
            this.Text = "PrintForm";
            this.Load += new System.EventHandler(this.PrintForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScoreGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ScoreGridView;
        private System.Windows.Forms.Button ToFileBtn;
        private System.Windows.Forms.Button PrintBtn;
    }
}