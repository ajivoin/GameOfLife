// andrewjivoin
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConwaysGameOfLife
{
    public partial class Form1 : Form
    {
        #region Vars
        private ColorTheme DEFAULT = new ColorTheme(Color.Cyan, Color.FromArgb(34, 34, 34));
        private ColorTheme DARK = new ColorTheme(Color.FromArgb(186, 186, 186), Color.FromArgb(10, 10, 10));
        private ColorTheme LIGHT = new ColorTheme(Color.Cyan, Color.White);
        private ColorTheme TERMINAL = new ColorTheme(Color.FromArgb(0, 225, 0), Color.Black);

        private ColorTheme current;

        private Game cgol;
        private Brush CELL_COLOR = Brushes.Cyan;
        private const int ROWS = 100;
        private const int COLUMNS = 100;
        private const int CELL_WIDTH = 6;
        public int generation;
        private bool pauseStatus = false;
        private List<bool[,]> grids = new List<bool[,]>();
        private bool autoplay = false;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Introduction introForm = new Introduction();
            introForm.ShowDialog();
            current = DEFAULT;
            pb.BackColor = current.GetBackground();
            cgol = new Game(new SolidBrush(current.GetForeground()), ROWS, COLUMNS, CELL_WIDTH);
            generation = 0;
            generationTimer.Start();
        }

        private void generationTimer_Tick(object sender, EventArgs e)
        {
            // attempting to add in code that auto-terminates a game that can no longer go on.
            grids.Add((bool[,])cgol.GetGrid().Clone());
            if (grids.Count >= 7 && cgol.Equals(grids[grids.Count - 7]) || grids.Count >= 3 && cgol.Equals(grids[grids.Count - 3]))
            {
                if (!autoplay)
                {
                    Pause();
                    MessageBox.Show("The game can go on no longer. Restarting...", "Game over!", MessageBoxButtons.OK);
                }
                Restart();
            }
            else
            {
                generation++;
                cgol.NewGeneration();
                lblGen.Text = generation.ToString();
                Refresh();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            cgol.Paint(e.Graphics);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            Pause();
        }

        private void verySlow2xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generationTimer.Interval = 1000 / 2;
        }

        private void slow4xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generationTimer.Interval = 1000 / 4;
        }

        private void normal8xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generationTimer.Interval = 1000 / 8;
        }

        private void fast12xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generationTimer.Interval = 1000 / 12;
        }

        private void veryFast32xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generationTimer.Interval = 1000 / 32;
        }

        private void superSpeed64xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generationTimer.Interval = 1000 / 64;
        }

        public int Generation
        {
            get
            {
                return generation;
            }
        }

        private void Restart()
        {
            cgol = new Game(new SolidBrush(current.GetForeground()), ROWS, COLUMNS, CELL_WIDTH);
            grids = new List<bool[,]>();
            generation = 0;
            btnPause.Text = "Pause";
            pauseStatus = false;
            generationTimer.Start();
            Refresh();
        }

        private void Pause()
        {
            pauseStatus = !pauseStatus;

            if (pauseStatus)
            {
                generationTimer.Stop();
                btnPause.Text = "Play";
            }
            else
            {
                generationTimer.Start();
                btnPause.Text = "Pause";
            }
        }

        private void cbAuto_CheckedChanged(object sender, EventArgs e)
        {
            autoplay = cbAuto.Checked;
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            current = DARK;
            ChangeTheme();
            Refresh();
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            current = LIGHT;
            ChangeTheme();
            Refresh();
        }

        private void ChangeTheme()
        {
            cgol.SetCellColor(current.GetForeground());
            pb.BackColor = current.GetBackground();
        }

        private void terminalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            current = TERMINAL;
            ChangeTheme();
            Refresh();
        }
    }
}
