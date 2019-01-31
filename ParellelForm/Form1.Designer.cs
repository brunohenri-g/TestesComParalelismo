namespace ParellelForm
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
            this.waitingStack = new System.Windows.Forms.ListBox();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.processingStack = new System.Windows.Forms.ListBox();
            this.completedStack = new System.Windows.Forms.ListBox();
            this.cancelTaskButton = new System.Windows.Forms.Button();
            this.proccessTasksButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.canceledStack = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // waitingStack
            // 
            this.waitingStack.FormattingEnabled = true;
            this.waitingStack.Location = new System.Drawing.Point(12, 12);
            this.waitingStack.Name = "waitingStack";
            this.waitingStack.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.waitingStack.Size = new System.Drawing.Size(195, 290);
            this.waitingStack.TabIndex = 0;
            // 
            // addTaskButton
            // 
            this.addTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTaskButton.ForeColor = System.Drawing.Color.OliveDrab;
            this.addTaskButton.Location = new System.Drawing.Point(12, 321);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(195, 23);
            this.addTaskButton.TabIndex = 1;
            this.addTaskButton.Text = "Adicionar Tarefa";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // processingStack
            // 
            this.processingStack.FormattingEnabled = true;
            this.processingStack.Location = new System.Drawing.Point(275, 12);
            this.processingStack.Name = "processingStack";
            this.processingStack.Size = new System.Drawing.Size(195, 290);
            this.processingStack.TabIndex = 2;
            // 
            // completedStack
            // 
            this.completedStack.FormattingEnabled = true;
            this.completedStack.Location = new System.Drawing.Point(801, 12);
            this.completedStack.Name = "completedStack";
            this.completedStack.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.completedStack.Size = new System.Drawing.Size(195, 290);
            this.completedStack.TabIndex = 3;
            // 
            // cancelTaskButton
            // 
            this.cancelTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelTaskButton.ForeColor = System.Drawing.Color.Crimson;
            this.cancelTaskButton.Location = new System.Drawing.Point(801, 321);
            this.cancelTaskButton.Name = "cancelTaskButton";
            this.cancelTaskButton.Size = new System.Drawing.Size(195, 23);
            this.cancelTaskButton.TabIndex = 4;
            this.cancelTaskButton.Text = "Cancelar Tarefa";
            this.cancelTaskButton.UseVisualStyleBackColor = true;
            this.cancelTaskButton.Click += new System.EventHandler(this.cancelTaskButton_Click);
            // 
            // proccessTasksButton
            // 
            this.proccessTasksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proccessTasksButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.proccessTasksButton.Location = new System.Drawing.Point(275, 321);
            this.proccessTasksButton.Name = "proccessTasksButton";
            this.proccessTasksButton.Size = new System.Drawing.Size(195, 23);
            this.proccessTasksButton.TabIndex = 5;
            this.proccessTasksButton.Text = "Processar Tarefas";
            this.proccessTasksButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quantidades de Taredas Simultâneas";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(216, 363);
            this.trackBar1.Maximum = 8;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 1;
            // 
            // canceledStack
            // 
            this.canceledStack.FormattingEnabled = true;
            this.canceledStack.Location = new System.Drawing.Point(538, 12);
            this.canceledStack.Name = "canceledStack";
            this.canceledStack.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.canceledStack.Size = new System.Drawing.Size(195, 290);
            this.canceledStack.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 420);
            this.Controls.Add(this.canceledStack);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.proccessTasksButton);
            this.Controls.Add(this.cancelTaskButton);
            this.Controls.Add(this.completedStack);
            this.Controls.Add(this.processingStack);
            this.Controls.Add(this.addTaskButton);
            this.Controls.Add(this.waitingStack);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox waitingStack;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.ListBox processingStack;
        private System.Windows.Forms.ListBox completedStack;
        private System.Windows.Forms.Button cancelTaskButton;
        private System.Windows.Forms.Button proccessTasksButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ListBox canceledStack;
    }
}

