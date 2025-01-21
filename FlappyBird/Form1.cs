namespace FlappyBird;

public partial class Form1 : Form
{

    int pipeSpeed = 8;
    int gravity = 10;
    int score = 0;

    public Form1() {
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

    private void EndGame() {}

    private void gameTimerEvent(object sender, EventArgs e) {
        flappyBird.Top += gravity;
        Console.WriteLine(gravity);
    }
}
