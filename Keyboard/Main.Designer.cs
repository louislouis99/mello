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
            this.groupBoxInstrument = new System.Windows.Forms.GroupBox();
            this.groupBoxKeys = new System.Windows.Forms.GroupBox();
            this.progressBarDuration = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // groupBoxInstrument
            // 
            this.groupBoxInstrument.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBoxInstrument.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxInstrument.Location = new System.Drawing.Point(0, 158);
            this.groupBoxInstrument.Name = "groupBoxInstrument";
            this.groupBoxInstrument.Size = new System.Drawing.Size(1924, 69);
            this.groupBoxInstrument.TabIndex = 0;
            this.groupBoxInstrument.TabStop = false;
            // 
            // groupBoxKeys
            // 
            this.groupBoxKeys.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBoxKeys.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxKeys.Location = new System.Drawing.Point(0, 0);
            this.groupBoxKeys.Name = "groupBoxKeys";
            this.groupBoxKeys.Size = new System.Drawing.Size(1924, 116);
            this.groupBoxKeys.TabIndex = 0;
            this.groupBoxKeys.TabStop = false;
            // 
            // progressBarDuration
            // 
            this.progressBarDuration.ForeColor = System.Drawing.Color.Black;
            this.progressBarDuration.Location = new System.Drawing.Point(12, 116);
            this.progressBarDuration.Maximum = 7000;
            this.progressBarDuration.Name = "progressBarDuration";
            this.progressBarDuration.Size = new System.Drawing.Size(494, 10);
            this.progressBarDuration.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1924, 227);
            this.Controls.Add(this.progressBarDuration);
            this.Controls.Add(this.groupBoxKeys);
            this.Controls.Add(this.groupBoxInstrument);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Main";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInstrument;
        private System.Windows.Forms.GroupBox groupBoxKeys;
        private System.Windows.Forms.ProgressBar progressBarDuration;
    }
}

