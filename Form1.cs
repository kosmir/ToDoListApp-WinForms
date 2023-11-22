

namespace ToDoListWinFroms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ActionWithTask_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            if (e.ClickedItem == addTaskToolStripMenuItem)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Enter a new task below", "New Task", null);
                ListForToday.Items.Add(input);
            }
            else if (e.ClickedItem == removeTaskToolStripMenuItem)
            {
                int selectedIndex = ListForToday.SelectedIndex;
                ListForToday.Items.RemoveAt(selectedIndex);
            }
            else if (e.ClickedItem == editTaskToolStripMenuItem)
            {
                int selectedIndex = ListForToday.SelectedIndex;
                string input = Microsoft.VisualBasic.Interaction.InputBox("Enter editted task below", "Edit task", null);
                ListForToday.Items[selectedIndex] = input;
            }

        }
        private void SaveList_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                File.WriteAllLines(path, ListForToday.Items.Cast<string>());
            }
        }

        private void Form1_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show("Just right click on the area above 'Save the list' button and you will see available actions: add task, edit task and remove task", "How to use this app?");
        }
    }
}

