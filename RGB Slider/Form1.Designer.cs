
namespace RGB_Slider
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
            this.components = new System.ComponentModel.Container();
            this.gtrack = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.rtrack = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.btrack = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bvalue = new System.Windows.Forms.Label();
            this.gvalue = new System.Windows.Forms.Label();
            this.rvalue = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SendSetClr = new System.Windows.Forms.Button();
            this.HexValue = new System.Windows.Forms.Label();
            this.TrackPixel1 = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.siticoneCheckBox2 = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gtrack
            // 
            this.gtrack.Location = new System.Drawing.Point(30, 167);
            this.gtrack.Maximum = 255;
            this.gtrack.Name = "gtrack";
            this.gtrack.Size = new System.Drawing.Size(262, 23);
            this.gtrack.TabIndex = 0;
            this.gtrack.ThumbColor = System.Drawing.Color.Green;
            // 
            // rtrack
            // 
            this.rtrack.Location = new System.Drawing.Point(30, 138);
            this.rtrack.Maximum = 255;
            this.rtrack.Name = "rtrack";
            this.rtrack.Size = new System.Drawing.Size(262, 23);
            this.rtrack.TabIndex = 1;
            this.rtrack.ThumbColor = System.Drawing.Color.Red;
            // 
            // btrack
            // 
            this.btrack.Location = new System.Drawing.Point(30, 196);
            this.btrack.Maximum = 255;
            this.btrack.Name = "btrack";
            this.btrack.Size = new System.Drawing.Size(262, 23);
            this.btrack.TabIndex = 2;
            this.btrack.ThumbColor = System.Drawing.Color.Blue;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-39, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 126);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(4, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(4, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(4, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "B";
            // 
            // bvalue
            // 
            this.bvalue.AutoSize = true;
            this.bvalue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bvalue.ForeColor = System.Drawing.Color.Blue;
            this.bvalue.Location = new System.Drawing.Point(298, 196);
            this.bvalue.Name = "bvalue";
            this.bvalue.Size = new System.Drawing.Size(19, 21);
            this.bvalue.TabIndex = 9;
            this.bvalue.Text = "0";
            // 
            // gvalue
            // 
            this.gvalue.AutoSize = true;
            this.gvalue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvalue.ForeColor = System.Drawing.Color.Green;
            this.gvalue.Location = new System.Drawing.Point(298, 167);
            this.gvalue.Name = "gvalue";
            this.gvalue.Size = new System.Drawing.Size(19, 21);
            this.gvalue.TabIndex = 8;
            this.gvalue.Text = "0";
            // 
            // rvalue
            // 
            this.rvalue.AutoSize = true;
            this.rvalue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rvalue.ForeColor = System.Drawing.Color.Red;
            this.rvalue.Location = new System.Drawing.Point(298, 138);
            this.rvalue.Name = "rvalue";
            this.rvalue.Size = new System.Drawing.Size(19, 21);
            this.rvalue.TabIndex = 7;
            this.rvalue.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 249);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 249);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(222, 249);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(41, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Red";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(142, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Green";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(252, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Blue";
            // 
            // SendSetClr
            // 
            this.SendSetClr.Location = new System.Drawing.Point(13, 275);
            this.SendSetClr.Name = "SendSetClr";
            this.SendSetClr.Size = new System.Drawing.Size(309, 23);
            this.SendSetClr.TabIndex = 16;
            this.SendSetClr.Text = "Send Custom Color";
            this.SendSetClr.UseVisualStyleBackColor = true;
            this.SendSetClr.Click += new System.EventHandler(this.SendSetClr_Click);
            // 
            // HexValue
            // 
            this.HexValue.AutoSize = true;
            this.HexValue.ForeColor = System.Drawing.Color.Black;
            this.HexValue.Location = new System.Drawing.Point(5, 305);
            this.HexValue.Name = "HexValue";
            this.HexValue.Size = new System.Drawing.Size(62, 13);
            this.HexValue.TabIndex = 17;
            this.HexValue.Text = "Hex Value :";
            // 
            // TrackPixel1
            // 
            this.TrackPixel1.AutoSize = true;
            this.TrackPixel1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TrackPixel1.CheckedState.BorderRadius = 0;
            this.TrackPixel1.CheckedState.BorderThickness = 0;
            this.TrackPixel1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TrackPixel1.Location = new System.Drawing.Point(8, 326);
            this.TrackPixel1.Name = "TrackPixel1";
            this.TrackPixel1.Size = new System.Drawing.Size(127, 17);
            this.TrackPixel1.TabIndex = 18;
            this.TrackPixel1.Text = "Track Pixel Method 1";
            this.TrackPixel1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TrackPixel1.UncheckedState.BorderRadius = 0;
            this.TrackPixel1.UncheckedState.BorderThickness = 0;
            this.TrackPixel1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TrackPixel1.CheckedChanged += new System.EventHandler(this.TrackPixel1_CheckedChanged);
            // 
            // siticoneCheckBox2
            // 
            this.siticoneCheckBox2.AutoSize = true;
            this.siticoneCheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox2.CheckedState.BorderRadius = 0;
            this.siticoneCheckBox2.CheckedState.BorderThickness = 0;
            this.siticoneCheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox2.Location = new System.Drawing.Point(165, 326);
            this.siticoneCheckBox2.Name = "siticoneCheckBox2";
            this.siticoneCheckBox2.Size = new System.Drawing.Size(127, 17);
            this.siticoneCheckBox2.TabIndex = 19;
            this.siticoneCheckBox2.Text = "Track Pixel Method 1";
            this.siticoneCheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox2.UncheckedState.BorderRadius = 0;
            this.siticoneCheckBox2.UncheckedState.BorderThickness = 0;
            this.siticoneCheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox2.CheckedChanged += new System.EventHandler(this.siticoneCheckBox2_CheckedChanged);
            // 
            // worker
            // 
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            this.worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.worker_ProgressChanged);
            this.worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.worker_RunWorkerCompleted);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 355);
            this.Controls.Add(this.siticoneCheckBox2);
            this.Controls.Add(this.TrackPixel1);
            this.Controls.Add(this.HexValue);
            this.Controls.Add(this.SendSetClr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bvalue);
            this.Controls.Add(this.gvalue);
            this.Controls.Add(this.rvalue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btrack);
            this.Controls.Add(this.rtrack);
            this.Controls.Add(this.gtrack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar gtrack;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar rtrack;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar btrack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label bvalue;
        private System.Windows.Forms.Label gvalue;
        private System.Windows.Forms.Label rvalue;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SendSetClr;
        private System.Windows.Forms.Label HexValue;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox TrackPixel1;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox siticoneCheckBox2;
        private System.ComponentModel.BackgroundWorker worker;
        private System.Windows.Forms.Timer timer2;
    }
}

