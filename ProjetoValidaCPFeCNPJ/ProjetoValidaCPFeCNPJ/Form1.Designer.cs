namespace ProjetoValidaCPFeCNPJ
{
    partial class Form1
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
            this.tabCNPJ = new System.Windows.Forms.TabPage();
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.btnValidaCNPJ = new System.Windows.Forms.Button();
            this.tabCPF = new System.Windows.Forms.TabPage();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.btnValidaCPF = new System.Windows.Forms.Button();
            this.tabCPFeCNPJ = new System.Windows.Forms.TabControl();
            this.tabCNPJ.SuspendLayout();
            this.tabCPF.SuspendLayout();
            this.tabCPFeCNPJ.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCNPJ
            // 
            this.tabCNPJ.Controls.Add(this.btnValidaCNPJ);
            this.tabCNPJ.Controls.Add(this.lblCNPJ);
            this.tabCNPJ.Controls.Add(this.txtCNPJ);
            this.tabCNPJ.Location = new System.Drawing.Point(4, 26);
            this.tabCNPJ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabCNPJ.Name = "tabCNPJ";
            this.tabCNPJ.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabCNPJ.Size = new System.Drawing.Size(559, 189);
            this.tabCNPJ.TabIndex = 1;
            this.tabCNPJ.Text = "CNPJ";
            this.tabCNPJ.UseVisualStyleBackColor = true;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(171, 64);
            this.txtCNPJ.Mask = "00,000,000/0000-00";
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(300, 22);
            this.txtCNPJ.TabIndex = 3;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(61, 67);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(86, 17);
            this.lblCNPJ.TabIndex = 4;
            this.lblCNPJ.Text = "Insira o CNPJ:";
            // 
            // btnValidaCNPJ
            // 
            this.btnValidaCNPJ.Location = new System.Drawing.Point(235, 127);
            this.btnValidaCNPJ.Name = "btnValidaCNPJ";
            this.btnValidaCNPJ.Size = new System.Drawing.Size(102, 27);
            this.btnValidaCNPJ.TabIndex = 5;
            this.btnValidaCNPJ.Text = "Validar";
            this.btnValidaCNPJ.UseVisualStyleBackColor = true;
            this.btnValidaCNPJ.Click += new System.EventHandler(this.btnValidaCNPJ_Click);
            // 
            // tabCPF
            // 
            this.tabCPF.Controls.Add(this.btnValidaCPF);
            this.tabCPF.Controls.Add(this.lblCPF);
            this.tabCPF.Controls.Add(this.txtCPF);
            this.tabCPF.Location = new System.Drawing.Point(4, 26);
            this.tabCPF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabCPF.Name = "tabCPF";
            this.tabCPF.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabCPF.Size = new System.Drawing.Size(559, 189);
            this.tabCPF.TabIndex = 0;
            this.tabCPF.Text = "CPF";
            this.tabCPF.UseVisualStyleBackColor = true;
            this.tabCPF.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(174, 64);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(300, 22);
            this.txtCPF.TabIndex = 0;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(64, 67);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(77, 17);
            this.lblCPF.TabIndex = 1;
            this.lblCPF.Text = "Insira o CPF:";
            // 
            // btnValidaCPF
            // 
            this.btnValidaCPF.Location = new System.Drawing.Point(238, 127);
            this.btnValidaCPF.Name = "btnValidaCPF";
            this.btnValidaCPF.Size = new System.Drawing.Size(102, 27);
            this.btnValidaCPF.TabIndex = 2;
            this.btnValidaCPF.Text = "Validar";
            this.btnValidaCPF.UseVisualStyleBackColor = true;
            this.btnValidaCPF.Click += new System.EventHandler(this.btnValidaCPF_Click);
            // 
            // tabCPFeCNPJ
            // 
            this.tabCPFeCNPJ.Controls.Add(this.tabCPF);
            this.tabCPFeCNPJ.Controls.Add(this.tabCNPJ);
            this.tabCPFeCNPJ.Location = new System.Drawing.Point(4, 1);
            this.tabCPFeCNPJ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabCPFeCNPJ.Name = "tabCPFeCNPJ";
            this.tabCPFeCNPJ.SelectedIndex = 0;
            this.tabCPFeCNPJ.Size = new System.Drawing.Size(567, 219);
            this.tabCPFeCNPJ.TabIndex = 0;
            this.tabCPFeCNPJ.Tag = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 223);
            this.Controls.Add(this.tabCPFeCNPJ);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabCNPJ.ResumeLayout(false);
            this.tabCNPJ.PerformLayout();
            this.tabCPF.ResumeLayout(false);
            this.tabCPF.PerformLayout();
            this.tabCPFeCNPJ.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabCNPJ;
        private System.Windows.Forms.Button btnValidaCNPJ;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.MaskedTextBox txtCNPJ;
        private System.Windows.Forms.TabPage tabCPF;
        private System.Windows.Forms.Button btnValidaCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.TabControl tabCPFeCNPJ;
    }
}

