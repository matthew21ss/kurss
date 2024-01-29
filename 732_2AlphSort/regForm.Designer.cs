namespace _732_2AlphSort
{
    partial class regForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(regForm));
            regLoginTB = new TextBox();
            regPwd1TB = new TextBox();
            regPwd2TB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            regButton = new Button();
            SuspendLayout();
            // 
            // regLoginTB
            // 
            regLoginTB.Location = new Point(18, 39);
            regLoginTB.Margin = new Padding(2);
            regLoginTB.Name = "regLoginTB";
            regLoginTB.Size = new Size(538, 27);
            regLoginTB.TabIndex = 0;
            regLoginTB.TextChanged += regLoginTB_TextChanged;
            // 
            // regPwd1TB
            // 
            regPwd1TB.Location = new Point(18, 103);
            regPwd1TB.Margin = new Padding(2);
            regPwd1TB.Name = "regPwd1TB";
            regPwd1TB.Size = new Size(538, 27);
            regPwd1TB.TabIndex = 1;
            // 
            // regPwd2TB
            // 
            regPwd2TB.Location = new Point(18, 167);
            regPwd2TB.Margin = new Padding(2);
            regPwd2TB.Name = "regPwd2TB";
            regPwd2TB.Size = new Size(538, 27);
            regPwd2TB.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 3;
            label1.Text = "Новый логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 81);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 145);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 5;
            label3.Text = "Повторить пароль";
            // 
            // regButton
            // 
            regButton.Location = new Point(22, 216);
            regButton.Margin = new Padding(2);
            regButton.Name = "regButton";
            regButton.Size = new Size(186, 27);
            regButton.TabIndex = 6;
            regButton.Text = "Зарегистрироваться";
            regButton.UseVisualStyleBackColor = true;
            regButton.Click += regButton_Click;
            // 
            // regForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(565, 262);
            Controls.Add(regButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(regPwd2TB);
            Controls.Add(regPwd1TB);
            Controls.Add(regLoginTB);
            Margin = new Padding(2);
            Name = "regForm";
            Text = "Регистрация";
            Load += regForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox regLoginTB;
        private TextBox regPwd1TB;
        private TextBox regPwd2TB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button regButton;
    }
}