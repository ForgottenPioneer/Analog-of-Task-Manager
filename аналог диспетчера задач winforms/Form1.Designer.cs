namespace аналог_диспетчера_задач_winforms
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
            this.dataGridViewProcesses = new System.Windows.Forms.DataGridView();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonTerminate = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonUserProcesses = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcesses)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProcesses
            // 
            this.dataGridViewProcesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcesses.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProcesses.Name = "dataGridViewProcesses";
            this.dataGridViewProcesses.Size = new System.Drawing.Size(646, 150);
            this.dataGridViewProcesses.TabIndex = 0;
            this.dataGridViewProcesses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(122, 182);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilter.TabIndex = 1;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(438, 208);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(337, 23);
            this.buttonFilter.TabIndex = 2;
            this.buttonFilter.Text = "фильтрует процессы по имени при нажатии кнопки \"Фильтр\"";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonTerminate
            // 
            this.buttonTerminate.Location = new System.Drawing.Point(287, 237);
            this.buttonTerminate.Name = "buttonTerminate";
            this.buttonTerminate.Size = new System.Drawing.Size(359, 23);
            this.buttonTerminate.TabIndex = 3;
            this.buttonTerminate.Text = " завершает выбранный процесс при нажатии кнопки";
            this.buttonTerminate.UseVisualStyleBackColor = true;
            this.buttonTerminate.Click += new System.EventHandler(this.buttonTerminate_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(0, 237);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(281, 23);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "обновляет список процессов при нажатии кнопки";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonUserProcesses
            // 
            this.buttonUserProcesses.Location = new System.Drawing.Point(652, 237);
            this.buttonUserProcesses.Name = "buttonUserProcesses";
            this.buttonUserProcesses.Size = new System.Drawing.Size(527, 23);
            this.buttonUserProcesses.TabIndex = 5;
            this.buttonUserProcesses.Text = "отображает процессы, запущенные текущим пользователем, при нажатии кнопки \"Процес" +
    "сы пользователя\"";
            this.buttonUserProcesses.UseVisualStyleBackColor = true;
            this.buttonUserProcesses.Click += new System.EventHandler(this.buttonUserProcesses_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1274, 261);
            this.Controls.Add(this.buttonUserProcesses);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonTerminate);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.dataGridViewProcesses);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcesses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridViewProcesses;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonTerminate;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonUserProcesses;
    }
}

