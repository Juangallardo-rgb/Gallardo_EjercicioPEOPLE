namespace JGPeople
{
    public partial class App : Application
    {
        public static JGPersonRepository PersonRepo { get; private set; }

        public App(JGPersonRepository repo)
        {
            InitializeComponent();
            PersonRepo = repo;
        }
    }
}
