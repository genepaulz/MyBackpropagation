namespace MyBack
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWeightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadWeightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLEARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datasetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.learnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basketballToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseballToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billiardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.footballToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soccerballToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volleyballToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rugbyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.neuralNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainingSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testSampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.testResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(127, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 279);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Training Set";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 260);
            this.panel1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Multiselect = true;
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.datasetsToolStripMenuItem,
            this.runToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(461, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNNToolStripMenuItem,
            this.cLEARToolStripMenuItem,
            this.saveWeightsToolStripMenuItem,
            this.loadWeightsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createNNToolStripMenuItem
            // 
            this.createNNToolStripMenuItem.Name = "createNNToolStripMenuItem";
            this.createNNToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createNNToolStripMenuItem.Text = "Create NN";
            this.createNNToolStripMenuItem.Click += new System.EventHandler(this.createNNToolStripMenuItem_Click);
            // 
            // saveWeightsToolStripMenuItem
            // 
            this.saveWeightsToolStripMenuItem.Name = "saveWeightsToolStripMenuItem";
            this.saveWeightsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveWeightsToolStripMenuItem.Text = "Save Weights";
            this.saveWeightsToolStripMenuItem.Click += new System.EventHandler(this.saveWeightsToolStripMenuItem_Click);
            // 
            // loadWeightsToolStripMenuItem
            // 
            this.loadWeightsToolStripMenuItem.Name = "loadWeightsToolStripMenuItem";
            this.loadWeightsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadWeightsToolStripMenuItem.Text = "Load Weights";
            this.loadWeightsToolStripMenuItem.Click += new System.EventHandler(this.loadWeightsToolStripMenuItem_Click);
            // 
            // cLEARToolStripMenuItem
            // 
            this.cLEARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuralNetworkToolStripMenuItem,
            this.trainingSetToolStripMenuItem});
            this.cLEARToolStripMenuItem.Name = "cLEARToolStripMenuItem";
            this.cLEARToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cLEARToolStripMenuItem.Text = "Reset";
            // 
            // datasetsToolStripMenuItem
            // 
            this.datasetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.learnToolStripMenuItem});
            this.datasetsToolStripMenuItem.Name = "datasetsToolStripMenuItem";
            this.datasetsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.datasetsToolStripMenuItem.Text = "Datasets";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainingToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // trainingToolStripMenuItem
            // 
            this.trainingToolStripMenuItem.Name = "trainingToolStripMenuItem";
            this.trainingToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.trainingToolStripMenuItem.Text = "Training Dataset";
            this.trainingToolStripMenuItem.Click += new System.EventHandler(this.trainingToolStripMenuItem_Click);
            // 
            // learnToolStripMenuItem
            // 
            this.learnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basketballToolStripMenuItem,
            this.baseballToolStripMenuItem,
            this.billiardsToolStripMenuItem,
            this.footballToolStripMenuItem,
            this.volleyballToolStripMenuItem,
            this.soccerballToolStripMenuItem,
            this.rugbyToolStripMenuItem});
            this.learnToolStripMenuItem.Name = "learnToolStripMenuItem";
            this.learnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.learnToolStripMenuItem.Text = "Learn Balls";
            // 
            // basketballToolStripMenuItem
            // 
            this.basketballToolStripMenuItem.Name = "basketballToolStripMenuItem";
            this.basketballToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.basketballToolStripMenuItem.Text = "Basketball";
            this.basketballToolStripMenuItem.Click += new System.EventHandler(this.basketballToolStripMenuItem_Click);
            // 
            // baseballToolStripMenuItem
            // 
            this.baseballToolStripMenuItem.Name = "baseballToolStripMenuItem";
            this.baseballToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.baseballToolStripMenuItem.Text = "Baseball";
            this.baseballToolStripMenuItem.Click += new System.EventHandler(this.baseballToolStripMenuItem_Click);
            // 
            // billiardsToolStripMenuItem
            // 
            this.billiardsToolStripMenuItem.Name = "billiardsToolStripMenuItem";
            this.billiardsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.billiardsToolStripMenuItem.Text = "Billiards";
            this.billiardsToolStripMenuItem.Click += new System.EventHandler(this.billiardsToolStripMenuItem_Click);
            // 
            // footballToolStripMenuItem
            // 
            this.footballToolStripMenuItem.Name = "footballToolStripMenuItem";
            this.footballToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.footballToolStripMenuItem.Text = "Football";
            this.footballToolStripMenuItem.Click += new System.EventHandler(this.footballToolStripMenuItem_Click);
            // 
            // soccerballToolStripMenuItem
            // 
            this.soccerballToolStripMenuItem.Name = "soccerballToolStripMenuItem";
            this.soccerballToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.soccerballToolStripMenuItem.Text = "Soccerball";
            this.soccerballToolStripMenuItem.Click += new System.EventHandler(this.soccerballToolStripMenuItem_Click);
            // 
            // volleyballToolStripMenuItem
            // 
            this.volleyballToolStripMenuItem.Name = "volleyballToolStripMenuItem";
            this.volleyballToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.volleyballToolStripMenuItem.Text = "Volleyball";
            this.volleyballToolStripMenuItem.Click += new System.EventHandler(this.volleyballToolStripMenuItem_Click);
            // 
            // rugbyToolStripMenuItem
            // 
            this.rugbyToolStripMenuItem.Name = "rugbyToolStripMenuItem";
            this.rugbyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rugbyToolStripMenuItem.Text = "Rugby";
            this.rugbyToolStripMenuItem.Click += new System.EventHandler(this.rugbyToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            this.openFileDialog3.Multiselect = true;
            this.openFileDialog3.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog3_FileOk);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_tick);
            // 
            // neuralNetworkToolStripMenuItem
            // 
            this.neuralNetworkToolStripMenuItem.Name = "neuralNetworkToolStripMenuItem";
            this.neuralNetworkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.neuralNetworkToolStripMenuItem.Text = "Neural Network";
            this.neuralNetworkToolStripMenuItem.Click += new System.EventHandler(this.neuralNetworkToolStripMenuItem_Click);
            // 
            // trainingSetToolStripMenuItem
            // 
            this.trainingSetToolStripMenuItem.Name = "trainingSetToolStripMenuItem";
            this.trainingSetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trainingSetToolStripMenuItem.Text = "Training Set";
            this.trainingSetToolStripMenuItem.Click += new System.EventHandler(this.trainingSetToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testSampleToolStripMenuItem,
            this.testResultsToolStripMenuItem});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.runToolStripMenuItem.Text = "Test";
            // 
            // testSampleToolStripMenuItem
            // 
            this.testSampleToolStripMenuItem.Name = "testSampleToolStripMenuItem";
            this.testSampleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testSampleToolStripMenuItem.Text = "Test Sample";
            this.testSampleToolStripMenuItem.Click += new System.EventHandler(this.testSampleToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // testResultsToolStripMenuItem
            // 
            this.testResultsToolStripMenuItem.Name = "testResultsToolStripMenuItem";
            this.testResultsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testResultsToolStripMenuItem.Text = "Test Results";
            this.testResultsToolStripMenuItem.Click += new System.EventHandler(this.testResultsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 328);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Zafra Tamad Parin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveWeightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadWeightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datasetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainingToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem learnToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.ToolStripMenuItem cLEARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basketballToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseballToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billiardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem footballToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soccerballToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volleyballToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rugbyToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem neuralNetworkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainingSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testSampleToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem testResultsToolStripMenuItem;
    }
}

