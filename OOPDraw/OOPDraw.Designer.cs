﻿
namespace OOPDraw
{
    partial class OOPDraw
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;

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
        protected void InitializeComponent()
        {
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.LineWidth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Colour = new System.Windows.Forms.ComboBox();
            this.Label = new System.Windows.Forms.Label();
            this.Shape = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Action = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.SystemColors.Window;
            this.Canvas.Location = new System.Drawing.Point(150, 12);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(700, 473);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // LineWidth
            // 
            this.LineWidth.FormattingEnabled = true;
            this.LineWidth.Items.AddRange(new object[] {
            "Thin",
            "Medium",
            "Thick"});
            this.LineWidth.Location = new System.Drawing.Point(15, 49);
            this.LineWidth.Name = "LineWidth";
            this.LineWidth.Size = new System.Drawing.Size(121, 24);
            this.LineWidth.TabIndex = 1;
            this.LineWidth.SelectedIndexChanged += new System.EventHandler(this.LineWidth_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Line Width";
            // 
            // Colour
            // 
            this.Colour.FormattingEnabled = true;
            this.Colour.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.Colour.Location = new System.Drawing.Point(15, 114);
            this.Colour.Name = "Colour";
            this.Colour.Size = new System.Drawing.Size(121, 24);
            this.Colour.TabIndex = 3;
            this.Colour.SelectedIndexChanged += new System.EventHandler(this.Colour_SelectedIndexChanged);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(15, 94);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(49, 17);
            this.Label.TabIndex = 4;
            this.Label.Text = "Colour";
            // 
            // Shape
            // 
            this.Shape.FormattingEnabled = true;
            this.Shape.Items.AddRange(new object[] {
            "Line",
            "Rectangle",
            "Ellipse",
            "Circle"});
            this.Shape.Location = new System.Drawing.Point(15, 176);
            this.Shape.Name = "Shape";
            this.Shape.Size = new System.Drawing.Size(121, 24);
            this.Shape.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Shapes";
            // 
            // Action
            // 
            this.Action.FormattingEnabled = true;
            this.Action.Items.AddRange(new object[] {
            "Draw",
            "Move",
            "Select",
            "Group",
            "Delete",
            "Duplicate"});
            this.Action.Location = new System.Drawing.Point(15, 237);
            this.Action.Name = "Action";
            this.Action.Size = new System.Drawing.Size(121, 24);
            this.Action.TabIndex = 7;
            this.Action.SelectedIndexChanged += new System.EventHandler(this.Action_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Action";
            // 
            // OOPDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 497);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Action);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Shape);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.Colour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LineWidth);
            this.Controls.Add(this.Canvas);
            this.Name = "OOPDraw";
            this.Text = "OOPDraw";
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.PictureBox Canvas;
        protected System.Windows.Forms.ComboBox LineWidth;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ComboBox Colour;
        protected System.Windows.Forms.Label Label;
        protected System.Windows.Forms.ComboBox Shape;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Action;
        private System.Windows.Forms.Label label3;
    }
}

