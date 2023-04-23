using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB_Slider
{
    public partial class Form1 : Form
    {
        private bool isTrackingEnabled = false;

        [DllImport("user32.dll")]
        private static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("gdi32.dll")]
        private static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);


        public Form1()
        {
            InitializeComponent();
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            TrackPixel1.CheckedChanged += TrackPixel1_CheckedChanged;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rvalue.Text = Convert.ToString(rtrack.Value);
            gvalue.Text = Convert.ToString(gtrack.Value);
            bvalue.Text = Convert.ToString(btrack.Value);

            pictureBox1.BackColor = Color.FromArgb(rtrack.Value, gtrack.Value, btrack.Value);

            int red = rtrack.Value;
            int green = gtrack.Value;
            int blue = btrack.Value;

            // Create a Color object using RGB values
            Color color = Color.FromArgb(red, green, blue);

            // Convert the Color object to hex string
            string hexValue = color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");


            HexValue.Text = "Hex Value : #" + hexValue;
        }

        private void SendSetClr_Click(object sender, EventArgs e)
        {

            int red = Convert.ToInt32(textBox1.Text); rtrack.Value = red;
            int green = Convert.ToInt32(textBox2.Text); gtrack.Value = green;
            int blue = Convert.ToInt32(textBox3.Text); btrack.Value = blue;

            pictureBox1.BackColor = Color.FromArgb(red, green, blue);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void TrackPixel1_CheckedChanged(object sender, EventArgs e)
        {
            isTrackingEnabled = TrackPixel1.Checked;

            if (isTrackingEnabled)
            {
                timer2.Start();
            }
            else
            {
                timer2.Stop();
            }

        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {

            while (true)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                if (isTrackingEnabled)
                {
                    Point cursorPosition = Cursor.Position;
                    Color pixelColor = GetPixelColor(cursorPosition);

                    worker.ReportProgress(0, pixelColor);
                }

                Thread.Sleep(100); // Adjust this value to control the tracking speed
            }
        }

        private Color GetPixelColor(Point cursorPosition)
        {
            IntPtr hdc = GetDC(IntPtr.Zero);
            uint pixel = GetPixel(hdc, cursorPosition.X, cursorPosition.Y);
            ReleaseDC(IntPtr.Zero, hdc);

            Color color = Color.FromArgb((int)(pixel & 0x000000FF),
                                          (int)(pixel & 0x0000FF00) >> 8,
                                          (int)(pixel & 0x00FF0000) >> 16);

            return color;
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Color pixelColor = (Color)e.UserState;
            label1.Text = $"R:{pixelColor.R} G:{pixelColor.G} B:{pixelColor.B}";
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            Point cursorPosition = Cursor.Position;
            Color pixelColor = GetPixelColor(cursorPosition);
            //label1.Text = $"R:{pixelColor.R} G:{pixelColor.G} B:{pixelColor.B}";

            int red = pixelColor.R; rtrack.Value = red;
            int green = pixelColor.G; gtrack.Value = green;
            int blue = pixelColor.B; btrack.Value = blue;
        }

        private void siticoneCheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
