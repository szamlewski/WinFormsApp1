namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CenterButton_Click(object sender, EventArgs e)
        {
            //Application.Exit();

            //szerokosc okna aplikacji
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
            CenterButton.Location = topLeftCorner;
        }
    }
}