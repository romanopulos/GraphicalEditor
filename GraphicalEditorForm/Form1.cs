namespace GraphicalEditorForm
{
    public partial class Form1 : Form
    {
        private bool isLeftMouseKeyPressed;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxPaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isLeftMouseKeyPressed)
            {
                return;
            }
        }

        private void pictureBoxPaint_MouseUp(object sender, MouseEventArgs e)
        {
            isLeftMouseKeyPressed = false;
        }

        private void pictureBoxPaint_MouseDown(object sender, MouseEventArgs e)
        {
            isLeftMouseKeyPressed = true;
        }
    }
}