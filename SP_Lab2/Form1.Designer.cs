namespace SP_Lab2
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            ProcessList = new ListBox();
            processTimer = new System.Windows.Forms.Timer(components);
            ProcessDetailsTextBox = new RichTextBox();
            button2 = new Button();
            Syop_btn = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(22, 19);
            button1.Name = "button1";
            button1.Size = new Size(385, 38);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ShowList;
            // 
            // ProcessList
            // 
            ProcessList.FormattingEnabled = true;
            ProcessList.Location = new Point(22, 75);
            ProcessList.Name = "ProcessList";
            ProcessList.Size = new Size(510, 284);
            ProcessList.TabIndex = 1;
            ProcessList.SelectedIndexChanged += ProcessList_SelectedIndexChanged;
            // 
            // ProcessDetailsTextBox
            // 
            ProcessDetailsTextBox.Location = new Point(22, 381);
            ProcessDetailsTextBox.Name = "ProcessDetailsTextBox";
            ProcessDetailsTextBox.Size = new Size(385, 92);
            ProcessDetailsTextBox.TabIndex = 2;
            ProcessDetailsTextBox.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(427, 401);
            button2.Name = "button2";
            button2.Size = new Size(92, 48);
            button2.TabIndex = 3;
            button2.Text = "Kill";
            button2.UseVisualStyleBackColor = true;
            button2.Click += KillButton_Click;
            // 
            // Syop_btn
            // 
            Syop_btn.Location = new Point(419, 19);
            Syop_btn.Name = "Syop_btn";
            Syop_btn.Size = new Size(100, 38);
            Syop_btn.TabIndex = 4;
            Syop_btn.Text = "Stop";
            Syop_btn.UseVisualStyleBackColor = true;
            Syop_btn.Click += StopUpdate;
            // 
            // button3
            // 
            button3.Location = new Point(559, 48);
            button3.Name = "button3";
            button3.Size = new Size(137, 49);
            button3.TabIndex = 5;
            button3.Text = "Notepad";
            button3.UseVisualStyleBackColor = true;
            button3.Click += RunProgramm;
            // 
            // button4
            // 
            button4.Location = new Point(559, 140);
            button4.Name = "button4";
            button4.Size = new Size(137, 49);
            button4.TabIndex = 6;
            button4.Text = "Calculator";
            button4.UseVisualStyleBackColor = true;
            button4.Click += RunProgramm;
            // 
            // button5
            // 
            button5.Location = new Point(559, 230);
            button5.Name = "button5";
            button5.Size = new Size(137, 49);
            button5.TabIndex = 7;
            button5.Text = "Paint";
            button5.UseVisualStyleBackColor = true;
            button5.Click += RunProgramm;
            // 
            // button6
            // 
            button6.Location = new Point(559, 328);
            button6.Name = "button6";
            button6.Size = new Size(137, 49);
            button6.TabIndex = 8;
            button6.Text = "WeatherApp";
            button6.UseVisualStyleBackColor = true;
            button6.Click += RunProgramm;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 485);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(Syop_btn);
            Controls.Add(button2);
            Controls.Add(ProcessDetailsTextBox);
            Controls.Add(ProcessList);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox ProcessList;
        private System.Windows.Forms.Timer processTimer;
        private RichTextBox ProcessDetailsTextBox;
        private Button button2;
        private Button Syop_btn;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
