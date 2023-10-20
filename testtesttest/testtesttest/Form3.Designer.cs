namespace testtesttest
{
    partial class Form3
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
            listBoxFiles = new ListBox();
            buttonConnect = new Button();
            SuspendLayout();
            // 
            // listBoxFiles
            // 
            listBoxFiles.FormattingEnabled = true;
            listBoxFiles.ItemHeight = 15;
            listBoxFiles.Location = new Point(12, 12);
            listBoxFiles.Name = "listBoxFiles";
            listBoxFiles.Size = new Size(649, 274);
            listBoxFiles.TabIndex = 0;
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(457, 339);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(206, 62);
            buttonConnect.TabIndex = 1;
            buttonConnect.Text = "buttonConnect";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click_1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonConnect);
            Controls.Add(listBoxFiles);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxFiles;
        private Button buttonConnect;
    }
}