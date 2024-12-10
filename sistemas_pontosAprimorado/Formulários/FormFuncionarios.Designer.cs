namespace sistemas_pontosAprimorado.Formulários
{
    partial class FormFuncionarios
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
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.dtGridFuncionario = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(627, 400);
            this.txtpesquisa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(186, 20);
            this.txtpesquisa.TabIndex = 0;
            this.txtpesquisa.TextChanged += new System.EventHandler(this.txtpesquisa_TextChanged);
            // 
            // dtGridFuncionario
            // 
            this.dtGridFuncionario.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dtGridFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridFuncionario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtGridFuncionario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridFuncionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtGridFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridFuncionario.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridFuncionario.DefaultCellStyle = dataGridViewCellStyle11;
            this.dtGridFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtGridFuncionario.EnableHeadersVisualStyles = false;
            this.dtGridFuncionario.Location = new System.Drawing.Point(0, 0);
            this.dtGridFuncionario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtGridFuncionario.Name = "dtGridFuncionario";
            this.dtGridFuncionario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtGridFuncionario.RowHeadersVisible = false;
            this.dtGridFuncionario.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dtGridFuncionario.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dtGridFuncionario.RowTemplate.Height = 24;
            this.dtGridFuncionario.Size = new System.Drawing.Size(844, 356);
            this.dtGridFuncionario.TabIndex = 2;
            this.dtGridFuncionario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridFuncionario_CellDoubleClick);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackgroundImage = global::sistemas_pontosAprimorado.Properties.Resources.phFundoLogin;
            this.btnAdicionar.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(11, 378);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(156, 45);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(502, 395);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pesquisar";
            // 
            // FormFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::sistemas_pontosAprimorado.Properties.Resources.phFundoLogin;
            this.ClientSize = new System.Drawing.Size(844, 431);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dtGridFuncionario);
            this.Controls.Add(this.txtpesquisa);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormFuncionarios";
            this.Text = "Formulário de funcionários";
            this.Load += new System.EventHandler(this.FormFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.DataGridView dtGridFuncionario;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label1;
    }
}