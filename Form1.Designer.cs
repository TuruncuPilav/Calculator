namespace Colculator
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.processScreen = new System.Windows.Forms.Label();
            this.screen = new System.Windows.Forms.Label();
            this.number1 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.numberC = new System.Windows.Forms.Button();
            this.numberSubtract = new System.Windows.Forms.Button();
            this.numberDivide = new System.Windows.Forms.Button();
            this.numberMultiply = new System.Windows.Forms.Button();
            this.numberEquals = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.nummberDelete = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.numberPlus = new System.Windows.Forms.Button();
            this.numberComma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // processScreen
            // 
            this.processScreen.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.processScreen, "processScreen");
            this.processScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.processScreen.Name = "processScreen";
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.screen, "screen");
            this.screen.Name = "screen";
            // 
            // number1
            // 
            resources.ApplyResources(this.number1, "number1");
            this.number1.Name = "number1";
            this.number1.TabStop = false;
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.number1_Click);
            // 
            // number2
            // 
            resources.ApplyResources(this.number2, "number2");
            this.number2.Name = "number2";
            this.number2.TabStop = false;
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.number2_Click);
            // 
            // number3
            // 
            resources.ApplyResources(this.number3, "number3");
            this.number3.Name = "number3";
            this.number3.TabStop = false;
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.number3_Click);
            // 
            // number4
            // 
            resources.ApplyResources(this.number4, "number4");
            this.number4.Name = "number4";
            this.number4.TabStop = false;
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.number4_Click);
            // 
            // number5
            // 
            resources.ApplyResources(this.number5, "number5");
            this.number5.Name = "number5";
            this.number5.TabStop = false;
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.number5_Click);
            // 
            // number6
            // 
            resources.ApplyResources(this.number6, "number6");
            this.number6.Name = "number6";
            this.number6.TabStop = false;
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.number6_Click);
            // 
            // number8
            // 
            resources.ApplyResources(this.number8, "number8");
            this.number8.Name = "number8";
            this.number8.TabStop = false;
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.number8_Click);
            // 
            // number9
            // 
            resources.ApplyResources(this.number9, "number9");
            this.number9.Name = "number9";
            this.number9.TabStop = false;
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.number9_Click);
            // 
            // number7
            // 
            resources.ApplyResources(this.number7, "number7");
            this.number7.Name = "number7";
            this.number7.TabStop = false;
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.number7_Click);
            // 
            // number0
            // 
            resources.ApplyResources(this.number0, "number0");
            this.number0.Name = "number0";
            this.number0.TabStop = false;
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.number0_Click);
            // 
            // numberC
            // 
            resources.ApplyResources(this.numberC, "numberC");
            this.numberC.Name = "numberC";
            this.numberC.TabStop = false;
            this.numberC.UseVisualStyleBackColor = true;
            this.numberC.Click += new System.EventHandler(this.numberC_Click);
            // 
            // numberSubtract
            // 
            resources.ApplyResources(this.numberSubtract, "numberSubtract");
            this.numberSubtract.Name = "numberSubtract";
            this.numberSubtract.TabStop = false;
            this.numberSubtract.UseVisualStyleBackColor = true;
            this.numberSubtract.Click += new System.EventHandler(this.numberSubtract_Click);
            // 
            // numberDivide
            // 
            resources.ApplyResources(this.numberDivide, "numberDivide");
            this.numberDivide.Name = "numberDivide";
            this.numberDivide.TabStop = false;
            this.numberDivide.UseVisualStyleBackColor = true;
            this.numberDivide.Click += new System.EventHandler(this.numberDivide_Click);
            // 
            // numberMultiply
            // 
            resources.ApplyResources(this.numberMultiply, "numberMultiply");
            this.numberMultiply.Name = "numberMultiply";
            this.numberMultiply.TabStop = false;
            this.numberMultiply.UseVisualStyleBackColor = true;
            this.numberMultiply.Click += new System.EventHandler(this.numberMultiply_Click);
            // 
            // numberEquals
            // 
            resources.ApplyResources(this.numberEquals, "numberEquals");
            this.numberEquals.Name = "numberEquals";
            this.numberEquals.TabStop = false;
            this.numberEquals.UseVisualStyleBackColor = true;
            this.numberEquals.Click += new System.EventHandler(this.numberEquals_Click);
            // 
            // button17
            // 
            resources.ApplyResources(this.button17, "button17");
            this.button17.Name = "button17";
            this.button17.TabStop = false;
            this.button17.UseVisualStyleBackColor = true;
            // 
            // nummberDelete
            // 
            resources.ApplyResources(this.nummberDelete, "nummberDelete");
            this.nummberDelete.Name = "nummberDelete";
            this.nummberDelete.TabStop = false;
            this.nummberDelete.UseVisualStyleBackColor = true;
            this.nummberDelete.Click += new System.EventHandler(this.nummberDelete_Click);
            // 
            // button19
            // 
            resources.ApplyResources(this.button19, "button19");
            this.button19.Name = "button19";
            this.button19.TabStop = false;
            this.button19.UseVisualStyleBackColor = true;
            // 
            // numberPlus
            // 
            resources.ApplyResources(this.numberPlus, "numberPlus");
            this.numberPlus.Name = "numberPlus";
            this.numberPlus.TabStop = false;
            this.numberPlus.UseVisualStyleBackColor = true;
            this.numberPlus.Click += new System.EventHandler(this.numberPlus_Click);
            // 
            // numberComma
            // 
            resources.ApplyResources(this.numberComma, "numberComma");
            this.numberComma.Name = "numberComma";
            this.numberComma.TabStop = false;
            this.numberComma.UseVisualStyleBackColor = true;
            this.numberComma.Click += new System.EventHandler(this.numberComma_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numberComma);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.nummberDelete);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.numberPlus);
            this.Controls.Add(this.numberEquals);
            this.Controls.Add(this.numberMultiply);
            this.Controls.Add(this.numberDivide);
            this.Controls.Add(this.numberSubtract);
            this.Controls.Add(this.numberC);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.processScreen);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label processScreen;
        private System.Windows.Forms.Label screen;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button numberC;
        private System.Windows.Forms.Button numberSubtract;
        private System.Windows.Forms.Button numberDivide;
        private System.Windows.Forms.Button numberMultiply;
        private System.Windows.Forms.Button numberEquals;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button nummberDelete;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button numberPlus;
        private System.Windows.Forms.Button numberComma;
    }
}

