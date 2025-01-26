
namespace FlappyBird;

partial class FlappyBird
{
    private System.Windows.Forms.PictureBox flappyBird;
    private System.Windows.Forms.PictureBox pipeTop;
    private System.Windows.Forms.PictureBox pipeBottom;
    private System.Windows.Forms.PictureBox ground;
    private System.Windows.Forms.Timer gameTimer;
    private System.Windows.Forms.Timer GameOverTimer;
    private System.Windows.Forms.Label scoreText;
    private Label startLabel;


    int pipeWidth = 125;
    int pipeHeight = 400;
    int padding = 200;
    int groundHeight = 200;


    ///  Required designer variable.
    private System.ComponentModel.IContainer components = null;

    ///  Clean up any resources being used.
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        // Define Flappy Bird
        this.flappyBird = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
        this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.flappyBird.Image = System.Drawing.Image.FromFile("Resources/FlappyBird.png");
        this.flappyBird.Location = new System.Drawing.Point(69, 228);
        this.flappyBird.Name = "flappyBird";
        this.flappyBird.Size = new System.Drawing.Size(82, 69);
        this.flappyBird.TabIndex = 2;
        this.flappyBird.TabStop = false;

        // Define Top Pipes
        this.pipeTop = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
        this.pipeTop.Name = "pipeTop";
        this.pipeTop.Image = System.Drawing.Image.FromFile("Resources/PipeTop.png");
        this.pipeTop.Location = new System.Drawing.Point(600, -padding);
        this.pipeTop.Size = new System.Drawing.Size(pipeWidth, pipeHeight);
        this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.pipeTop.TabIndex = 0;
        this.pipeTop.TabStop = false;
        
        // Define Bottom Pipes
        this.pipeBottom = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
        this.pipeBottom.Name = "pipeBottom";
        this.pipeBottom.Image = System.Drawing.Image.FromFile("Resources/PipeBottom.png");
        this.pipeBottom.Location = new System.Drawing.Point(400, 800 - pipeHeight);
        this.pipeBottom.Size = new System.Drawing.Size(pipeWidth, pipeHeight);
        this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.pipeBottom.TabIndex = 1;
        this.pipeBottom.TabStop = false;

        // ground
        this.ground = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
        this.ground.Name = "ground";
        this.ground.Image = System.Drawing.Image.FromFile("Resources/Ground.png");
        this.ground.Location = new System.Drawing.Point(-16, 616);
        this.ground.Size = new System.Drawing.Size(816, 200);
        this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.ground.TabIndex = 2;
        this.ground.TabStop = false;

        // Define Background
        // TODO: add a picture, could use some clouds idk
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 800);
        this.BackColor = System.Drawing.Color.SkyBlue;
        this.Text = "FlappyBird";

        // Define Score
        this.scoreText = new System.Windows.Forms.Label();
        this.scoreText.AutoSize = true;
        this.scoreText.BackColor = System.Drawing.Color.PaleGoldenrod;
        this.scoreText.Font = new System.Drawing.Font("Calibri", 20F);
        this.scoreText.Location = new System.Drawing.Point(622, 700);
        this.scoreText.Name = "scoreText";
        this.scoreText.Size = new System.Drawing.Size(122, 37);
        this.scoreText.TabIndex = 4;
        this.scoreText.Text = "Score: 0";

        // Define Start Label
        this.startLabel = new Label();
        this.startLabel.Text = "Press Space to Start";
        this.startLabel.Font = new Font("Calibri", 16, FontStyle.Bold);
        this.startLabel.ForeColor = Color.White;
        this.startLabel.BackColor = Color.Transparent;
        this.startLabel.AutoSize = true;
        this.startLabel.Location = new Point(this.ClientSize.Width / 2 - 100, this.ClientSize.Height / 2 - 50); // Center it
        this.Controls.Add(this.startLabel);

        // Define Game Timer
        this.gameTimer = new System.Windows.Forms.Timer(this.components);
        this.gameTimer.Enabled = false;
        this.gameTimer.Interval = 20;
        this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
        this.KeyDown += new KeyEventHandler(this.Form1_KeyDown);
        
        // Define GameOver Timer
        this.GameOverTimer = new System.Windows.Forms.Timer(this.components);
        this.GameOverTimer.Enabled = false;
        this.GameOverTimer.Interval = 20;
        this.GameOverTimer.Tick += new System.EventHandler(this.gameOverEvent);

        this.SuspendLayout();

        // Add Controls
        this.Controls.Add(this.scoreText);
        this.Controls.Add(this.flappyBird);
        this.Controls.Add(this.ground);
        this.Controls.Add(this.pipeTop);
        this.Controls.Add(this.pipeBottom);

        // Space Bar to Fly
        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FlapWings);
        this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Fall);

        ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
}
