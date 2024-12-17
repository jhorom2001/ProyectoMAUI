namespace ProyectoMAUI
{
    public partial class MainPage : ContentPage
    {
        String nameFile= Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
        public MainPage()
        {
            InitializeComponent();
            if (File.Exists(nameFile))
            {
                editor.Text = File.ReadAllText(nameFile);
            }
        }

        private void clicarAnnadir(object sender, EventArgs e)
        {
            
        }

        private void clicarBorrar(object sender, EventArgs e)
        {

        }
    }

}
