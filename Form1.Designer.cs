namespace calculate_tax
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
            era = new ComboBox();
            label1 = new Label();
            txtYear = new TextBox();
            label2 = new Label();
            button1 = new Button();
            labelResult = new Label();
            label3 = new Label();
            labelEra = new Label();
            SuspendLayout();
            // 
            // era
            // 
            era.FormattingEnabled = true;
            era.Location = new Point(180, 70);
            era.Name = "era";
            era.Size = new Size(151, 28);
            era.TabIndex = 4;
            era.SelectedIndexChanged += era_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 35);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 5;
            label1.Text = "เลือกศักราชที่ต้องการจะแปลง";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(180, 178);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(151, 27);
            txtYear.TabIndex = 6;
            txtYear.TextChanged += txtYear_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 143);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 5;
            label2.Text = "ใส่ปี";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(180, 319);
            button1.Name = "button1";
            button1.Size = new Size(151, 45);
            button1.TabIndex = 7;
            button1.Text = "คำนวณ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(236, 249);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 20);
            labelResult.TabIndex = 8;
            labelResult.Click += labelResult_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 143);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 5;
            label3.Click += label2_Click;
            // 
            // labelEra
            // 
            labelEra.AutoSize = true;
            labelEra.Location = new Point(196, 249);
            labelEra.Name = "labelEra";
            labelEra.Size = new Size(0, 20);
            labelEra.TabIndex = 9;
            labelEra.Click += labelEra_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 450);
            Controls.Add(labelEra);
            Controls.Add(labelResult);
            Controls.Add(button1);
            Controls.Add(txtYear);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(era);
            Name = "Form1";
            Text = "Era";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox era;
        private Label label1;
        private TextBox txtYear;
        private Label label2;
        private Button button1;
        private Label labelResult;
        private Label label3;
        private Label labelEra;
    }
}
