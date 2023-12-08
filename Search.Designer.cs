namespace Student_Management
{
    partial class Search
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
            txtSearch = new TextBox();
            btnBack = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            dvg1 = new DataGridView();
            dataGridViewBindingSource1 = new BindingSource(components);
            dataGridViewBindingSource = new BindingSource(components);
            dataGridViewTextBoxEditingControlBindingSource = new BindingSource(components);
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dvg1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTextBoxEditingControlBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(865, 35);
            txtSearch.Margin = new Padding(30, 10, 10, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(230, 31);
            txtSearch.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(912, 617);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 0;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1012, 617);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1112, 35);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += button3_Click;
            // 
            // dvg1
            // 
            dvg1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg1.Location = new Point(226, 109);
            dvg1.Name = "dvg1";
            dvg1.RowHeadersWidth = 51;
            dvg1.RowTemplate.Height = 29;
            dvg1.Size = new Size(802, 478);
            dvg1.TabIndex = 5;
            dvg1.CellContentClick += dvg1_CellContentClick;
            // 
            // dataGridViewBindingSource1
            // 
            dataGridViewBindingSource1.DataSource = typeof(DataGridView);
            // 
            // dataGridViewTextBoxEditingControlBindingSource
            // 
            dataGridViewTextBoxEditingControlBindingSource.DataSource = typeof(DataGridViewTextBoxEditingControl);
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1112, 617);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1262, 673);
            Controls.Add(btnRefresh);
            Controls.Add(dvg1);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnBack);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Search";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search";
            Load += Search_Load;
            ((System.ComponentModel.ISupportInitialize)dvg1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTextBoxEditingControlBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSearch;
        private Button btnBack;
        private Button btnDelete;
        private Button btnSearch;
        private DataGridView dvg1;
        private BindingSource dataGridViewBindingSource1;
        private BindingSource dataGridViewBindingSource;
        private BindingSource dataGridViewTextBoxEditingControlBindingSource;
        private Button btnRefresh;
    }
}