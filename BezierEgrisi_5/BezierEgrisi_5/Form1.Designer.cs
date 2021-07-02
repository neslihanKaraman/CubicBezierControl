
namespace BezierEgrisi_5
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
            this.myBezierCurve1 = new BezierEgrisi_5.MyBezierCurve();
            this.SuspendLayout();
            // 
            // myBezierCurve1
            // 
            this.myBezierCurve1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.myBezierCurve1.Location = new System.Drawing.Point(27, 26);
            this.myBezierCurve1.Name = "myBezierCurve1";
            this.myBezierCurve1.Pen_width = 5;
            this.myBezierCurve1.Size = new System.Drawing.Size(816, 457);
            this.myBezierCurve1.TabIndex = 0;
            this.myBezierCurve1.Text = "myBezierCurve1";
            this.myBezierCurve1.X1 = 10F;
            this.myBezierCurve1.X2 = 45F;
            this.myBezierCurve1.X3 = 55F;
            this.myBezierCurve1.X4 = 274F;
            this.myBezierCurve1.Y1 = 20F;
            this.myBezierCurve1.Y2 = 67F;
            this.myBezierCurve1.Y3 = 36F;
            this.myBezierCurve1.Y4 = 30F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 505);
            this.Controls.Add(this.myBezierCurve1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MyBezierCurve myBezierCurve1;
    }
}

