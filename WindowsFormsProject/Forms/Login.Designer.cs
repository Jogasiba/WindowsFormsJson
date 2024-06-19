namespace WindowsFormsProject
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginInput = new System.Windows.Forms.TextBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.senhaInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.emailCad = new System.Windows.Forms.TextBox();
            this.nomeCad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.senhaCad = new System.Windows.Forms.TextBox();
            this.loginCad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.teleCad = new System.Windows.Forms.MaskedTextBox();
            this.cpfCad = new System.Windows.Forms.MaskedTextBox();
            this.cepCad = new System.Windows.Forms.MaskedTextBox();
            this.lembreDeMimLog = new System.Windows.Forms.CheckBox();
            this.lembreDeMimCad = new System.Windows.Forms.CheckBox();
            this.btnCad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login";
            // 
            // loginInput
            // 
            this.loginInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginInput.Location = new System.Drawing.Point(260, 94);
            this.loginInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginInput.Name = "loginInput";
            this.loginInput.Size = new System.Drawing.Size(267, 22);
            this.loginInput.TabIndex = 2;
            this.loginInput.Leave += new System.EventHandler(this.loginInput_Leave);
            // 
            // btnLogar
            // 
            this.btnLogar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogar.Location = new System.Drawing.Point(327, 206);
            this.btnLogar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(129, 28);
            this.btnLogar.TabIndex = 3;
            this.btnLogar.Text = "Confirmar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // senhaInput
            // 
            this.senhaInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.senhaInput.Location = new System.Drawing.Point(260, 137);
            this.senhaInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.senhaInput.Name = "senhaInput";
            this.senhaInput.PasswordChar = '#';
            this.senhaInput.Size = new System.Drawing.Size(267, 22);
            this.senhaInput.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 550);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "CEP";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(289, 311);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 36);
            this.label6.TabIndex = 6;
            this.label6.Text = "CADASTRO";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 507);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "CPF";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 468);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Telefone";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(208, 425);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Email";
            // 
            // emailCad
            // 
            this.emailCad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailCad.Location = new System.Drawing.Point(259, 421);
            this.emailCad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailCad.Name = "emailCad";
            this.emailCad.Size = new System.Drawing.Size(267, 22);
            this.emailCad.TabIndex = 18;
            this.emailCad.Leave += new System.EventHandler(this.emailCad_Leave);
            // 
            // nomeCad
            // 
            this.nomeCad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nomeCad.Location = new System.Drawing.Point(259, 378);
            this.nomeCad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nomeCad.Name = "nomeCad";
            this.nomeCad.Size = new System.Drawing.Size(267, 22);
            this.nomeCad.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(207, 382);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Nome";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 636);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Senha";
            // 
            // senhaCad
            // 
            this.senhaCad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.senhaCad.Location = new System.Drawing.Point(259, 633);
            this.senhaCad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.senhaCad.Name = "senhaCad";
            this.senhaCad.PasswordChar = '#';
            this.senhaCad.Size = new System.Drawing.Size(267, 22);
            this.senhaCad.TabIndex = 22;
            // 
            // loginCad
            // 
            this.loginCad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginCad.Location = new System.Drawing.Point(259, 590);
            this.loginCad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginCad.Name = "loginCad";
            this.loginCad.Size = new System.Drawing.Size(267, 22);
            this.loginCad.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(207, 593);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Login";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button1.Location = new System.Drawing.Point(536, 134);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 28);
            this.button1.TabIndex = 24;
            this.button1.Text = "N";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button2.Location = new System.Drawing.Point(535, 629);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 28);
            this.button2.TabIndex = 25;
            this.button2.Text = "N";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // teleCad
            // 
            this.teleCad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.teleCad.Location = new System.Drawing.Point(259, 464);
            this.teleCad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teleCad.Mask = "(99) 0 00000-0000";
            this.teleCad.Name = "teleCad";
            this.teleCad.Size = new System.Drawing.Size(267, 22);
            this.teleCad.TabIndex = 26;
            // 
            // cpfCad
            // 
            this.cpfCad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cpfCad.Location = new System.Drawing.Point(259, 503);
            this.cpfCad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cpfCad.Mask = "000-000-000.00";
            this.cpfCad.Name = "cpfCad";
            this.cpfCad.Size = new System.Drawing.Size(267, 22);
            this.cpfCad.TabIndex = 27;
            // 
            // cepCad
            // 
            this.cepCad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cepCad.Location = new System.Drawing.Point(260, 546);
            this.cepCad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cepCad.Mask = "00000-000";
            this.cepCad.Name = "cepCad";
            this.cepCad.Size = new System.Drawing.Size(267, 22);
            this.cepCad.TabIndex = 28;
            this.cepCad.Leave += new System.EventHandler(this.cepCad_Leave);
            // 
            // lembreDeMimLog
            // 
            this.lembreDeMimLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lembreDeMimLog.Location = new System.Drawing.Point(325, 169);
            this.lembreDeMimLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lembreDeMimLog.Name = "lembreDeMimLog";
            this.lembreDeMimLog.Size = new System.Drawing.Size(131, 30);
            this.lembreDeMimLog.TabIndex = 29;
            this.lembreDeMimLog.Text = "Lembre de mim";
            this.lembreDeMimLog.UseVisualStyleBackColor = true;
            // 
            // lembreDeMimCad
            // 
            this.lembreDeMimCad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lembreDeMimCad.Location = new System.Drawing.Point(325, 665);
            this.lembreDeMimCad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lembreDeMimCad.Name = "lembreDeMimCad";
            this.lembreDeMimCad.Size = new System.Drawing.Size(131, 30);
            this.lembreDeMimCad.TabIndex = 31;
            this.lembreDeMimCad.Text = "Lembre de mim";
            this.lembreDeMimCad.UseVisualStyleBackColor = true;
            // 
            // btnCad
            // 
            this.btnCad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCad.Location = new System.Drawing.Point(327, 702);
            this.btnCad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(129, 28);
            this.btnCad.TabIndex = 30;
            this.btnCad.Text = "Confirmar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 791);
            this.Controls.Add(this.lembreDeMimCad);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.lembreDeMimLog);
            this.Controls.Add(this.cepCad);
            this.Controls.Add(this.cpfCad);
            this.Controls.Add(this.teleCad);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.senhaCad);
            this.Controls.Add(this.loginCad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.emailCad);
            this.Controls.Add(this.nomeCad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.senhaInput);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.loginInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginInput;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.TextBox senhaInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox emailCad;
        private System.Windows.Forms.TextBox nomeCad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox senhaCad;
        private System.Windows.Forms.TextBox loginCad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox teleCad;
        private System.Windows.Forms.MaskedTextBox cpfCad;
        private System.Windows.Forms.MaskedTextBox cepCad;
        private System.Windows.Forms.CheckBox lembreDeMimLog;
        private System.Windows.Forms.CheckBox lembreDeMimCad;
        private System.Windows.Forms.Button btnCad;
    }
}