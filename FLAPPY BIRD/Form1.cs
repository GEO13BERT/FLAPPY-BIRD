namespace FLAPPY_BIRD
{
    public partial class Form1 : Form
    {
        int gravity = 5;
        int pipe = 8;
        int score = 0;
        Random rnd = new Random();
        int highscore = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
            label5.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bird.Top = bird.Top + gravity;
            top.Left -= pipe;
            bottom.Left -= pipe;

            if (bottom.Left < -100)
            {
                bottom.Left = 800;
                top.Left = 800;
                bottom.Top = rnd.Next(200, 400);
                top.Top = bottom.Top - 150 - top.Height;
                score++;
                label1.Text = $"Σκορ: {score}";
                if (score % 5 == 0)
                {
                    pipe += 2;
                }
            }
            if (bird.Bounds.IntersectsWith(top.Bounds) || bird.Bounds.IntersectsWith(bottom.Bounds) || bird.Bounds.IntersectsWith(patwma.Bounds) || bird.Top < -25)
            {
                timer1.Stop();

                if (score > highscore)
                {
                    highscore = score;
                    label5.Text = $"HIGHSCORE: {highscore}";
                    label5.Show();
                }

                score = 0;
                label1.Text = $"Σκορ: {score}";
                bird.Top = 100;
                top.Left = 800;
                bottom.Left = 800;
                bottom.Top = rnd.Next(200, 400);
                top.Top = bottom.Top - 150 - top.Height;
                pipe = 8;
                label2.Show();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
                timer1.Start();
                label2.Hide();

            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

       
    }
}
