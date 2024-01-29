namespace _732_2AlphSort
{
    partial class authForm
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
            authLoginTB = new TextBox();
            authPwdTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            authLoginB = new Button();
            label3 = new Label();
            authGoReg = new LinkLabel();
            SuspendLayout();
            // 
            // authLoginTB
            // 
            authLoginTB.Location = new Point(18, 43);
            authLoginTB.Margin = new Padding(2);
            authLoginTB.Name = "authLoginTB";
            authLoginTB.Size = new Size(538, 27);
            authLoginTB.TabIndex = 0;
            authLoginTB.TextChanged += authLoginTB_TextChanged;
            // 
            // authPwdTB
            // 
            authPwdTB.Location = new Point(18, 109);
            authPwdTB.Margin = new Padding(2);
            authPwdTB.Name = "authPwdTB";
            authPwdTB.PasswordChar = '*';
            authPwdTB.Size = new Size(538, 27);
            authPwdTB.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 2;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 78);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 3;
            label2.Text = "Пароль";
            // 
            // authLoginB
            // 
            authLoginB.Location = new Point(20, 150);
            authLoginB.Margin = new Padding(2);
            authLoginB.Name = "authLoginB";
            authLoginB.Size = new Size(90, 27);
            authLoginB.TabIndex = 4;
            authLoginB.Text = "Войти";
            authLoginB.UseVisualStyleBackColor = true;
            authLoginB.Click += authLoginB_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 154);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(154, 20);
            label3.TabIndex = 5;
            label3.Text = "Нет учетной записи?";
            // 
            // authGoReg
            // 
            authGoReg.AutoSize = true;
            authGoReg.Location = new Point(412, 154);
            authGoReg.Margin = new Padding(2, 0, 2, 0);
            authGoReg.Name = "authGoReg";
            authGoReg.Size = new Size(151, 20);
            authGoReg.TabIndex = 6;
            authGoReg.TabStop = true;
            authGoReg.Text = "Зарегистрироваться";
            authGoReg.LinkClicked += authGoReg_LinkClicked;
            // 
            // authForm
            // 
            AcceptButton = authLoginB;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 201);
            Controls.Add(authGoReg);
            Controls.Add(label3);
            Controls.Add(authLoginB);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(authPwdTB);
            Controls.Add(authLoginTB);
            Margin = new Padding(2);
            Name = "authForm";
            Text = "Аутентификация";
            FormClosed += authForm_FormClosed;
            Load += authForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox authLoginTB;
        private TextBox authPwdTB;
        private Label label1;
        private Label label2;
        private Button authLoginB;
        private Label label3;
        private LinkLabel authGoReg;
    }
}