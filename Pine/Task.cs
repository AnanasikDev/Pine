using System;
using System.Windows.Forms;
namespace Pine
{
    public struct Task
    {
        public string Title;
        public bool IsDone;

        public Vector2 Position;

        public Control[] FormsElements;

        public Task(string title, Vector2 position, bool isDone)
        {
            Title = title;
            Position = position;
            IsDone = isDone;

            CheckBox checkBox = new CheckBox();
            checkBox.SetPosition(position + Locations.CheckBoxPosition);
            
            checkBox.Checked = false;
            checkBox.Enabled = true;
            checkBox.Name = Title;
            checkBox.Text = Title;
            checkBox.AutoSize = true;

            FormsElements = new Control[1] { checkBox };
        }
    }
    public static class Locations
    {
        public static readonly Vector2 CheckBoxPosition = Vector2.zero;
        public static readonly Vector2 TitlePosition = new Vector2(100, 0);
    }
}
