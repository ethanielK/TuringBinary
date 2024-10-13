namespace 多线程UI刷新
{
    partial class Form1
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
            panelTop = new Panel();
            btnTask = new Button();
            btnThread = new Button();
            panelLeft = new Panel();
            panelMain = new Panel();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(btnTask);
            panelTop.Controls.Add(btnThread);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(893, 54);
            panelTop.TabIndex = 0;
            // 
            // btnTask
            // 
            btnTask.Dock = DockStyle.Left;
            btnTask.Location = new Point(75, 0);
            btnTask.Name = "btnTask";
            btnTask.Size = new Size(75, 54);
            btnTask.TabIndex = 1;
            btnTask.Text = "任务刷新";
            btnTask.UseVisualStyleBackColor = true;
            // 
            // btnThread
            // 
            btnThread.Dock = DockStyle.Left;
            btnThread.Location = new Point(0, 0);
            btnThread.Name = "btnThread";
            btnThread.Size = new Size(75, 54);
            btnThread.TabIndex = 0;
            btnThread.Text = "线程刷新";
            btnThread.UseVisualStyleBackColor = true;
            // 
            // panelLeft
            // 
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 54);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(255, 482);
            panelLeft.TabIndex = 0;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(255, 54);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(638, 482);
            panelMain.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 536);
            Controls.Add(panelMain);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            Name = "Form1";
            Text = "Form1";
            panelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelLeft;
        private Panel panelMain;
        private Button btnTask;
        private Button btnThread;
    }
}
