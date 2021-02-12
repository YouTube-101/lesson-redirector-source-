using System.Threading.Tasks;
using System.Windows;

namespace LessonRedirector
{
    public partial class MoreClassesWindow : Window
    {
        string SubjectCode;
        public MoreClassesWindow()
        {
            InitializeComponent();
        }
        private async void OnLoaded(object s, RoutedEventArgs e)
        {
            await Task.Delay(120000);
            MessageBox.Show("Program Zaman Aşımına Uğradı","Program Kapatılıyor",MessageBoxButton.OK,MessageBoxImage.Warning);
            Application.Current.Shutdown();
        }
        private void Shutdown(object s, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Literature(object s, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
            Application.Current.Shutdown();
        }
        private void Maths(object s, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
            Application.Current.Shutdown();
        }
        private void Geometry(object s, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
            Application.Current.Shutdown();
        }
        private void Physics(object s, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
            Application.Current.Shutdown();
        }
        private void Chemistry(object s, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
            Application.Current.Shutdown();
        }
        private void Biology(object s, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
            Application.Current.Shutdown();
        }
        private void History(object s, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
            Application.Current.Shutdown();
        }
        private void Geography(object s, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
            Application.Current.Shutdown();
        }
        private void Religion(object s, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
            Application.Current.Shutdown();
        }
        private void Philosophy(object s, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
            Application.Current.Shutdown();
        }
        private void English(object s, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
            Application.Current.Shutdown();
        }
        private void EnglishPN(object s, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
            Application.Current.Shutdown();
        }
        private void German(object s, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
            Application.Current.Shutdown();
        }
        private void Arts(object s, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
            Application.Current.Shutdown();
        }
        private void PE(object s, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
            Application.Current.Shutdown();
        }
        private void Exam(object s, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
            Application.Current.Shutdown();
        }
        private void ComputerScience(object s, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
            Application.Current.Shutdown();
        }
        private void Other(object s, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
            Application.Current.Shutdown();
        }
    }
}