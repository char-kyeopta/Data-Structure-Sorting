using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting
{
    public partial class Form1 : Form
    {
        List<Button> buttons;
        int[] arr;

        public Form1()
        {
            InitializeComponent();
            buttons = new List<Button>();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            int value = (int)numericUpDown1.Value;

            Button btn = new Button()
            {
                BackColor = Content.fillColor,
                ForeColor = Content.foreColor,
                Font = new Font("Century Gothic", 11F),
                Size = new Size(Content.WIDTH_SIZE, Content.HEIGHT_SIZE),
                Text = value.ToString()
            };
            btn.Location = new Point(
                Content.DISTANCE + pnlSimulation.Controls.Count * (btn.Width + Content.DISTANCE),
                pnlSimulation.Height / 2 - btn.Height / 2);
            pnlSimulation.Controls.Add(btn);
            buttons.Add(btn);

            btnRun.Enabled = pnlSimulation.Controls.Count >= 2;

            btnAddNote.Enabled = pnlSimulation.Controls.Count < 10;
            this.AcceptButton = pnlSimulation.Controls.Count < 10 ? btnAddNote : null;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            arr = new int[buttons.Count];
            for (int i = 0; i < buttons.Count; i++)
                arr[i] = Convert.ToInt32(buttons[i].Text);

            if (cboAlgorithms.SelectedIndex == 0)
                bgwBubbleSort.RunWorkerAsync();
            else if (cboAlgorithms.SelectedIndex == 1)
                bgwSelectionSort.RunWorkerAsync();
            else if (cboAlgorithms.SelectedIndex == 2)
                bgwQuickSort.RunWorkerAsync();
            else if (cboAlgorithms.SelectedIndex == 3)
                bgwInsertionSort.RunWorkerAsync();
            btnAddNote.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            buttons = new List<Button>();
            pnlSimulation.Controls.Clear();
        }
        private void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        private void MoveButtons(BackgroundWorker bgw, int local1, int local2)
        {
            Status st = new Status();
            st.Local1 = local1;
            st.Local2 = local2;

            st.Type = MoveType.UP_DOWN;
            for (int i = 0; i < Content.HEIGHT; i++)
            {
                bgw.ReportProgress(0, st);
                Thread.Sleep(Content.threadTime);
            }

            st.Type = MoveType.RIGHT_LEFT;
            int WIDTH = Math.Abs(local1 - local2) * (Content.WIDTH_SIZE + Content.DISTANCE);
            for (int i = 0; i < WIDTH; i++)
            {
                bgw.ReportProgress(0, st);
                Thread.Sleep(Content.threadTime);
            }

            st.Type = MoveType.DOWN_UP;
            for (int i = 0; i < Content.HEIGHT; i++)
            {
                bgw.ReportProgress(0, st);
                Thread.Sleep(Content.threadTime);
            }

            st.Type = MoveType.STOP;
            bgw.ReportProgress(0, st);
        }

        private void ProgressButtons(Status st, string moveType)
        {
            if (st == null) return;
            if (st.Type == MoveType.STOP)
            {
                Button btn = buttons[st.Local2];
                buttons[st.Local2] = buttons[st.Local1];
                buttons[st.Local1] = btn;
                return;
            }

            Button btn1 = buttons[st.Local1];
            Button btn2 = buttons[st.Local2];
            if (st.Type == MoveType.UP_DOWN)
            {
                btn1.Top += 1;
                btn2.Top -= 1;
            }
            else if (st.Type == MoveType.RIGHT_LEFT)
            {
                if (moveType == "RL")
                {
                    btn1.Left -= 1;
                    btn2.Left += 1;
                }
                else
                {
                    btn1.Left += 1;
                    btn2.Left -= 1;
                }
            }
            else if (st.Type == MoveType.DOWN_UP)
            {
                btn1.Top -= 1;
                btn2.Top += 1;
            }
        }

        private void RunWorkerCompletedButtons()
        {
            foreach (Button btn in pnlSimulation.Controls)
            {
                btn.BackColor = Content.fillColorFinish;
                btn.ForeColor = Content.foreColorFinish;
            }
            btnAddNote.Enabled = true;
            btnRun.Enabled = false;
            btnClear.Enabled = true;
        }
        private void BubbleSort(int[] arr)
        {
            Status st = new Status();
            for (int i = 0; i < arr.Length; i++)
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        Swap(ref arr[j], ref arr[j - 1]);
                        Thread.Sleep(Content.threadTime);
                        MoveButtons(bgwBubbleSort, j, j - 1);
                    }
                }
        }

        private void bgwBubbleSort_DoWork(object sender, DoWorkEventArgs e)
        {
            BubbleSort(arr);
        }

        private void bgwBubbleSort_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressButtons(e.UserState as Status, "RL");
        }

        private void bgwBubbleSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            RunWorkerCompletedButtons();
        }
        private void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                        min = j;
                }
                Swap(ref arr[min], ref arr[i]);
                Thread.Sleep(Content.threadTime);
                MoveButtons(bgwSelectionSort, min, i);
            }
        }

        private void bgwSelectionSort_DoWork(object sender, DoWorkEventArgs e)
        {
            SelectionSort(arr);
        }

        private void bgwSelectionSort_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressButtons(e.UserState as Status, "RL");
        }

        private void bgwSelectionSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            RunWorkerCompletedButtons();
        }
        private void QuickSort(int[] arr, int left, int right)
        {
            int i = left, j = right;
            int mid = arr[(i + j) / 2];
            do
            {
                while (arr[i] < mid) i++;
                while (arr[j] > mid) j--;

                if (i <= j)
                {
                    Swap(ref arr[i], ref arr[j]);
                    Thread.Sleep(Content.threadTime);
                    MoveButtons(bgwQuickSort, i, j);
                    i++; j--;
                }
            }
            while (i < j);
            if (left < j) QuickSort(arr, left, j);
            if (i < right) QuickSort(arr, i, right);
        }

        private void bgwQuickSort_DoWork(object sender, DoWorkEventArgs e)
        {
            QuickSort(arr, 0, arr.Length - 1);
        }

        private void bgwQuickSort_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressButtons(e.UserState as Status, "LR");
        }

        private void bgwQuickSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            RunWorkerCompletedButtons();
        }
        private void InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        Swap(ref arr[j - 1], ref arr[j]);
                        Thread.Sleep(Content.threadTime);
                        MoveButtons(bgwInsertionSort, j - 1, j);
                    }
                }
        }

        private void bgwInsertionSort_DoWork(object sender, DoWorkEventArgs e)
        {
            InsertionSort(arr);
        }

        private void bgwInsertionSort_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressButtons(e.UserState as Status, "LR");
        }

        private void bgwInsertionSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            RunWorkerCompletedButtons();
        }
    }
    public class Content
    {
        public static int HEIGHT = 100;
        public static int WIDTH_SIZE = 60;
        public static int HEIGHT_SIZE = 50;
        public static int DISTANCE = 20;


        public static int RANDOM_START = 0;
        public static int RANDOM_END = 100;


        public static Color fillColor = Color.FromArgb(255, 120, 80);
        public static Color foreColor = Color.White;
        public static Color fillColorFinish = Color.FromArgb(255, 239, 100);
        public static Color foreColorFinish = Color.Black;


        public static int threadTime = 1;
    }
    public enum MoveType { UP_DOWN, RIGHT_LEFT, DOWN_UP, STOP }

    public class Status
    {
        public MoveType Type { get; set; }
        public int Local1 { get; set; }
        public int Local2 { get; set; }
    }
}
