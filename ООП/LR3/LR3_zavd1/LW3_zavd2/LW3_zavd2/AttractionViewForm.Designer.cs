namespace LW4_zavd2
{
    partial class AttractionViewForm
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
            pictureBox = new PictureBox();
            button3 = new Button();
            labelName = new Label();
            labelInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(12, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(246, 248);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.Location = new Point(222, 341);
            button3.Name = "button3";
            button3.Size = new Size(188, 53);
            button3.TabIndex = 4;
            button3.Text = "EXIT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(282, 30);
            labelName.Name = "labelName";
            labelName.Size = new Size(82, 20);
            labelName.TabIndex = 5;
            labelName.Text = "labelName";
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(282, 61);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(50, 20);
            labelInfo.TabIndex = 8;
            labelInfo.Text = "label4";
            // 
            // AttractionViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 450);
            Controls.Add(labelInfo);
            Controls.Add(labelName);
            Controls.Add(button3);
            Controls.Add(pictureBox);
            Name = "AttractionViewForm";
            Text = "AttractionViewForm";
            Load += AttractionViewForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Button button3;
        private Label labelName;
        private Label labelInfo;
    }
}