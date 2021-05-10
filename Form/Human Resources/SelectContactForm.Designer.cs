
namespace QLSV
{
    partial class SelectContactForm
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
            this.ContactGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ContactGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ContactGridView
            // 
            this.ContactGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ContactGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContactGridView.Location = new System.Drawing.Point(12, 12);
            this.ContactGridView.Name = "ContactGridView";
            this.ContactGridView.Size = new System.Drawing.Size(471, 271);
            this.ContactGridView.TabIndex = 0;
            this.ContactGridView.DoubleClick += new System.EventHandler(this.ContactGridView_DoubleClick);
            // 
            // SelectContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(495, 295);
            this.Controls.Add(this.ContactGridView);
            this.Name = "SelectContactForm";
            this.Text = "SelectContactForm";
            this.Load += new System.EventHandler(this.SelectContactForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContactGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView ContactGridView;
    }
}