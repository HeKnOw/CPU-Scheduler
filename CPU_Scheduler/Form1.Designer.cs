namespace CPU_Scheduler
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pickalgo = new System.Windows.Forms.Button();
            this.editpro = new System.Windows.Forms.Button();
            this.FCFSbutton = new System.Windows.Forms.Button();
            this.SJFbutton = new System.Windows.Forms.Button();
            this.MLFQbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(990, 153);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU Scheduler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(695, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Christian Hinostroza and Alexander Sanchez";
            // 
            // pickalgo
            // 
            this.pickalgo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickalgo.Location = new System.Drawing.Point(324, 313);
            this.pickalgo.Name = "pickalgo";
            this.pickalgo.Size = new System.Drawing.Size(275, 55);
            this.pickalgo.TabIndex = 2;
            this.pickalgo.Text = "Continue to pick algorithm";
            this.pickalgo.UseVisualStyleBackColor = true;
            this.pickalgo.Click += new System.EventHandler(this.button1_Click);
            // 
            // editpro
            // 
            this.editpro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editpro.Location = new System.Drawing.Point(739, 313);
            this.editpro.Name = "editpro";
            this.editpro.Size = new System.Drawing.Size(273, 57);
            this.editpro.TabIndex = 3;
            this.editpro.Text = "Edit Processes";
            this.editpro.UseVisualStyleBackColor = true;
            this.editpro.Click += new System.EventHandler(this.editpro_Click);
            // 
            // FCFSbutton
            // 
            this.FCFSbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FCFSbutton.Location = new System.Drawing.Point(324, 390);
            this.FCFSbutton.Name = "FCFSbutton";
            this.FCFSbutton.Size = new System.Drawing.Size(217, 54);
            this.FCFSbutton.TabIndex = 4;
            this.FCFSbutton.Text = "FCFS";
            this.FCFSbutton.UseVisualStyleBackColor = true;
            this.FCFSbutton.Click += new System.EventHandler(this.FCFSbutton_Click);
            // 
            // SJFbutton
            // 
            this.SJFbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SJFbutton.Location = new System.Drawing.Point(576, 390);
            this.SJFbutton.Name = "SJFbutton";
            this.SJFbutton.Size = new System.Drawing.Size(204, 53);
            this.SJFbutton.TabIndex = 5;
            this.SJFbutton.Text = "SJF";
            this.SJFbutton.UseVisualStyleBackColor = true;
            this.SJFbutton.Click += new System.EventHandler(this.SJFbutton_Click);
            // 
            // MLFQbutton
            // 
            this.MLFQbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLFQbutton.Location = new System.Drawing.Point(807, 390);
            this.MLFQbutton.Name = "MLFQbutton";
            this.MLFQbutton.Size = new System.Drawing.Size(204, 53);
            this.MLFQbutton.TabIndex = 6;
            this.MLFQbutton.Text = "MLFQ";
            this.MLFQbutton.UseVisualStyleBackColor = true;
            this.MLFQbutton.Click += new System.EventHandler(this.MLFQbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 591);
            this.Controls.Add(this.MLFQbutton);
            this.Controls.Add(this.SJFbutton);
            this.Controls.Add(this.FCFSbutton);
            this.Controls.Add(this.editpro);
            this.Controls.Add(this.pickalgo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button pickalgo;
        private System.Windows.Forms.Button editpro;
        private System.Windows.Forms.Button FCFSbutton;
        private System.Windows.Forms.Button SJFbutton;
        private System.Windows.Forms.Button MLFQbutton;
    }
}

