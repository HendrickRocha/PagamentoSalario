namespace PagamentoSalario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cpf_lbl = new System.Windows.Forms.Label();
            this.nome_lbl = new System.Windows.Forms.Label();
            this.valorHora_lbl = new System.Windows.Forms.Label();
            this.horasTrabalhadas_lbl = new System.Windows.Forms.Label();
            this.salario_lbl = new System.Windows.Forms.Label();
            this.cpf_txtb = new System.Windows.Forms.TextBox();
            this.nome_txtb = new System.Windows.Forms.TextBox();
            this.valorHora_txtb = new System.Windows.Forms.TextBox();
            this.horasTrabalhas_txtb = new System.Windows.Forms.TextBox();
            this.salario_txtb = new System.Windows.Forms.TextBox();
            this.calc_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cpf_lbl
            // 
            this.cpf_lbl.AutoSize = true;
            this.cpf_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpf_lbl.Location = new System.Drawing.Point(12, 29);
            this.cpf_lbl.Name = "cpf_lbl";
            this.cpf_lbl.Size = new System.Drawing.Size(48, 30);
            this.cpf_lbl.TabIndex = 0;
            this.cpf_lbl.Text = "CPF";
            // 
            // nome_lbl
            // 
            this.nome_lbl.AutoSize = true;
            this.nome_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nome_lbl.Location = new System.Drawing.Point(12, 87);
            this.nome_lbl.Name = "nome_lbl";
            this.nome_lbl.Size = new System.Drawing.Size(70, 30);
            this.nome_lbl.TabIndex = 1;
            this.nome_lbl.Text = "Nome";
            // 
            // valorHora_lbl
            // 
            this.valorHora_lbl.AutoSize = true;
            this.valorHora_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valorHora_lbl.Location = new System.Drawing.Point(12, 151);
            this.valorHora_lbl.Name = "valorHora_lbl";
            this.valorHora_lbl.Size = new System.Drawing.Size(110, 30);
            this.valorHora_lbl.TabIndex = 2;
            this.valorHora_lbl.Text = "Valor Hora";
            // 
            // horasTrabalhadas_lbl
            // 
            this.horasTrabalhadas_lbl.AutoSize = true;
            this.horasTrabalhadas_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.horasTrabalhadas_lbl.Location = new System.Drawing.Point(12, 217);
            this.horasTrabalhadas_lbl.Name = "horasTrabalhadas_lbl";
            this.horasTrabalhadas_lbl.Size = new System.Drawing.Size(183, 30);
            this.horasTrabalhadas_lbl.TabIndex = 3;
            this.horasTrabalhadas_lbl.Text = "Horas Trabalhadas";
            // 
            // salario_lbl
            // 
            this.salario_lbl.AutoSize = true;
            this.salario_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salario_lbl.Location = new System.Drawing.Point(12, 284);
            this.salario_lbl.Name = "salario_lbl";
            this.salario_lbl.Size = new System.Drawing.Size(75, 30);
            this.salario_lbl.TabIndex = 4;
            this.salario_lbl.Text = "Salário";
            this.salario_lbl.Click += new System.EventHandler(this.label5_Click);
            // 
            // cpf_txtb
            // 
            this.cpf_txtb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpf_txtb.Location = new System.Drawing.Point(86, 30);
            this.cpf_txtb.MaxLength = 11;
            this.cpf_txtb.Name = "cpf_txtb";
            this.cpf_txtb.Size = new System.Drawing.Size(200, 29);
            this.cpf_txtb.TabIndex = 5;
            // 
            // nome_txtb
            // 
            this.nome_txtb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nome_txtb.Location = new System.Drawing.Point(86, 88);
            this.nome_txtb.Name = "nome_txtb";
            this.nome_txtb.Size = new System.Drawing.Size(200, 29);
            this.nome_txtb.TabIndex = 6;
            // 
            // valorHora_txtb
            // 
            this.valorHora_txtb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valorHora_txtb.Location = new System.Drawing.Point(128, 152);
            this.valorHora_txtb.Name = "valorHora_txtb";
            this.valorHora_txtb.Size = new System.Drawing.Size(200, 29);
            this.valorHora_txtb.TabIndex = 7;
            // 
            // horasTrabalhas_txtb
            // 
            this.horasTrabalhas_txtb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.horasTrabalhas_txtb.Location = new System.Drawing.Point(201, 218);
            this.horasTrabalhas_txtb.Name = "horasTrabalhas_txtb";
            this.horasTrabalhas_txtb.Size = new System.Drawing.Size(200, 29);
            this.horasTrabalhas_txtb.TabIndex = 8;
            // 
            // salario_txtb
            // 
            this.salario_txtb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salario_txtb.Location = new System.Drawing.Point(93, 285);
            this.salario_txtb.Name = "salario_txtb";
            this.salario_txtb.ReadOnly = true;
            this.salario_txtb.Size = new System.Drawing.Size(200, 29);
            this.salario_txtb.TabIndex = 9;
            // 
            // calc_btn
            // 
            this.calc_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calc_btn.Location = new System.Drawing.Point(86, 357);
            this.calc_btn.Name = "calc_btn";
            this.calc_btn.Size = new System.Drawing.Size(200, 57);
            this.calc_btn.TabIndex = 10;
            this.calc_btn.Text = "Calcular";
            this.calc_btn.UseVisualStyleBackColor = true;
            this.calc_btn.Click += new System.EventHandler(this.calc_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.calc_btn);
            this.Controls.Add(this.salario_txtb);
            this.Controls.Add(this.horasTrabalhas_txtb);
            this.Controls.Add(this.valorHora_txtb);
            this.Controls.Add(this.nome_txtb);
            this.Controls.Add(this.cpf_txtb);
            this.Controls.Add(this.salario_lbl);
            this.Controls.Add(this.horasTrabalhadas_lbl);
            this.Controls.Add(this.valorHora_lbl);
            this.Controls.Add(this.nome_lbl);
            this.Controls.Add(this.cpf_lbl);
            this.Name = "Form1";
            this.Text = "Calculo Salário";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label cpf_lbl;
        private Label nome_lbl;
        private Label valorHora_lbl;
        private Label horasTrabalhadas_lbl;
        private Label salario_lbl;
        private TextBox cpf_txtb;
        private TextBox nome_txtb;
        private TextBox valorHora_txtb;
        private TextBox horasTrabalhas_txtb;
        private TextBox salario_txtb;
        private Button calc_btn;
    }
}