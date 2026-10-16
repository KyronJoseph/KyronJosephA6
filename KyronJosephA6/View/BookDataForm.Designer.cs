namespace KyronJosephA6
{
    partial class BookDataForm
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
            chooseFileButton = new Button();
            exportDataCSVButton = new Button();
            exportDataJsonButton = new Button();
            SuspendLayout();
            // 
            // chooseFileButton
            // 
            chooseFileButton.Location = new Point(192, 146);
            chooseFileButton.Name = "chooseFileButton";
            chooseFileButton.Size = new Size(139, 29);
            chooseFileButton.TabIndex = 0;
            chooseFileButton.Text = "Choose File:";
            chooseFileButton.UseVisualStyleBackColor = true;
            chooseFileButton.Click += chooseFileButton_Click;
            // 
            // exportDataCSVButton
            // 
            exportDataCSVButton.Location = new Point(372, 146);
            exportDataCSVButton.Name = "exportDataCSVButton";
            exportDataCSVButton.Size = new Size(164, 29);
            exportDataCSVButton.TabIndex = 1;
            exportDataCSVButton.Text = "Export Data as CSV:";
            exportDataCSVButton.UseVisualStyleBackColor = true;
            exportDataCSVButton.Click += exportDataCSVButton_Click;
            // 
            // exportDataJsonButton
            // 
            exportDataJsonButton.Location = new Point(192, 201);
            exportDataJsonButton.Name = "exportDataJsonButton";
            exportDataJsonButton.Size = new Size(171, 29);
            exportDataJsonButton.TabIndex = 2;
            exportDataJsonButton.Text = "Export Data as JSON:";
            exportDataJsonButton.UseVisualStyleBackColor = true;
            exportDataJsonButton.Click += exportDataJsonButton_Click;
            // 
            // BookDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exportDataJsonButton);
            Controls.Add(exportDataCSVButton);
            Controls.Add(chooseFileButton);
            Name = "BookDataForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button chooseFileButton;
        private Button exportDataCSVButton;
        private Button exportDataJsonButton;
    }
}
