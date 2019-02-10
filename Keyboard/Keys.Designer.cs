namespace Keyboard
{
    partial class Keys
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonKey = new System.Windows.Forms.Button();
            this.timerDuration = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonKey
            // 
            this.buttonKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKey.Location = new System.Drawing.Point(0, 0);
            this.buttonKey.Name = "buttonKey";
            this.buttonKey.Size = new System.Drawing.Size(75, 23);
            this.buttonKey.TabIndex = 0;
            this.buttonKey.Text = "buttonKey";
            this.buttonKey.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonKey.UseVisualStyleBackColor = true;
            this.buttonKey.Click += new System.EventHandler(this.buttonKey_Click);
            // 
            // timerDuration
            // 
            this.timerDuration.Tick += new System.EventHandler(this.timerDuration_Tick);
            // 
            // Keys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonKey);
            this.Name = "Keys";
            this.Size = new System.Drawing.Size(94, 160);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKey;
        private System.Windows.Forms.Timer timerDuration;
    }
}
