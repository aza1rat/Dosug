namespace Dosug.A
{
    partial class FormTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTemplate));
            this.TableLayoutPanelUpper = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.LabelFormName = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.TableLayoutPanelDown = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanelUpper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanelUpper
            // 
            this.TableLayoutPanelUpper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.TableLayoutPanelUpper.ColumnCount = 3;
            this.TableLayoutPanelUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.875F));
            this.TableLayoutPanelUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.875F));
            this.TableLayoutPanelUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.25F));
            this.TableLayoutPanelUpper.Controls.Add(this.PictureBoxLogo, 0, 0);
            this.TableLayoutPanelUpper.Controls.Add(this.LabelFormName, 1, 0);
            this.TableLayoutPanelUpper.Controls.Add(this.ButtonExit, 2, 0);
            this.TableLayoutPanelUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableLayoutPanelUpper.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelUpper.Name = "TableLayoutPanelUpper";
            this.TableLayoutPanelUpper.RowCount = 1;
            this.TableLayoutPanelUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TableLayoutPanelUpper.Size = new System.Drawing.Size(800, 50);
            this.TableLayoutPanelUpper.TabIndex = 0;
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxLogo.Image = global::Dosug.Properties.Resources.events_logo;
            this.PictureBoxLogo.Location = new System.Drawing.Point(3, 3);
            this.PictureBoxLogo.MinimumSize = new System.Drawing.Size(50, 50);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(50, 50);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxLogo.TabIndex = 0;
            this.PictureBoxLogo.TabStop = false;
            // 
            // LabelFormName
            // 
            this.LabelFormName.AutoSize = true;
            this.LabelFormName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelFormName.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelFormName.Location = new System.Drawing.Point(58, 0);
            this.LabelFormName.Name = "LabelFormName";
            this.LabelFormName.Size = new System.Drawing.Size(593, 50);
            this.LabelFormName.TabIndex = 1;
            this.LabelFormName.Text = "Название формы";
            this.LabelFormName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonExit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonExit.Location = new System.Drawing.Point(657, 3);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(140, 44);
            this.ButtonExit.TabIndex = 2;
            this.ButtonExit.Text = "Выход";
            this.ButtonExit.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanelDown
            // 
            this.TableLayoutPanelDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.TableLayoutPanelDown.ColumnCount = 1;
            this.TableLayoutPanelDown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelDown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelDown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TableLayoutPanelDown.Location = new System.Drawing.Point(0, 400);
            this.TableLayoutPanelDown.Name = "TableLayoutPanelDown";
            this.TableLayoutPanelDown.RowCount = 1;
            this.TableLayoutPanelDown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelDown.Size = new System.Drawing.Size(800, 50);
            this.TableLayoutPanelDown.TabIndex = 1;
            // 
            // FormTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TableLayoutPanelDown);
            this.Controls.Add(this.TableLayoutPanelUpper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTemplate";
            this.Text = "Шаблон";
            this.TableLayoutPanelUpper.ResumeLayout(false);
            this.TableLayoutPanelUpper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelUpper;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label LabelFormName;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelDown;
    }
}

