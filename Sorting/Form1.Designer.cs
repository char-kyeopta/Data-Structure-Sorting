
namespace Sorting
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
            this.pnlCustomize = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.cboAlgorithms = new System.Windows.Forms.ComboBox();
            this.lblAlgorithms = new System.Windows.Forms.Label();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblItem = new System.Windows.Forms.Label();
            this.pnlSimulation = new System.Windows.Forms.Panel();
            this.bgwBubbleSort = new System.ComponentModel.BackgroundWorker();
            this.bgwSelectionSort = new System.ComponentModel.BackgroundWorker();
            this.bgwQuickSort = new System.ComponentModel.BackgroundWorker();
            this.bgwInsertionSort = new System.ComponentModel.BackgroundWorker();
            this.pnlCustomize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCustomize
            // 
            this.pnlCustomize.BackColor = System.Drawing.Color.White;
            this.pnlCustomize.Controls.Add(this.btnClear);
            this.pnlCustomize.Controls.Add(this.btnRun);
            this.pnlCustomize.Controls.Add(this.cboAlgorithms);
            this.pnlCustomize.Controls.Add(this.lblAlgorithms);
            this.pnlCustomize.Controls.Add(this.btnAddNote);
            this.pnlCustomize.Controls.Add(this.numericUpDown1);
            this.pnlCustomize.Controls.Add(this.lblItem);
            this.pnlCustomize.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCustomize.Location = new System.Drawing.Point(0, 0);
            this.pnlCustomize.Name = "pnlCustomize";
            this.pnlCustomize.Size = new System.Drawing.Size(1076, 65);
            this.pnlCustomize.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(849, 14);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 33);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRun.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(756, 14);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 34);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // cboAlgorithms
            // 
            this.cboAlgorithms.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAlgorithms.FormattingEnabled = true;
            this.cboAlgorithms.Items.AddRange(new object[] {
            "Bubble Sort",
            "Selection Sort",
            "Quick Sort",
            "Insertion Sort"});
            this.cboAlgorithms.Location = new System.Drawing.Point(575, 15);
            this.cboAlgorithms.Name = "cboAlgorithms";
            this.cboAlgorithms.Size = new System.Drawing.Size(159, 29);
            this.cboAlgorithms.TabIndex = 4;
            // 
            // lblAlgorithms
            // 
            this.lblAlgorithms.AutoSize = true;
            this.lblAlgorithms.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlgorithms.Location = new System.Drawing.Point(469, 21);
            this.lblAlgorithms.Name = "lblAlgorithms";
            this.lblAlgorithms.Size = new System.Drawing.Size(100, 21);
            this.lblAlgorithms.TabIndex = 3;
            this.lblAlgorithms.Text = "Algorithms:";
            // 
            // btnAddNote
            // 
            this.btnAddNote.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddNote.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNote.Location = new System.Drawing.Point(336, 14);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(64, 34);
            this.btnAddNote.TabIndex = 2;
            this.btnAddNote.Text = "Add";
            this.btnAddNote.UseVisualStyleBackColor = false;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(269, 17);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(61, 28);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(205, 19);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(58, 21);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "Item: ";
            // 
            // pnlSimulation
            // 
            this.pnlSimulation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSimulation.Location = new System.Drawing.Point(0, 65);
            this.pnlSimulation.Name = "pnlSimulation";
            this.pnlSimulation.Size = new System.Drawing.Size(1076, 413);
            this.pnlSimulation.TabIndex = 3;
            // 
            // bgwBubbleSort
            // 
            this.bgwBubbleSort.WorkerReportsProgress = true;
            this.bgwBubbleSort.WorkerSupportsCancellation = true;
            this.bgwBubbleSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwBubbleSort_DoWork);
            this.bgwBubbleSort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwBubbleSort_ProgressChanged);
            this.bgwBubbleSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwBubbleSort_RunWorkerCompleted);
            // 
            // bgwSelectionSort
            // 
            this.bgwSelectionSort.WorkerReportsProgress = true;
            this.bgwSelectionSort.WorkerSupportsCancellation = true;
            this.bgwSelectionSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSelectionSort_DoWork);
            this.bgwSelectionSort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwSelectionSort_ProgressChanged);
            this.bgwSelectionSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSelectionSort_RunWorkerCompleted);
            // 
            // bgwQuickSort
            // 
            this.bgwQuickSort.WorkerReportsProgress = true;
            this.bgwQuickSort.WorkerSupportsCancellation = true;
            this.bgwQuickSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwQuickSort_DoWork);
            this.bgwQuickSort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwQuickSort_ProgressChanged);
            this.bgwQuickSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwQuickSort_RunWorkerCompleted);
            // 
            // bgwInsertionSort
            // 
            this.bgwInsertionSort.WorkerReportsProgress = true;
            this.bgwInsertionSort.WorkerSupportsCancellation = true;
            this.bgwInsertionSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwInsertionSort_DoWork);
            this.bgwInsertionSort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwInsertionSort_ProgressChanged);
            this.bgwInsertionSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwInsertionSort_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1076, 478);
            this.Controls.Add(this.pnlSimulation);
            this.Controls.Add(this.pnlCustomize);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Sorting";
            this.pnlCustomize.ResumeLayout(false);
            this.pnlCustomize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCustomize;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ComboBox cboAlgorithms;
        private System.Windows.Forms.Label lblAlgorithms;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Panel pnlSimulation;
        private System.ComponentModel.BackgroundWorker bgwBubbleSort;
        private System.ComponentModel.BackgroundWorker bgwSelectionSort;
        private System.ComponentModel.BackgroundWorker bgwQuickSort;
        private System.ComponentModel.BackgroundWorker bgwInsertionSort;
    }
}

