namespace PharmarcyManagementSystem
{
    partial class Billing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            this.BillingForm = new Guna.UI.WinForms.GunaLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Qty = new ns1.BunifuMaterialTextbox();
            this.Stockdbl = new System.Windows.Forms.Label();
            this.AddEmpbtn = new Guna.UI.WinForms.GunaButton();
            this.BillGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totalprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamount = new Guna.UI.WinForms.GunaLabel();
            this.Printbtn = new Guna.UI.WinForms.GunaButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BillingForm
            // 
            this.BillingForm.AutoSize = true;
            this.BillingForm.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BillingForm.ForeColor = System.Drawing.Color.Brown;
            this.BillingForm.Location = new System.Drawing.Point(12, 9);
            this.BillingForm.Name = "BillingForm";
            this.BillingForm.Size = new System.Drawing.Size(207, 34);
            this.BillingForm.TabIndex = 2;
            this.BillingForm.Text = "Billing Form";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(31, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Select Medicine";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // Qty
            // 
            this.Qty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Qty.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Qty.ForeColor = System.Drawing.Color.Brown;
            this.Qty.HintForeColor = System.Drawing.Color.Empty;
            this.Qty.HintText = "";
            this.Qty.isPassword = false;
            this.Qty.LineFocusedColor = System.Drawing.Color.Brown;
            this.Qty.LineIdleColor = System.Drawing.Color.Gray;
            this.Qty.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.Qty.LineThickness = 3;
            this.Qty.Location = new System.Drawing.Point(31, 205);
            this.Qty.Margin = new System.Windows.Forms.Padding(4);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(147, 39);
            this.Qty.TabIndex = 20;
            this.Qty.Text = "Quantity";
            this.Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Stockdbl
            // 
            this.Stockdbl.AutoSize = true;
            this.Stockdbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Stockdbl.Location = new System.Drawing.Point(36, 143);
            this.Stockdbl.Name = "Stockdbl";
            this.Stockdbl.Size = new System.Drawing.Size(134, 23);
            this.Stockdbl.TabIndex = 21;
            this.Stockdbl.Text = "Available Stock";
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
            this.AddEmpbtn.Location = new System.Drawing.Point(40, 280);
            this.AddEmpbtn.Name = "AddEmpbtn";
            this.AddEmpbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.AddEmpbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddEmpbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.AddEmpbtn.OnHoverImage = null;
            this.AddEmpbtn.OnPressedColor = System.Drawing.Color.Black;
            this.AddEmpbtn.Size = new System.Drawing.Size(111, 43);
            this.AddEmpbtn.TabIndex = 22;
            this.AddEmpbtn.Text = "Add To Bill";
            this.AddEmpbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddEmpbtn.Click += new System.EventHandler(this.AddEmpbtn_Click);
            // 
            // BillGridView
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.BillGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.BillGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillGridView.BackgroundColor = System.Drawing.Color.White;
            this.BillGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.BillGridView.ColumnHeadersHeight = 30;
            this.BillGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Medname,
            this.MedQty,
            this.Unitprice,
            this.Totalprice});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.BillGridView.EnableHeadersVisualStyles = false;
            this.BillGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillGridView.Location = new System.Drawing.Point(401, 12);
            this.BillGridView.Name = "BillGridView";
            this.BillGridView.RowHeadersVisible = false;
            this.BillGridView.RowHeadersWidth = 51;
            this.BillGridView.RowTemplate.Height = 30;
            this.BillGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillGridView.Size = new System.Drawing.Size(734, 462);
            this.BillGridView.TabIndex = 27;
            this.BillGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.BillGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BillGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BillGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BillGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BillGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BillGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BillGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Brown;
            this.BillGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BillGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BillGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BillGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BillGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.BillGridView.ThemeStyle.ReadOnly = false;
            this.BillGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BillGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BillGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BillGridView.ThemeStyle.RowsStyle.Height = 30;
            this.BillGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Id
            // 
            this.Id.HeaderText = "MedId";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            // 
            // Medname
            // 
            this.Medname.HeaderText = "Medname";
            this.Medname.MinimumWidth = 6;
            this.Medname.Name = "Medname";
            // 
            // MedQty
            // 
            this.MedQty.HeaderText = "Quantity";
            this.MedQty.MinimumWidth = 6;
            this.MedQty.Name = "MedQty";
            // 
            // Unitprice
            // 
            this.Unitprice.HeaderText = "UnitPrice";
            this.Unitprice.MinimumWidth = 6;
            this.Unitprice.Name = "Unitprice";
            // 
            // Totalprice
            // 
            this.Totalprice.HeaderText = "TotalPrice";
            this.Totalprice.MinimumWidth = 6;
            this.Totalprice.Name = "Totalprice";
            // 
            // totalamount
            // 
            this.totalamount.AutoSize = true;
            this.totalamount.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalamount.ForeColor = System.Drawing.Color.Brown;
            this.totalamount.Location = new System.Drawing.Point(652, 477);
            this.totalamount.Name = "totalamount";
            this.totalamount.Size = new System.Drawing.Size(229, 34);
            this.totalamount.TabIndex = 28;
            this.totalamount.Text = "Total Amount";
            // 
            // Printbtn
            // 
            this.Printbtn.AnimationHoverSpeed = 0.07F;
            this.Printbtn.AnimationSpeed = 0.03F;
            this.Printbtn.BaseColor = System.Drawing.Color.Brown;
            this.Printbtn.BorderColor = System.Drawing.Color.Black;
            this.Printbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Printbtn.FocusedColor = System.Drawing.Color.Empty;
            this.Printbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Printbtn.ForeColor = System.Drawing.Color.White;
            this.Printbtn.Image = null;
            this.Printbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Printbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.Printbtn.Location = new System.Drawing.Point(717, 525);
            this.Printbtn.Name = "Printbtn";
            this.Printbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Printbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Printbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.Printbtn.OnHoverImage = null;
            this.Printbtn.OnPressedColor = System.Drawing.Color.Black;
            this.Printbtn.Size = new System.Drawing.Size(111, 43);
            this.Printbtn.TabIndex = 29;
            this.Printbtn.Text = "PRINT";
            this.Printbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Printbtn.Click += new System.EventHandler(this.Printbtn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
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
            this.gunaButton1.Location = new System.Drawing.Point(497, 525);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(111, 43);
            this.gunaButton1.TabIndex = 30;
            this.gunaButton1.Text = "home";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 580);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.Printbtn);
            this.Controls.Add(this.totalamount);
            this.Controls.Add(this.BillGridView);
            this.Controls.Add(this.AddEmpbtn);
            this.Controls.Add(this.Stockdbl);
            this.Controls.Add(this.Qty);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BillingForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel BillingForm;
        private System.Windows.Forms.ComboBox comboBox1;
        private ns1.BunifuMaterialTextbox Qty;
        private System.Windows.Forms.Label Stockdbl;
        private Guna.UI.WinForms.GunaButton AddEmpbtn;
        private Guna.UI.WinForms.GunaDataGridView BillGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medname;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totalprice;
        private Guna.UI.WinForms.GunaLabel totalamount;
        private Guna.UI.WinForms.GunaButton Printbtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}