﻿namespace FamaciaWindowsForms
{
    partial class Farmacia
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(632, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 431);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(12, 446);
            panel2.Name = "panel2";
            panel2.Size = new Size(1260, 178);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new Point(12, 224);
            panel3.Name = "panel3";
            panel3.Size = new Size(614, 216);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Location = new Point(12, 9);
            panel4.Name = "panel4";
            panel4.Size = new Size(613, 209);
            panel4.TabIndex = 3;
            // 
            // Farmacia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 632);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Farmacia";
            Text = "Farmacia";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}
