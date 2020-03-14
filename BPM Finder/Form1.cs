using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

// AvgBPM
// NearestWhole
// TapTimes

namespace BPM_Finder
{
    public partial class MainForm : Form
    {
        private Stopwatch BPMTimer { get; set; } = new Stopwatch();
        private bool IsFirstTap { get; set; } = true;
        private int TimesTapped { get; set; } = 0;
        private double AverageBPM { get; set; } = 0;

        //private const double epsilon = 1e-20; // Used to compare time reference to desired reset time; assumes 20 digit precision

        public MainForm()
        {
            InitializeComponent();
        }

        #region Events
        private void TapButton_Click(object sender, EventArgs e)
        {
            UpdateBPM();
        }

        private void ResetBPMButton_Click(object sender, EventArgs e)
        {
            ResetBPM();
            TapButton.Focus();
        }

        private void SecondsToReset_Click(object sender, EventArgs e)
        {
            ResetTimer.Interval = (int)SecondsToReset.Value * 1000;
            TapButton.Focus();
        }
        private void ResetTimer_Tick(object sender, EventArgs e)
        {
            ResetBPM();
        }
        #endregion

        #region Helpers
        private void UpdateBPM()
        {
            if (IsFirstTap)
            {
                StartRecordingBPM();
            }
            else
            {
                ++TimesTapped;

                AverageBPM = TimesTapped * (60 / BPMTimer.Elapsed.TotalSeconds);

                ResetTimer.Restart();

                AvgBPM.Text = string.Format("{0:0.00}", AverageBPM);
                NearestWhole.Text = (Math.Round(AverageBPM)).ToString();
                TapTimes.Text = TimesTapped.ToString();
            }

            MetronomeImage.Image =
                    ((TimesTapped % 2) == 1)
                    ? Properties.Resources.Metronome1
                    : Properties.Resources.Metronome0;
        }

        private void StartRecordingBPM()
        {
            IsFirstTap = false;
            ResetTimer.Start();
            BPMTimer.Reset();
            BPMTimer.Start();

            ++TimesTapped;

            AvgBPM.Text = NearestWhole.Text = TapTimes.Text = "First beat";
        }

        private void ResetBPM()
        {
            ResetTimer.Stop();
            if (BPMTimer.IsRunning)
            {
                BPMTimer.Stop();
            }

            IsFirstTap = true;
            TimesTapped = 0;
            AverageBPM = 0;

            MetronomeImage.Image = Properties.Resources.Metronome0;
            AvgBPM.Text = NearestWhole.Text = TapTimes.Text = "-";
        }
        #endregion
    }

    public static class FormExtensions
    {
        public static void Restart(this Component comp)
        {
            if (comp is null)
            {
                throw new ArgumentNullException(nameof(comp));
            }

            System.Windows.Forms.Timer timer = comp as System.Windows.Forms.Timer;

            if (timer is null)
            {
                throw new ArgumentOutOfRangeException(nameof(timer));
            }

            timer.Stop();
            timer.Start();
        }
    }
}
