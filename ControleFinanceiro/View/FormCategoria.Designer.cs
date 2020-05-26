namespace ControleFinanceiro.View
{
    partial class FormCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoria));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNovaCategoria = new System.Windows.Forms.Button();
            this.btnEditarCategoria = new System.Windows.Forms.Button();
            this.btnExcluirCategoria = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvTransacao = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacao)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Controls.Add(this.btnExcluirCategoria, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnEditarCategoria, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnNovaCategoria, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label13, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvTransacao, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(850, 669);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnNovaCategoria
            // 
            this.btnNovaCategoria.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNovaCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnNovaCategoria.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNovaCategoria.FlatAppearance.BorderSize = 0;
            this.btnNovaCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnNovaCategoria.Image")));
            this.btnNovaCategoria.Location = new System.Drawing.Point(339, 619);
            this.btnNovaCategoria.Name = "btnNovaCategoria";
            this.btnNovaCategoria.Size = new System.Drawing.Size(45, 40);
            this.btnNovaCategoria.TabIndex = 2;
            this.btnNovaCategoria.UseVisualStyleBackColor = false;
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnEditarCategoria.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditarCategoria.FlatAppearance.BorderSize = 0;
            this.btnEditarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarCategoria.Image")));
            this.btnEditarCategoria.Location = new System.Drawing.Point(402, 619);
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.Size = new System.Drawing.Size(45, 40);
            this.btnEditarCategoria.TabIndex = 3;
            this.btnEditarCategoria.UseVisualStyleBackColor = false;
            // 
            // btnExcluirCategoria
            // 
            this.btnExcluirCategoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnExcluirCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnExcluirCategoria.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluirCategoria.FlatAppearance.BorderSize = 0;
            this.btnExcluirCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirCategoria.Image")));
            this.btnExcluirCategoria.Location = new System.Drawing.Point(465, 619);
            this.btnExcluirCategoria.Name = "btnExcluirCategoria";
            this.btnExcluirCategoria.Size = new System.Drawing.Size(45, 40);
            this.btnExcluirCategoria.TabIndex = 4;
            this.btnExcluirCategoria.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label13.Location = new System.Drawing.Point(43, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(267, 44);
            this.label13.TabIndex = 5;
            this.label13.Text = "CATEGORIAS";
            // 
            // dgvTransacao
            // 
            this.dgvTransacao.AllowUserToAddRows = false;
            this.dgvTransacao.AllowUserToDeleteRows = false;
            this.dgvTransacao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dgvTransacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTransacao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvTransacao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransacao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransacao.ColumnHeadersHeight = 35;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvTransacao, 5);
            this.dgvTransacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransacao.EnableHeadersVisualStyles = false;
            this.dgvTransacao.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.dgvTransacao.Location = new System.Drawing.Point(43, 79);
            this.dgvTransacao.MultiSelect = false;
            this.dgvTransacao.Name = "dgvTransacao";
            this.dgvTransacao.ReadOnly = true;
            this.dgvTransacao.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTransacao.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransacao.Size = new System.Drawing.Size(763, 517);
            this.dgvTransacao.TabIndex = 6;
            // 
            // FormCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(868, 685);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCategoria";
            this.Text = "FormCategoria";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNovaCategoria;
        private System.Windows.Forms.Button btnEditarCategoria;
        private System.Windows.Forms.Button btnExcluirCategoria;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvTransacao;
    }
}