namespace AnalizadorLexico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.topPane = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnCompile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtErrors = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.RichTextBox();
            this.dgvTokens = new System.Windows.Forms.DataGridView();
            this.dgvcToken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblColumn = new System.Windows.Forms.Label();
            this.lblLines = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.topPane.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.topPane, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.445995F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.133318F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.42068F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(992, 554);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // topPane
            // 
            this.topPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.topPane.Controls.Add(this.btnSave);
            this.topPane.Controls.Add(this.btnOpen);
            this.topPane.Controls.Add(this.btnCompile);
            this.topPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topPane.Location = new System.Drawing.Point(3, 31);
            this.topPane.Name = "topPane";
            this.topPane.Size = new System.Drawing.Size(986, 21);
            this.topPane.TabIndex = 3;
            this.topPane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPane_MouseDown);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(156, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 21);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpen.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.ForeColor = System.Drawing.Color.Black;
            this.btnOpen.Location = new System.Drawing.Point(78, 0);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(78, 21);
            this.btnOpen.TabIndex = 9;
            this.btnOpen.Text = "Abrir";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnCompile
            // 
            this.btnCompile.BackColor = System.Drawing.SystemColors.Control;
            this.btnCompile.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCompile.FlatAppearance.BorderSize = 0;
            this.btnCompile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompile.ForeColor = System.Drawing.Color.Black;
            this.btnCompile.Location = new System.Drawing.Point(0, 0);
            this.btnCompile.Name = "btnCompile";
            this.btnCompile.Size = new System.Drawing.Size(78, 21);
            this.btnCompile.TabIndex = 6;
            this.btnCompile.Text = "Play";
            this.btnCompile.UseVisualStyleBackColor = false;
            this.btnCompile.Click += new System.EventHandler(this.btnCompile_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(986, 469);
            this.panel2.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvTokens);
            this.splitContainer1.Size = new System.Drawing.Size(986, 469);
            this.splitContainer1.SplitterDistance = 312;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtErrors);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtCode);
            this.splitContainer2.Size = new System.Drawing.Size(986, 312);
            this.splitContainer2.SplitterDistance = 328;
            this.splitContainer2.TabIndex = 1;
            // 
            // txtErrors
            // 
            this.txtErrors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtErrors.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtErrors.Location = new System.Drawing.Point(-526, 0);
            this.txtErrors.Multiline = true;
            this.txtErrors.Name = "txtErrors";
            this.txtErrors.Size = new System.Drawing.Size(854, 312);
            this.txtErrors.TabIndex = 1;
            // 
            // txtCode
            // 
            this.txtCode.AcceptsTab = true;
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCode.BulletIndent = 4;
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.Location = new System.Drawing.Point(0, 0);
            this.txtCode.Name = "txtCode";
            this.txtCode.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtCode.ShowSelectionMargin = true;
            this.txtCode.Size = new System.Drawing.Size(654, 312);
            this.txtCode.TabIndex = 0;
            this.txtCode.Text = "";
            this.txtCode.SelectionChanged += new System.EventHandler(this.txtCode_SelectionChanged);
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // dgvTokens
            // 
            this.dgvTokens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTokens.BackgroundColor = System.Drawing.Color.White;
            this.dgvTokens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTokens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTokens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTokens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcToken,
            this.dgvcType,
            this.dgvcValue});
            this.dgvTokens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTokens.GridColor = System.Drawing.Color.White;
            this.dgvTokens.Location = new System.Drawing.Point(0, 0);
            this.dgvTokens.Name = "dgvTokens";
            this.dgvTokens.ReadOnly = true;
            this.dgvTokens.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTokens.RowHeadersVisible = false;
            this.dgvTokens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTokens.Size = new System.Drawing.Size(986, 153);
            this.dgvTokens.TabIndex = 0;
            // 
            // dgvcToken
            // 
            this.dgvcToken.HeaderText = "Token";
            this.dgvcToken.Name = "dgvcToken";
            this.dgvcToken.ReadOnly = true;
            // 
            // dgvcType
            // 
            this.dgvcType.HeaderText = "Tipo";
            this.dgvcType.Name = "dgvcType";
            this.dgvcType.ReadOnly = true;
            // 
            // dgvcValue
            // 
            this.dgvcValue.HeaderText = "Valor";
            this.dgvcValue.Name = "dgvcValue";
            this.dgvcValue.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblColumn);
            this.panel1.Controls.Add(this.lblLines);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 533);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 18);
            this.panel1.TabIndex = 6;
            // 
            // lblColumn
            // 
            this.lblColumn.AutoSize = true;
            this.lblColumn.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblColumn.ForeColor = System.Drawing.Color.White;
            this.lblColumn.Location = new System.Drawing.Point(915, 0);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(34, 13);
            this.lblColumn.TabIndex = 1;
            this.lblColumn.Text = "COL: ";
            // 
            // lblLines
            // 
            this.lblLines.AutoSize = true;
            this.lblLines.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLines.ForeColor = System.Drawing.Color.White;
            this.lblLines.Location = new System.Drawing.Point(949, 0);
            this.lblLines.Name = "lblLines";
            this.lblLines.Size = new System.Drawing.Size(37, 13);
            this.lblLines.TabIndex = 0;
            this.lblLines.Text = "LINE: ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMinimize);
            this.panel3.Controls.Add(this.btnMaximize);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(986, 22);
            this.panel3.TabIndex = 7;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(747, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(78, 22);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.Text = "__";
            this.btnMinimize.UseVisualStyleBackColor = false;
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(825, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(78, 22);
            this.btnMaximize.TabIndex = 5;
            this.btnMaximize.Text = "•";
            this.btnMaximize.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(903, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 22);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(992, 554);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.topPane.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txtErrors;
        private System.Windows.Forms.DataGridView dgvTokens;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcToken;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcValue;
        private System.Windows.Forms.RichTextBox txtCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLines;
        private System.Windows.Forms.Label lblColumn;
        private System.Windows.Forms.Panel topPane;
        private System.Windows.Forms.Button btnCompile;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
    }
}

