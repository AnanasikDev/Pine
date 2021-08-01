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
    public struct Vector2
    {
        public int x { get; set; }
        public int y { get; set; }
        public static Vector2 zero { get { return new Vector2(0, 0); } }

        public Vector2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static Vector2 operator + (Vector2 a, Vector2 b)
        {
            return new Vector2(a.x + b.x, a.y + b.y);
        }
    }
    public static class Extensions
    {
        public static Vector2 GetPosition (this Control element)
        {
            return new Vector2(element.Bounds.X + element.Width / 2, element.Bounds.Y - element.Height / 2);
        }
        public static void SetPosition(this Control element, Vector2 position)
        {
            Vector2 size = new Vector2(element.Width, element.Height);

            element.Bounds = 
                new System.Drawing.Rectangle(
                    position.x + size.x / 2, 
                    position.y - size.y / 2,

                    size.x,
                    size.y);
        }
    }
}
