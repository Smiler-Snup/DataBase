
namespace CourseProject
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.gradientPanel1 = new Lab__8.GradientPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ButtonFinish = new CourseProject.ImagePersonal();
            this.LabelFinish = new CourseProject.LabelMy();
            this.BackGroundButtonFinish = new CourseProject.ImagePersonal();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonFinish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGroundButtonFinish)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 245F;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(49)))));
            this.gradientPanel1.Controls.Add(this.ButtonFinish);
            this.gradientPanel1.Controls.Add(this.BackGroundButtonFinish);
            this.gradientPanel1.Controls.Add(this.LabelFinish);
            this.gradientPanel1.Controls.Add(this.label5);
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(584, 361);
            this.gradientPanel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(165, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Закрытие окна через 25 . . .";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(92, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(430, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Выполнил: Персицков Д.Д. группы 19ВП2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(46, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(535, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Область \"Успеваемость студентов на факультете\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(190, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тема \"База данных\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Курсовая работа";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ButtonFinish
            // 
            this.ButtonFinish.BackColor = System.Drawing.Color.Transparent;
            this.ButtonFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonFinish.Image = global::CourseProject.Properties.Resources.ЗавершитьСчетБезФона;
            this.ButtonFinish.imageBase = global::CourseProject.Properties.Resources.ЗавершитьСчетБезФона;
            this.ButtonFinish.imageChange = global::CourseProject.Properties.Resources.ЗавершитьСчетСФоном;
            this.ButtonFinish.ImageClickDown = global::CourseProject.Properties.Resources.ЗавершитьСчетСФономПоНажатию;
            this.ButtonFinish.labelMy = this.LabelFinish;
            this.ButtonFinish.Location = new System.Drawing.Point(170, 228);
            this.ButtonFinish.MyImageBack = this.BackGroundButtonFinish;
            this.ButtonFinish.Name = "ButtonFinish";
            this.ButtonFinish.Size = new System.Drawing.Size(55, 54);
            this.ButtonFinish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonFinish.TabIndex = 18;
            this.ButtonFinish.TabStop = false;
            this.ButtonFinish.Click += new System.EventHandler(this.ButtonFinish_Click);
            // 
            // LabelFinish
            // 
            this.LabelFinish.AutoSize = true;
            this.LabelFinish.BackColor = System.Drawing.Color.Transparent;
            this.LabelFinish.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(49)))));
            this.LabelFinish.ChangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.LabelFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelFinish.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelFinish.imagePersonal = this.ButtonFinish;
            this.LabelFinish.Location = new System.Drawing.Point(239, 237);
            this.LabelFinish.Name = "LabelFinish";
            this.LabelFinish.Size = new System.Drawing.Size(231, 36);
            this.LabelFinish.TabIndex = 17;
            this.LabelFinish.Text = "Закрыть окно";
            this.LabelFinish.Click += new System.EventHandler(this.LabelFinish_Click);
            // 
            // BackGroundButtonFinish
            // 
            this.BackGroundButtonFinish.BackColor = System.Drawing.Color.Transparent;
            this.BackGroundButtonFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackGroundButtonFinish.Image = ((System.Drawing.Image)(resources.GetObject("BackGroundButtonFinish.Image")));
            this.BackGroundButtonFinish.imageBase = ((System.Drawing.Image)(resources.GetObject("BackGroundButtonFinish.imageBase")));
            this.BackGroundButtonFinish.imageChange = ((System.Drawing.Image)(resources.GetObject("BackGroundButtonFinish.imageChange")));
            this.BackGroundButtonFinish.ImageClickDown = null;
            this.BackGroundButtonFinish.labelMy = null;
            this.BackGroundButtonFinish.Location = new System.Drawing.Point(156, 220);
            this.BackGroundButtonFinish.MyImageBack = null;
            this.BackGroundButtonFinish.Name = "BackGroundButtonFinish";
            this.BackGroundButtonFinish.Size = new System.Drawing.Size(81, 69);
            this.BackGroundButtonFinish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackGroundButtonFinish.TabIndex = 19;
            this.BackGroundButtonFinish.TabStop = false;
            this.BackGroundButtonFinish.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.gradientPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Доброго времени суток";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonFinish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGroundButtonFinish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Lab__8.GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private ImagePersonal ButtonFinish;
        private LabelMy LabelFinish;
        private ImagePersonal BackGroundButtonFinish;
    }
}