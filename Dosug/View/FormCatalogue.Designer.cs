namespace Dosug
{
    partial class FormCatalogue
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCatalogue));
            this.TableLayoutPanelUpper = new System.Windows.Forms.TableLayoutPanel();
            this.LabelFormName = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.TableLayoutPanelDown = new System.Windows.Forms.TableLayoutPanel();
            this.DataGridViewEvents = new System.Windows.Forms.DataGridView();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableLayoutPanelUpper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEvents)).BeginInit();
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
            this.TableLayoutPanelUpper.Size = new System.Drawing.Size(1262, 50);
            this.TableLayoutPanelUpper.TabIndex = 0;
            // 
            // LabelFormName
            // 
            this.LabelFormName.AutoSize = true;
            this.LabelFormName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelFormName.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelFormName.Location = new System.Drawing.Point(89, 0);
            this.LabelFormName.Name = "LabelFormName";
            this.LabelFormName.Size = new System.Drawing.Size(938, 50);
            this.LabelFormName.TabIndex = 1;
            this.LabelFormName.Text = "Просмотр мероприятий";
            this.LabelFormName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonExit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonExit.Location = new System.Drawing.Point(1033, 3);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(226, 44);
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
            this.TableLayoutPanelDown.Location = new System.Drawing.Point(0, 623);
            this.TableLayoutPanelDown.Name = "TableLayoutPanelDown";
            this.TableLayoutPanelDown.RowCount = 1;
            this.TableLayoutPanelDown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelDown.Size = new System.Drawing.Size(1262, 50);
            this.TableLayoutPanelDown.TabIndex = 1;
            // 
            // DataGridViewEvents
            // 
            this.DataGridViewEvents.AllowUserToAddRows = false;
            this.DataGridViewEvents.AllowUserToDeleteRows = false;
            this.DataGridViewEvents.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewEvents.ColumnHeadersVisible = false;
            this.DataGridViewEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DataGridViewEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewEvents.Location = new System.Drawing.Point(0, 50);
            this.DataGridViewEvents.Name = "DataGridViewEvents";
            this.DataGridViewEvents.ReadOnly = true;
            this.DataGridViewEvents.RowTemplate.Height = 24;
            this.DataGridViewEvents.Size = new System.Drawing.Size(1262, 573);
            this.DataGridViewEvents.TabIndex = 2;
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxLogo.Image = global::Dosug.Properties.Resources.events_logo;
            this.PictureBoxLogo.Location = new System.Drawing.Point(3, 3);
            this.PictureBoxLogo.MaximumSize = new System.Drawing.Size(50, 50);
            this.PictureBoxLogo.MinimumSize = new System.Drawing.Size(50, 50);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(50, 50);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxLogo.TabIndex = 0;
            this.PictureBoxLogo.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // FormCatalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.DataGridViewEvents);
            this.Controls.Add(this.TableLayoutPanelDown);
            this.Controls.Add(this.TableLayoutPanelUpper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(740, 500);
            this.Name = "FormCatalogue";
            this.Text = "Просмотр мероприятий";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCatalogue_FormClosing);
            this.Load += new System.EventHandler(this.FormCatalogue_Load);
            this.TableLayoutPanelUpper.ResumeLayout(false);
            this.TableLayoutPanelUpper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelUpper;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label LabelFormName;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelDown;
        private System.Windows.Forms.DataGridView DataGridViewEvents;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

