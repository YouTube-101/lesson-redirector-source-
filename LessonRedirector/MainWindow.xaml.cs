using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media.Imaging;
using static LessonRedirector.System32;

namespace LessonRedirector
{
    public partial class MainWindow : Window
    {
        internal MoreClassesWindow HelpMe = new MoreClassesWindow();
        string SubjectCode;
        int Day;
        int Hour;
        int HourToMinute;
        int Minute;
        int Time;
        bool Helped = false;
        public MainWindow()
        {
            InitializeComponent();
        }
        private async void OnLoaded(object s, RoutedEventArgs e)
        {
            var hwnd = new WindowInteropHelper(this).Handle;
            SetWindowLong(hwnd, GWL_STYLE, GetWindowLong(hwnd, GWL_STYLE) & ~WS_SYSMENU);

            Timer.Content = "Hoş Geldin " + Environment.UserName;
            Day = Convert.ToInt32(DateTime.Now.DayOfWeek);
            Hour = Convert.ToInt32(DateTime.Now.Hour);
            Minute = Convert.ToInt32(DateTime.Now.Minute);
            HourToMinute = Hour * 60;
            Time = HourToMinute + Minute;
            CloseText.Visibility = Visibility.Visible;
            BarIncrease(s, e);

            if (Day == 1)
            {
                if ((Time >= 530) && (Time <= 1065))
                {
                    if ((Time >= 530) && (Time <= 910))
                    {
                        if ((Time >= 540) && (Time <= 910))
                        {
                            if ((Time >= 540) && (Time <= 569))
                            {
                                Subject.Content = "Geometri";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Şimdi Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Geometry";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780776703567724555/geometry.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                RedirectTimer(s, e);
                            }
                            else if ((Time >= 570) && (Time <= 579))
                            {
                                Subject.Content = "Teneffüstesiniz";
                                MinutesLeft.Visibility = Visibility.Visible;
                                MinutesLeft.Content = "Edebiyatın Başlamasına " + (580 - Time) + " Dakika Kaldı";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Erken Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Literature";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                Shutdown(s, e);
                            }
                            else if ((Time >= 580) && (Time <= 609))
                            {
                                Subject.Content = "Türk Dili ve Edebiyatı";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Şimdi Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Literature";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780780014576336916/literature.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                RedirectTimer(s, e);
                            }
                            else if ((Time >= 610) && (Time <= 619))
                            {
                                Subject.Content = "Teneffüstesiniz";
                                MinutesLeft.Visibility = Visibility.Visible;
                                MinutesLeft.Content = "Almancanın Başlamasına " + (620 - Time) + " Dakika Kaldı";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Erken Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "German";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                Shutdown(s, e);
                            }
                            else if ((Time >= 620) && (Time <= 649))
                            {
                                Subject.Content = "Almanca";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Şimdi Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "German";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780780403827933204/german.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                RedirectTimer(s, e);
                            }
                            else if ((Time >= 650) && (Time <= 659))
                            {
                                Subject.Content = "Teneffüstesiniz";
                                MinutesLeft.Visibility = Visibility.Visible;
                                MinutesLeft.Content = "Sınavın Başlamasına " + (660 - Time) + " Dakika Kaldı";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Erken Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Exam";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                Shutdown(s, e);
                            }
                            else if ((Time >= 660) && (Time <= 689))
                            {
                                Subject.Content = "Sınav";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Şimdi Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Exam";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780781288151842856/exam.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                RedirectTimer(s, e);
                            }
                            else if ((Time >= 690) && (Time <= 699))
                            {
                                Subject.Content = "Teneffüstesiniz";
                                MinutesLeft.Visibility = Visibility.Visible;
                                MinutesLeft.Content = "Matematiğin Başlamasına " + (700 - Time) + " Dakika Kaldı";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Erken Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Maths";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                Shutdown(s, e);
                            }
                            else if ((Time >= 700) && (Time <= 729))
                            {
                                Subject.Content = "Matematik";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Şimdi Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Maths";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780782512280305734/maths.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                RedirectTimer(s, e);
                            }
                            else if ((Time >= 730) && (Time <= 759))
                            {
                                Subject.Content = "Öğle Teneffüsündesiniz";
                                MinutesLeft.Visibility = Visibility.Visible;
                                MinutesLeft.Content = "İngilizcenin Başlamasına " + (760 - Time) + " Dakika Kaldı";
                                CloseButton.Visibility = Visibility.Hidden;
                                Option1Button.Content = "Rasim İşbilen";
                                Option2Button.Content = "Pınar Nerse";
                                SubjectCode = "EngBasic";
                                Option1Button.Visibility = Visibility.Visible;
                                Option2Button.Visibility = Visibility.Visible;
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                Shutdown(s, e);
                            }
                            else if ((Time >= 760) && (Time <= 789))
                            {
                                Bar.Visibility = Visibility.Hidden;
                                this.Height = this.Width;
                                Image.Margin = new Thickness(0, 0, 0, 0);
                                Subject.Content = "İngilizce";
                                CloseButton.Visibility = Visibility.Hidden;
                                Option1Button.Content = "Rasim İşbilen";
                                Option2Button.Content = "Pınar Nerse";
                                SubjectCode = "EngBasic";
                                Option1Button.Visibility = Visibility.Visible;
                                Option2Button.Visibility = Visibility.Visible;
                                CloseText.Content = "Öğretmeninizin İsmi?";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780795162154500147/english.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                await Task.Delay(60000);
                                MessageBox.Show("Program Zaman Aşımına Uğradı", "Program Kapatılıyor", MessageBoxButton.OK, MessageBoxImage.Warning);
                                Application.Current.Shutdown();
                            }
                            else if ((Time >= 790) && (Time <= 799))
                            {
                                Subject.Content = "Teneffüsdesiniz";
                                MinutesLeft.Visibility = Visibility.Visible;
                                MinutesLeft.Content = "Fiziğin Başlamasına " + (800 - Time) + " Dakika Kaldı";
                                CloseButton.Visibility = Visibility.Hidden;
                                SubjectCode = "Physics";
                                Send.Content = "Erken Gir";
                                Send.Visibility = Visibility.Visible;
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                Shutdown(s, e);
                            }
                            else if ((Time >= 800) && (Time <= 829))
                            {
                                Subject.Content = "Fizik";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Şimdi Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Physics";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780800196585062410/physics.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                RedirectTimer(s, e);
                            }
                            else if ((Time >= 830) && (Time <= 839))
                            {
                                Subject.Content = "Teneffüsdesiniz";
                                MinutesLeft.Visibility = Visibility.Visible;
                                MinutesLeft.Content = "Biyolojinin Başlamasına " + (840 - Time) + " Dakika Kaldı";
                                CloseButton.Visibility = Visibility.Hidden;
                                SubjectCode = "Biology";
                                Send.Content = "Erken Gir";
                                Send.Visibility = Visibility.Visible;
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                Shutdown(s, e);
                            }
                            else if ((Time >= 840) && (Time <= 869))
                            {
                                Subject.Content = "Biyoloji";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Şimdi Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Biology";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780802345855352873/biology.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                RedirectTimer(s, e);
                            }
                            else if ((Time >= 870) && (Time <= 879))
                            {
                                Subject.Content = "Teneffüsdesiniz";
                                MinutesLeft.Visibility = Visibility.Visible;
                                MinutesLeft.Content = "Kimyanın Başlamasına " + (880 - Time) + " Dakika Kaldı";
                                CloseButton.Visibility = Visibility.Hidden;
                                SubjectCode = "Chemistry";
                                Send.Content = "Erken Gir";
                                Send.Visibility = Visibility.Visible;
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                Shutdown(s, e);
                            }
                            else if ((Time >= 880) && (Time <= 909))
                            {
                                Subject.Content = "Kimya";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Şimdi Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Chemistry";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780803131906588692/chemistry.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                RedirectTimer(s, e);
                            }
                        }
                        else
                        {
                            Subject.Content = "Birazdan Başlayacak";
                            MinutesLeft.Visibility = Visibility.Visible;
                            MinutesLeft.Content = "Geometrinin Başlamasına " + (540 - Time) + " Dakika Kaldı";
                            CloseButton.Visibility = Visibility.Hidden;
                            Send.Content = "Erken Gir";
                            Send.Visibility = Visibility.Visible;
                            SubjectCode = "Geometry";
                            BitmapImage bitmap = new BitmapImage();
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                            bitmap.EndInit();
                            Image.Source = bitmap;
                            Shutdown(s, e);
                        }
                    }
                    else
                    {
                        if ((Time >= 1020) && (Time <= 1065))
                        {
                            Subject.Content = "Ek Dersler Desteklenmiyor";
                            MinutesLeft.Content = "Ek Dersin ne olduğu her hafta değiştiğinden dolayı\n           bu program ek dersleri desteklemiyor";
                            MinutesLeft.Visibility = Visibility.Visible;
                            BitmapImage bitmap = new BitmapImage();
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780738966483369984/closing.png");
                            bitmap.EndInit();
                            Image.Source = bitmap;
                            Shutdown(s, e);
                        }
                        else
                        {
                            Subject.Content = "Şu an teneffüstesiniz";
                            BitmapImage bitmap = new BitmapImage();
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                            bitmap.EndInit();
                            Image.Source = bitmap;
                            Shutdown(s, e);
                        }
                    }
                }
                else
                {
                    Subject.Content = "Şu an ders yok";
                    BitmapImage bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780738966483369984/closing.png");
                    bitmap.EndInit();
                    Image.Source = bitmap;
                    Shutdown(s, e);
                }
            }
            else if (Day == 2)
            {
                if ((Time >= 530) && (Time <= 1065))
                {
                    if ((Time >= 530) && (Time <= 910))
                    {
                        if ((Time >= 540) && (Time <= 910))
                        {
                            if ((Time >= 540) && (Time <= 569))
                            {
                                Subject.Content = "Coğrafya";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Şimdi Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Geography";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780803939431612416/geography.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                RedirectTimer(s, e);
                            }
                            else if ((Time >= 570) && (Time <= 579))
                            {
                                Subject.Content = "Teneffüstesiniz";
                                MinutesLeft.Visibility = Visibility.Visible;
                                MinutesLeft.Content = "Geometrinin Başlamasına " + (580 - Time) + " Dakika Kaldı";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Erken Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Geometry";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                Shutdown(s, e);
                            }
                            else if ((Time >= 580) && (Time <= 609))
                            {
                                Subject.Content = "Geometri";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Şimdi Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Geometry";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780776703567724555/geometry.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                RedirectTimer(s, e);
                            }
                            else if ((Time >= 610) && (Time <= 619))
                            {
                                Subject.Content = "Teneffüstesiniz";
                                MinutesLeft.Visibility = Visibility.Visible;
                                MinutesLeft.Content = "Kimyanın Başlamasına " + (620 - Time) + " Dakika Kaldı";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Erken Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Chemistry";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                Shutdown(s, e);
                            }
                            else if ((Time >= 620) && (Time <= 649))
                            {
                                Subject.Content = "Kimya";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Şimdi Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Chemistry";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780803131906588692/chemistry.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                RedirectTimer(s, e);
                            }
                            else if ((Time >= 650) && (Time <= 659))
                            {
                                Subject.Content = "Teneffüstesiniz";
                                MinutesLeft.Visibility = Visibility.Visible;
                                MinutesLeft.Content = "Felsefenin Başlamasına " + (660 - Time) + " Dakika Kaldı";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Erken Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Philosophy";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                Shutdown(s, e);
                            }
                            else if ((Time >= 660) && (Time <= 689))
                            {
                                Subject.Content = "Felsefe";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Şimdi Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Philosophy";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780804719949250560/philosophy.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                RedirectTimer(s, e);
                            }
                            else if ((Time >= 690) && (Time <= 699))
                            {
                                Subject.Content = "Teneffüstesiniz";
                                MinutesLeft.Visibility = Visibility.Visible;
                                MinutesLeft.Content = "Fiziğin Başlamasına " + (700 - Time) + " Dakika Kaldı";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Erken Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Physics";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                Shutdown(s, e);
                            }
                            else if ((Time >= 700) && (Time <= 729))
                            {
                                Subject.Content = "Fizik";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Şimdi Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Physics";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780800196585062410/physics.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                RedirectTimer(s, e);
                            }
                            else if ((Time >= 730) && (Time <= 759))
                            {
                                Subject.Content = "Öğle Teneffüsündesiniz";
                                MinutesLeft.Visibility = Visibility.Visible;
                                MinutesLeft.Content = "Matematiğin Başlamasına " + (760 - Time) + " Dakika Kaldı";
                                CloseButton.Visibility = Visibility.Hidden;
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Erken Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Maths";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                Shutdown(s, e);
                            }
                            else if ((Time >= 760) && (Time <= 789))
                            {
                                Subject.Content = "Matematik";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Şimdi Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Maths";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780782512280305734/maths.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                RedirectTimer(s, e);
                            }
                            else if ((Time >= 790) && (Time <= 799))
                            {
                                Subject.Content = "Teneffüsdesiniz";
                                MinutesLeft.Visibility = Visibility.Visible;
                                MinutesLeft.Content = "Aktivitenin Başlamasına " + (800 - Time) + " Dakika Kaldı";
                                CloseButton.Visibility = Visibility.Hidden;
                                Option1Button.Content = "Görsel Sanatlar";
                                Option2Button.Content = "Beden Eğitimi";
                                SubjectCode = "Activity";
                                Option1Button.Visibility = Visibility.Visible;
                                Option2Button.Visibility = Visibility.Visible;
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                Shutdown(s, e);
                            }
                            else if ((Time >= 800) && (Time <= 829))
                            {
                                Bar.Visibility = Visibility.Hidden;
                                this.Height = this.Width;
                                Image.Margin = new Thickness(0, 0, 0, 0);
                                Subject.Content = "Uygulamalı Dersler";
                                CloseButton.Visibility = Visibility.Hidden;
                                Option1Button.Content = "Görsel Sanatlar";
                                Option2Button.Content = "Beden Eğitimi";
                                SubjectCode = "Activity";
                                Option1Button.Visibility = Visibility.Visible;
                                Option2Button.Visibility = Visibility.Visible;
                                CloseText.Content = "Hangi Aktivitedesiniz?";
                                await Task.Delay(60000);
                                MessageBox.Show("Program Zaman Aşımına Uğradı", "Program Kapatılıyor", MessageBoxButton.OK, MessageBoxImage.Warning);
                                Application.Current.Shutdown();
                            }
                            else if ((Time >= 830) && (Time <= 839))
                            {
                                Subject.Content = "Teneffüsdesiniz";
                                MinutesLeft.Visibility = Visibility.Visible;
                                MinutesLeft.Content = "Edebiyatın Başlamasına " + (840 - Time) + " Dakika Kaldı";
                                CloseButton.Visibility = Visibility.Hidden;
                                SubjectCode = "Literature";
                                Send.Content = "Erken Gir";
                                Send.Visibility = Visibility.Visible;
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                Shutdown(s, e);
                            }
                            else if ((Time >= 840) && (Time <= 869))
                            {
                                Subject.Content = "Türk Dili ve Edebiyatı";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Şimdi Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Literature";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780780014576336916/literature.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                RedirectTimer(s, e);
                            }
                            else if ((Time >= 870) && (Time <= 879))
                            {
                                Subject.Content = "Teneffüsdesiniz";
                                MinutesLeft.Visibility = Visibility.Visible;
                                MinutesLeft.Content = "Biyolojinin Başlamasına " + (880 - Time) + " Dakika Kaldı";
                                CloseButton.Visibility = Visibility.Hidden;
                                SubjectCode = "Biology";
                                Send.Content = "Erken Gir";
                                Send.Visibility = Visibility.Visible;
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                Shutdown(s, e);
                            }
                            else if ((Time >= 880) && (Time <= 909))
                            {
                                Subject.Content = "Biyoloji";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Şimdi Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Biology";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780802345855352873/biology.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                RedirectTimer(s, e);
                            }
                        }
                        else
                        {
                            Subject.Content = "Birazdan Başlayacak";
                            MinutesLeft.Visibility = Visibility.Visible;
                            MinutesLeft.Content = "Coğrafyanın Başlamasına " + (540 - Time) + " Dakika Kaldı";
                            CloseButton.Visibility = Visibility.Hidden;
                            Send.Content = "Erken Gir";
                            Send.Visibility = Visibility.Visible;
                            SubjectCode = "Geography";
                            BitmapImage bitmap = new BitmapImage();
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                            bitmap.EndInit();
                            Image.Source = bitmap;
                            Shutdown(s, e);
                        }
                    }
                    else
                    {
                        if ((Time >= 1020) && (Time <= 1065))
                        {
                            Subject.Content = "Ek Dersler Desteklenmiyor";
                            MinutesLeft.Content = "Ek Dersin ne olduğu her hafta değiştiğinden dolayı\n           bu program ek dersleri desteklemiyor";
                            MinutesLeft.Visibility = Visibility.Visible;
                            BitmapImage bitmap = new BitmapImage();
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780738966483369984/closing.png");
                            bitmap.EndInit();
                            Image.Source = bitmap;
                            Shutdown(s, e);
                        }
                        else
                        {
                            Subject.Content = "Şu an teneffüstesiniz";
                            BitmapImage bitmap = new BitmapImage();
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                            bitmap.EndInit();
                            Image.Source = bitmap;
                            Shutdown(s, e);
                        }
                    }
                }
                else
                {
                    Subject.Content = "Şu an ders yok";
                    BitmapImage bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780738966483369984/closing.png");
                    bitmap.EndInit();
                    Image.Source = bitmap;
                    Shutdown(s, e);
                }
            }
            else if (Day == 3)
            {
                if ((Time >= 530) && (Time <= 1065))
                {
                    if ((Time >= 530) && (Time <= 770))
                    {
                        if ((Time >= 540) && (Time <= 770))
                        {
                            if ((Time >= 540) && (Time <= 569))
                            {
                                Subject.Content = "Matematik";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Şimdi Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Maths";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780782512280305734/maths.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                RedirectTimer(s, e);
                            }
                            else if ((Time >= 570) && (Time <= 579))
                            {
                                Subject.Content = "Teneffüsdesiniz";
                                MinutesLeft.Visibility = Visibility.Visible;
                                MinutesLeft.Content = "İngilizcenin Başlamasına " + (580 - Time) + " Dakika Kaldı";
                                CloseButton.Visibility = Visibility.Hidden;
                                Option1Button.Content = "Rasim İşbilen";
                                Option2Button.Content = "Pınar Nerse";
                                SubjectCode = "EngBasic";
                                Option1Button.Visibility = Visibility.Visible;
                                Option2Button.Visibility = Visibility.Visible;
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                Shutdown(s, e);
                            }
                            else if ((Time >= 580) && (Time <= 609))
                            {
                                Bar.Visibility = Visibility.Hidden;
                                this.Height = this.Width;
                                Image.Margin = new Thickness(0, 0, 0, 0);
                                Subject.Content = "İngilizce";
                                CloseButton.Visibility = Visibility.Hidden;
                                Option1Button.Content = "Rasim İşbilen";
                                Option2Button.Content = "Pınar Nerse";
                                SubjectCode = "EngBasic";
                                Option1Button.Visibility = Visibility.Visible;
                                Option2Button.Visibility = Visibility.Visible;
                                CloseText.Content = "Öğretmeninizin İsmi?";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780795162154500147/english.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                await Task.Delay(60000);
                                MessageBox.Show("Program Zaman Aşımına Uğradı", "Program Kapatılıyor", MessageBoxButton.OK, MessageBoxImage.Warning);
                                Application.Current.Shutdown();
                            }
                            else if ((Time >= 610) && (Time <= 619))
                            {
                                Subject.Content = "Teneffüstesiniz";
                                MinutesLeft.Visibility = Visibility.Visible;
                                MinutesLeft.Content = "Bilişimin Başlamasına " + (620 - Time) + " Dakika Kaldı";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Erken Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "ComputerScience";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                Shutdown(s, e);
                            }
                            else if ((Time >= 620) && (Time <= 649))
                            {
                                Subject.Content = "Bilgisayar Bilimi";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Şimdi Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "ComputerScience";
                                RedirectTimer(s, e);
                            }
                            else if ((Time >= 650) && (Time <= 659))
                            {
                                Subject.Content = "Teneffüstesiniz";
                                MinutesLeft.Visibility = Visibility.Visible;
                                MinutesLeft.Content = "Edebiyatın Başlamasına " + (660 - Time) + " Dakika Kaldı";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Erken Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Literature";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                Shutdown(s, e);
                            }
                            else if ((Time >= 660) && (Time <= 689))
                            {
                                Subject.Content = "Edebiyat";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Şimdi Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Literature";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780780014576336916/literature.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                RedirectTimer(s, e);
                            }
                            else if ((Time >= 690) && (Time <= 699))
                            {
                                Subject.Content = "Teneffüstesiniz";
                                MinutesLeft.Visibility = Visibility.Visible;
                                MinutesLeft.Content = "Tarihin Başlamasına " + (700 - Time) + " Dakika Kaldı";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Erken Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "History";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                Shutdown(s, e);
                            }
                            else if ((Time >= 700) && (Time <= 729))
                            {
                                Subject.Content = "Tarih";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Şimdi Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "History";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780814810954596382/history.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                RedirectTimer(s, e);
                            }
                            else if ((Time >= 730) && (Time <= 739))
                            {
                                Subject.Content = "Teneffüsdesiniz";
                                MinutesLeft.Visibility = Visibility.Visible;
                                MinutesLeft.Content = "Biyolojinin Başlamasına " + (740 - Time) + " Dakika Kaldı";
                                CloseButton.Visibility = Visibility.Hidden;
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Erken Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Biology";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                Shutdown(s, e);
                            }
                            else if ((Time >= 740) && (Time <= 769))
                            {
                                Subject.Content = "Biyoloji";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Şimdi Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Biology";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780802345855352873/biology.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                RedirectTimer(s, e);
                            }
                        }
                        else
                        {
                            Subject.Content = "Birazdan Başlayacak";
                            MinutesLeft.Visibility = Visibility.Visible;
                            MinutesLeft.Content = "Matematik Başlamasına " + (540 - Time) + " Dakika Kaldı";
                            CloseButton.Visibility = Visibility.Hidden;
                            Send.Content = "Erken Gir";
                            Send.Visibility = Visibility.Visible;
                            SubjectCode = "Maths";
                            BitmapImage bitmap = new BitmapImage();
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                            bitmap.EndInit();
                            Image.Source = bitmap;
                            Shutdown(s, e);
                        }
                    }
                    else
                    {
                        if ((Time >= 1020) && (Time <= 1065))
                        {
                            Subject.Content = "Ek Dersler Desteklenmiyor";
                            MinutesLeft.Content = "Ek Dersin ne olduğu her hafta değiştiğinden dolayı\n           bu program ek dersleri desteklemiyor";
                            MinutesLeft.Visibility = Visibility.Visible;
                            BitmapImage bitmap = new BitmapImage();
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780738966483369984/closing.png");
                            bitmap.EndInit();
                            Image.Source = bitmap;
                            Shutdown(s, e);
                        }
                        else
                        {
                            Subject.Content = "Şu an teneffüstesiniz";
                            BitmapImage bitmap = new BitmapImage();
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                            bitmap.EndInit();
                            Image.Source = bitmap;
                            Shutdown(s, e);
                        }
                    }
                }
                else
                {
                    Subject.Content = "Şu an ders yok";
                    BitmapImage bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780738966483369984/closing.png");
                    bitmap.EndInit();
                    Image.Source = bitmap;
                    Shutdown(s, e);
                }
            }
            else if (Day == 4)
            {
                if ((Time >= 530) && (Time <= 1065))
                {
                    if ((Time >= 530) && (Time <= 910))
                    {
                        if ((Time >= 540) && (Time <= 910))
                        {
                            if ((Time >= 540) && (Time <= 569))
                            {
                                Subject.Content = "Biyoloji";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Şimdi Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Biology";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780802345855352873/biology.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                RedirectTimer(s, e);
                            }
                            else if ((Time >= 570) && (Time <= 579))
                            {
                                Subject.Content = "Teneffüstesiniz";
                                MinutesLeft.Visibility = Visibility.Visible;
                                MinutesLeft.Content = "Edebiyatın Başlamasına " + (580 - Time) + " Dakika Kaldı";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Erken Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Literature";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                Shutdown(s, e);
                            }
                            else if ((Time >= 580) && (Time <= 609))
                            {
                                Subject.Content = "Türk Dili ve Edebiyatı";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Şimdi Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Literature";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780780014576336916/literature.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                RedirectTimer(s, e);
                            }
                            else if ((Time >= 610) && (Time <= 619))
                            {
                                Subject.Content = "Teneffüstesiniz";
                                MinutesLeft.Visibility = Visibility.Visible;
                                MinutesLeft.Content = "Coğrafyanın Başlamasına " + (620 - Time) + " Dakika Kaldı";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Erken Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Geography";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                Shutdown(s, e);
                            }
                            else if ((Time >= 620) && (Time <= 649))
                            {
                                Subject.Content = "Coğrafya";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Şimdi Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Geography";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780803939431612416/geography.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                RedirectTimer(s, e);
                            }
                            else if ((Time >= 650) && (Time <= 659))
                            {
                                Subject.Content = "Teneffüsdesiniz";
                                MinutesLeft.Visibility = Visibility.Visible;
                                MinutesLeft.Content = "İngilizcenin Başlamasına " + (660 - Time) + " Dakika Kaldı";
                                CloseButton.Visibility = Visibility.Hidden;
                                Option1Button.Content = "Rasim İşbilen";
                                Option2Button.Content = "Pınar Nerse";
                                SubjectCode = "EngBasic";
                                Option1Button.Visibility = Visibility.Visible;
                                Option2Button.Visibility = Visibility.Visible;
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                Shutdown(s, e);
                            }
                            else if ((Time >= 660) && (Time <= 689))
                            {
                                Bar.Visibility = Visibility.Hidden;
                                this.Height = this.Width;
                                Image.Margin = new Thickness(0, 0, 0, 0);
                                Subject.Content = "İngilizce";
                                CloseButton.Visibility = Visibility.Hidden;
                                Option1Button.Content = "Rasim İşbilen";
                                Option2Button.Content = "Pınar Nerse";
                                SubjectCode = "EngBasic";
                                Option1Button.Visibility = Visibility.Visible;
                                Option2Button.Visibility = Visibility.Visible;
                                CloseText.Content = "Öğretmeninizin İsmi?";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780795162154500147/english.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                await Task.Delay(60000);
                                MessageBox.Show("Program Zaman Aşımına Uğradı", "Program Kapatılıyor", MessageBoxButton.OK, MessageBoxImage.Warning);
                                Application.Current.Shutdown();
                            }
                            else if ((Time >= 690) && (Time <= 699))
                            {
                                Subject.Content = "Teneffüstesiniz";
                                MinutesLeft.Visibility = Visibility.Visible;
                                MinutesLeft.Content = "Fiziğin Başlamasına " + (700 - Time) + " Dakika Kaldı";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Erken Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Physics";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                Shutdown(s, e);
                            }
                            else if ((Time >= 700) && (Time <= 729))
                            {
                                Subject.Content = "Fizik";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Şimdi Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Physics";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780800196585062410/physics.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                RedirectTimer(s, e);
                            }
                            else if ((Time >= 730) && (Time <= 759))
                            {
                                Subject.Content = "Öğle Teneffüsündesiniz";
                                MinutesLeft.Visibility = Visibility.Visible;
                                MinutesLeft.Content = "Geometrinin Başlamasına " + (760 - Time) + " Dakika Kaldı";
                                CloseButton.Visibility = Visibility.Hidden;
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Erken Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Geometry";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                Shutdown(s, e);
                            }
                            else if ((Time >= 760) && (Time <= 789))
                            {
                                Subject.Content = "Geometri";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Şimdi Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Geometry";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780776703567724555/geometry.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                RedirectTimer(s, e);
                            }
                            else if ((Time >= 790) && (Time <= 799))
                            {
                                Subject.Content = "Teneffüsdesiniz";
                                MinutesLeft.Visibility = Visibility.Visible;
                                MinutesLeft.Content = "Din Kültürünün Başlamasına " + (800 - Time) + " Dakika Kaldı";
                                CloseButton.Visibility = Visibility.Hidden;
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Erken Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Religion";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                Shutdown(s, e);
                            }
                            else if ((Time >= 800) && (Time <= 829))
                            {
                                Subject.Content = "Din Kültürü ve Ahlak Bilgisi";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Şimdi Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Religion";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780820066442280960/religion.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                RedirectTimer(s, e);
                            }
                            else if ((Time >= 830) && (Time <= 839))
                            {
                                Subject.Content = "Teneffüsdesiniz";
                                MinutesLeft.Visibility = Visibility.Visible;
                                MinutesLeft.Content = "Kimyanın Başlamasına " + (840 - Time) + " Dakika Kaldı";
                                CloseButton.Visibility = Visibility.Hidden;
                                SubjectCode = "Chemistry";
                                Send.Content = "Erken Gir";
                                Send.Visibility = Visibility.Visible;
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                Shutdown(s, e);
                            }
                            else if ((Time >= 840) && (Time <= 869))
                            {
                                Subject.Content = "Kimya";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Şimdi Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Chemistry";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780803131906588692/chemistry.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                RedirectTimer(s, e);
                            }
                            else if ((Time >= 870) && (Time <= 879))
                            {
                                Subject.Content = "Teneffüsdesiniz";
                                MinutesLeft.Visibility = Visibility.Visible;
                                MinutesLeft.Content = "Matematiğin Başlamasına " + (880 - Time) + " Dakika Kaldı";
                                CloseButton.Visibility = Visibility.Hidden;
                                SubjectCode = "Maths";
                                Send.Content = "Erken Gir";
                                Send.Visibility = Visibility.Visible;
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                Shutdown(s, e);
                            }
                            else if ((Time >= 880) && (Time <= 909))
                            {
                                Subject.Content = "Matematik";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Şimdi Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Maths";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780782512280305734/maths.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                RedirectTimer(s, e);
                            }
                        }
                        else
                        {
                            Subject.Content = "Birazdan Başlayacak";
                            MinutesLeft.Visibility = Visibility.Visible;
                            MinutesLeft.Content = "Biyolojinin Başlamasına " + (540 - Time) + " Dakika Kaldı";
                            CloseButton.Visibility = Visibility.Hidden;
                            Send.Content = "Erken Gir";
                            Send.Visibility = Visibility.Visible;
                            SubjectCode = "Biology";
                            BitmapImage bitmap = new BitmapImage();
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                            bitmap.EndInit();
                            Image.Source = bitmap;
                            Shutdown(s, e);
                        }
                    }
                    else
                    {
                        if ((Time >= 1020) && (Time <= 1065))
                        {
                            Subject.Content = "Ek Dersler Desteklenmiyor";
                            MinutesLeft.Content = "Ek Dersin ne olduğu her hafta değiştiğinden dolayı\n           bu program ek dersleri desteklemiyor";
                            MinutesLeft.Visibility = Visibility.Visible;
                            BitmapImage bitmap = new BitmapImage();
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780738966483369984/closing.png");
                            bitmap.EndInit();
                            Image.Source = bitmap;
                            Shutdown(s, e);
                        }
                        else
                        {
                            Subject.Content = "Şu an teneffüstesiniz";
                            BitmapImage bitmap = new BitmapImage();
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                            bitmap.EndInit();
                            Image.Source = bitmap;
                            Shutdown(s, e);
                        }
                    }
                }
                else
                {
                    Subject.Content = "Şu an ders yok";
                    BitmapImage bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780738966483369984/closing.png");
                    bitmap.EndInit();
                    Image.Source = bitmap;
                    Shutdown(s, e);
                }
            }
            else if (Day == 5)
            {
                if ((Time >= 530) && (Time <= 830))
                {
                    if ((Time >= 540) && (Time <= 830))
                    {
                        if ((Time >= 540) && (Time <= 569))
                        {
                            Subject.Content = "Tarih";
                            CloseButton.Visibility = Visibility.Hidden;
                            Send.Content = "Şimdi Gir";
                            Send.Visibility = Visibility.Visible;
                            SubjectCode = "History";
                            BitmapImage bitmap = new BitmapImage();
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780814810954596382/history.png");
                            bitmap.EndInit();
                            Image.Source = bitmap;
                            RedirectTimer(s, e);
                        }
                        else if ((Time >= 570) && (Time <= 579))
                        {
                            Subject.Content = "Teneffüstesiniz";
                            MinutesLeft.Visibility = Visibility.Visible;
                            MinutesLeft.Content = "Almancanın Başlamasına " + (580 - Time) + " Dakika Kaldı";
                            CloseButton.Visibility = Visibility.Hidden;
                            Send.Content = "Erken Gir";
                            Send.Visibility = Visibility.Visible;
                            SubjectCode = "German";
                            BitmapImage bitmap = new BitmapImage();
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                            bitmap.EndInit();
                            Image.Source = bitmap;
                            Shutdown(s, e);
                        }
                        else if ((Time >= 580) && (Time <= 609))
                        {
                            Subject.Content = "Almanca";
                            CloseButton.Visibility = Visibility.Hidden;
                            Send.Content = "Şimdi Gir";
                            Send.Visibility = Visibility.Visible;
                            SubjectCode = "German";
                            BitmapImage bitmap = new BitmapImage();
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780780403827933204/german.png");
                            bitmap.EndInit();
                            Image.Source = bitmap;
                            RedirectTimer(s, e);
                        }
                        else if ((Time >= 610) && (Time <= 619))
                        {
                            Subject.Content = "Teneffüstesiniz";
                            MinutesLeft.Visibility = Visibility.Visible;
                            MinutesLeft.Content = "Fiziğin Başlamasına " + (620 - Time) + " Dakika Kaldı";
                            CloseButton.Visibility = Visibility.Hidden;
                            Send.Content = "Erken Gir";
                            Send.Visibility = Visibility.Visible;
                            SubjectCode = "Physics";
                            BitmapImage bitmap = new BitmapImage();
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                            bitmap.EndInit();
                            Image.Source = bitmap;
                            Shutdown(s, e);
                        }
                        else if ((Time >= 620) && (Time <= 649))
                        {
                            Subject.Content = "Fizik";
                            CloseButton.Visibility = Visibility.Hidden;
                            Send.Content = "Şimdi Gir";
                            Send.Visibility = Visibility.Visible;
                            SubjectCode = "Physics";
                            BitmapImage bitmap = new BitmapImage();
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780800196585062410/physics.png");
                            bitmap.EndInit();
                            Image.Source = bitmap;
                            RedirectTimer(s, e);
                        }
                        else if ((Time >= 650) && (Time <= 659))
                        {
                            Subject.Content = "Teneffüstesiniz";
                            MinutesLeft.Visibility = Visibility.Visible;
                            MinutesLeft.Content = "Kimyanın Başlamasına " + (660 - Time) + " Dakika Kaldı";
                            CloseButton.Visibility = Visibility.Hidden;
                            Send.Content = "Erken Gir";
                            Send.Visibility = Visibility.Visible;
                            SubjectCode = "Chemistry";
                            BitmapImage bitmap = new BitmapImage();
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                            bitmap.EndInit();
                            Image.Source = bitmap;
                            Shutdown(s, e);
                        }
                        else if ((Time >= 660) && (Time <= 689))
                        {
                            Subject.Content = "Kimya";
                            CloseButton.Visibility = Visibility.Hidden;
                            Send.Content = "Şimdi Gir";
                            Send.Visibility = Visibility.Visible;
                            SubjectCode = "Chemistry";
                            BitmapImage bitmap = new BitmapImage();
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780803131906588692/chemistry.png");
                            bitmap.EndInit();
                            Image.Source = bitmap;
                            RedirectTimer(s, e);
                        }
                        else if ((Time >= 690) && (Time <= 699))
                        {
                            Subject.Content = "Teneffüstesiniz";
                            MinutesLeft.Visibility = Visibility.Visible;
                            MinutesLeft.Content = "Edebiyatın Başlamasına " + (700 - Time) + " Dakika Kaldı";
                            CloseButton.Visibility = Visibility.Hidden;
                            Send.Content = "Erken Gir";
                            Send.Visibility = Visibility.Visible;
                            SubjectCode = "Literature";
                            BitmapImage bitmap = new BitmapImage();
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                            bitmap.EndInit();
                            Image.Source = bitmap;
                            Shutdown(s, e);
                        }
                        else if ((Time >= 700) && (Time <= 729))
                        {
                            Subject.Content = "Türk Dili ve Edebiyatı";
                            CloseButton.Visibility = Visibility.Hidden;
                            Send.Content = "Şimdi Gir";
                            Send.Visibility = Visibility.Visible;
                            SubjectCode = "Literature";
                            BitmapImage bitmap = new BitmapImage();
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780780014576336916/literature.png");
                            bitmap.EndInit();
                            Image.Source = bitmap;
                            RedirectTimer(s, e);
                        }
                        else if ((Time >= 730) && (Time <= 759))
                        {    
                            Subject.Content = "Teneffüstesiniz";
                            MinutesLeft.Visibility = Visibility.Visible;
                            MinutesLeft.Content = "Matematiğin Başlamasına " + (760 - Time) + " Dakika Kaldı";
                            CloseButton.Visibility = Visibility.Hidden;
                            Send.Content = "Erken Gir";
                            Send.Visibility = Visibility.Visible;
                            SubjectCode = "Maths";
                            BitmapImage bitmap = new BitmapImage();
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                            bitmap.EndInit();
                            Image.Source = bitmap;
                            Shutdown(s, e);
                        }
                        else if ((Time >= 760) && (Time <= 789))
                        {
                                Subject.Content = "Matematik";
                                CloseButton.Visibility = Visibility.Hidden;
                                Send.Content = "Şimdi Gir";
                                Send.Visibility = Visibility.Visible;
                                SubjectCode = "Maths";
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780782512280305734/maths.png");
                                bitmap.EndInit();
                                Image.Source = bitmap;
                                RedirectTimer(s, e);
                        }
                        else if ((Time >= 790) && (Time <= 799))
                        {
                            Subject.Content = "Teneffüsdesiniz";
                            MinutesLeft.Visibility = Visibility.Visible;
                            MinutesLeft.Content = "İngilizcenin Başlamasına " + (800 - Time) + " Dakika Kaldı";
                            CloseButton.Visibility = Visibility.Hidden;
                            Option1Button.Content = "Rasim İşbilen";
                            Option2Button.Content = "Pınar Nerse";
                            SubjectCode = "EngBasic";
                            Option1Button.Visibility = Visibility.Visible;
                            Option2Button.Visibility = Visibility.Visible;
                            BitmapImage bitmap = new BitmapImage();
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                            bitmap.EndInit();
                            Image.Source = bitmap;
                            Shutdown(s, e);
                        }
                        else if ((Time >= 800) && (Time <= 829))
                        {
                            Bar.Visibility = Visibility.Hidden;
                            this.Height = this.Width;
                            Image.Margin = new Thickness(0, 0, 0, 0);
                            Subject.Content = "İngilizce";
                            CloseButton.Visibility = Visibility.Hidden;
                            Option1Button.Content = "Rasim İşbilen";
                            Option2Button.Content = "Pınar Nerse";
                            SubjectCode = "EngBasic";
                            Option1Button.Visibility = Visibility.Visible;
                            Option2Button.Visibility = Visibility.Visible;
                            CloseText.Content = "Öğretmeninizin İsmi?";
                            BitmapImage bitmap = new BitmapImage();
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780795162154500147/english.png");
                            bitmap.EndInit();
                            Image.Source = bitmap;
                            await Task.Delay(60000);
                            MessageBox.Show("Program Zaman Aşımına Uğradı", "Program Kapatılıyor", MessageBoxButton.OK, MessageBoxImage.Warning);
                            Application.Current.Shutdown();
                        }
                    }
                    else
                    {
                        Subject.Content = "Birazdan Başlayacak";
                        MinutesLeft.Visibility = Visibility.Visible;
                        MinutesLeft.Content = "Tarihin Başlamasına " + (540 - Time) + " Dakika Kaldı";
                        CloseButton.Visibility = Visibility.Hidden;
                        Send.Content = "Erken Gir";
                        Send.Visibility = Visibility.Visible;
                        SubjectCode = "Tarih";
                        BitmapImage bitmap = new BitmapImage();
                        bitmap.BeginInit();
                        bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780732149732605972/recess.png");
                        bitmap.EndInit();
                        Image.Source = bitmap;
                        Shutdown(s, e);
                    }
                }
                else
                {
                    Subject.Content = "Şu an ders yok";
                    BitmapImage bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780738966483369984/closing.png");
                    bitmap.EndInit();
                    Image.Source = bitmap;
                    Shutdown(s, e);
                }
            }
            else
            {
                Subject.Content = "Şu an ders yok";
                MinutesLeft.Content = "Hafta Sonundasınız";
                MinutesLeft.Visibility = Visibility.Visible;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri("https://cdn.discordapp.com/attachments/690543745799684116/780738966483369984/closing.png");
                bitmap.EndInit();
                Image.Source = bitmap;
                Shutdown(s, e);
            }
        }
        private async void RedirectToOne(object s, RoutedEventArgs e)
        {
            if (SubjectCode == "EngBasic") {SubjectCode = "English";}
            else if (SubjectCode == "Activity") {SubjectCode = "Art";}
            Redirect(s, e);
        }
        private async void RedirectToTwo(object s, RoutedEventArgs e)
        {
            if (SubjectCode == "EngBasic") { SubjectCode = "EnglishPN"; }
            else if (SubjectCode == "Activity") { SubjectCode = "PE"; }
            Redirect(s, e);
        }
        private async void Shutdown(object s, RoutedEventArgs e)
        {
            CloseText.Content = "5 Saniye Sonra Kapatılıyor";
            await Task.Delay(1000);
            CloseText.Content = "4 Saniye Sonra Kapatılıyor";
            await Task.Delay(1000);
            CloseText.Content = "3 Saniye Sonra Kapatılıyor";
            await Task.Delay(1000);
            CloseText.Content = "2 Saniye Sonra Kapatılıyor";
            await Task.Delay(1000);
            CloseText.Content = "1 Saniye Sonra Kapatılıyor";
            await Task.Delay(1000);
            CloseText.Content = "0 Saniye Sonra Kapatılıyor";
            await Task.Delay(1000);
            if (!Helped)
            {
                Application.Current.Shutdown();
            }
        }
        private async void BarIncrease(object s, RoutedEventArgs e)
        {
            while (true)
            {
                await Task.Delay(1);
                Bar.Width = this.Width;
                Bar.Value = (Bar.Value) + 1;
            }
        }

