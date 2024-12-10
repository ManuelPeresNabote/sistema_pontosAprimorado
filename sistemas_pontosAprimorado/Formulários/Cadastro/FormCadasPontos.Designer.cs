namespace sistemas_pontosAprimorado.Formulários.Cadastro
{
    partial class FormCadasPontos
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpHoraSaida = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.cbFuncionarios = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Image = global::sistemas_pontosAprimorado.Properties.Resources.fundoMenu;
            this.label4.Location = new System.Drawing.Point(20, 248);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Hora da saída";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Image = global::sistemas_pontosAprimorado.Properties.Resources.fundoMenu;
            this.label3.Location = new System.Drawing.Point(22, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Hora da entrada";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Image = global::sistemas_pontosAprimorado.Properties.Resources.fundoMenu;
            this.label2.Location = new System.Drawing.Point(22, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Data da entrada";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = global::sistemas_pontosAprimorado.Properties.Resources.fundoMenu;
            this.label1.Location = new System.Drawing.Point(19, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Funcionário";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpHoraSaida
            // 
            this.dtpHoraSaida.CustomFormat = "hh:mm:ss";
            this.dtpHoraSaida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraSaida.Location = new System.Drawing.Point(22, 272);
            this.dtpHoraSaida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpHoraSaida.Name = "dtpHoraSaida";
            this.dtpHoraSaida.Size = new System.Drawing.Size(145, 20);
            this.dtpHoraSaida.TabIndex = 13;
            this.dtpHoraSaida.ValueChanged += new System.EventHandler(this.dtpHoraSaida_ValueChanged);
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.CustomFormat = "hh:mm:ss";
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraEntrada.Location = new System.Drawing.Point(22, 216);
            this.dtpHoraEntrada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.Size = new System.Drawing.Size(145, 20);
            this.dtpHoraEntrada.TabIndex = 12;
            this.dtpHoraEntrada.Value = new System.DateTime(2024, 12, 9, 19, 26, 9, 0);
            this.dtpHoraEntrada.ValueChanged += new System.EventHandler(this.dtpHoraEntrada_ValueChanged);
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(22, 159);
            this.dtpData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(145, 20);
            this.dtpData.TabIndex = 11;
            this.dtpData.ValueChanged += new System.EventHandler(this.dtpData_ValueChanged);
            // 
            // cbFuncionarios
            // 
            this.cbFuncionarios.FormattingEnabled = true;
            this.cbFuncionarios.Location = new System.Drawing.Point(22, 96);
            this.cbFuncionarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFuncionarios.Name = "cbFuncionarios";
            this.cbFuncionarios.Size = new System.Drawing.Size(145, 21);
            this.cbFuncionarios.TabIndex = 10;
            this.cbFuncionarios.SelectedIndexChanged += new System.EventHandler(this.cbFuncionarios_SelectedIndexChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(25, 314);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(151, 42);
            this.btnCadastrar.TabIndex = 18;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // FormCadasPontos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sistemas_pontosAprimorado.Properties.Resources.fundoMenu;
            this.ClientSize = new System.Drawing.Size(202, 366);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpHoraSaida);
            this.Controls.Add(this.dtpHoraEntrada);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.cbFuncionarios);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCadasPontos";
            this.Text = "Cadastrar ponto";
            this.Load += new System.EventHandler(this.FormCadasPontos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpHoraSaida;
        private System.Windows.Forms.DateTimePicker dtpHoraEntrada;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.ComboBox cbFuncionarios;
        private System.Windows.Forms.Button btnCadastrar;
    }
}