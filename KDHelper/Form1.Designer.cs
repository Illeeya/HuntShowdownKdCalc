
namespace KDHelper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currentKdBtn = new System.Windows.Forms.Button();
            this.desiredKdBtn = new System.Windows.Forms.Button();
            this.dividerLbl = new System.Windows.Forms.Label();
            this.currentKdLabel = new System.Windows.Forms.Label();
            this.killsNeededLbl = new System.Windows.Forms.Label();
            this.currentKillsLbl = new System.Windows.Forms.Label();
            this.currentDeathsLbl = new System.Windows.Forms.Label();
            this.desiredKdLbl = new System.Windows.Forms.Label();
            this.deathsInput = new System.Windows.Forms.NumericUpDown();
            this.killsInput = new System.Windows.Forms.NumericUpDown();
            this.desiredKdInput = new System.Windows.Forms.NumericUpDown();
            this.currentKdValueLbl = new System.Windows.Forms.Label();
            this.killsNeededValueLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deathsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.killsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desiredKdInput)).BeginInit();
            this.SuspendLayout();
            // 
            // currentKdBtn
            // 
            this.currentKdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentKdBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.currentKdBtn.Location = new System.Drawing.Point(50, 120);
            this.currentKdBtn.Name = "currentKdBtn";
            this.currentKdBtn.Size = new System.Drawing.Size(300, 50);
            this.currentKdBtn.TabIndex = 0;
            this.currentKdBtn.Text = "Calculate current KD";
            this.currentKdBtn.UseVisualStyleBackColor = true;
            this.currentKdBtn.Click += new System.EventHandler(this.currentKdBtn_Click);
            // 
            // desiredKdBtn
            // 
            this.desiredKdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.desiredKdBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.desiredKdBtn.Location = new System.Drawing.Point(450, 120);
            this.desiredKdBtn.Name = "desiredKdBtn";
            this.desiredKdBtn.Size = new System.Drawing.Size(300, 50);
            this.desiredKdBtn.TabIndex = 1;
            this.desiredKdBtn.Text = "Calculate desired KD";
            this.desiredKdBtn.UseVisualStyleBackColor = true;
            this.desiredKdBtn.Click += new System.EventHandler(this.desiredKdBtn_Click);
            // 
            // dividerLbl
            // 
            this.dividerLbl.AutoSize = true;
            this.dividerLbl.Location = new System.Drawing.Point(396, 10);
            this.dividerLbl.Name = "dividerLbl";
            this.dividerLbl.Size = new System.Drawing.Size(9, 234);
            this.dividerLbl.TabIndex = 2;
            this.dividerLbl.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // currentKdLabel
            // 
            this.currentKdLabel.AutoSize = true;
            this.currentKdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentKdLabel.Location = new System.Drawing.Point(50, 200);
            this.currentKdLabel.Name = "currentKdLabel";
            this.currentKdLabel.Size = new System.Drawing.Size(130, 25);
            this.currentKdLabel.TabIndex = 3;
            this.currentKdLabel.Text = "Current KD: ";
            // 
            // killsNeededLbl
            // 
            this.killsNeededLbl.AutoSize = true;
            this.killsNeededLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.killsNeededLbl.Location = new System.Drawing.Point(450, 200);
            this.killsNeededLbl.Name = "killsNeededLbl";
            this.killsNeededLbl.Size = new System.Drawing.Size(170, 25);
            this.killsNeededLbl.TabIndex = 4;
            this.killsNeededLbl.Text = "Deaths needed: ";
            // 
            // currentKillsLbl
            // 
            this.currentKillsLbl.AutoSize = true;
            this.currentKillsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentKillsLbl.Location = new System.Drawing.Point(50, 15);
            this.currentKillsLbl.Name = "currentKillsLbl";
            this.currentKillsLbl.Size = new System.Drawing.Size(58, 25);
            this.currentKillsLbl.TabIndex = 5;
            this.currentKillsLbl.Text = "Kills:";
            // 
            // currentDeathsLbl
            // 
            this.currentDeathsLbl.AutoSize = true;
            this.currentDeathsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentDeathsLbl.Location = new System.Drawing.Point(230, 15);
            this.currentDeathsLbl.Name = "currentDeathsLbl";
            this.currentDeathsLbl.Size = new System.Drawing.Size(92, 25);
            this.currentDeathsLbl.TabIndex = 6;
            this.currentDeathsLbl.Text = "Deaths: ";
            // 
            // desiredKdLbl
            // 
            this.desiredKdLbl.AutoSize = true;
            this.desiredKdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.desiredKdLbl.Location = new System.Drawing.Point(450, 15);
            this.desiredKdLbl.Name = "desiredKdLbl";
            this.desiredKdLbl.Size = new System.Drawing.Size(127, 25);
            this.desiredKdLbl.TabIndex = 7;
            this.desiredKdLbl.Text = "Desired KD:";
            // 
            // deathsInput
            // 
            this.deathsInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deathsInput.Location = new System.Drawing.Point(230, 60);
            this.deathsInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.deathsInput.Name = "deathsInput";
            this.deathsInput.Size = new System.Drawing.Size(120, 29);
            this.deathsInput.TabIndex = 9;
            // 
            // killsInput
            // 
            this.killsInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.killsInput.Location = new System.Drawing.Point(50, 60);
            this.killsInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.killsInput.Name = "killsInput";
            this.killsInput.Size = new System.Drawing.Size(120, 29);
            this.killsInput.TabIndex = 10;
            // 
            // desiredKdInput
            // 
            this.desiredKdInput.DecimalPlaces = 2;
            this.desiredKdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.desiredKdInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.desiredKdInput.Location = new System.Drawing.Point(450, 60);
            this.desiredKdInput.Name = "desiredKdInput";
            this.desiredKdInput.Size = new System.Drawing.Size(150, 29);
            this.desiredKdInput.TabIndex = 11;
            // 
            // currentKdValueLbl
            // 
            this.currentKdValueLbl.AutoSize = true;
            this.currentKdValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentKdValueLbl.Location = new System.Drawing.Point(174, 196);
            this.currentKdValueLbl.Name = "currentKdValueLbl";
            this.currentKdValueLbl.Size = new System.Drawing.Size(0, 29);
            this.currentKdValueLbl.TabIndex = 12;
            // 
            // killsNeededValueLbl
            // 
            this.killsNeededValueLbl.AutoSize = true;
            this.killsNeededValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.killsNeededValueLbl.Location = new System.Drawing.Point(611, 197);
            this.killsNeededValueLbl.Name = "killsNeededValueLbl";
            this.killsNeededValueLbl.Size = new System.Drawing.Size(0, 29);
            this.killsNeededValueLbl.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 250);
            this.Controls.Add(this.killsNeededValueLbl);
            this.Controls.Add(this.currentKdValueLbl);
            this.Controls.Add(this.desiredKdInput);
            this.Controls.Add(this.killsInput);
            this.Controls.Add(this.deathsInput);
            this.Controls.Add(this.desiredKdLbl);
            this.Controls.Add(this.currentDeathsLbl);
            this.Controls.Add(this.currentKillsLbl);
            this.Controls.Add(this.killsNeededLbl);
            this.Controls.Add(this.currentKdLabel);
            this.Controls.Add(this.dividerLbl);
            this.Controls.Add(this.desiredKdBtn);
            this.Controls.Add(this.currentKdBtn);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.deathsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.killsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desiredKdInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button currentKdBtn;
        private System.Windows.Forms.Button desiredKdBtn;
        private System.Windows.Forms.Label dividerLbl;
        private System.Windows.Forms.Label currentKdLabel;
        private System.Windows.Forms.Label killsNeededLbl;
        private System.Windows.Forms.Label currentKillsLbl;
        private System.Windows.Forms.Label currentDeathsLbl;
        private System.Windows.Forms.Label desiredKdLbl;
        private System.Windows.Forms.NumericUpDown deathsInput;
        private System.Windows.Forms.NumericUpDown killsInput;
        private System.Windows.Forms.NumericUpDown desiredKdInput;
        private System.Windows.Forms.Label currentKdValueLbl;
        private System.Windows.Forms.Label killsNeededValueLbl;
    }
}

