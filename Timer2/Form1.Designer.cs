namespace Timer2
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
            components=new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timer1=new System.Windows.Forms.Timer(components);
            Bt_start=new Button();
            label1=new Label();
            numericUp=new NumericUpDown();
            label2=new Label();
            Bt_stop=new Button();
            ((System.ComponentModel.ISupportInitialize)numericUp).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval=1000;
            timer1.Tick+=timer1_Tick;
            // 
            // Bt_start
            // 
            Bt_start.BackColor=Color.Chartreuse;
            Bt_start.Location=new Point(32, 90);
            Bt_start.Name="Bt_start";
            Bt_start.Size=new Size(132, 23);
            Bt_start.TabIndex=0;
            Bt_start.Text="START";
            Bt_start.UseVisualStyleBackColor=false;
            Bt_start.Click+=button1_Click;
            // 
            // label1
            // 
            label1.BackColor=Color.White;
            label1.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(167, 129);
            label1.Name="label1";
            label1.Size=new Size(45, 21);
            label1.TabIndex=1;
            label1.Text="0";
            label1.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // numericUp
            // 
            numericUp.Location=new Point(212, 45);
            numericUp.Name="numericUp";
            numericUp.Size=new Size(120, 23);
            numericUp.TabIndex=2;
            numericUp.TextAlign=HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.BackColor=SystemColors.ActiveCaption;
            label2.Location=new Point(32, 45);
            label2.Name="label2";
            label2.Size=new Size(132, 23);
            label2.TabIndex=3;
            label2.Text="Количество секунд";
            label2.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // Bt_stop
            // 
            Bt_stop.BackColor=Color.FromArgb(255, 128, 128);
            Bt_stop.Location=new Point(212, 90);
            Bt_stop.Name="Bt_stop";
            Bt_stop.Size=new Size(120, 23);
            Bt_stop.TabIndex=4;
            Bt_stop.Text="STOP";
            Bt_stop.UseVisualStyleBackColor=false;
            Bt_stop.Click+=button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.AppWorkspace;
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout=ImageLayout.Stretch;
            ClientSize=new Size(369, 176);
            Controls.Add(Bt_stop);
            Controls.Add(label2);
            Controls.Add(numericUp);
            Controls.Add(label1);
            Controls.Add(Bt_start);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            Icon=(Icon)resources.GetObject("$this.Icon");
            Name="Form1";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Form1";
            ((System.ComponentModel.ISupportInitialize)numericUp).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button Bt_start;
        private Label label1;
        private NumericUpDown numericUp;
        private Label label2;
        private Button Bt_stop;
    }
}