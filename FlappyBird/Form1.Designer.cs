
namespace FlappyBird;

partial class Form1
{
    private System.Windows.Forms.PictureBox flappyBird;
    private System.Windows.Forms.PictureBox pipeTop;
    private System.Windows.Forms.PictureBox pipeBottom;
    private System.Windows.Forms.PictureBox ground;
    private System.Windows.Forms.Timer gameTimer;


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
        // Define FlappyBird
        // TODO: add a picture
        this.flappyBird = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
        this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.flappyBird.BackColor = System.Drawing.Color.Yellow;
        this.flappyBird.Location = new System.Drawing.Point(69, 228);
        this.flappyBird.Name = "flappyBird";
        this.flappyBird.Size = new System.Drawing.Size(82, 69);
        this.flappyBird.TabIndex = 2;
        this.flappyBird.TabStop = false;


        // Define Top Pipes
        // TODO: add a picture
        this.pipeTop = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
        this.pipeTop.BackColor = System.Drawing.Color.Green;
        this.pipeTop.Location = new System.Drawing.Point(495, -59);
        this.pipeTop.Name = "pipeTop";
        this.pipeTop.Size = new System.Drawing.Size(100, 266);
        this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.pipeTop.TabIndex = 0;
        this.pipeTop.TabStop = false;
        

        // Define Bottom Pipes
        // TODO: add a picture
        this.pipeBottom = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
        this.pipeBottom.BackColor = System.Drawing.Color.Green;
        this.pipeBottom.Location = new System.Drawing.Point(362, 418);
        this.pipeBottom.Name = "pipeBottom";
        this.pipeBottom.Size = new System.Drawing.Size(109, 286);
        this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.pipeBottom.TabIndex = 1;
        this.pipeBottom.TabStop = false;

        // ground
        // TODO: add a picture
        this.ground = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
        this.ground.BackColor = System.Drawing.Color.Green;
        this.ground.Location = new System.Drawing.Point(-16, 633);
        this.ground.Name = "ground";
        this.ground.Size = new System.Drawing.Size(816, 120);
        this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.ground.TabIndex = 3;
        this.ground.TabStop = false;

        // Define Background
        // TODO: add a picture, could use some clouds idk
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 800);
        this.BackColor = System.Drawing.Color.SkyBlue;
        this.Text = "Form1";

        // Define Game Timer
        this.gameTimer = new System.Windows.Forms.Timer(this.components);
        this.gameTimer.Enabled = true;
        this.gameTimer.Interval = 20;
        this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);

        this.SuspendLayout();

        // Add Controls
        this.Controls.Add(this.flappyBird);
        this.Controls.Add(this.pipeTop);
        this.Controls.Add(this.pipeBottom);
        this.Controls.Add(this.ground);

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
