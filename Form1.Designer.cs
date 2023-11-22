using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ToDoListWinFroms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ListForToday = new ListBox();
            ActionWithTask = new ContextMenuStrip(components);
            addTaskToolStripMenuItem = new ToolStripMenuItem();
            editTaskToolStripMenuItem = new ToolStripMenuItem();
            removeTaskToolStripMenuItem = new ToolStripMenuItem();
            SaveList = new Button();
            saveFileDialog1 = new SaveFileDialog();
            tableLayoutPanel1 = new TableLayoutPanel();
            ActionWithTask.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ListForToday
            // 
            ListForToday.BackColor = Color.Cornsilk;
            ListForToday.ContextMenuStrip = ActionWithTask;
            ListForToday.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ListForToday.FormattingEnabled = true;
            ListForToday.ItemHeight = 25;
            ListForToday.Location = new Point(3, 3);
            ListForToday.Name = "ListForToday";
            ListForToday.ScrollAlwaysVisible = true;
            ListForToday.Size = new Size(509, 379);
            ListForToday.TabIndex = 2;
            // 
            // ActionWithTask
            // 
            ActionWithTask.Items.AddRange(new ToolStripItem[] { addTaskToolStripMenuItem, editTaskToolStripMenuItem, removeTaskToolStripMenuItem });
            ActionWithTask.Name = "ActionWithTask";
            ActionWithTask.Size = new Size(143, 70);
            ActionWithTask.ItemClicked += ActionWithTask_ItemClicked;
            // 
            // addTaskToolStripMenuItem
            // 
            addTaskToolStripMenuItem.Name = "addTaskToolStripMenuItem";
            addTaskToolStripMenuItem.Size = new Size(142, 22);
            addTaskToolStripMenuItem.Text = "Add Task";
            // 
            // editTaskToolStripMenuItem
            // 
            editTaskToolStripMenuItem.Name = "editTaskToolStripMenuItem";
            editTaskToolStripMenuItem.Size = new Size(142, 22);
            editTaskToolStripMenuItem.Text = "Edit Task";
            // 
            // removeTaskToolStripMenuItem
            // 
            removeTaskToolStripMenuItem.Name = "removeTaskToolStripMenuItem";
            removeTaskToolStripMenuItem.Size = new Size(142, 22);
            removeTaskToolStripMenuItem.Text = "Remove Task";
            // 
            // SaveList
            // 
            SaveList.BackColor = Color.Khaki;
            SaveList.ForeColor = SystemColors.WindowText;
            SaveList.Location = new Point(3, 385);
            SaveList.Margin = new Padding(3, 0, 3, 3);
            SaveList.Name = "SaveList";
            SaveList.Size = new Size(509, 40);
            SaveList.TabIndex = 1;
            SaveList.Text = "Save the list";
            SaveList.UseVisualStyleBackColor = false;
            SaveList.Click += SaveList_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.FileName = "22112023";
            saveFileDialog1.Title = "Save File";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(ListForToday, 0, 0);
            tableLayoutPanel1.Controls.Add(SaveList, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(524, 437);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(524, 437);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(540, 476);
            MinimizeBox = false;
            MinimumSize = new Size(540, 476);
            Name = "Form1";
            Text = "To Do List App";
            HelpButtonClicked += Form1_HelpButtonClicked;
            ActionWithTask.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox ListForToday;
        private ContextMenuStrip ActionWithTask;
        private ToolStripMenuItem addTaskToolStripMenuItem;
        private ToolStripMenuItem editTaskToolStripMenuItem;
        private ToolStripMenuItem removeTaskToolStripMenuItem;
        private Button SaveList;
        private SaveFileDialog saveFileDialog1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
