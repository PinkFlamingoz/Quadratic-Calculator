namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sw = new System.Windows.Forms.Label();
            this.rtsHistory = new System.Windows.Forms.RichTextBox();
            this.DeleteHistory = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BOXB = new System.Windows.Forms.TextBox();
            this.BOXA = new System.Windows.Forms.TextBox();
            this.BOXC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonnext = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hANoHelpForYouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvineteZaMojoHumorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pressMeForInstructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sw);
            this.groupBox1.Controls.Add(this.rtsHistory);
            this.groupBox1.Controls.Add(this.DeleteHistory);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.Result);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BOXB);
            this.groupBox1.Controls.Add(this.BOXA);
            this.groupBox1.Controls.Add(this.BOXC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 406);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quadratic Calculator";
            // 
            // sw
            // 
            this.sw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sw.Location = new System.Drawing.Point(6, 62);
            this.sw.Name = "sw";
            this.sw.Size = new System.Drawing.Size(210, 20);
            this.sw.TabIndex = 25;
            this.toolTip1.SetToolTip(this.sw, "Stopwatch for calculation of the time it takes to execute the program!");
            // 
            // rtsHistory
            // 
            this.rtsHistory.BackColor = System.Drawing.SystemColors.Menu;
            this.rtsHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtsHistory.Location = new System.Drawing.Point(222, 102);
            this.rtsHistory.Name = "rtsHistory";
            this.rtsHistory.ReadOnly = true;
            this.rtsHistory.Size = new System.Drawing.Size(189, 160);
            this.rtsHistory.TabIndex = 24;
            this.rtsHistory.Text = "";
            this.toolTip1.SetToolTip(this.rtsHistory, "If you see \'i\' that represents the Imaginary numebr, the complex root!");
            // 
            // DeleteHistory
            // 
            this.DeleteHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteHistory.Location = new System.Drawing.Point(330, 268);
            this.DeleteHistory.Name = "DeleteHistory";
            this.DeleteHistory.Size = new System.Drawing.Size(81, 40);
            this.DeleteHistory.TabIndex = 23;
            this.DeleteHistory.Text = "☠☢♻";
            this.toolTip1.SetToolTip(this.DeleteHistory, "Delete your history!");
            this.DeleteHistory.UseVisualStyleBackColor = true;
            this.DeleteHistory.Visible = false;
            this.DeleteHistory.Click += new System.EventHandler(this.DeleteHistory_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "History";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(222, 268);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(29, 40);
            this.button14.TabIndex = 20;
            this.button14.Text = "⌫";
            this.toolTip1.SetToolTip(this.button14, "Backspace for all of your mistakes !");
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(41, 129);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(66, 40);
            this.button12.TabIndex = 19;
            this.button12.Text = "-";
            this.toolTip1.SetToolTip(this.button12, "- is for negative numbers!");
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(114, 129);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(66, 40);
            this.button13.TabIndex = 18;
            this.button13.Text = "9";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(150, 221);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(66, 40);
            this.button9.TabIndex = 17;
            this.button9.Text = "5";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(78, 221);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(66, 40);
            this.button10.TabIndex = 16;
            this.button10.Text = "4";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(6, 221);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(66, 40);
            this.button11.TabIndex = 15;
            this.button11.Text = "3";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(150, 175);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(66, 40);
            this.button6.TabIndex = 14;
            this.button6.Text = "8";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(78, 175);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(66, 40);
            this.button7.TabIndex = 13;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(6, 175);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(66, 40);
            this.button8.TabIndex = 12;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(150, 268);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 40);
            this.button5.TabIndex = 11;
            this.button5.Text = "2";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(78, 268);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 40);
            this.button4.TabIndex = 10;
            this.button4.Text = "1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(6, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 40);
            this.button3.TabIndex = 9;
            this.button3.Text = "0";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // Result
            // 
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Result.Location = new System.Drawing.Point(222, 39);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(189, 43);
            this.Result.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Result";
            // 
            // BOXB
            // 
            this.BOXB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BOXB.Location = new System.Drawing.Point(80, 39);
            this.BOXB.Name = "BOXB";
            this.BOXB.ReadOnly = true;
            this.BOXB.Size = new System.Drawing.Size(63, 20);
            this.BOXB.TabIndex = 6;
            // 
            // BOXA
            // 
            this.BOXA.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BOXA.Location = new System.Drawing.Point(6, 39);
            this.BOXA.Name = "BOXA";
            this.BOXA.ReadOnly = true;
            this.BOXA.Size = new System.Drawing.Size(63, 20);
            this.BOXA.TabIndex = 5;
            // 
            // BOXC
            // 
            this.BOXC.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BOXC.Location = new System.Drawing.Point(153, 39);
            this.BOXC.Name = "BOXC";
            this.BOXC.ReadOnly = true;
            this.BOXC.Size = new System.Drawing.Size(63, 20);
            this.BOXC.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "B";
            this.toolTip1.SetToolTip(this.label3, "This is X");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "C";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "A";
            this.toolTip1.SetToolTip(this.label1, "This is X²");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonnext);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(6, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 78);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commands";
            // 
            // buttonnext
            // 
            this.buttonnext.Location = new System.Drawing.Point(232, 32);
            this.buttonnext.Name = "buttonnext";
            this.buttonnext.Size = new System.Drawing.Size(107, 40);
            this.buttonnext.TabIndex = 2;
            this.buttonnext.Text = "Next";
            this.toolTip1.SetToolTip(this.buttonnext, "Cycle between A, B and C !");
            this.buttonnext.UseVisualStyleBackColor = true;
            this.buttonnext.Click += new System.EventHandler(this.buttonnext_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(119, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Reset";
            this.toolTip1.SetToolTip(this.button2, "♪ Go to sleep! ♫ Go to sleep!♪");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fix Problem";
            this.toolTip1.SetToolTip(this.button1, "But can it fix my life :/");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniToolStripMenuItem,
            this.pressMeForInstructionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(435, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniToolStripMenuItem
            // 
            this.meniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.meniToolStripMenuItem.Name = "meniToolStripMenuItem";
            this.meniToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.meniToolStripMenuItem.Text = "Menu";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hANoHelpForYouToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.helpToolStripMenuItem.Text = "Help!";
            // 
            // hANoHelpForYouToolStripMenuItem
            // 
            this.hANoHelpForYouToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izvineteZaMojoHumorToolStripMenuItem});
            this.hANoHelpForYouToolStripMenuItem.Name = "hANoHelpForYouToolStripMenuItem";
            this.hANoHelpForYouToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.hANoHelpForYouToolStripMenuItem.Text = "HA! No Help for you!";
            // 
            // izvineteZaMojoHumorToolStripMenuItem
            // 
            this.izvineteZaMojoHumorToolStripMenuItem.Name = "izvineteZaMojoHumorToolStripMenuItem";
            this.izvineteZaMojoHumorToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.izvineteZaMojoHumorToolStripMenuItem.Text = "Sorry for my humur :/";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "Exit ";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pressMeForInstructionsToolStripMenuItem
            // 
            this.pressMeForInstructionsToolStripMenuItem.Name = "pressMeForInstructionsToolStripMenuItem";
            this.pressMeForInstructionsToolStripMenuItem.Size = new System.Drawing.Size(152, 20);
            this.pressMeForInstructionsToolStripMenuItem.Text = "Press me for instructions!";
            this.pressMeForInstructionsToolStripMenuItem.Click += new System.EventHandler(this.pressMeForInstructionsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(435, 437);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(451, 476);
            this.MinimumSize = new System.Drawing.Size(451, 476);
            this.Name = "Form1";
            this.Text = "Super Mega Awesome Fun Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BOXB;
        private System.Windows.Forms.TextBox BOXA;
        private System.Windows.Forms.TextBox BOXC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonnext;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button DeleteHistory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtsHistory;
        private System.Windows.Forms.ToolStripMenuItem pressMeForInstructionsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label sw;
        private System.Windows.Forms.ToolStripMenuItem meniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hANoHelpForYouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvineteZaMojoHumorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

