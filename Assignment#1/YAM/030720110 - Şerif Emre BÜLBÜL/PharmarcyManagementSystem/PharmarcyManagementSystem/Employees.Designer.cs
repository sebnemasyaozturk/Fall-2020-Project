namespace PharmarcyManagementSystem
{
    partial class Employees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.Empnametb = new ns1.BunifuMaterialTextbox();
            this.empagetb = new ns1.BunifuMaterialTextbox();
            this.empsaltb = new ns1.BunifuMaterialTextbox();
            this.Empidtb = new ns1.BunifuMaterialTextbox();
            this.empphonetb = new ns1.BunifuMaterialTextbox();
            this.AddEmpbtn = new Guna.UI.WinForms.GunaButton();
            this.UpdateEmpbtn = new Guna.UI.WinForms.GunaButton();
            this.DelEmpbtn = new Guna.UI.WinForms.GunaButton();
            this.Backbtn = new Guna.UI.WinForms.GunaButton();
            this.EmployeeDataGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.Emppasstb = new ns1.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Brown;
            this.gunaLabel1.Location = new System.Drawing.Point(130, 60);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(186, 34);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Employees";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // Empnametb
            // 
            this.Empnametb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Empnametb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Empnametb.ForeColor = System.Drawing.Color.Brown;
            this.Empnametb.HintForeColor = System.Drawing.Color.Empty;
            this.Empnametb.HintText = "";
            this.Empnametb.isPassword = false;
            this.Empnametb.LineFocusedColor = System.Drawing.Color.Brown;
            this.Empnametb.LineIdleColor = System.Drawing.Color.Gray;
            this.Empnametb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.Empnametb.LineThickness = 3;
            this.Empnametb.Location = new System.Drawing.Point(27, 223);
            this.Empnametb.Margin = new System.Windows.Forms.Padding(4);
            this.Empnametb.Name = "Empnametb";
            this.Empnametb.Size = new System.Drawing.Size(162, 39);
            this.Empnametb.TabIndex = 5;
            this.Empnametb.Text = "Employee Name";
            this.Empnametb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // empagetb
            // 
            this.empagetb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empagetb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.empagetb.ForeColor = System.Drawing.Color.Brown;
            this.empagetb.HintForeColor = System.Drawing.Color.Empty;
            this.empagetb.HintText = "";
            this.empagetb.isPassword = false;
            this.empagetb.LineFocusedColor = System.Drawing.Color.Brown;
            this.empagetb.LineIdleColor = System.Drawing.Color.Gray;
            this.empagetb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.empagetb.LineThickness = 3;
            this.empagetb.Location = new System.Drawing.Point(27, 313);
            this.empagetb.Margin = new System.Windows.Forms.Padding(4);
            this.empagetb.Name = "empagetb";
            this.empagetb.Size = new System.Drawing.Size(147, 39);
            this.empagetb.TabIndex = 6;
            this.empagetb.Text = "Employee Age";
            this.empagetb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // empsaltb
            // 
            this.empsaltb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empsaltb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.empsaltb.ForeColor = System.Drawing.Color.Brown;
            this.empsaltb.HintForeColor = System.Drawing.Color.Empty;
            this.empsaltb.HintText = "";
            this.empsaltb.isPassword = false;
            this.empsaltb.LineFocusedColor = System.Drawing.Color.Brown;
            this.empsaltb.LineIdleColor = System.Drawing.Color.Gray;
            this.empsaltb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.empsaltb.LineThickness = 3;
            this.empsaltb.Location = new System.Drawing.Point(276, 136);
            this.empsaltb.Margin = new System.Windows.Forms.Padding(4);
            this.empsaltb.Name = "empsaltb";
            this.empsaltb.Size = new System.Drawing.Size(147, 39);
            this.empsaltb.TabIndex = 7;
            this.empsaltb.Text = "Salary";
            this.empsaltb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Empidtb
            // 
            this.Empidtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Empidtb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Empidtb.ForeColor = System.Drawing.Color.Brown;
            this.Empidtb.HintForeColor = System.Drawing.Color.Empty;
            this.Empidtb.HintText = "";
            this.Empidtb.isPassword = false;
            this.Empidtb.LineFocusedColor = System.Drawing.Color.Brown;
            this.Empidtb.LineIdleColor = System.Drawing.Color.Gray;
            this.Empidtb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.Empidtb.LineThickness = 3;
            this.Empidtb.Location = new System.Drawing.Point(27, 136);
            this.Empidtb.Margin = new System.Windows.Forms.Padding(4);
            this.Empidtb.Name = "Empidtb";
            this.Empidtb.Size = new System.Drawing.Size(147, 39);
            this.Empidtb.TabIndex = 10;
            this.Empidtb.Text = "Employee Id";
            this.Empidtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Empidtb.OnValueChanged += new System.EventHandler(this.Empidtb_OnValueChanged);
            // 
            // empphonetb
            // 
            this.empphonetb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empphonetb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.empphonetb.ForeColor = System.Drawing.Color.Brown;
            this.empphonetb.HintForeColor = System.Drawing.Color.Empty;
            this.empphonetb.HintText = "";
            this.empphonetb.isPassword = false;
            this.empphonetb.LineFocusedColor = System.Drawing.Color.Brown;
            this.empphonetb.LineIdleColor = System.Drawing.Color.Gray;
            this.empphonetb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.empphonetb.LineThickness = 3;
            this.empphonetb.Location = new System.Drawing.Point(276, 223);
            this.empphonetb.Margin = new System.Windows.Forms.Padding(4);
            this.empphonetb.Name = "empphonetb";
            this.empphonetb.Size = new System.Drawing.Size(147, 39);
            this.empphonetb.TabIndex = 11;
            this.empphonetb.Text = "Phone Number";
            this.empphonetb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AddEmpbtn
            // 
            this.AddEmpbtn.AnimationHoverSpeed = 0.07F;
            this.AddEmpbtn.AnimationSpeed = 0.03F;
            this.AddEmpbtn.BaseColor = System.Drawing.Color.Brown;
            this.AddEmpbtn.BorderColor = System.Drawing.Color.Black;
            this.AddEmpbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddEmpbtn.FocusedColor = System.Drawing.Color.Empty;
            this.AddEmpbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddEmpbtn.ForeColor = System.Drawing.Color.White;
            this.AddEmpbtn.Image = null;
            this.AddEmpbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddEmpbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.AddEmpbtn.Location = new System.Drawing.Point(27, 464);
            this.AddEmpbtn.Name = "AddEmpbtn";
            this.AddEmpbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.AddEmpbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddEmpbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.AddEmpbtn.OnHoverImage = null;
            this.AddEmpbtn.OnPressedColor = System.Drawing.Color.Black;
            this.AddEmpbtn.Size = new System.Drawing.Size(111, 43);
            this.AddEmpbtn.TabIndex = 12;
            this.AddEmpbtn.Text = "ADD";
            this.AddEmpbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddEmpbtn.Click += new System.EventHandler(this.AddEmpbtn_Click);
            // 
            // UpdateEmpbtn
            // 
            this.UpdateEmpbtn.AnimationHoverSpeed = 0.07F;
            this.UpdateEmpbtn.AnimationSpeed = 0.03F;
            this.UpdateEmpbtn.BaseColor = System.Drawing.Color.Brown;
            this.UpdateEmpbtn.BorderColor = System.Drawing.Color.Black;
            this.UpdateEmpbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.UpdateEmpbtn.FocusedColor = System.Drawing.Color.Empty;
            this.UpdateEmpbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UpdateEmpbtn.ForeColor = System.Drawing.Color.White;
            this.UpdateEmpbtn.Image = null;
            this.UpdateEmpbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpdateEmpbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.UpdateEmpbtn.Location = new System.Drawing.Point(178, 464);
            this.UpdateEmpbtn.Name = "UpdateEmpbtn";
            this.UpdateEmpbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.UpdateEmpbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.UpdateEmpbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.UpdateEmpbtn.OnHoverImage = null;
            this.UpdateEmpbtn.OnPressedColor = System.Drawing.Color.Black;
            this.UpdateEmpbtn.Size = new System.Drawing.Size(111, 43);
            this.UpdateEmpbtn.TabIndex = 13;
            this.UpdateEmpbtn.Text = "UPDATE";
            this.UpdateEmpbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpdateEmpbtn.Click += new System.EventHandler(this.UpdateEmpbtn_Click);
            // 
            // DelEmpbtn
            // 
            this.DelEmpbtn.AnimationHoverSpeed = 0.07F;
            this.DelEmpbtn.AnimationSpeed = 0.03F;
            this.DelEmpbtn.BaseColor = System.Drawing.Color.Brown;
            this.DelEmpbtn.BorderColor = System.Drawing.Color.Black;
            this.DelEmpbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DelEmpbtn.FocusedColor = System.Drawing.Color.Empty;
            this.DelEmpbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DelEmpbtn.ForeColor = System.Drawing.Color.White;
            this.DelEmpbtn.Image = null;
            this.DelEmpbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DelEmpbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.DelEmpbtn.Location = new System.Drawing.Point(312, 464);
            this.DelEmpbtn.Name = "DelEmpbtn";
            this.DelEmpbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.DelEmpbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.DelEmpbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.DelEmpbtn.OnHoverImage = null;
            this.DelEmpbtn.OnPressedColor = System.Drawing.Color.Black;
            this.DelEmpbtn.Size = new System.Drawing.Size(111, 43);
            this.DelEmpbtn.TabIndex = 14;
            this.DelEmpbtn.Text = "DELETE";
            this.DelEmpbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DelEmpbtn.Click += new System.EventHandler(this.DelEmpbtn_Click);
            // 
            // Backbtn
            // 
            this.Backbtn.AnimationHoverSpeed = 0.07F;
            this.Backbtn.AnimationSpeed = 0.03F;
            this.Backbtn.BaseColor = System.Drawing.Color.Brown;
            this.Backbtn.BorderColor = System.Drawing.Color.Black;
            this.Backbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Backbtn.FocusedColor = System.Drawing.Color.Empty;
            this.Backbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Backbtn.ForeColor = System.Drawing.Color.White;
            this.Backbtn.Image = null;
            this.Backbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Backbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.Backbtn.Location = new System.Drawing.Point(178, 525);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Backbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Backbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.Backbtn.OnHoverImage = null;
            this.Backbtn.OnPressedColor = System.Drawing.Color.Black;
            this.Backbtn.Size = new System.Drawing.Size(111, 43);
            this.Backbtn.TabIndex = 15;
            this.Backbtn.Text = "Back";
            this.Backbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // EmployeeDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.EmployeeDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.EmployeeDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmployeeDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeDataGridView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmployeeDataGridView.EnableHeadersVisualStyles = false;
            this.EmployeeDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeDataGridView.Location = new System.Drawing.Point(455, 12);
            this.EmployeeDataGridView.Name = "EmployeeDataGridView";
            this.EmployeeDataGridView.RowHeadersVisible = false;
            this.EmployeeDataGridView.RowHeadersWidth = 51;
            this.EmployeeDataGridView.RowTemplate.Height = 30;
            this.EmployeeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeDataGridView.Size = new System.Drawing.Size(696, 578);
            this.EmployeeDataGridView.TabIndex = 16;
            this.EmployeeDataGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.EmployeeDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmployeeDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmployeeDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmployeeDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmployeeDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Brown;
            this.EmployeeDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmployeeDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EmployeeDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmployeeDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmployeeDataGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.EmployeeDataGridView.ThemeStyle.ReadOnly = false;
            this.EmployeeDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmployeeDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EmployeeDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmployeeDataGridView.ThemeStyle.RowsStyle.Height = 30;
            this.EmployeeDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmployeeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeDataGridView_CellContentClick);
            // 
            // Emppasstb
            // 
            this.Emppasstb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Emppasstb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Emppasstb.ForeColor = System.Drawing.Color.Brown;
            this.Emppasstb.HintForeColor = System.Drawing.Color.Empty;
            this.Emppasstb.HintText = "";
            this.Emppasstb.isPassword = false;
            this.Emppasstb.LineFocusedColor = System.Drawing.Color.Brown;
            this.Emppasstb.LineIdleColor = System.Drawing.Color.Gray;
            this.Emppasstb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.Emppasstb.LineThickness = 3;
            this.Emppasstb.Location = new System.Drawing.Point(276, 313);
            this.Emppasstb.Margin = new System.Windows.Forms.Padding(4);
            this.Emppasstb.Name = "Emppasstb";
            this.Emppasstb.Size = new System.Drawing.Size(147, 39);
            this.Emppasstb.TabIndex = 17;
            this.Emppasstb.Text = "EmpPassword";
            this.Emppasstb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1174, 580);
            this.Controls.Add(this.Emppasstb);
            this.Controls.Add(this.EmployeeDataGridView);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.DelEmpbtn);
            this.Controls.Add(this.UpdateEmpbtn);
            this.Controls.Add(this.AddEmpbtn);
            this.Controls.Add(this.empphonetb);
            this.Controls.Add(this.Empidtb);
            this.Controls.Add(this.empsaltb);
            this.Controls.Add(this.empagetb);
            this.Controls.Add(this.Empnametb);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private ns1.BunifuMaterialTextbox Empnametb;
        private ns1.BunifuMaterialTextbox empagetb;
        private ns1.BunifuMaterialTextbox empsaltb;
        private ns1.BunifuMaterialTextbox Empidtb;
        private ns1.BunifuMaterialTextbox empphonetb;
        private Guna.UI.WinForms.GunaButton AddEmpbtn;
        private Guna.UI.WinForms.GunaButton UpdateEmpbtn;
        private Guna.UI.WinForms.GunaButton DelEmpbtn;
        private Guna.UI.WinForms.GunaButton Backbtn;
        private Guna.UI.WinForms.GunaDataGridView EmployeeDataGridView;
        private ns1.BunifuMaterialTextbox Emppasstb;
    }
}