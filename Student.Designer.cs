
namespace Student_Management
{
    partial class Student
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
            components = new System.ComponentModel.Container();
            btnAdd = new Button();
            lab_stuname = new Label();
            lab_stuphone = new Label();
            lab_pro = new Label();
            lab_stuid = new Label();
            lab_dob = new Label();
            lab_gender = new Label();
            txt_stuid = new TextBox();
            txt_stuname = new TextBox();
            txt_stuphone = new TextBox();
            txt_stupro = new TextBox();
            radio_female = new RadioButton();
            radio_male = new RadioButton();
            date_dob = new DateTimePicker();
            btnUpdate = new Button();
            dataGrid = new DataGridView();
            btnBack = new Button();
            dataGridViewBindingSource = new BindingSource(components);
            dataGridViewTextBoxEditingControlBindingSource = new BindingSource(components);
            dataGridViewComboBoxEditingControlBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTextBoxEditingControlBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewComboBoxEditingControlBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Window;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(1041, 589);
            btnAdd.Margin = new Padding(10);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(189, 65);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lab_stuname
            // 
            lab_stuname.AutoSize = true;
            lab_stuname.Font = new Font("Inter Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lab_stuname.Location = new Point(57, 155);
            lab_stuname.Name = "lab_stuname";
            lab_stuname.Size = new Size(198, 28);
            lab_stuname.TabIndex = 10;
            lab_stuname.Text = "Student Name :";
            // 
            // lab_stuphone
            // 
            lab_stuphone.AutoSize = true;
            lab_stuphone.Font = new Font("Inter Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lab_stuphone.Location = new Point(57, 251);
            lab_stuphone.Name = "lab_stuphone";
            lab_stuphone.Size = new Size(204, 28);
            lab_stuphone.TabIndex = 11;
            lab_stuphone.Text = "Phone Number :";
            // 
            // lab_pro
            // 
            lab_pro.AutoSize = true;
            lab_pro.Font = new Font("Inter Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lab_pro.Location = new Point(63, 348);
            lab_pro.Name = "lab_pro";
            lab_pro.Size = new Size(133, 28);
            lab_pro.TabIndex = 22;
            lab_pro.Text = "Province :";
            // 
            // lab_stuid
            // 
            lab_stuid.AutoSize = true;
            lab_stuid.Font = new Font("Inter Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lab_stuid.Location = new Point(57, 68);
            lab_stuid.Name = "lab_stuid";
            lab_stuid.Size = new Size(155, 28);
            lab_stuid.TabIndex = 31;
            lab_stuid.Text = "Student ID :";
            // 
            // lab_dob
            // 
            lab_dob.AutoSize = true;
            lab_dob.Font = new Font("Inter Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lab_dob.Location = new Point(645, 160);
            lab_dob.Name = "lab_dob";
            lab_dob.Size = new Size(181, 28);
            lab_dob.TabIndex = 18;
            lab_dob.Text = "Date of Birth :";
            lab_dob.Click += lab_dob_Click;
            // 
            // lab_gender
            // 
            lab_gender.AutoSize = true;
            lab_gender.Font = new Font("Inter Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lab_gender.Location = new Point(645, 68);
            lab_gender.Name = "lab_gender";
            lab_gender.Size = new Size(115, 28);
            lab_gender.TabIndex = 32;
            lab_gender.Text = "Gender :";
            lab_gender.Click += lab_gender_Click;
            // 
            // txt_stuid
            // 
            txt_stuid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_stuid.Location = new Point(278, 68);
            txt_stuid.Name = "txt_stuid";
            txt_stuid.Size = new Size(290, 34);
            txt_stuid.TabIndex = 12;
            txt_stuid.TextChanged += txt_stuid_TextChanged;
            // 
            // txt_stuname
            // 
            txt_stuname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_stuname.Location = new Point(278, 155);
            txt_stuname.Name = "txt_stuname";
            txt_stuname.Size = new Size(290, 34);
            txt_stuname.TabIndex = 13;
            // 
            // txt_stuphone
            // 
            txt_stuphone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_stuphone.Location = new Point(278, 245);
            txt_stuphone.Name = "txt_stuphone";
            txt_stuphone.Size = new Size(290, 34);
            txt_stuphone.TabIndex = 14;
            // 
            // txt_stupro
            // 
            txt_stupro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_stupro.Location = new Point(278, 348);
            txt_stupro.Name = "txt_stupro";
            txt_stupro.Size = new Size(290, 34);
            txt_stupro.TabIndex = 15;
            // 
            // radio_female
            // 
            radio_female.AutoSize = true;
            radio_female.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radio_female.Location = new Point(906, 66);
            radio_female.Name = "radio_female";
            radio_female.Size = new Size(95, 32);
            radio_female.TabIndex = 17;
            radio_female.TabStop = true;
            radio_female.Text = "Female";
            radio_female.UseVisualStyleBackColor = true;
            radio_female.CheckedChanged += radio_female_CheckedChanged;
            // 
            // radio_male
            // 
            radio_male.AutoSize = true;
            radio_male.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radio_male.Location = new Point(800, 65);
            radio_male.Name = "radio_male";
            radio_male.Size = new Size(76, 32);
            radio_male.TabIndex = 16;
            radio_male.TabStop = true;
            radio_male.Text = "Male";
            radio_male.UseVisualStyleBackColor = true;
            radio_male.CheckedChanged += radio_male_CheckedChanged;
            // 
            // date_dob
            // 
            date_dob.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            date_dob.Location = new Point(849, 154);
            date_dob.Name = "date_dob";
            date_dob.Size = new Size(326, 34);
            date_dob.TabIndex = 19;
            date_dob.ValueChanged += date_dob_ValueChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Window;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(844, 589);
            btnUpdate.Margin = new Padding(10);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(189, 65);
            btnUpdate.TabIndex = 33;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dataGrid
            // 
            dataGrid.BackgroundColor = SystemColors.Window;
            dataGrid.ColumnHeadersHeight = 29;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGrid.Location = new Point(645, 207);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 51;
            dataGrid.RowTemplate.Height = 29;
            dataGrid.Size = new Size(587, 369);
            dataGrid.TabIndex = 34;
            dataGrid.CellClick += dataGrid_CellClick;
            dataGrid.CellContentClick += dataGrid_CellContentClick;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.Window;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(645, 589);
            btnBack.Margin = new Padding(10);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(189, 65);
            btnBack.TabIndex = 35;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // dataGridViewBindingSource
            // 
            dataGridViewBindingSource.DataSource = typeof(DataGridView);
            // 
            // dataGridViewTextBoxEditingControlBindingSource
            // 
            dataGridViewTextBoxEditingControlBindingSource.DataSource = typeof(DataGridViewTextBoxEditingControl);
            // 
            // dataGridViewComboBoxEditingControlBindingSource
            // 
            dataGridViewComboBoxEditingControlBindingSource.DataSource = typeof(DataGridViewComboBoxEditingControl);
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1262, 673);
            Controls.Add(btnBack);
            Controls.Add(dataGrid);
            Controls.Add(btnUpdate);
            Controls.Add(lab_gender);
            Controls.Add(lab_stuid);
            Controls.Add(lab_pro);
            Controls.Add(lab_stuphone);
            Controls.Add(lab_stuname);
            Controls.Add(lab_dob);
            Controls.Add(date_dob);
            Controls.Add(radio_female);
            Controls.Add(radio_male);
            Controls.Add(txt_stupro);
            Controls.Add(txt_stuphone);
            Controls.Add(txt_stuname);
            Controls.Add(txt_stuid);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student";
            KeyPress += Student_KeyPress;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTextBoxEditingControlBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewComboBoxEditingControlBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void lab_dob_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion


        private Button btnAdd;
        private Label lab_stuname;
        private Label lab_stuphone;
        private Label lab_pro;
        private Label lab_stuid;
        private Label lab_gender;
        private Label lab_dob;
        private TextBox txt_stupro;
        private TextBox txt_stuid;
        private TextBox txt_stuname;
        private TextBox txt_stuphone;
        private RadioButton radio_male;
        private RadioButton radio_female;
        private DateTimePicker date_dob;
        private Button btnUpdate;
        private DataGridView dataGrid;
        private Button btnBack;
        private BindingSource dataGridViewBindingSource;
        private BindingSource dataGridViewTextBoxEditingControlBindingSource;
        private BindingSource dataGridViewComboBoxEditingControlBindingSource;
    }
}