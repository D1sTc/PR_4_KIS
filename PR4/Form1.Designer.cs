namespace PR4
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Task = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Applications = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplicationAddRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Reference = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonWithdrawList = new System.Windows.Forms.Button();
            this.Actions = new System.Windows.Forms.GroupBox();
            this.ButtonDeleteaRequestFromList = new System.Windows.Forms.Button();
            this.ButtonWithdrawAllRequests = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.ButtonAddaRequestToList = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.ButtonWithdrawRequest = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.GroupBox();
            this.labelApplicationNumber = new System.Windows.Forms.Label();
            this.textDepartureDate = new System.Windows.Forms.TextBox();
            this.textFIO = new System.Windows.Forms.TextBox();
            this.textFlightNumber = new System.Windows.Forms.TextBox();
            this.textDestination = new System.Windows.Forms.TextBox();
            this.labelDepartureDate = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelFlightNumber = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.ApplicationDeleteApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplicationWithdrawApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplicationWithdrawAllApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplicationDisplaysaList = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxNaumber = new System.Windows.Forms.ComboBox();
            this.Task.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Menu.SuspendLayout();
            this.Actions.SuspendLayout();
            this.List.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Task
            // 
            this.Task.Controls.Add(this.pictureBox1);
            this.Task.Location = new System.Drawing.Point(12, 27);
            this.Task.Name = "Task";
            this.Task.Size = new System.Drawing.Size(648, 140);
            this.Task.TabIndex = 2;
            this.Task.TabStop = false;
            this.Task.Text = "Задание";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PR4.Properties.Resources._24798217457;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(634, 114);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.Reference});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(670, 24);
            this.Menu.TabIndex = 3;
            this.Menu.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Applications,
            this.ClearMenu,
            this.ExitMenu});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(48, 20);
            this.FileMenu.Text = "файл";
            // 
            // Applications
            // 
            this.Applications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ApplicationAddRequest,
            this.ApplicationDeleteApplication,
            this.ApplicationWithdrawApplication,
            this.ApplicationWithdrawAllApplication,
            this.ApplicationDisplaysaList});
            this.Applications.Name = "Applications";
            this.Applications.Size = new System.Drawing.Size(180, 22);
            this.Applications.Text = "Приложения";
            // 
            // ApplicationAddRequest
            // 
            this.ApplicationAddRequest.Name = "ApplicationAddRequest";
            this.ApplicationAddRequest.Size = new System.Drawing.Size(265, 22);
            this.ApplicationAddRequest.Text = "Приложение \"Добавить заявку\"";
            // 
            // ClearMenu
            // 
            this.ClearMenu.Name = "ClearMenu";
            this.ClearMenu.Size = new System.Drawing.Size(180, 22);
            this.ClearMenu.Text = "Очистить";
            this.ClearMenu.Click += new System.EventHandler(this.ClearMenu_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(180, 22);
            this.ExitMenu.Text = "Выход";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // Reference
            // 
            this.Reference.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgram});
            this.Reference.Name = "Reference";
            this.Reference.Size = new System.Drawing.Size(63, 20);
            this.Reference.Text = "справка";
            // 
            // AboutProgram
            // 
            this.AboutProgram.Name = "AboutProgram";
            this.AboutProgram.Size = new System.Drawing.Size(180, 22);
            this.AboutProgram.Text = "О программе";
            // 
            // ButtonWithdrawList
            // 
            this.ButtonWithdrawList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ButtonWithdrawList.Location = new System.Drawing.Point(6, 105);
            this.ButtonWithdrawList.Name = "ButtonWithdrawList";
            this.ButtonWithdrawList.Size = new System.Drawing.Size(140, 41);
            this.ButtonWithdrawList.TabIndex = 4;
            this.ButtonWithdrawList.Text = "вывести список";
            this.ButtonWithdrawList.UseVisualStyleBackColor = true;
            this.ButtonWithdrawList.Click += new System.EventHandler(this.ButtonWithdrawList_Click);
            // 
            // Actions
            // 
            this.Actions.Controls.Add(this.ButtonWithdrawList);
            this.Actions.Controls.Add(this.ButtonDeleteaRequestFromList);
            this.Actions.Controls.Add(this.ButtonWithdrawAllRequests);
            this.Actions.Controls.Add(this.Clear);
            this.Actions.Controls.Add(this.ButtonAddaRequestToList);
            this.Actions.Controls.Add(this.Exit);
            this.Actions.Controls.Add(this.ButtonWithdrawRequest);
            this.Actions.Location = new System.Drawing.Point(146, 407);
            this.Actions.Name = "Actions";
            this.Actions.Size = new System.Drawing.Size(381, 152);
            this.Actions.TabIndex = 3;
            this.Actions.TabStop = false;
            this.Actions.Text = "Действия";
            // 
            // ButtonDeleteaRequestFromList
            // 
            this.ButtonDeleteaRequestFromList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ButtonDeleteaRequestFromList.Location = new System.Drawing.Point(181, 22);
            this.ButtonDeleteaRequestFromList.Name = "ButtonDeleteaRequestFromList";
            this.ButtonDeleteaRequestFromList.Size = new System.Drawing.Size(192, 36);
            this.ButtonDeleteaRequestFromList.TabIndex = 7;
            this.ButtonDeleteaRequestFromList.Text = "удалить заявку 🗑️";
            this.ButtonDeleteaRequestFromList.UseVisualStyleBackColor = true;
            this.ButtonDeleteaRequestFromList.Click += new System.EventHandler(this.ButtonDeleteaRequestFromList_Click);
            // 
            // ButtonWithdrawAllRequests
            // 
            this.ButtonWithdrawAllRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ButtonWithdrawAllRequests.Location = new System.Drawing.Point(183, 64);
            this.ButtonWithdrawAllRequests.Name = "ButtonWithdrawAllRequests";
            this.ButtonWithdrawAllRequests.Size = new System.Drawing.Size(192, 35);
            this.ButtonWithdrawAllRequests.TabIndex = 8;
            this.ButtonWithdrawAllRequests.Text = "вывести все заявки";
            this.ButtonWithdrawAllRequests.UseVisualStyleBackColor = true;
            this.ButtonWithdrawAllRequests.Click += new System.EventHandler(this.ButtonWithdrawAllRequests_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Clear.Location = new System.Drawing.Point(149, 109);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(124, 33);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "Очистить 🗑️";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ButtonAddaRequestToList
            // 
            this.ButtonAddaRequestToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ButtonAddaRequestToList.Location = new System.Drawing.Point(6, 23);
            this.ButtonAddaRequestToList.Name = "ButtonAddaRequestToList";
            this.ButtonAddaRequestToList.Size = new System.Drawing.Size(166, 35);
            this.ButtonAddaRequestToList.TabIndex = 6;
            this.ButtonAddaRequestToList.Text = "добавить заявку ᵕ̈";
            this.ButtonAddaRequestToList.UseVisualStyleBackColor = true;
            this.ButtonAddaRequestToList.Click += new System.EventHandler(this.ButtonAddaRequestToList_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Exit.Location = new System.Drawing.Point(274, 109);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(99, 33);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "Выход ✘";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ButtonWithdrawRequest
            // 
            this.ButtonWithdrawRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ButtonWithdrawRequest.Location = new System.Drawing.Point(6, 64);
            this.ButtonWithdrawRequest.Name = "ButtonWithdrawRequest";
            this.ButtonWithdrawRequest.Size = new System.Drawing.Size(166, 35);
            this.ButtonWithdrawRequest.TabIndex = 9;
            this.ButtonWithdrawRequest.Text = "вывести заявку";
            this.ButtonWithdrawRequest.UseVisualStyleBackColor = true;
            this.ButtonWithdrawRequest.Click += new System.EventHandler(this.ButtonWithdrawRequest_Click);
            // 
            // List
            // 
            this.List.Controls.Add(this.comboBoxNaumber);
            this.List.Controls.Add(this.labelApplicationNumber);
            this.List.Controls.Add(this.textDepartureDate);
            this.List.Controls.Add(this.textFIO);
            this.List.Controls.Add(this.textFlightNumber);
            this.List.Controls.Add(this.textDestination);
            this.List.Controls.Add(this.labelDepartureDate);
            this.List.Controls.Add(this.labelFIO);
            this.List.Controls.Add(this.labelFlightNumber);
            this.List.Controls.Add(this.labelDestination);
            this.List.Location = new System.Drawing.Point(146, 173);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(381, 228);
            this.List.TabIndex = 11;
            this.List.TabStop = false;
            this.List.Text = "Заявка на бронирование авиабилета ✎";
            // 
            // labelApplicationNumber
            // 
            this.labelApplicationNumber.AutoSize = true;
            this.labelApplicationNumber.Location = new System.Drawing.Point(6, 30);
            this.labelApplicationNumber.Name = "labelApplicationNumber";
            this.labelApplicationNumber.Size = new System.Drawing.Size(110, 13);
            this.labelApplicationNumber.TabIndex = 8;
            this.labelApplicationNumber.Text = "№ заявки на выбор:";
            // 
            // textDepartureDate
            // 
            this.textDepartureDate.Location = new System.Drawing.Point(88, 187);
            this.textDepartureDate.Name = "textDepartureDate";
            this.textDepartureDate.Size = new System.Drawing.Size(113, 20);
            this.textDepartureDate.TabIndex = 7;
            // 
            // textFIO
            // 
            this.textFIO.Location = new System.Drawing.Point(152, 145);
            this.textFIO.Name = "textFIO";
            this.textFIO.Size = new System.Drawing.Size(177, 20);
            this.textFIO.TabIndex = 6;
            // 
            // textFlightNumber
            // 
            this.textFlightNumber.Location = new System.Drawing.Point(89, 105);
            this.textFlightNumber.Name = "textFlightNumber";
            this.textFlightNumber.Size = new System.Drawing.Size(113, 20);
            this.textFlightNumber.TabIndex = 5;
            // 
            // textDestination
            // 
            this.textDestination.Location = new System.Drawing.Point(114, 66);
            this.textDestination.Name = "textDestination";
            this.textDestination.Size = new System.Drawing.Size(259, 20);
            this.textDestination.TabIndex = 4;
            // 
            // labelDepartureDate
            // 
            this.labelDepartureDate.AutoSize = true;
            this.labelDepartureDate.Location = new System.Drawing.Point(6, 190);
            this.labelDepartureDate.Name = "labelDepartureDate";
            this.labelDepartureDate.Size = new System.Drawing.Size(76, 13);
            this.labelDepartureDate.TabIndex = 3;
            this.labelDepartureDate.Text = "Дата вылета:";
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(6, 148);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(143, 13);
            this.labelFIO.TabIndex = 2;
            this.labelFIO.Text = "Фамилия И.О. пассажира:";
            // 
            // labelFlightNumber
            // 
            this.labelFlightNumber.AutoSize = true;
            this.labelFlightNumber.Location = new System.Drawing.Point(6, 108);
            this.labelFlightNumber.Name = "labelFlightNumber";
            this.labelFlightNumber.Size = new System.Drawing.Size(77, 13);
            this.labelFlightNumber.TabIndex = 1;
            this.labelFlightNumber.Text = "Номер рейса:";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(6, 69);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(102, 13);
            this.labelDestination.TabIndex = 0;
            this.labelDestination.Text = "Пункт назначения:";
            // 
            // ApplicationDeleteApplication
            // 
            this.ApplicationDeleteApplication.Name = "ApplicationDeleteApplication";
            this.ApplicationDeleteApplication.Size = new System.Drawing.Size(265, 22);
            this.ApplicationDeleteApplication.Text = "Приложение \"Удалить заявку\"";
            // 
            // ApplicationWithdrawApplication
            // 
            this.ApplicationWithdrawApplication.Name = "ApplicationWithdrawApplication";
            this.ApplicationWithdrawApplication.Size = new System.Drawing.Size(265, 22);
            this.ApplicationWithdrawApplication.Text = "Приложение \"Вывести заявку\"";
            // 
            // ApplicationWithdrawAllApplication
            // 
            this.ApplicationWithdrawAllApplication.Name = "ApplicationWithdrawAllApplication";
            this.ApplicationWithdrawAllApplication.Size = new System.Drawing.Size(265, 22);
            this.ApplicationWithdrawAllApplication.Text = "Приложение \"Вывести все заявки\"";
            // 
            // ApplicationDisplaysaList
            // 
            this.ApplicationDisplaysaList.Name = "ApplicationDisplaysaList";
            this.ApplicationDisplaysaList.Size = new System.Drawing.Size(265, 22);
            this.ApplicationDisplaysaList.Text = "Приложение \"Вывести список\"";
            // 
            // comboBoxNaumber
            // 
            this.comboBoxNaumber.FormattingEnabled = true;
            this.comboBoxNaumber.Location = new System.Drawing.Point(122, 27);
            this.comboBoxNaumber.Name = "comboBoxNaumber";
            this.comboBoxNaumber.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNaumber.TabIndex = 12;
            this.comboBoxNaumber.SelectedIndexChanged += new System.EventHandler(this.comboBoxNumber_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 571);
            this.Controls.Add(this.List);
            this.Controls.Add(this.Actions);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Task);
            this.Name = "Form1";
            this.Text = "Практическая работа №4";
            this.Task.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.Actions.ResumeLayout(false);
            this.List.ResumeLayout(false);
            this.List.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox Task;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem Applications;
        private System.Windows.Forms.ToolStripMenuItem ApplicationAddRequest;
        private System.Windows.Forms.ToolStripMenuItem ClearMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem Reference;
        private System.Windows.Forms.ToolStripMenuItem AboutProgram;
        private System.Windows.Forms.Button ButtonWithdrawList;
        private System.Windows.Forms.GroupBox Actions;
        private System.Windows.Forms.Button ButtonAddaRequestToList;
        private System.Windows.Forms.Button ButtonDeleteaRequestFromList;
        private System.Windows.Forms.Button ButtonWithdrawRequest;
        private System.Windows.Forms.Button ButtonWithdrawAllRequests;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.GroupBox List;
        private System.Windows.Forms.Label labelApplicationNumber;
        private System.Windows.Forms.TextBox textDepartureDate;
        private System.Windows.Forms.TextBox textFIO;
        private System.Windows.Forms.TextBox textFlightNumber;
        private System.Windows.Forms.TextBox textDestination;
        private System.Windows.Forms.Label labelDepartureDate;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelFlightNumber;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.ToolStripMenuItem ApplicationDeleteApplication;
        private System.Windows.Forms.ToolStripMenuItem ApplicationWithdrawApplication;
        private System.Windows.Forms.ToolStripMenuItem ApplicationWithdrawAllApplication;
        private System.Windows.Forms.ToolStripMenuItem ApplicationDisplaysaList;
        private System.Windows.Forms.ComboBox comboBoxNaumber;
    }
}

