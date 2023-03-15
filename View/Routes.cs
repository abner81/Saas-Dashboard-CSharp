namespace Dashboard_Study.View
{
    public class Routes
    {
        private Panel _contentPlace { get; set; }

        public Routes(Panel contentPlace)
        {
            _contentPlace = contentPlace;
        }

        public void GoTo(UserControl destination)
        {
            
            _contentPlace.Controls.Clear();
            destination.Dock = DockStyle.Fill;
            _contentPlace.Controls.Add(destination);
            destination.Show();
        }
    }
}
