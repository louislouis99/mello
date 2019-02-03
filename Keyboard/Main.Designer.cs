namespace Keyboard
{
    partial class Main
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
            this.Instruments = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Instruments
            // 
            this.Instruments.FormattingEnabled = true;
            this.Instruments.ItemHeight = 16;
            this.Instruments.Location = new System.Drawing.Point(23, 308);
            this.Instruments.Name = "Instruments";
            this.Instruments.Size = new System.Drawing.Size(388, 228);
            this.Instruments.TabIndex = 0;
            this.Instruments.SelectedIndexChanged += new System.EventHandler(this.Instruments_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1379, 553);
            this.Controls.Add(this.Instruments);
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Instruments;
    }
}

