namespace PharmarcyManagementSystem
{
    partial class Company
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
            this.CompAddresstb = new ns1.BunifuMaterialTextbox();
            this.Compphonetb = new ns1.BunifuMaterialTextbox();
            this.CompIdtb = new ns1.BunifuMaterialTextbox();
            this.Compnametb = new ns1.BunifuMaterialTextbox();
            this.Backbtn = new Guna.UI.WinForms.GunaButton();
            this.DelCompbtn = new Guna.UI.WinForms.GunaButton();
            this.UpdateCompbtn = new Guna.UI.WinForms.GunaButton();
            this.AddCompbtn = new Guna.UI.WinForms.GunaButton();
            this.CompanyDataGridView = new Guna.UI.WinForms.GunaDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Brown;
            this.gunaLabel1.Location = new System.Drawing.Point(24, 84);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(379, 34);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Medicine Manufacturer";
            // 
            // CompAddresstb
            // 
            this.CompAddresstb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CompAddresstb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CompAddresstb.ForeColor = System.Drawing.Color.Brown;
            this.CompAddresstb.HintForeColor = System.Drawing.Color.Empty;
            this.CompAddresstb.HintText = "";
            this.CompAddresstb.isPassword = false;
            this.CompAddresstb.LineFocusedColor = System.Drawing.Color.Brown;
            this.CompAddresstb.LineIdleColor = System.Drawing.Color.Gray;
            this.CompAddresstb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.CompAddresstb.LineThickness = 3;
            this.CompAddresstb.Location = new System.Drawing.Point(243, 307);
            this.CompAddresstb.Margin = new System.Windows.Forms.Padding(4);
            this.CompAddresstb.Name = "CompAddresstb";
            this.CompAddresstb.Size = new System.Drawing.Size(147, 39);
            this.CompAddresstb.TabIndex = 21;
            this.CompAddresstb.Text = "Adress";
            this.CompAddresstb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Compphonetb
            // 
            this.Compphonetb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Compphonetb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Compphonetb.ForeColor = System.Drawing.Color.Brown;
            this.Compphonetb.HintForeColor = System.Drawing.Color.Empty;
            this.Compphonetb.HintText = "";
            this.Compphonetb.isPassword = false;
            this.Compphonetb.LineFocusedColor = System.Drawing.Color.Brown;
            this.Compphonetb.LineIdleColor = System.Drawing.Color.Gray;
            this.Compphonetb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.Compphonetb.LineThickness = 3;
            this.Compphonetb.Location = new System.Drawing.Point(243, 216);
            this.Compphonetb.Margin = new System.Windows.Forms.Padding(4);
            this.Compphonetb.Name = "Compphonetb";
            this.Compphonetb.Size = new System.Drawing.Size(147, 39);
            this.Compphonetb.TabIndex = 20;
            this.Compphonetb.Text = "PhoneNumber";
            this.Compphonetb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CompIdtb
            // 
            this.CompIdtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CompIdtb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CompIdtb.ForeColor = System.Drawing.Color.Brown;
            this.CompIdtb.HintForeColor = System.Drawing.Color.Empty;
            this.CompIdtb.HintText = "";
            this.CompIdtb.isPassword = false;
            this.CompIdtb.LineFocusedColor = System.Drawing.Color.Brown;
            this.CompIdtb.LineIdleColor = System.Drawing.Color.Gray;
            this.CompIdtb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.CompIdtb.LineThickness = 3;
            this.CompIdtb.Location = new System.Drawing.Point(30, 216);
            this.CompIdtb.Margin = new System.Windows.Forms.Padding(4);
            this.CompIdtb.Name = "CompIdtb";
            this.CompIdtb.Size = new System.Drawing.Size(147, 39);
            this.CompIdtb.TabIndex = 19;
            this.CompIdtb.Text = "CompanyId";
            this.CompIdtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Compnametb
            // 
            this.Compnametb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Compnametb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Compnametb.ForeColor = System.Drawing.Color.Brown;
            this.Compnametb.HintForeColor = System.Drawing.Color.Empty;
            this.Compnametb.HintText = "";
            this.Compnametb.isPassword = false;
            this.Compnametb.LineFocusedColor = System.Drawing.Color.Brown;
            this.Compnametb.LineIdleColor = System.Drawing.Color.Gray;
            this.Compnametb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.Compnametb.LineThickness = 3;
            this.Compnametb.Location = new System.Drawing.Point(30, 307);
            this.Compnametb.Margin = new System.Windows.Forms.Padding(4);
            this.Compnametb.Name = "Compnametb";
            this.Compnametb.Size = new System.Drawing.Size(162, 39);
            this.Compnametb.TabIndex = 18;
            this.Compnametb.Text = "CompanyName";
            this.Compnametb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.Backbtn.Location = new System.Drawing.Point(170, 510);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Backbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Backbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.Backbtn.OnHoverImage = null;
            this.Backbtn.OnPressedColor = System.Drawing.Color.Black;
            this.Backbtn.Size = new System.Drawing.Size(111, 43);
            this.Backbtn.TabIndex = 25;
            this.Backbtn.Text = "Back";
            this.Backbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // DelCompbtn
            // 
            this.DelCompbtn.AnimationHoverSpeed = 0.07F;
            this.DelCompbtn.AnimationSpeed = 0.03F;
            this.DelCompbtn.BaseColor = System.Drawing.Color.Brown;
            this.DelCompbtn.BorderColor = System.Drawing.Color.Black;
            this.DelCompbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DelCompbtn.FocusedColor = System.Drawing.Color.Empty;
            this.DelCompbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DelCompbtn.ForeColor = System.Drawing.Color.White;
            this.DelCompbtn.Image = null;
            this.DelCompbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DelCompbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.DelCompbtn.Location = new System.Drawing.Point(304, 449);
            this.DelCompbtn.Name = "DelCompbtn";
            this.DelCompbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.DelCompbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.DelCompbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.DelCompbtn.OnHoverImage = null;
            this.DelCompbtn.OnPressedColor = System.Drawing.Color.Black;
            this.DelCompbtn.Size = new System.Drawing.Size(111, 43);
            this.DelCompbtn.TabIndex = 24;
            this.DelCompbtn.Text = "DELETE";
            this.DelCompbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DelCompbtn.Click += new System.EventHandler(this.DelCompbtn_Click);
            // 
            // UpdateCompbtn
            // 
            this.UpdateCompbtn.AnimationHoverSpeed = 0.07F;
            this.UpdateCompbtn.AnimationSpeed = 0.03F;
            this.UpdateCompbtn.BaseColor = System.Drawing.Color.Brown;
            this.UpdateCompbtn.BorderColor = System.Drawing.Color.Black;
            this.UpdateCompbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.UpdateCompbtn.FocusedColor = System.Drawing.Color.Empty;
            this.UpdateCompbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UpdateCompbtn.ForeColor = System.Drawing.Color.White;
            this.UpdateCompbtn.Image = null;
            this.UpdateCompbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpdateCompbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.UpdateCompbtn.Location = new System.Drawing.Point(170, 449);
            this.UpdateCompbtn.Name = "UpdateCompbtn";
            this.UpdateCompbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.UpdateCompbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.UpdateCompbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.UpdateCompbtn.OnHoverImage = null;
            this.UpdateCompbtn.OnPressedColor = System.Drawing.Color.Black;
            this.UpdateCompbtn.Size = new System.Drawing.Size(111, 43);
            this.UpdateCompbtn.TabIndex = 23;
            this.UpdateCompbtn.Text = "UPDATE";
            this.UpdateCompbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpdateCompbtn.Click += new System.EventHandler(this.UpdateCompbtn_Click);
            // 
            // AddCompbtn
            // 
            this.AddCompbtn.AnimationHoverSpeed = 0.07F;
            this.AddCompbtn.AnimationSpeed = 0.03F;
            this.AddCompbtn.BaseColor = System.Drawing.Color.Brown;
            this.AddCompbtn.BorderColor = System.Drawing.Color.Black;
            this.AddCompbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddCompbtn.FocusedColor = System.Drawing.Color.Empty;
            this.AddCompbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddCompbtn.ForeColor = System.Drawing.Color.White;
            this.AddCompbtn.Image = null;
            this.AddCompbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddCompbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.AddCompbtn.Location = new System.Drawing.Point(19, 449);
            this.AddCompbtn.Name = "AddCompbtn";
            this.AddCompbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.AddCompbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddCompbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.AddCompbtn.OnHoverImage = null;
            this.AddCompbtn.OnPressedColor = System.Drawing.Color.Black;
            this.AddCompbtn.Size = new System.Drawing.Size(111, 43);
            this.AddCompbtn.TabIndex = 22;
            this.AddCompbtn.Text = "ADD";
            this.AddCompbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddCompbtn.Click += new System.EventHandler(this.AddCompbtn_Click);
            // 
            // CompanyDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CompanyDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CompanyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CompanyDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.CompanyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CompanyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CompanyDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CompanyDataGridView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CompanyDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.CompanyDataGridView.EnableHeadersVisualStyles = false;
            this.CompanyDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CompanyDataGridView.Location = new System.Drawing.Point(456, 26);
            this.CompanyDataGridView.Name = "CompanyDataGridView";
            this.CompanyDataGridView.RowHeadersVisible = false;
            this.CompanyDataGridView.RowHeadersWidth = 51;
            this.CompanyDataGridView.RowTemplate.Height = 30;
            this.CompanyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CompanyDataGridView.Size = new System.Drawing.Size(696, 563);
            this.CompanyDataGridView.TabIndex = 26;
            this.CompanyDataGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.CompanyDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CompanyDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CompanyDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CompanyDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CompanyDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CompanyDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CompanyDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CompanyDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Brown;
            this.CompanyDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CompanyDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CompanyDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CompanyDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CompanyDataGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.CompanyDataGridView.ThemeStyle.ReadOnly = false;
            this.CompanyDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CompanyDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CompanyDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CompanyDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CompanyDataGridView.ThemeStyle.RowsStyle.Height = 30;
            this.CompanyDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CompanyDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CompanyDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CompanyDataGridView_CellContentClick);
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 580);
            this.Controls.Add(this.CompanyDataGridView);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.DelCompbtn);
            this.Controls.Add(this.UpdateCompbtn);
            this.Controls.Add(this.AddCompbtn);
            this.Controls.Add(this.CompAddresstb);
            this.Controls.Add(this.Compphonetb);
            this.Controls.Add(this.CompIdtb);
            this.Controls.Add(this.Compnametb);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Company";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company";
            this.Load += new System.EventHandler(this.Company_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CompanyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private ns1.BunifuMaterialTextbox CompAddresstb;
        private ns1.BunifuMaterialTextbox Compphonetb;
        private ns1.BunifuMaterialTextbox CompIdtb;
        private ns1.BunifuMaterialTextbox Compnametb;
        private Guna.UI.WinForms.GunaButton Backbtn;
        private Guna.UI.WinForms.GunaButton DelCompbtn;
        private Guna.UI.WinForms.GunaButton UpdateCompbtn;
        private Guna.UI.WinForms.GunaButton AddCompbtn;
        private Guna.UI.WinForms.GunaDataGridView CompanyDataGridView;
    }
}