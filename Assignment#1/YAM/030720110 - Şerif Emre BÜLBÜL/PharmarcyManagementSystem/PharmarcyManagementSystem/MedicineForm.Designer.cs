namespace PharmarcyManagementSystem
{
    partial class MedicineForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.MedicineGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.Mednametb = new ns1.BunifuMaterialTextbox();
            this.Bptb = new ns1.BunifuMaterialTextbox();
            this.sptb = new ns1.BunifuMaterialTextbox();
            this.qtytb = new ns1.BunifuMaterialTextbox();
            this.ExpireDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.companycb = new Guna.UI.WinForms.GunaComboBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Brown;
            this.gunaLabel1.Location = new System.Drawing.Point(12, 12);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(253, 34);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Medicine Stock";
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gunaDataGridView1.ColumnHeadersHeight = 4;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(761, 356);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowHeadersWidth = 51;
            this.gunaDataGridView1.RowTemplate.Height = 24;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(8, 8);
            this.gunaDataGridView1.TabIndex = 1;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MedicineGridView
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.MedicineGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.MedicineGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MedicineGridView.BackgroundColor = System.Drawing.Color.White;
            this.MedicineGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MedicineGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MedicineGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MedicineGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.MedicineGridView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MedicineGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.MedicineGridView.EnableHeadersVisualStyles = false;
            this.MedicineGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MedicineGridView.Location = new System.Drawing.Point(520, 12);
            this.MedicineGridView.Name = "MedicineGridView";
            this.MedicineGridView.RowHeadersVisible = false;
            this.MedicineGridView.RowHeadersWidth = 51;
            this.MedicineGridView.RowTemplate.Height = 30;
            this.MedicineGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MedicineGridView.Size = new System.Drawing.Size(642, 578);
            this.MedicineGridView.TabIndex = 2;
            this.MedicineGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.MedicineGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.MedicineGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.MedicineGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.MedicineGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.MedicineGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.MedicineGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.MedicineGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MedicineGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Brown;
            this.MedicineGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MedicineGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MedicineGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MedicineGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.MedicineGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.MedicineGridView.ThemeStyle.ReadOnly = false;
            this.MedicineGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.MedicineGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MedicineGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MedicineGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MedicineGridView.ThemeStyle.RowsStyle.Height = 30;
            this.MedicineGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MedicineGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MedicineGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MedicineGridView_CellContentClick);
            // 
            // Mednametb
            // 
            this.Mednametb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Mednametb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Mednametb.ForeColor = System.Drawing.Color.Brown;
            this.Mednametb.HintForeColor = System.Drawing.Color.Empty;
            this.Mednametb.HintText = "";
            this.Mednametb.isPassword = false;
            this.Mednametb.LineFocusedColor = System.Drawing.Color.Brown;
            this.Mednametb.LineIdleColor = System.Drawing.Color.Gray;
            this.Mednametb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.Mednametb.LineThickness = 3;
            this.Mednametb.Location = new System.Drawing.Point(13, 94);
            this.Mednametb.Margin = new System.Windows.Forms.Padding(4);
            this.Mednametb.Name = "Mednametb";
            this.Mednametb.Size = new System.Drawing.Size(147, 39);
            this.Mednametb.TabIndex = 3;
            this.Mednametb.Text = "MedicineName";
            this.Mednametb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Mednametb.OnValueChanged += new System.EventHandler(this.Mednametb_OnValueChanged);
            // 
            // Bptb
            // 
            this.Bptb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Bptb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Bptb.ForeColor = System.Drawing.Color.Brown;
            this.Bptb.HintForeColor = System.Drawing.Color.Empty;
            this.Bptb.HintText = "";
            this.Bptb.isPassword = false;
            this.Bptb.LineFocusedColor = System.Drawing.Color.Brown;
            this.Bptb.LineIdleColor = System.Drawing.Color.Gray;
            this.Bptb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.Bptb.LineThickness = 3;
            this.Bptb.Location = new System.Drawing.Point(350, 94);
            this.Bptb.Margin = new System.Windows.Forms.Padding(4);
            this.Bptb.Name = "Bptb";
            this.Bptb.Size = new System.Drawing.Size(147, 39);
            this.Bptb.TabIndex = 4;
            this.Bptb.Text = "BuyingPrice";
            this.Bptb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Bptb.OnValueChanged += new System.EventHandler(this.Bptb_OnValueChanged);
            // 
            // sptb
            // 
            this.sptb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sptb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.sptb.ForeColor = System.Drawing.Color.Brown;
            this.sptb.HintForeColor = System.Drawing.Color.Empty;
            this.sptb.HintText = "";
            this.sptb.isPassword = false;
            this.sptb.LineFocusedColor = System.Drawing.Color.Brown;
            this.sptb.LineIdleColor = System.Drawing.Color.Gray;
            this.sptb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.sptb.LineThickness = 3;
            this.sptb.Location = new System.Drawing.Point(350, 191);
            this.sptb.Margin = new System.Windows.Forms.Padding(4);
            this.sptb.Name = "sptb";
            this.sptb.Size = new System.Drawing.Size(147, 39);
            this.sptb.TabIndex = 5;
            this.sptb.Text = "SellingPrice";
            this.sptb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sptb.OnValueChanged += new System.EventHandler(this.sptb_OnValueChanged);
            // 
            // qtytb
            // 
            this.qtytb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.qtytb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.qtytb.ForeColor = System.Drawing.Color.Brown;
            this.qtytb.HintForeColor = System.Drawing.Color.Empty;
            this.qtytb.HintText = "";
            this.qtytb.isPassword = false;
            this.qtytb.LineFocusedColor = System.Drawing.Color.Brown;
            this.qtytb.LineIdleColor = System.Drawing.Color.Gray;
            this.qtytb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.qtytb.LineThickness = 3;
            this.qtytb.Location = new System.Drawing.Point(350, 280);
            this.qtytb.Margin = new System.Windows.Forms.Padding(4);
            this.qtytb.Name = "qtytb";
            this.qtytb.Size = new System.Drawing.Size(147, 39);
            this.qtytb.TabIndex = 6;
            this.qtytb.Text = "Quantity";
            this.qtytb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.qtytb.OnValueChanged += new System.EventHandler(this.qtytb_OnValueChanged);
            // 
            // ExpireDate
            // 
            this.ExpireDate.BaseColor = System.Drawing.Color.OrangeRed;
            this.ExpireDate.BorderColor = System.Drawing.Color.Silver;
            this.ExpireDate.CustomFormat = null;
            this.ExpireDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.ExpireDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ExpireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpireDate.ForeColor = System.Drawing.Color.White;
            this.ExpireDate.Location = new System.Drawing.Point(13, 172);
            this.ExpireDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ExpireDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ExpireDate.Name = "ExpireDate";
            this.ExpireDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.ExpireDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ExpireDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ExpireDate.OnPressedColor = System.Drawing.Color.Black;
            this.ExpireDate.Size = new System.Drawing.Size(219, 70);
            this.ExpireDate.TabIndex = 7;
            this.ExpireDate.Text = "Sunday, October 18, 2020";
            this.ExpireDate.Value = new System.DateTime(2020, 10, 18, 21, 45, 41, 823);
            // 
            // companycb
            // 
            this.companycb.BackColor = System.Drawing.Color.Transparent;
            this.companycb.BaseColor = System.Drawing.Color.White;
            this.companycb.BorderColor = System.Drawing.Color.Silver;
            this.companycb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.companycb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.companycb.FocusedColor = System.Drawing.Color.Empty;
            this.companycb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.companycb.ForeColor = System.Drawing.Color.Brown;
            this.companycb.FormattingEnabled = true;
            this.companycb.Location = new System.Drawing.Point(18, 297);
            this.companycb.Name = "companycb";
            this.companycb.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.companycb.OnHoverItemForeColor = System.Drawing.Color.White;
            this.companycb.Size = new System.Drawing.Size(171, 31);
            this.companycb.TabIndex = 8;
            this.companycb.SelectedIndexChanged += new System.EventHandler(this.companycb_SelectedIndexChanged);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.Brown;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(18, 417);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(111, 43);
            this.gunaButton1.TabIndex = 9;
            this.gunaButton1.Text = "ADD";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.Brown;
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(205, 417);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(111, 43);
            this.gunaButton2.TabIndex = 10;
            this.gunaButton2.Text = "UPDATE";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BaseColor = System.Drawing.Color.Brown;
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = null;
            this.gunaButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton3.Location = new System.Drawing.Point(386, 417);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Size = new System.Drawing.Size(111, 43);
            this.gunaButton3.TabIndex = 11;
            this.gunaButton3.Text = "DELETE";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton3.Click += new System.EventHandler(this.gunaButton3_Click);
            // 
            // gunaButton4
            // 
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BaseColor = System.Drawing.Color.Brown;
            this.gunaButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton4.ForeColor = System.Drawing.Color.White;
            this.gunaButton4.Image = null;
            this.gunaButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton4.Location = new System.Drawing.Point(205, 486);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Size = new System.Drawing.Size(111, 43);
            this.gunaButton4.TabIndex = 12;
            this.gunaButton4.Text = "Back";
            this.gunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton4.Click += new System.EventHandler(this.gunaButton4_Click);
            // 
            // MedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 580);
            this.Controls.Add(this.gunaButton4);
            this.Controls.Add(this.gunaButton3);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.companycb);
            this.Controls.Add(this.ExpireDate);
            this.Controls.Add(this.qtytb);
            this.Controls.Add(this.sptb);
            this.Controls.Add(this.Bptb);
            this.Controls.Add(this.Mednametb);
            this.Controls.Add(this.MedicineGridView);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicineForm";
            this.Load += new System.EventHandler(this.MedicineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Guna.UI.WinForms.GunaDataGridView MedicineGridView;
        private ns1.BunifuMaterialTextbox Mednametb;
        private ns1.BunifuMaterialTextbox Bptb;
        private ns1.BunifuMaterialTextbox sptb;
        private ns1.BunifuMaterialTextbox qtytb;
        private Guna.UI.WinForms.GunaDateTimePicker ExpireDate;
        private Guna.UI.WinForms.GunaComboBox companycb;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaButton gunaButton4;
    }
}