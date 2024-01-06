using System;
using Aplicatie.Data;
using System.IO;
namespace Aplicatie
{
    public partial class App : Application
    {
        static ParinteDatabase? parinteDatabase;
        static ElevDatabase? elevDatabase;

        public static ParinteDatabase ParinteDatabase
        {
            get
            {
                if (parinteDatabase == null)
                {
                    parinteDatabase = new ParinteDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ParinteDatabase.db3"));
                }
                return parinteDatabase;
            }
        }

        public static ElevDatabase ElevDatabase
        {
            get
            {
                if (elevDatabase == null)
                {
                    elevDatabase = new ElevDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ElevDatabase.db3"));
                }
                return elevDatabase;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
        protected override void OnStart()
        {
            // Tratează evenimentul de începere a aplicației
        }

        protected override void OnSleep()
        {
            // Tratează evenimentul de adormire a aplicației
        }

        protected override void OnResume()
        {
            // Tratează evenimentul de reluare a aplicației
        }
    }
}