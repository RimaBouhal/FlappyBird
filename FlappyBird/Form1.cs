namespace FlappyBird;

public partial class FlappyBird : Form
{
    int pipeSpeed = 8;
    int gravity = 20;
    int score = 0;
    private bool flying = false;
    private bool dead = false;
    private bool gameStarted = false;
    private Image originalBirdImage;

    public FlappyBird() {
        InitializeComponent();
        originalBirdImage = System.Drawing.Image.FromFile("Resources/FlappyBird.png");
    }

    public void FlapWings(object sender, KeyEventArgs e) {
        if (dead) return;

        if (e.KeyCode == Keys.Space) {
            gravity = -15;

            if(!flying) {
                UpdateBirdFlying();
            }

            flying = true;
        }
    }

    public void Fall(object sender, KeyEventArgs e) {
        if (dead) return;

        if (e.KeyCode == Keys.Space) {
            gravity = 15;
            
            if(flying) {
                UpdateBirdFalling();
            }

            flying = false;
        }
    }

    private void GameOver() {
        dead = true;
        gameTimer.Stop();
        GameOverTimer.Start();
    }

    private void MovePipes() {
        var rand = new Random();

        if(pipeBottom.Left < -150)
        {
            pipeBottom.Top = rand.Next(Math.Min(pipeTop.Bottom+200, 400), 400);
            pipeBottom.Left = 800;
            score++;
        }
        
        if(pipeTop.Left < -180)
        {
            pipeTop.Top = rand.Next(200, Math.Min(pipeBottom.Top+200, 400)) - 400;
            pipeTop.Left = 950;
            score++;
        }
    }

    private Image RotateImage(Image image, float angle) {
    Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
    rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

    using (Graphics g = Graphics.FromImage(rotatedBmp))
        {
            g.TranslateTransform(image.Width / 2, image.Height / 2);
            g.RotateTransform(angle);
            g.TranslateTransform(-image.Width / 2, -image.Height / 2);
            g.DrawImage(image, new Point(0, 0));
        }

        return rotatedBmp;
    }

    private void UpdateBirdFalling() {
        float angleDown = 30f;
        this.flappyBird.Image = RotateImage(originalBirdImage, angleDown);
    }


    private void UpdateBirdDead() {
        float angleDead = 90f;
        this.flappyBird.Image = RotateImage(originalBirdImage, angleDead);
    }

    private void UpdateBirdFlying() {
        float angleUp = -30f;
        this.flappyBird.Image = RotateImage(originalBirdImage, angleUp);
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e) {
        if (!gameStarted && e.KeyCode == Keys.Space) {
            gameStarted = true;
            
            this.gameTimer.Start();

            if (startLabel != null) {
                startLabel.Visible = false;
            }
        }
    }

    private void gameTimerEvent(object sender, EventArgs e) {
        flappyBird.Top += gravity;
        pipeBottom.Left -= pipeSpeed;
        pipeTop.Left -= pipeSpeed;
        scoreText.Text = "Score: " + score;

        // End the game if bird hits the ground or pipes
        if (
            flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
            flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) || 
            flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds)
            )
        {
            GameOver();
        } 

        MovePipes();
    }

    private void gameOverEvent(object sender, EventArgs e) {
        UpdateBirdDead();
        gravity = 30;
        flappyBird.Top += gravity;

        if (flappyBird.Bounds.IntersectsWith(ground.Bounds))
        {
            GameOverTimer.Stop();
        }
    }
}
