namespace _732_2AlphSort
{
    partial class MainForm
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
            Input = new TextBox();
            MakeSort = new Button();
            Output = new Label();
            SuspendLayout();
            // 
            // Input
            // 
            Input.Location = new Point(52, 54);
            Input.Margin = new Padding(2);
            Input.Name = "Input";
            Input.Size = new Size(519, 27);
            Input.TabIndex = 0;
            Input.KeyPress += Input_TextChanged;
            // 
            // MakeSort
            // 
            MakeSort.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            MakeSort.Location = new Point(32, 204);
            MakeSort.Margin = new Padding(2);
            MakeSort.Name = "MakeSort";
            MakeSort.Size = new Size(518, 109);
            MakeSort.TabIndex = 1;
            MakeSort.Text = "Отсортировать";
            MakeSort.UseVisualStyleBackColor = true;
            MakeSort.Click += MakeSort_Click;
            // 
            // Output
            // 
            Output.AutoSize = true;
            Output.Location = new Point(203, 142);
            Output.Margin = new Padding(2, 0, 2, 0);
            Output.Name = "Output";
            Output.Size = new Size(217, 20);
            Output.TabIndex = 2;
            Output.Text = "Тут могла быть ваша реклама";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(Output);
            Controls.Add(MakeSort);
            Controls.Add(Input);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "Алфавитная сортировка";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Input;
        private Button MakeSort;
        private Label Output;
    }
}