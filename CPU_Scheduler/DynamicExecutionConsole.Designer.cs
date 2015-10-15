namespace CPU_Scheduler
{
    partial class DynamicExecutionConsole
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
            this.execTimeLabel = new System.Windows.Forms.Label();
            this.readyQueueLabel = new System.Windows.Forms.Label();
            this.processLabel = new System.Windows.Forms.Label();
            this.remainingTimeLabel = new System.Windows.Forms.Label();
            this.processReady1Label = new System.Windows.Forms.Label();
            this.processReady2Label = new System.Windows.Forms.Label();
            this.processReady3Label = new System.Windows.Forms.Label();
            this.processReady4Label = new System.Windows.Forms.Label();
            this.processReady5Label = new System.Windows.Forms.Label();
            this.processReady7Label = new System.Windows.Forms.Label();
            this.processReady6Label = new System.Windows.Forms.Label();
            this.processReady8Label = new System.Windows.Forms.Label();
            this.processReady1TimeLabel = new System.Windows.Forms.Label();
            this.processReady2TimeLabel = new System.Windows.Forms.Label();
            this.processReady3TimeLabel = new System.Windows.Forms.Label();
            this.processReady4TimeLabel = new System.Windows.Forms.Label();
            this.processReady5TimeLabel = new System.Windows.Forms.Label();
            this.processReady6TimeLabel = new System.Windows.Forms.Label();
            this.processReady7TimeLabel = new System.Windows.Forms.Label();
            this.processReady8TimeLabel = new System.Windows.Forms.Label();
            this.processReady9TimeLabel = new System.Windows.Forms.Label();
            this.ioQueueLabel = new System.Windows.Forms.Label();
            this.execTimeLabelVar = new System.Windows.Forms.Label();
            this.processReady9Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.runningProcessLabel = new System.Windows.Forms.Label();
            this.runnigProcessLabelVar = new System.Windows.Forms.Label();
            this.completedProcessLabel = new System.Windows.Forms.Label();
            this.processCompleted1LabelVar = new System.Windows.Forms.Label();
            this.processIO9Label = new System.Windows.Forms.Label();
            this.processIO9TimeLabel = new System.Windows.Forms.Label();
            this.processIO8TimeLabel = new System.Windows.Forms.Label();
            this.processIO7TimeLabel = new System.Windows.Forms.Label();
            this.processIO6TimeLabel = new System.Windows.Forms.Label();
            this.processIO5TimeLabel = new System.Windows.Forms.Label();
            this.processIO4TimeLabel = new System.Windows.Forms.Label();
            this.processIO3TimeLabel = new System.Windows.Forms.Label();
            this.processIO2TimeLabel = new System.Windows.Forms.Label();
            this.processIO1TimeLabel = new System.Windows.Forms.Label();
            this.processIO8Label = new System.Windows.Forms.Label();
            this.processIO6Label = new System.Windows.Forms.Label();
            this.processIO7Label = new System.Windows.Forms.Label();
            this.processIO5Label = new System.Windows.Forms.Label();
            this.processIO4Label = new System.Windows.Forms.Label();
            this.processIO3Label = new System.Windows.Forms.Label();
            this.processIO2Label = new System.Windows.Forms.Label();
            this.processIO1Label = new System.Windows.Forms.Label();
            this.processCompleted4LabelVar = new System.Windows.Forms.Label();
            this.processCompleted3LabelVar = new System.Windows.Forms.Label();
            this.processCompleted5LabelVar = new System.Windows.Forms.Label();
            this.processCompleted7LabelVar = new System.Windows.Forms.Label();
            this.processCompleted6LabelVar = new System.Windows.Forms.Label();
            this.processCompleted2LabelVar = new System.Windows.Forms.Label();
            this.processCompleted8LabelVar = new System.Windows.Forms.Label();
            this.processCompleted9LabelVar = new System.Windows.Forms.Label();
            this.CPUclock = new System.Windows.Forms.Timer(this.components);
            this.executingTimeProcess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // execTimeLabel
            // 
            this.execTimeLabel.AutoSize = true;
            this.execTimeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.execTimeLabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.execTimeLabel.ForeColor = System.Drawing.Color.Lime;
            this.execTimeLabel.Location = new System.Drawing.Point(27, 12);
            this.execTimeLabel.Name = "execTimeLabel";
            this.execTimeLabel.Size = new System.Drawing.Size(252, 23);
            this.execTimeLabel.TabIndex = 0;
            this.execTimeLabel.Text = "Current Execution Time";
            // 
            // readyQueueLabel
            // 
            this.readyQueueLabel.AutoSize = true;
            this.readyQueueLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.readyQueueLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readyQueueLabel.ForeColor = System.Drawing.Color.Lime;
            this.readyQueueLabel.Location = new System.Drawing.Point(86, 76);
            this.readyQueueLabel.Name = "readyQueueLabel";
            this.readyQueueLabel.Size = new System.Drawing.Size(108, 19);
            this.readyQueueLabel.TabIndex = 1;
            this.readyQueueLabel.Text = "Ready Queue";
            // 
            // processLabel
            // 
            this.processLabel.AutoSize = true;
            this.processLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processLabel.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processLabel.ForeColor = System.Drawing.Color.Lime;
            this.processLabel.Location = new System.Drawing.Point(51, 110);
            this.processLabel.Name = "processLabel";
            this.processLabel.Size = new System.Drawing.Size(64, 17);
            this.processLabel.TabIndex = 2;
            this.processLabel.Text = "Process";
            // 
            // remainingTimeLabel
            // 
            this.remainingTimeLabel.AutoSize = true;
            this.remainingTimeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.remainingTimeLabel.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingTimeLabel.ForeColor = System.Drawing.Color.Lime;
            this.remainingTimeLabel.Location = new System.Drawing.Point(164, 110);
            this.remainingTimeLabel.Name = "remainingTimeLabel";
            this.remainingTimeLabel.Size = new System.Drawing.Size(120, 17);
            this.remainingTimeLabel.TabIndex = 3;
            this.remainingTimeLabel.Text = "Remaining Time";
            // 
            // processReady1Label
            // 
            this.processReady1Label.AutoSize = true;
            this.processReady1Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processReady1Label.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processReady1Label.ForeColor = System.Drawing.Color.Lime;
            this.processReady1Label.Location = new System.Drawing.Point(51, 141);
            this.processReady1Label.Name = "processReady1Label";
            this.processReady1Label.Size = new System.Drawing.Size(19, 13);
            this.processReady1Label.TabIndex = 4;
            this.processReady1Label.Text = "P1";
            this.processReady1Label.Visible = false;
            // 
            // processReady2Label
            // 
            this.processReady2Label.AutoSize = true;
            this.processReady2Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processReady2Label.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processReady2Label.ForeColor = System.Drawing.Color.Lime;
            this.processReady2Label.Location = new System.Drawing.Point(50, 168);
            this.processReady2Label.Name = "processReady2Label";
            this.processReady2Label.Size = new System.Drawing.Size(19, 13);
            this.processReady2Label.TabIndex = 5;
            this.processReady2Label.Text = "P2";
            this.processReady2Label.Visible = false;
            // 
            // processReady3Label
            // 
            this.processReady3Label.AutoSize = true;
            this.processReady3Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processReady3Label.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processReady3Label.ForeColor = System.Drawing.Color.Lime;
            this.processReady3Label.Location = new System.Drawing.Point(50, 197);
            this.processReady3Label.Name = "processReady3Label";
            this.processReady3Label.Size = new System.Drawing.Size(19, 13);
            this.processReady3Label.TabIndex = 6;
            this.processReady3Label.Text = "P3";
            this.processReady3Label.Visible = false;
            // 
            // processReady4Label
            // 
            this.processReady4Label.AutoSize = true;
            this.processReady4Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processReady4Label.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processReady4Label.ForeColor = System.Drawing.Color.Lime;
            this.processReady4Label.Location = new System.Drawing.Point(50, 227);
            this.processReady4Label.Name = "processReady4Label";
            this.processReady4Label.Size = new System.Drawing.Size(19, 13);
            this.processReady4Label.TabIndex = 7;
            this.processReady4Label.Text = "P4";
            this.processReady4Label.Visible = false;
            // 
            // processReady5Label
            // 
            this.processReady5Label.AutoSize = true;
            this.processReady5Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processReady5Label.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processReady5Label.ForeColor = System.Drawing.Color.Lime;
            this.processReady5Label.Location = new System.Drawing.Point(50, 257);
            this.processReady5Label.Name = "processReady5Label";
            this.processReady5Label.Size = new System.Drawing.Size(19, 13);
            this.processReady5Label.TabIndex = 8;
            this.processReady5Label.Text = "P5";
            this.processReady5Label.Visible = false;
            // 
            // processReady7Label
            // 
            this.processReady7Label.AutoSize = true;
            this.processReady7Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processReady7Label.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processReady7Label.ForeColor = System.Drawing.Color.Lime;
            this.processReady7Label.Location = new System.Drawing.Point(50, 315);
            this.processReady7Label.Name = "processReady7Label";
            this.processReady7Label.Size = new System.Drawing.Size(19, 13);
            this.processReady7Label.TabIndex = 9;
            this.processReady7Label.Text = "P7";
            this.processReady7Label.Visible = false;
            // 
            // processReady6Label
            // 
            this.processReady6Label.AutoSize = true;
            this.processReady6Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processReady6Label.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processReady6Label.ForeColor = System.Drawing.Color.Lime;
            this.processReady6Label.Location = new System.Drawing.Point(50, 288);
            this.processReady6Label.Name = "processReady6Label";
            this.processReady6Label.Size = new System.Drawing.Size(19, 13);
            this.processReady6Label.TabIndex = 10;
            this.processReady6Label.Text = "P6";
            this.processReady6Label.Visible = false;
            // 
            // processReady8Label
            // 
            this.processReady8Label.AutoSize = true;
            this.processReady8Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processReady8Label.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processReady8Label.ForeColor = System.Drawing.Color.Lime;
            this.processReady8Label.Location = new System.Drawing.Point(50, 341);
            this.processReady8Label.Name = "processReady8Label";
            this.processReady8Label.Size = new System.Drawing.Size(19, 13);
            this.processReady8Label.TabIndex = 11;
            this.processReady8Label.Text = "P8";
            this.processReady8Label.Visible = false;
            // 
            // processReady1TimeLabel
            // 
            this.processReady1TimeLabel.AutoSize = true;
            this.processReady1TimeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processReady1TimeLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processReady1TimeLabel.ForeColor = System.Drawing.Color.Lime;
            this.processReady1TimeLabel.Location = new System.Drawing.Point(164, 141);
            this.processReady1TimeLabel.Name = "processReady1TimeLabel";
            this.processReady1TimeLabel.Size = new System.Drawing.Size(13, 13);
            this.processReady1TimeLabel.TabIndex = 12;
            this.processReady1TimeLabel.Text = "0";
            this.processReady1TimeLabel.Visible = false;
            // 
            // processReady2TimeLabel
            // 
            this.processReady2TimeLabel.AutoSize = true;
            this.processReady2TimeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processReady2TimeLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processReady2TimeLabel.ForeColor = System.Drawing.Color.Lime;
            this.processReady2TimeLabel.Location = new System.Drawing.Point(164, 168);
            this.processReady2TimeLabel.Name = "processReady2TimeLabel";
            this.processReady2TimeLabel.Size = new System.Drawing.Size(13, 13);
            this.processReady2TimeLabel.TabIndex = 13;
            this.processReady2TimeLabel.Text = "0";
            this.processReady2TimeLabel.Visible = false;
            // 
            // processReady3TimeLabel
            // 
            this.processReady3TimeLabel.AutoSize = true;
            this.processReady3TimeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processReady3TimeLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processReady3TimeLabel.ForeColor = System.Drawing.Color.Lime;
            this.processReady3TimeLabel.Location = new System.Drawing.Point(164, 197);
            this.processReady3TimeLabel.Name = "processReady3TimeLabel";
            this.processReady3TimeLabel.Size = new System.Drawing.Size(13, 13);
            this.processReady3TimeLabel.TabIndex = 14;
            this.processReady3TimeLabel.Text = "0";
            this.processReady3TimeLabel.Visible = false;
            // 
            // processReady4TimeLabel
            // 
            this.processReady4TimeLabel.AutoSize = true;
            this.processReady4TimeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processReady4TimeLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processReady4TimeLabel.ForeColor = System.Drawing.Color.Lime;
            this.processReady4TimeLabel.Location = new System.Drawing.Point(164, 227);
            this.processReady4TimeLabel.Name = "processReady4TimeLabel";
            this.processReady4TimeLabel.Size = new System.Drawing.Size(13, 13);
            this.processReady4TimeLabel.TabIndex = 15;
            this.processReady4TimeLabel.Text = "0";
            this.processReady4TimeLabel.Visible = false;
            // 
            // processReady5TimeLabel
            // 
            this.processReady5TimeLabel.AutoSize = true;
            this.processReady5TimeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processReady5TimeLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processReady5TimeLabel.ForeColor = System.Drawing.Color.Lime;
            this.processReady5TimeLabel.Location = new System.Drawing.Point(164, 257);
            this.processReady5TimeLabel.Name = "processReady5TimeLabel";
            this.processReady5TimeLabel.Size = new System.Drawing.Size(13, 13);
            this.processReady5TimeLabel.TabIndex = 16;
            this.processReady5TimeLabel.Text = "0";
            this.processReady5TimeLabel.Visible = false;
            // 
            // processReady6TimeLabel
            // 
            this.processReady6TimeLabel.AutoSize = true;
            this.processReady6TimeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processReady6TimeLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processReady6TimeLabel.ForeColor = System.Drawing.Color.Lime;
            this.processReady6TimeLabel.Location = new System.Drawing.Point(164, 288);
            this.processReady6TimeLabel.Name = "processReady6TimeLabel";
            this.processReady6TimeLabel.Size = new System.Drawing.Size(13, 13);
            this.processReady6TimeLabel.TabIndex = 17;
            this.processReady6TimeLabel.Text = "0";
            this.processReady6TimeLabel.Visible = false;
            // 
            // processReady7TimeLabel
            // 
            this.processReady7TimeLabel.AutoSize = true;
            this.processReady7TimeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processReady7TimeLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processReady7TimeLabel.ForeColor = System.Drawing.Color.Lime;
            this.processReady7TimeLabel.Location = new System.Drawing.Point(164, 315);
            this.processReady7TimeLabel.Name = "processReady7TimeLabel";
            this.processReady7TimeLabel.Size = new System.Drawing.Size(13, 13);
            this.processReady7TimeLabel.TabIndex = 18;
            this.processReady7TimeLabel.Text = "0";
            this.processReady7TimeLabel.Visible = false;
            // 
            // processReady8TimeLabel
            // 
            this.processReady8TimeLabel.AutoSize = true;
            this.processReady8TimeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processReady8TimeLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processReady8TimeLabel.ForeColor = System.Drawing.Color.Lime;
            this.processReady8TimeLabel.Location = new System.Drawing.Point(164, 341);
            this.processReady8TimeLabel.Name = "processReady8TimeLabel";
            this.processReady8TimeLabel.Size = new System.Drawing.Size(13, 13);
            this.processReady8TimeLabel.TabIndex = 19;
            this.processReady8TimeLabel.Text = "0";
            this.processReady8TimeLabel.Visible = false;
            // 
            // processReady9TimeLabel
            // 
            this.processReady9TimeLabel.AutoSize = true;
            this.processReady9TimeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processReady9TimeLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processReady9TimeLabel.ForeColor = System.Drawing.Color.Lime;
            this.processReady9TimeLabel.Location = new System.Drawing.Point(164, 369);
            this.processReady9TimeLabel.Name = "processReady9TimeLabel";
            this.processReady9TimeLabel.Size = new System.Drawing.Size(13, 13);
            this.processReady9TimeLabel.TabIndex = 20;
            this.processReady9TimeLabel.Text = "0";
            this.processReady9TimeLabel.Visible = false;
            // 
            // ioQueueLabel
            // 
            this.ioQueueLabel.AutoSize = true;
            this.ioQueueLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ioQueueLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ioQueueLabel.ForeColor = System.Drawing.Color.Lime;
            this.ioQueueLabel.Location = new System.Drawing.Point(422, 76);
            this.ioQueueLabel.Name = "ioQueueLabel";
            this.ioQueueLabel.Size = new System.Drawing.Size(90, 19);
            this.ioQueueLabel.TabIndex = 21;
            this.ioQueueLabel.Text = "I/O Queue";
            this.ioQueueLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // execTimeLabelVar
            // 
            this.execTimeLabelVar.AutoSize = true;
            this.execTimeLabelVar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.execTimeLabelVar.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.execTimeLabelVar.ForeColor = System.Drawing.Color.Lime;
            this.execTimeLabelVar.Location = new System.Drawing.Point(339, 12);
            this.execTimeLabelVar.Name = "execTimeLabelVar";
            this.execTimeLabelVar.Size = new System.Drawing.Size(21, 23);
            this.execTimeLabelVar.TabIndex = 22;
            this.execTimeLabelVar.Text = "0";
            this.execTimeLabelVar.Click += new System.EventHandler(this.execTimeLabelVar_Click);
            // 
            // processReady9Label
            // 
            this.processReady9Label.AutoSize = true;
            this.processReady9Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processReady9Label.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processReady9Label.ForeColor = System.Drawing.Color.Lime;
            this.processReady9Label.Location = new System.Drawing.Point(50, 369);
            this.processReady9Label.Name = "processReady9Label";
            this.processReady9Label.Size = new System.Drawing.Size(19, 13);
            this.processReady9Label.TabIndex = 23;
            this.processReady9Label.Text = "P9";
            this.processReady9Label.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(362, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Process";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(475, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Remaining Time";
            // 
            // runningProcessLabel
            // 
            this.runningProcessLabel.AutoSize = true;
            this.runningProcessLabel.Location = new System.Drawing.Point(12, 47);
            this.runningProcessLabel.Name = "runningProcessLabel";
            this.runningProcessLabel.Size = new System.Drawing.Size(88, 13);
            this.runningProcessLabel.TabIndex = 26;
            this.runningProcessLabel.Text = "Running Process";
            // 
            // runnigProcessLabelVar
            // 
            this.runnigProcessLabelVar.AutoSize = true;
            this.runnigProcessLabelVar.Location = new System.Drawing.Point(114, 47);
            this.runnigProcessLabelVar.Name = "runnigProcessLabelVar";
            this.runnigProcessLabelVar.Size = new System.Drawing.Size(80, 13);
            this.runnigProcessLabelVar.TabIndex = 27;
            this.runnigProcessLabelVar.Text = "current process";
            this.runnigProcessLabelVar.Visible = false;
            this.runnigProcessLabelVar.Click += new System.EventHandler(this.label4_Click);
            // 
            // completedProcessLabel
            // 
            this.completedProcessLabel.AutoSize = true;
            this.completedProcessLabel.Location = new System.Drawing.Point(282, 47);
            this.completedProcessLabel.Name = "completedProcessLabel";
            this.completedProcessLabel.Size = new System.Drawing.Size(98, 13);
            this.completedProcessLabel.TabIndex = 28;
            this.completedProcessLabel.Text = "Process Completed";
            // 
            // processCompleted1LabelVar
            // 
            this.processCompleted1LabelVar.AutoSize = true;
            this.processCompleted1LabelVar.Location = new System.Drawing.Point(386, 47);
            this.processCompleted1LabelVar.Name = "processCompleted1LabelVar";
            this.processCompleted1LabelVar.Size = new System.Drawing.Size(20, 13);
            this.processCompleted1LabelVar.TabIndex = 29;
            this.processCompleted1LabelVar.Text = "P1";
            this.processCompleted1LabelVar.Visible = false;
            // 
            // processIO9Label
            // 
            this.processIO9Label.AutoSize = true;
            this.processIO9Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processIO9Label.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processIO9Label.ForeColor = System.Drawing.Color.Lime;
            this.processIO9Label.Location = new System.Drawing.Point(361, 369);
            this.processIO9Label.Name = "processIO9Label";
            this.processIO9Label.Size = new System.Drawing.Size(19, 13);
            this.processIO9Label.TabIndex = 47;
            this.processIO9Label.Text = "P9";
            this.processIO9Label.Visible = false;
            // 
            // processIO9TimeLabel
            // 
            this.processIO9TimeLabel.AutoSize = true;
            this.processIO9TimeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processIO9TimeLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processIO9TimeLabel.ForeColor = System.Drawing.Color.Lime;
            this.processIO9TimeLabel.Location = new System.Drawing.Point(475, 371);
            this.processIO9TimeLabel.Name = "processIO9TimeLabel";
            this.processIO9TimeLabel.Size = new System.Drawing.Size(13, 13);
            this.processIO9TimeLabel.TabIndex = 46;
            this.processIO9TimeLabel.Text = "0";
            this.processIO9TimeLabel.Visible = false;
            // 
            // processIO8TimeLabel
            // 
            this.processIO8TimeLabel.AutoSize = true;
            this.processIO8TimeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processIO8TimeLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processIO8TimeLabel.ForeColor = System.Drawing.Color.Lime;
            this.processIO8TimeLabel.Location = new System.Drawing.Point(475, 341);
            this.processIO8TimeLabel.Name = "processIO8TimeLabel";
            this.processIO8TimeLabel.Size = new System.Drawing.Size(13, 13);
            this.processIO8TimeLabel.TabIndex = 45;
            this.processIO8TimeLabel.Text = "0";
            this.processIO8TimeLabel.Visible = false;
            // 
            // processIO7TimeLabel
            // 
            this.processIO7TimeLabel.AutoSize = true;
            this.processIO7TimeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processIO7TimeLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processIO7TimeLabel.ForeColor = System.Drawing.Color.Lime;
            this.processIO7TimeLabel.Location = new System.Drawing.Point(475, 315);
            this.processIO7TimeLabel.Name = "processIO7TimeLabel";
            this.processIO7TimeLabel.Size = new System.Drawing.Size(13, 13);
            this.processIO7TimeLabel.TabIndex = 44;
            this.processIO7TimeLabel.Text = "0";
            this.processIO7TimeLabel.Visible = false;
            // 
            // processIO6TimeLabel
            // 
            this.processIO6TimeLabel.AutoSize = true;
            this.processIO6TimeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processIO6TimeLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processIO6TimeLabel.ForeColor = System.Drawing.Color.Lime;
            this.processIO6TimeLabel.Location = new System.Drawing.Point(475, 288);
            this.processIO6TimeLabel.Name = "processIO6TimeLabel";
            this.processIO6TimeLabel.Size = new System.Drawing.Size(13, 13);
            this.processIO6TimeLabel.TabIndex = 43;
            this.processIO6TimeLabel.Text = "0";
            this.processIO6TimeLabel.Visible = false;
            // 
            // processIO5TimeLabel
            // 
            this.processIO5TimeLabel.AutoSize = true;
            this.processIO5TimeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processIO5TimeLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processIO5TimeLabel.ForeColor = System.Drawing.Color.Lime;
            this.processIO5TimeLabel.Location = new System.Drawing.Point(475, 257);
            this.processIO5TimeLabel.Name = "processIO5TimeLabel";
            this.processIO5TimeLabel.Size = new System.Drawing.Size(13, 13);
            this.processIO5TimeLabel.TabIndex = 42;
            this.processIO5TimeLabel.Text = "0";
            this.processIO5TimeLabel.Visible = false;
            // 
            // processIO4TimeLabel
            // 
            this.processIO4TimeLabel.AutoSize = true;
            this.processIO4TimeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processIO4TimeLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processIO4TimeLabel.ForeColor = System.Drawing.Color.Lime;
            this.processIO4TimeLabel.Location = new System.Drawing.Point(475, 227);
            this.processIO4TimeLabel.Name = "processIO4TimeLabel";
            this.processIO4TimeLabel.Size = new System.Drawing.Size(13, 13);
            this.processIO4TimeLabel.TabIndex = 41;
            this.processIO4TimeLabel.Text = "0";
            this.processIO4TimeLabel.Visible = false;
            // 
            // processIO3TimeLabel
            // 
            this.processIO3TimeLabel.AutoSize = true;
            this.processIO3TimeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processIO3TimeLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processIO3TimeLabel.ForeColor = System.Drawing.Color.Lime;
            this.processIO3TimeLabel.Location = new System.Drawing.Point(475, 197);
            this.processIO3TimeLabel.Name = "processIO3TimeLabel";
            this.processIO3TimeLabel.Size = new System.Drawing.Size(13, 13);
            this.processIO3TimeLabel.TabIndex = 40;
            this.processIO3TimeLabel.Text = "0";
            this.processIO3TimeLabel.Visible = false;
            // 
            // processIO2TimeLabel
            // 
            this.processIO2TimeLabel.AutoSize = true;
            this.processIO2TimeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processIO2TimeLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processIO2TimeLabel.ForeColor = System.Drawing.Color.Lime;
            this.processIO2TimeLabel.Location = new System.Drawing.Point(475, 168);
            this.processIO2TimeLabel.Name = "processIO2TimeLabel";
            this.processIO2TimeLabel.Size = new System.Drawing.Size(13, 13);
            this.processIO2TimeLabel.TabIndex = 39;
            this.processIO2TimeLabel.Text = "0";
            this.processIO2TimeLabel.Visible = false;
            // 
            // processIO1TimeLabel
            // 
            this.processIO1TimeLabel.AutoSize = true;
            this.processIO1TimeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processIO1TimeLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processIO1TimeLabel.ForeColor = System.Drawing.Color.Lime;
            this.processIO1TimeLabel.Location = new System.Drawing.Point(475, 141);
            this.processIO1TimeLabel.Name = "processIO1TimeLabel";
            this.processIO1TimeLabel.Size = new System.Drawing.Size(13, 13);
            this.processIO1TimeLabel.TabIndex = 38;
            this.processIO1TimeLabel.Text = "0";
            this.processIO1TimeLabel.Visible = false;
            // 
            // processIO8Label
            // 
            this.processIO8Label.AutoSize = true;
            this.processIO8Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processIO8Label.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processIO8Label.ForeColor = System.Drawing.Color.Lime;
            this.processIO8Label.Location = new System.Drawing.Point(361, 341);
            this.processIO8Label.Name = "processIO8Label";
            this.processIO8Label.Size = new System.Drawing.Size(19, 13);
            this.processIO8Label.TabIndex = 37;
            this.processIO8Label.Text = "P8";
            this.processIO8Label.Visible = false;
            // 
            // processIO6Label
            // 
            this.processIO6Label.AutoSize = true;
            this.processIO6Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processIO6Label.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processIO6Label.ForeColor = System.Drawing.Color.Lime;
            this.processIO6Label.Location = new System.Drawing.Point(361, 288);
            this.processIO6Label.Name = "processIO6Label";
            this.processIO6Label.Size = new System.Drawing.Size(19, 13);
            this.processIO6Label.TabIndex = 36;
            this.processIO6Label.Text = "P6";
            this.processIO6Label.Visible = false;
            // 
            // processIO7Label
            // 
            this.processIO7Label.AutoSize = true;
            this.processIO7Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processIO7Label.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processIO7Label.ForeColor = System.Drawing.Color.Lime;
            this.processIO7Label.Location = new System.Drawing.Point(361, 315);
            this.processIO7Label.Name = "processIO7Label";
            this.processIO7Label.Size = new System.Drawing.Size(19, 13);
            this.processIO7Label.TabIndex = 35;
            this.processIO7Label.Text = "P7";
            this.processIO7Label.Visible = false;
            // 
            // processIO5Label
            // 
            this.processIO5Label.AutoSize = true;
            this.processIO5Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processIO5Label.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processIO5Label.ForeColor = System.Drawing.Color.Lime;
            this.processIO5Label.Location = new System.Drawing.Point(361, 257);
            this.processIO5Label.Name = "processIO5Label";
            this.processIO5Label.Size = new System.Drawing.Size(19, 13);
            this.processIO5Label.TabIndex = 34;
            this.processIO5Label.Text = "P5";
            this.processIO5Label.Visible = false;
            // 
            // processIO4Label
            // 
            this.processIO4Label.AutoSize = true;
            this.processIO4Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processIO4Label.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processIO4Label.ForeColor = System.Drawing.Color.Lime;
            this.processIO4Label.Location = new System.Drawing.Point(361, 227);
            this.processIO4Label.Name = "processIO4Label";
            this.processIO4Label.Size = new System.Drawing.Size(19, 13);
            this.processIO4Label.TabIndex = 33;
            this.processIO4Label.Text = "P4";
            this.processIO4Label.Visible = false;
            // 
            // processIO3Label
            // 
            this.processIO3Label.AutoSize = true;
            this.processIO3Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processIO3Label.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processIO3Label.ForeColor = System.Drawing.Color.Lime;
            this.processIO3Label.Location = new System.Drawing.Point(361, 197);
            this.processIO3Label.Name = "processIO3Label";
            this.processIO3Label.Size = new System.Drawing.Size(19, 13);
            this.processIO3Label.TabIndex = 32;
            this.processIO3Label.Text = "P3";
            this.processIO3Label.Visible = false;
            // 
            // processIO2Label
            // 
            this.processIO2Label.AutoSize = true;
            this.processIO2Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processIO2Label.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processIO2Label.ForeColor = System.Drawing.Color.Lime;
            this.processIO2Label.Location = new System.Drawing.Point(361, 168);
            this.processIO2Label.Name = "processIO2Label";
            this.processIO2Label.Size = new System.Drawing.Size(19, 13);
            this.processIO2Label.TabIndex = 31;
            this.processIO2Label.Text = "P2";
            this.processIO2Label.Visible = false;
            // 
            // processIO1Label
            // 
            this.processIO1Label.AutoSize = true;
            this.processIO1Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processIO1Label.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processIO1Label.ForeColor = System.Drawing.Color.Lime;
            this.processIO1Label.Location = new System.Drawing.Point(362, 141);
            this.processIO1Label.Name = "processIO1Label";
            this.processIO1Label.Size = new System.Drawing.Size(19, 13);
            this.processIO1Label.TabIndex = 30;
            this.processIO1Label.Text = "P1";
            this.processIO1Label.Visible = false;
            // 
            // processCompleted4LabelVar
            // 
            this.processCompleted4LabelVar.AutoSize = true;
            this.processCompleted4LabelVar.Location = new System.Drawing.Point(464, 47);
            this.processCompleted4LabelVar.Name = "processCompleted4LabelVar";
            this.processCompleted4LabelVar.Size = new System.Drawing.Size(20, 13);
            this.processCompleted4LabelVar.TabIndex = 48;
            this.processCompleted4LabelVar.Text = "P1";
            this.processCompleted4LabelVar.Visible = false;
            // 
            // processCompleted3LabelVar
            // 
            this.processCompleted3LabelVar.AutoSize = true;
            this.processCompleted3LabelVar.Location = new System.Drawing.Point(438, 47);
            this.processCompleted3LabelVar.Name = "processCompleted3LabelVar";
            this.processCompleted3LabelVar.Size = new System.Drawing.Size(20, 13);
            this.processCompleted3LabelVar.TabIndex = 49;
            this.processCompleted3LabelVar.Text = "P1";
            this.processCompleted3LabelVar.Visible = false;
            // 
            // processCompleted5LabelVar
            // 
            this.processCompleted5LabelVar.AutoSize = true;
            this.processCompleted5LabelVar.Location = new System.Drawing.Point(490, 47);
            this.processCompleted5LabelVar.Name = "processCompleted5LabelVar";
            this.processCompleted5LabelVar.Size = new System.Drawing.Size(20, 13);
            this.processCompleted5LabelVar.TabIndex = 50;
            this.processCompleted5LabelVar.Text = "P1";
            this.processCompleted5LabelVar.Visible = false;
            // 
            // processCompleted7LabelVar
            // 
            this.processCompleted7LabelVar.AutoSize = true;
            this.processCompleted7LabelVar.Location = new System.Drawing.Point(542, 47);
            this.processCompleted7LabelVar.Name = "processCompleted7LabelVar";
            this.processCompleted7LabelVar.Size = new System.Drawing.Size(20, 13);
            this.processCompleted7LabelVar.TabIndex = 51;
            this.processCompleted7LabelVar.Text = "P1";
            this.processCompleted7LabelVar.Visible = false;
            // 
            // processCompleted6LabelVar
            // 
            this.processCompleted6LabelVar.AutoSize = true;
            this.processCompleted6LabelVar.Location = new System.Drawing.Point(516, 47);
            this.processCompleted6LabelVar.Name = "processCompleted6LabelVar";
            this.processCompleted6LabelVar.Size = new System.Drawing.Size(20, 13);
            this.processCompleted6LabelVar.TabIndex = 52;
            this.processCompleted6LabelVar.Text = "P1";
            this.processCompleted6LabelVar.Visible = false;
            // 
            // processCompleted2LabelVar
            // 
            this.processCompleted2LabelVar.AutoSize = true;
            this.processCompleted2LabelVar.Location = new System.Drawing.Point(412, 47);
            this.processCompleted2LabelVar.Name = "processCompleted2LabelVar";
            this.processCompleted2LabelVar.Size = new System.Drawing.Size(20, 13);
            this.processCompleted2LabelVar.TabIndex = 53;
            this.processCompleted2LabelVar.Text = "P1";
            this.processCompleted2LabelVar.Visible = false;
            // 
            // processCompleted8LabelVar
            // 
            this.processCompleted8LabelVar.AutoSize = true;
            this.processCompleted8LabelVar.Location = new System.Drawing.Point(568, 47);
            this.processCompleted8LabelVar.Name = "processCompleted8LabelVar";
            this.processCompleted8LabelVar.Size = new System.Drawing.Size(20, 13);
            this.processCompleted8LabelVar.TabIndex = 54;
            this.processCompleted8LabelVar.Text = "P1";
            this.processCompleted8LabelVar.Visible = false;
            // 
            // processCompleted9LabelVar
            // 
            this.processCompleted9LabelVar.AutoSize = true;
            this.processCompleted9LabelVar.Location = new System.Drawing.Point(594, 47);
            this.processCompleted9LabelVar.Name = "processCompleted9LabelVar";
            this.processCompleted9LabelVar.Size = new System.Drawing.Size(20, 13);
            this.processCompleted9LabelVar.TabIndex = 55;
            this.processCompleted9LabelVar.Text = "P1";
            this.processCompleted9LabelVar.Visible = false;
            // 
            // CPUclock
            // 
            this.CPUclock.Interval = 10;
            this.CPUclock.Tick += new System.EventHandler(this.CPUclock_Tick);
            // 
            // executingTimeProcess
            // 
            this.executingTimeProcess.AutoSize = true;
            this.executingTimeProcess.Location = new System.Drawing.Point(196, 47);
            this.executingTimeProcess.Name = "executingTimeProcess";
            this.executingTimeProcess.Size = new System.Drawing.Size(77, 13);
            this.executingTimeProcess.TabIndex = 56;
            this.executingTimeProcess.Text = "time remaining ";
            this.executingTimeProcess.Visible = false;
            // 
            // DynamicExecutionConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(619, 393);
            this.Controls.Add(this.executingTimeProcess);
            this.Controls.Add(this.processCompleted9LabelVar);
            this.Controls.Add(this.processCompleted8LabelVar);
            this.Controls.Add(this.processCompleted2LabelVar);
            this.Controls.Add(this.processCompleted6LabelVar);
            this.Controls.Add(this.processCompleted7LabelVar);
            this.Controls.Add(this.processCompleted5LabelVar);
            this.Controls.Add(this.processCompleted3LabelVar);
            this.Controls.Add(this.processCompleted4LabelVar);
            this.Controls.Add(this.processIO9Label);
            this.Controls.Add(this.processIO9TimeLabel);
            this.Controls.Add(this.processIO8TimeLabel);
            this.Controls.Add(this.processIO7TimeLabel);
            this.Controls.Add(this.processIO6TimeLabel);
            this.Controls.Add(this.processIO5TimeLabel);
            this.Controls.Add(this.processIO4TimeLabel);
            this.Controls.Add(this.processIO3TimeLabel);
            this.Controls.Add(this.processIO2TimeLabel);
            this.Controls.Add(this.processIO1TimeLabel);
            this.Controls.Add(this.processIO8Label);
            this.Controls.Add(this.processIO6Label);
            this.Controls.Add(this.processIO7Label);
            this.Controls.Add(this.processIO5Label);
            this.Controls.Add(this.processIO4Label);
            this.Controls.Add(this.processIO3Label);
            this.Controls.Add(this.processIO2Label);
            this.Controls.Add(this.processIO1Label);
            this.Controls.Add(this.processCompleted1LabelVar);
            this.Controls.Add(this.completedProcessLabel);
            this.Controls.Add(this.runnigProcessLabelVar);
            this.Controls.Add(this.runningProcessLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.processReady9Label);
            this.Controls.Add(this.execTimeLabelVar);
            this.Controls.Add(this.ioQueueLabel);
            this.Controls.Add(this.processReady9TimeLabel);
            this.Controls.Add(this.processReady8TimeLabel);
            this.Controls.Add(this.processReady7TimeLabel);
            this.Controls.Add(this.processReady6TimeLabel);
            this.Controls.Add(this.processReady5TimeLabel);
            this.Controls.Add(this.processReady4TimeLabel);
            this.Controls.Add(this.processReady3TimeLabel);
            this.Controls.Add(this.processReady2TimeLabel);
            this.Controls.Add(this.processReady1TimeLabel);
            this.Controls.Add(this.processReady8Label);
            this.Controls.Add(this.processReady6Label);
            this.Controls.Add(this.processReady7Label);
            this.Controls.Add(this.processReady5Label);
            this.Controls.Add(this.processReady4Label);
            this.Controls.Add(this.processReady3Label);
            this.Controls.Add(this.processReady2Label);
            this.Controls.Add(this.processReady1Label);
            this.Controls.Add(this.remainingTimeLabel);
            this.Controls.Add(this.processLabel);
            this.Controls.Add(this.readyQueueLabel);
            this.Controls.Add(this.execTimeLabel);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Name = "DynamicExecutionConsole";
            this.Text = "DynamicExecutionConsole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label execTimeLabel;
        private System.Windows.Forms.Label readyQueueLabel;
        private System.Windows.Forms.Label processLabel;
        private System.Windows.Forms.Label remainingTimeLabel;
        private System.Windows.Forms.Label ioQueueLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label runningProcessLabel;
        private System.Windows.Forms.Label completedProcessLabel;
        public System.Windows.Forms.Label runnigProcessLabelVar;
        public System.Windows.Forms.Label processReady1Label;
        public System.Windows.Forms.Label processReady2Label;
        public System.Windows.Forms.Label processReady3Label;
        public System.Windows.Forms.Label processReady4Label;
        public System.Windows.Forms.Label processReady5Label;
        public System.Windows.Forms.Label processReady7Label;
        public System.Windows.Forms.Label processReady6Label;
        public System.Windows.Forms.Label processReady8Label;
        public System.Windows.Forms.Label processReady1TimeLabel;
        public System.Windows.Forms.Label processReady2TimeLabel;
        public System.Windows.Forms.Label processReady3TimeLabel;
        public System.Windows.Forms.Label processReady4TimeLabel;
        public System.Windows.Forms.Label processReady5TimeLabel;
        public System.Windows.Forms.Label processReady6TimeLabel;
        public System.Windows.Forms.Label processReady7TimeLabel;
        public System.Windows.Forms.Label processReady8TimeLabel;
        public System.Windows.Forms.Label processReady9TimeLabel;
        public System.Windows.Forms.Label execTimeLabelVar;
        public System.Windows.Forms.Label processReady9Label;
        public System.Windows.Forms.Label processCompleted1LabelVar;
        public System.Windows.Forms.Label processIO9Label;
        public System.Windows.Forms.Label processIO9TimeLabel;
        public System.Windows.Forms.Label processIO8TimeLabel;
        public System.Windows.Forms.Label processIO7TimeLabel;
        public System.Windows.Forms.Label processIO6TimeLabel;
        public System.Windows.Forms.Label processIO5TimeLabel;
        public System.Windows.Forms.Label processIO4TimeLabel;
        public System.Windows.Forms.Label processIO3TimeLabel;
        public System.Windows.Forms.Label processIO2TimeLabel;
        public System.Windows.Forms.Label processIO1TimeLabel;
        public System.Windows.Forms.Label processIO8Label;
        public System.Windows.Forms.Label processIO6Label;
        public System.Windows.Forms.Label processIO7Label;
        public System.Windows.Forms.Label processIO5Label;
        public System.Windows.Forms.Label processIO4Label;
        public System.Windows.Forms.Label processIO3Label;
        public System.Windows.Forms.Label processIO2Label;
        public System.Windows.Forms.Label processIO1Label;
        public System.Windows.Forms.Label processCompleted4LabelVar;
        public System.Windows.Forms.Label processCompleted3LabelVar;
        public System.Windows.Forms.Label processCompleted5LabelVar;
        public System.Windows.Forms.Label processCompleted7LabelVar;
        public System.Windows.Forms.Label processCompleted6LabelVar;
        public System.Windows.Forms.Label processCompleted2LabelVar;
        public System.Windows.Forms.Label processCompleted8LabelVar;
        public System.Windows.Forms.Label processCompleted9LabelVar;
        public System.Windows.Forms.Timer CPUclock;
        public System.Windows.Forms.Label executingTimeProcess;
    }
}