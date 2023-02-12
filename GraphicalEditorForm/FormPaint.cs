namespace GraphicalEditorForm
{
    public partial class FormPaint : Form
    {
        private bool isLeftMouseKeyPressed;
        private Graphics graph;
        public FormPaint()
        {
            InitializeComponent();
        }

        private void pictureBoxPaint_MouseMove(object sender, MouseEventArgs e)
        {
            //g.dr
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

        private void btnColor_Click(object sender, EventArgs e)
        {

        }

        private void btnFill_Click(object sender, EventArgs e)
        {

        }

        private void btnPencil_Click(object sender, EventArgs e)
        {

        }

        private void btnEraser_Click(object sender, EventArgs e)
        {

        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {

        }

        private void btn_rect_Click(object sender, EventArgs e)
        {

        }

        private void btnLine_Click(object sender, EventArgs e)
        {

        }
    }
}