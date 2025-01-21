namespace FlappyBird;

public partial class FlappyBird : Form
{
    int pipeSpeed = 8;
    int gravity = 10;
    int score = 0;

    public FlappyBird() {
        InitializeComponent();
    }

    public void FlapWings(object sender, KeyEventArgs e) {
        if (e.KeyCode == Keys.Space) {
            gravity = -10;
        }
    }

    public void Fall(object sender, KeyEventArgs e) {
        if (e.KeyCode == Keys.Space) {
            gravity = 10;
        }
    }

    private void EndGame() {
        gameTimer.Stop();
    }


    // TODO: Make these more variant
    private void MovePipes() {
        var rand = new Random();

        if(pipeBottom.Left < -150)
        {
            pipeBottom.Top = rand.Next(Math.Max(pipeTop.Height-200, 200), 600);
            pipeBottom.Left = 800;
            score++;
        }
        
        if(pipeTop.Left < -180)
        {
            pipeTop.Height = rand.Next(0, Math.Max(pipeBottom.Top-200, 0));
            pipeTop.Left = 950;
            score++;
        }
    }

    private void LevelUp() {
        pipeSpeed++;
    }

    private void gameTimerEvent(object sender, EventArgs e) {
        flappyBird.Top += gravity;
        pipeBottom.Left -= pipeSpeed;
        pipeTop.Left -= pipeSpeed;

        // End the game if bird hits the ground or pipes
        if (
            flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
            flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) || 
            flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds)
            )
        {
            EndGame();
        } 

        MovePipes();
    }
}
