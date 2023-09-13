namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Random r;
        int punkty;
        public Form1()
        {

            InitializeComponent();
            r = new Random();
            punkty = 0;
            timer1.Start();
        }


        private void CenterButton_Click(object sender, EventArgs e)
        {
            MoveButton();
            punkty++;
            toolStripStatusLabel1.Text = "Punkty: " + punkty.ToString();
            timer1.Stop();
            timer1.Start();
           

            //Application.Exit();
            
            /* //szerokosc okna aplikacji
             int windowWidth = Size.Width;
             //wysokosc okna aplikacji
             int windowHeight = Size.Height;

             //zeby uniknac sytuacji, kiedy guzik wyladuje poza oknem aplikacji, odejmujemy jego szerokosc i wysokosc odpowiednio
             windowWidth -= CenterButton.Width;
             windowHeight -= CenterButton.Height;

             //inicjalizacja generatora losowych liczb
             Random rnd = new Random();

             //losowa odleglosc od lewej
             int randomLeft = rnd.Next(windowWidth);

             //analogicznie z odlegloscia od gory
             int randomTop = rnd.Next(windowHeight);

             //przesuwamy guzik
             //location musi byc przekazany jako punkt na ekranie
             Point topLeftCorner = new Point(randomLeft, randomTop);
             //CenterButton no nazwa (atrybut Name) mojego guzika
             CenterButton.Location = topLeftCorner; */
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            MoveButton();
            punkty = 0;
            toolStripStatusLabel1.Text = "Punkty: " + punkty.ToString();
        }

        private void MoveButton()
        {
            int maxX = this.Size.Width - CenterButton.Size.Width - 50;
            int maxY = this.Size.Height - CenterButton.Size.Height - 50;
            Point p = new Point();
            p.X = r.Next(12, maxX);
            p.Y = r.Next(12, maxY);
            CenterButton.Location = p;
        }
    }
}