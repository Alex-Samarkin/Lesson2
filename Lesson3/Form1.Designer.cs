
namespace Lesson3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label bLabel;
            System.Windows.Forms.Label d_inLabel;
            System.Windows.Forms.Label d_outLabel;
            System.Windows.Forms.Label fLabel;
            System.Windows.Forms.Label hLabel;
            System.Windows.Forms.Label lLabel;
            System.Windows.Forms.Label rLabel;
            System.Windows.Forms.Label zLabel;
            this.splineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.d_inTextBox = new System.Windows.Forms.TextBox();
            this.d_outTextBox = new System.Windows.Forms.TextBox();
            this.fTextBox = new System.Windows.Forms.TextBox();
            this.hTextBox = new System.Windows.Forms.TextBox();
            this.lTextBox = new System.Windows.Forms.TextBox();
            this.rTextBox = new System.Windows.Forms.TextBox();
            this.zTextBox = new System.Windows.Forms.TextBox();
            bLabel = new System.Windows.Forms.Label();
            d_inLabel = new System.Windows.Forms.Label();
            d_outLabel = new System.Windows.Forms.Label();
            fLabel = new System.Windows.Forms.Label();
            hLabel = new System.Windows.Forms.Label();
            lLabel = new System.Windows.Forms.Label();
            rLabel = new System.Windows.Forms.Label();
            zLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splineBindingSource
            // 
            this.splineBindingSource.DataSource = typeof(Lesson3.Spline);
            // 
            // bLabel
            // 
            bLabel.AutoSize = true;
            bLabel.Location = new System.Drawing.Point(25, 43);
            bLabel.Name = "bLabel";
            bLabel.Size = new System.Drawing.Size(16, 13);
            bLabel.TabIndex = 1;
            bLabel.Text = "b:";
            // 
            // bTextBox
            // 
            this.bTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.splineBindingSource, "b", true));
            this.bTextBox.Location = new System.Drawing.Point(67, 40);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(100, 20);
            this.bTextBox.TabIndex = 2;
            // 
            // d_inLabel
            // 
            d_inLabel.AutoSize = true;
            d_inLabel.Location = new System.Drawing.Point(25, 69);
            d_inLabel.Name = "d_inLabel";
            d_inLabel.Size = new System.Drawing.Size(27, 13);
            d_inLabel.TabIndex = 3;
            d_inLabel.Text = "d in:";
            // 
            // d_inTextBox
            // 
            this.d_inTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.splineBindingSource, "d_in", true));
            this.d_inTextBox.Location = new System.Drawing.Point(67, 66);
            this.d_inTextBox.Name = "d_inTextBox";
            this.d_inTextBox.Size = new System.Drawing.Size(100, 20);
            this.d_inTextBox.TabIndex = 4;
            // 
            // d_outLabel
            // 
            d_outLabel.AutoSize = true;
            d_outLabel.Location = new System.Drawing.Point(25, 95);
            d_outLabel.Name = "d_outLabel";
            d_outLabel.Size = new System.Drawing.Size(36, 13);
            d_outLabel.TabIndex = 5;
            d_outLabel.Text = "D out:";
            // 
            // d_outTextBox
            // 
            this.d_outTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.splineBindingSource, "D_out", true));
            this.d_outTextBox.Location = new System.Drawing.Point(67, 92);
            this.d_outTextBox.Name = "d_outTextBox";
            this.d_outTextBox.Size = new System.Drawing.Size(100, 20);
            this.d_outTextBox.TabIndex = 6;
            // 
            // fLabel
            // 
            fLabel.AutoSize = true;
            fLabel.Location = new System.Drawing.Point(25, 121);
            fLabel.Name = "fLabel";
            fLabel.Size = new System.Drawing.Size(13, 13);
            fLabel.TabIndex = 7;
            fLabel.Text = "f:";
            // 
            // fTextBox
            // 
            this.fTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.splineBindingSource, "f", true));
            this.fTextBox.Location = new System.Drawing.Point(67, 118);
            this.fTextBox.Name = "fTextBox";
            this.fTextBox.Size = new System.Drawing.Size(100, 20);
            this.fTextBox.TabIndex = 8;
            // 
            // hLabel
            // 
            hLabel.AutoSize = true;
            hLabel.Location = new System.Drawing.Point(25, 147);
            hLabel.Name = "hLabel";
            hLabel.Size = new System.Drawing.Size(16, 13);
            hLabel.TabIndex = 9;
            hLabel.Text = "h:";
            // 
            // hTextBox
            // 
            this.hTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.splineBindingSource, "h", true));
            this.hTextBox.Location = new System.Drawing.Point(67, 144);
            this.hTextBox.Name = "hTextBox";
            this.hTextBox.Size = new System.Drawing.Size(100, 20);
            this.hTextBox.TabIndex = 10;
            // 
            // lLabel
            // 
            lLabel.AutoSize = true;
            lLabel.Location = new System.Drawing.Point(25, 173);
            lLabel.Name = "lLabel";
            lLabel.Size = new System.Drawing.Size(12, 13);
            lLabel.TabIndex = 11;
            lLabel.Text = "l:";
            // 
            // lTextBox
            // 
            this.lTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.splineBindingSource, "l", true));
            this.lTextBox.Location = new System.Drawing.Point(67, 170);
            this.lTextBox.Name = "lTextBox";
            this.lTextBox.Size = new System.Drawing.Size(100, 20);
            this.lTextBox.TabIndex = 12;
            // 
            // rLabel
            // 
            rLabel.AutoSize = true;
            rLabel.Location = new System.Drawing.Point(25, 199);
            rLabel.Name = "rLabel";
            rLabel.Size = new System.Drawing.Size(13, 13);
            rLabel.TabIndex = 13;
            rLabel.Text = "r:";
            // 
            // rTextBox
            // 
            this.rTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.splineBindingSource, "r", true));
            this.rTextBox.Location = new System.Drawing.Point(67, 196);
            this.rTextBox.Name = "rTextBox";
            this.rTextBox.Size = new System.Drawing.Size(100, 20);
            this.rTextBox.TabIndex = 14;
            // 
            // zLabel
            // 
            zLabel.AutoSize = true;
            zLabel.Location = new System.Drawing.Point(25, 225);
            zLabel.Name = "zLabel";
            zLabel.Size = new System.Drawing.Size(15, 13);
            zLabel.TabIndex = 15;
            zLabel.Text = "z:";
            // 
            // zTextBox
            // 
            this.zTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.splineBindingSource, "z", true));
            this.zTextBox.Location = new System.Drawing.Point(67, 222);
            this.zTextBox.Name = "zTextBox";
            this.zTextBox.Size = new System.Drawing.Size(100, 20);
            this.zTextBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(bLabel);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(d_inLabel);
            this.Controls.Add(this.d_inTextBox);
            this.Controls.Add(d_outLabel);
            this.Controls.Add(this.d_outTextBox);
            this.Controls.Add(fLabel);
            this.Controls.Add(this.fTextBox);
            this.Controls.Add(hLabel);
            this.Controls.Add(this.hTextBox);
            this.Controls.Add(lLabel);
            this.Controls.Add(this.lTextBox);
            this.Controls.Add(rLabel);
            this.Controls.Add(this.rTextBox);
            this.Controls.Add(zLabel);
            this.Controls.Add(this.zTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.splineBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource splineBindingSource;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.TextBox d_inTextBox;
        private System.Windows.Forms.TextBox d_outTextBox;
        private System.Windows.Forms.TextBox fTextBox;
        private System.Windows.Forms.TextBox hTextBox;
        private System.Windows.Forms.TextBox lTextBox;
        private System.Windows.Forms.TextBox rTextBox;
        private System.Windows.Forms.TextBox zTextBox;
    }
}

