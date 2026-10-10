namespace StreamsTextFileApp
{
    partial class FrmRegistration
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
            label1 = new Label();
            label2 = new Label();
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtAge = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtFirstName = new TextBox();
            label7 = new Label();
            label8 = new Label();
            cmbProgram = new ComboBox();
            cmbGender = new ComboBox();
            txtMI = new TextBox();
            label9 = new Label();
            dtPickerBirthday = new DateTimePicker();
            txtContactNo = new TextBox();
            label10 = new Label();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Schoolbook", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(150, 28);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 66);
            label2.Name = "label2";
            label2.Size = new Size(92, 18);
            label2.TabIndex = 1;
            label2.Text = "Student No.";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentNo.Location = new Point(136, 63);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(176, 26);
            txtStudentNo.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(136, 111);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(176, 26);
            txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 114);
            label3.Name = "label3";
            label3.Size = new Size(84, 18);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(51, 210);
            label4.Name = "label4";
            label4.Size = new Size(71, 18);
            label4.TabIndex = 7;
            label4.Text = "Birthday";
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(136, 159);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(117, 26);
            txtAge.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(87, 162);
            label5.Name = "label5";
            label5.Size = new Size(35, 18);
            label5.TabIndex = 5;
            label5.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(362, 162);
            label6.Name = "label6";
            label6.Size = new Size(61, 18);
            label6.TabIndex = 13;
            label6.Text = "Gender";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(440, 111);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(176, 26);
            txtFirstName.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(335, 114);
            label7.Name = "label7";
            label7.Size = new Size(88, 18);
            label7.TabIndex = 11;
            label7.Text = "First Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(354, 66);
            label8.Name = "label8";
            label8.Size = new Size(69, 18);
            label8.TabIndex = 9;
            label8.Text = "Program";
            // 
            // cmbProgram
            // 
            cmbProgram.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProgram.FormattingEnabled = true;
            cmbProgram.Items.AddRange(new object[] { "BSIT", "BSCS", "BSCPE", "BSTM", "BSHM" });
            cmbProgram.Location = new Point(440, 63);
            cmbProgram.Name = "cmbProgram";
            cmbProgram.Size = new Size(332, 26);
            cmbProgram.TabIndex = 15;
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(440, 159);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(120, 26);
            cmbGender.TabIndex = 16;
            // 
            // txtMI
            // 
            txtMI.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMI.Location = new Point(688, 111);
            txtMI.Name = "txtMI";
            txtMI.Size = new Size(84, 26);
            txtMI.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(636, 114);
            label9.Name = "label9";
            label9.Size = new Size(36, 18);
            label9.TabIndex = 18;
            label9.Text = "M.I.";
            // 
            // dtPickerBirthday
            // 
            dtPickerBirthday.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtPickerBirthday.Location = new Point(136, 208);
            dtPickerBirthday.Name = "dtPickerBirthday";
            dtPickerBirthday.Size = new Size(275, 26);
            dtPickerBirthday.TabIndex = 19;
            // 
            // txtContactNo
            // 
            txtContactNo.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContactNo.Location = new Point(537, 202);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(235, 26);
            txtContactNo.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(440, 208);
            label10.Name = "label10";
            label10.Size = new Size(91, 18);
            label10.TabIndex = 20;
            label10.Text = "Contact No.";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(354, 264);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(96, 42);
            btnRegister.TabIndex = 22;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BGWEB;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(814, 345);
            Controls.Add(btnRegister);
            Controls.Add(txtContactNo);
            Controls.Add(label10);
            Controls.Add(dtPickerBirthday);
            Controls.Add(label9);
            Controls.Add(txtMI);
            Controls.Add(cmbGender);
            Controls.Add(cmbProgram);
            Controls.Add(label6);
            Controls.Add(txtFirstName);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(txtAge);
            Controls.Add(label5);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtStudentNo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegistration";
            Text = "s";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private Label label3;
        private Label label4;
        private TextBox txtAge;
        private Label label5;
        private Label label6;
        private TextBox txtFirstName;
        private Label label7;
        private Label label8;
        private ComboBox cmbProgram;
        private ComboBox cmbGender;
        private TextBox txtMI;
        private Label label9;
        private DateTimePicker dtPickerBirthday;
        private TextBox txtContactNo;
        private Label label10;
        private Button btnRegister;
    }
}