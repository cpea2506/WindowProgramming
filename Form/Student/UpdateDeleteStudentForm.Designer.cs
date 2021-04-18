
namespace QLSV
{
    partial class UpdateDeleteStudentForm
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
            this.ID = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.Bdate = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.FindBtn = new System.Windows.Forms.Button();
            this.UploadImage = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.FnameTextBox = new System.Windows.Forms.TextBox();
            this.LNameTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.BdateBox = new System.Windows.Forms.DateTimePicker();
            this.MaleRadio = new System.Windows.Forms.RadioButton();
            this.FemaleRadio = new System.Windows.Forms.RadioButton();
            this.Address = new System.Windows.Forms.Label();
            this.Picture = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.AddCourseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(80, 30);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(28, 20);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(12, 74);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(96, 20);
            this.FirstName.TabIndex = 1;
            this.FirstName.Text = "First Name";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(13, 119);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(95, 20);
            this.LastName.TabIndex = 2;
            this.LastName.Text = "Last Name";
            // 
            // Bdate
            // 
            this.Bdate.AutoSize = true;
            this.Bdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bdate.Location = new System.Drawing.Point(22, 161);
            this.Bdate.Name = "Bdate";
            this.Bdate.Size = new System.Drawing.Size(86, 20);
            this.Bdate.TabIndex = 3;
            this.Bdate.Text = "BirthDate";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(39, 208);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(69, 20);
            this.Gender.TabIndex = 4;
            this.Gender.Text = "Gender";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(48, 254);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(60, 20);
            this.Phone.TabIndex = 5;
            this.Phone.Text = "Phone";
            // 
            // FindBtn
            // 
            this.FindBtn.BackColor = System.Drawing.Color.DarkViolet;
            this.FindBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FindBtn.Location = new System.Drawing.Point(260, 24);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(99, 26);
            this.FindBtn.TabIndex = 6;
            this.FindBtn.Text = "Find";
            this.FindBtn.UseVisualStyleBackColor = false;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // UploadImage
            // 
            this.UploadImage.Location = new System.Drawing.Point(504, 257);
            this.UploadImage.Name = "UploadImage";
            this.UploadImage.Size = new System.Drawing.Size(206, 23);
            this.UploadImage.TabIndex = 7;
            this.UploadImage.Text = "Upload Image";
            this.UploadImage.UseVisualStyleBackColor = true;
            this.UploadImage.Click += new System.EventHandler(this.UploadImage_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.PaleGreen;
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Location = new System.Drawing.Point(40, 343);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(162, 59);
            this.Edit.TabIndex = 8;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.Color.Red;
            this.Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Remove.Location = new System.Drawing.Point(283, 343);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(162, 59);
            this.Remove.TabIndex = 9;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTextBox.Location = new System.Drawing.Point(125, 254);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(234, 26);
            this.PhoneTextBox.TabIndex = 10;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextBox.Location = new System.Drawing.Point(125, 24);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(123, 26);
            this.IDTextBox.TabIndex = 11;
            this.IDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxId_KeyPress);
            // 
            // FnameTextBox
            // 
            this.FnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FnameTextBox.Location = new System.Drawing.Point(125, 68);
            this.FnameTextBox.Name = "FnameTextBox";
            this.FnameTextBox.Size = new System.Drawing.Size(234, 26);
            this.FnameTextBox.TabIndex = 12;
            // 
            // LNameTextBox
            // 
            this.LNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameTextBox.Location = new System.Drawing.Point(125, 113);
            this.LNameTextBox.Name = "LNameTextBox";
            this.LNameTextBox.Size = new System.Drawing.Size(234, 26);
            this.LNameTextBox.TabIndex = 13;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(504, 24);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(206, 111);
            this.AddressTextBox.TabIndex = 14;
            // 
            // BdateBox
            // 
            this.BdateBox.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BdateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BdateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BdateBox.Location = new System.Drawing.Point(125, 155);
            this.BdateBox.Name = "BdateBox";
            this.BdateBox.Size = new System.Drawing.Size(234, 26);
            this.BdateBox.TabIndex = 16;
            // 
            // MaleRadio
            // 
            this.MaleRadio.AutoSize = true;
            this.MaleRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleRadio.Location = new System.Drawing.Point(141, 204);
            this.MaleRadio.Name = "MaleRadio";
            this.MaleRadio.Size = new System.Drawing.Size(61, 24);
            this.MaleRadio.TabIndex = 17;
            this.MaleRadio.TabStop = true;
            this.MaleRadio.Text = "Male";
            this.MaleRadio.UseVisualStyleBackColor = true;
            // 
            // FemaleRadio
            // 
            this.FemaleRadio.AutoSize = true;
            this.FemaleRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleRadio.Location = new System.Drawing.Point(269, 204);
            this.FemaleRadio.Name = "FemaleRadio";
            this.FemaleRadio.Size = new System.Drawing.Size(80, 24);
            this.FemaleRadio.TabIndex = 18;
            this.FemaleRadio.TabStop = true;
            this.FemaleRadio.Text = "Female";
            this.FemaleRadio.UseVisualStyleBackColor = true;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(409, 27);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(75, 20);
            this.Address.TabIndex = 19;
            this.Address.Text = "Address";
            // 
            // Picture
            // 
            this.Picture.AutoSize = true;
            this.Picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Picture.Location = new System.Drawing.Point(419, 141);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(65, 20);
            this.Picture.TabIndex = 20;
            this.Picture.Text = "Picture";
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PictureBox.Location = new System.Drawing.Point(504, 141);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(206, 110);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 21;
            this.PictureBox.TabStop = false;
            // 
            // AddCourseBtn
            // 
            this.AddCourseBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddCourseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCourseBtn.Location = new System.Drawing.Point(527, 343);
            this.AddCourseBtn.Name = "AddCourseBtn";
            this.AddCourseBtn.Size = new System.Drawing.Size(162, 59);
            this.AddCourseBtn.TabIndex = 22;
            this.AddCourseBtn.Text = "Add Course";
            this.AddCourseBtn.UseVisualStyleBackColor = false;
            this.AddCourseBtn.Click += new System.EventHandler(this.AddCourseBtn_Click);
            // 
            // UpdateDeleteStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(722, 425);
            this.Controls.Add(this.AddCourseBtn);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.FemaleRadio);
            this.Controls.Add(this.MaleRadio);
            this.Controls.Add(this.BdateBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.LNameTextBox);
            this.Controls.Add(this.FnameTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.UploadImage);
            this.Controls.Add(this.FindBtn);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Bdate);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.ID);
            this.Name = "UpdateDeleteStudentForm";
            this.Text = "UpdateDeleteStudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label Bdate;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Button FindBtn;
        private System.Windows.Forms.Button UploadImage;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Picture;
        public System.Windows.Forms.TextBox PhoneTextBox;
        public System.Windows.Forms.TextBox IDTextBox;
        public System.Windows.Forms.TextBox FnameTextBox;
        public System.Windows.Forms.TextBox LNameTextBox;
        public System.Windows.Forms.TextBox AddressTextBox;
        public System.Windows.Forms.DateTimePicker BdateBox;
        public System.Windows.Forms.PictureBox PictureBox;
        public System.Windows.Forms.RadioButton MaleRadio;
        public System.Windows.Forms.RadioButton FemaleRadio;
        private System.Windows.Forms.Button AddCourseBtn;
    }
}