        private async void RedirectTimer(object s, RoutedEventArgs e)
        {
            CloseText.Content = "5 Saniye Sonra Derse Giriliyor";
            await Task.Delay(1000);
            CloseText.Content = "4 Saniye Sonra Derse Giriliyor";
            await Task.Delay(1000);
            CloseText.Content = "3 Saniye Sonra Derse Giriliyor";
            await Task.Delay(1000);
            CloseText.Content = "2 Saniye Sonra Derse Giriliyor";
            await Task.Delay(1000);
            CloseText.Content = "1 Saniye Sonra Derse Giriliyor";
            await Task.Delay(1000);
            CloseText.Content = "0 Saniye Sonra Derse Giriliyor";
            await Task.Delay(1000);
            Redirect(s, e);
        }
        private async void Redirect(object s, RoutedEventArgs e)
        {
            if (!Helped)
            {
                if (SubjectCode == "Literature")
                {
                    System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
                    Application.Current.Shutdown();
                }
                else if (SubjectCode == "Maths")
                {
                    System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
                    Application.Current.Shutdown();
                }
                else if (SubjectCode == "Geometry")
                {
                    System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
                    Application.Current.Shutdown();
                }
                else if (SubjectCode == "Physics")
                {
                    System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
                    Application.Current.Shutdown();
                }
                else if (SubjectCode == "Chemistry")
                {
                    System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
                    Application.Current.Shutdown();
                }
                else if (SubjectCode == "Biology")
                {
                    System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
                    Application.Current.Shutdown();
                }
                else if (SubjectCode == "History")
                {
                    System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
                    Application.Current.Shutdown();
                }
                else if (SubjectCode == "Geography")
                {
                    System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
                    Application.Current.Shutdown();
                }
                else if (SubjectCode == "Religion")
                {
                    System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
                    Application.Current.Shutdown();
                }
                else if (SubjectCode == "Philosophy")
                {
                    System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
                    Application.Current.Shutdown();
                }
                else if (SubjectCode == "English")
                {
                    System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
                    Application.Current.Shutdown();
                }
                else if (SubjectCode == "EnglishPN")
                {
                    System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
                    Application.Current.Shutdown();
                }
                else if (SubjectCode == "German")
                {
                    System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
                    Application.Current.Shutdown();
                }
                else if (SubjectCode == "PE")
                {
                    System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
                    Application.Current.Shutdown();
                }
                else if (SubjectCode == "Art")
                {
                    System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
                    Application.Current.Shutdown();
                }
                else if (SubjectCode == "Exam")
                {
                    System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
                    Application.Current.Shutdown();
                }
                else if (SubjectCode == "ComputerScience")
                {
                    System.Diagnostics.Process.Start("https://meet.google.com/vvr-pwap-yrj");
                    Application.Current.Shutdown();
                }
            }
        }
        private async void Help(object s, RoutedEventArgs e)
        {
            Helped = true;
            HelpMe = new MoreClassesWindow();
            HelpMe.Show();
            this.Close();
        }
    }
}