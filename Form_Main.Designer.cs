namespace MNM_OOA_NumerosAleatorios
{
    partial class Form_Main
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
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.btn_SaveInDisc = new System.Windows.Forms.Button();
            this.btn_GenerateNumber = new System.Windows.Forms.Button();
            this.tb_ShowRandomNumber = new System.Windows.Forms.TextBox();
            this.btn_GenerateTxt = new System.Windows.Forms.Button();
            this.pnl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.btn_GenerateTxt);
            this.pnl_Main.Controls.Add(this.btn_SaveInDisc);
            this.pnl_Main.Controls.Add(this.btn_GenerateNumber);
            this.pnl_Main.Controls.Add(this.tb_ShowRandomNumber);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(304, 206);
            this.pnl_Main.TabIndex = 0;
            // 
            // btn_SaveInDisc
            // 
            this.btn_SaveInDisc.Location = new System.Drawing.Point(115, 117);
            this.btn_SaveInDisc.Name = "btn_SaveInDisc";
            this.btn_SaveInDisc.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveInDisc.TabIndex = 2;
            this.btn_SaveInDisc.Text = "Salvar";
            this.btn_SaveInDisc.UseVisualStyleBackColor = true;
            this.btn_SaveInDisc.Click += new System.EventHandler(this.btn_SaveInDisc_Click);
            // 
            // btn_GenerateNumber
            // 
            this.btn_GenerateNumber.Location = new System.Drawing.Point(115, 88);
            this.btn_GenerateNumber.Name = "btn_GenerateNumber";
            this.btn_GenerateNumber.Size = new System.Drawing.Size(75, 23);
            this.btn_GenerateNumber.TabIndex = 1;
            this.btn_GenerateNumber.Text = "Gerar nº";
            this.btn_GenerateNumber.UseVisualStyleBackColor = true;
            this.btn_GenerateNumber.Click += new System.EventHandler(this.btn_GenerateNumber_Click);
            // 
            // tb_ShowRandomNumber
            // 
            this.tb_ShowRandomNumber.Location = new System.Drawing.Point(76, 38);
            this.tb_ShowRandomNumber.Name = "tb_ShowRandomNumber";
            this.tb_ShowRandomNumber.Size = new System.Drawing.Size(153, 20);
            this.tb_ShowRandomNumber.TabIndex = 0;
            // 
            // btn_GenerateTxt
            // 
            this.btn_GenerateTxt.Location = new System.Drawing.Point(115, 146);
            this.btn_GenerateTxt.Name = "btn_GenerateTxt";
            this.btn_GenerateTxt.Size = new System.Drawing.Size(75, 23);
            this.btn_GenerateTxt.TabIndex = 3;
            this.btn_GenerateTxt.Text = "Gerar TXT";
            this.btn_GenerateTxt.UseVisualStyleBackColor = true;
            this.btn_GenerateTxt.Click += new System.EventHandler(this.btn_GenerateTxt_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 206);
            this.Controls.Add(this.pnl_Main);
            this.Name = "Form_Main";
            this.Text = "Gerador de Números Aleatórios";
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Button btn_SaveInDisc;
        private System.Windows.Forms.Button btn_GenerateNumber;
        private System.Windows.Forms.TextBox tb_ShowRandomNumber;
        private System.Windows.Forms.Button btn_GenerateTxt;
    }
}

