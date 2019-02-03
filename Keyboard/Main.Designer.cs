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
            this.SuspendLayout();
            // 
            // groupBoxInstrument
            // 
            this.groupBoxInstrument.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBoxInstrument.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxInstrument.Location = new System.Drawing.Point(0, 415);
            this.groupBoxInstrument.Name = "groupBoxInstrument";
            this.groupBoxInstrument.Size = new System.Drawing.Size(716, 138);
            this.groupBoxInstrument.TabIndex = 0;
            this.groupBoxInstrument.TabStop = false;
            // 
            // groupBoxKeys
            // 
            this.groupBoxKeys.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBoxKeys.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxKeys.Location = new System.Drawing.Point(0, 0);
            this.groupBoxKeys.Name = "groupBoxKeys";
            this.groupBoxKeys.Size = new System.Drawing.Size(716, 337);
            this.groupBoxKeys.TabIndex = 0;
            this.groupBoxKeys.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(716, 553);
            this.Controls.Add(this.groupBoxKeys);
            this.Controls.Add(this.groupBoxInstrument);
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInstrument;
        private System.Windows.Forms.GroupBox groupBoxKeys;
    }
}

