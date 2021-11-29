using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AlbumZdjec
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        Image[] img;
        ImageSource[] source;
        List<ImageSource> s1 = new List<ImageSource>();
        List<String> dirFiles = new List<String>();
        string[] files;
        Boolean last = false;

        int curr = 3;

        public MainWindow()
        {
            InitializeComponent();

            img = new Image[] { img1, img2, img3, img4, img5, img6, img7 };

            source = new ImageSource[] { img1.Source, img2.Source, img3.Source, img4.Source, img5.Source, img6.Source, img7.Source, };

            s1.Add(img1.Source);
            s1.Add(img2.Source);
            s1.Add(img3.Source);
            s1.Add(img4.Source);
            s1.Add(img5.Source);
            s1.Add(img6.Source);
            s1.Add(img7.Source);

            files = Directory.GetFiles("Z:\\STUDIA\\SEMESTR 7\\TECHNOLOGIE SYSTEMÓW MULTIMEDIALNYCH\\LAB 4\\zadanie\\AlbumZdjec\\Albumy");

            for(int i = 0; i < files.Length; i++)
            {
                dirFiles.Add(files[i]);
            }


        }



        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (curr == s1.Count-1)
            {
                return;
            }

            myanim_Completed();

            DoubleAnimation dblAnimX = new();
            //dblAnimX.Completed += new EventHandler(myanim_Completed);
            dblAnimX.By = -50;
            dblAnimX.Duration = new Duration(TimeSpan.FromSeconds(0.5));            
            TranslateTransform trnPrzesun = new();
            img[0].RenderTransform = trnPrzesun;
            img[1].RenderTransform = trnPrzesun;
            img[2].RenderTransform = trnPrzesun;
            img[5].RenderTransform = trnPrzesun;
            img[6].RenderTransform = trnPrzesun;

            DoubleAnimation dblAnimX2 = new();
            dblAnimX2.By = -50;
            dblAnimX2.Duration = new Duration(TimeSpan.FromSeconds(0.5));
            TranslateTransform trnPrzesun2 = new();
            img[3].RenderTransform = trnPrzesun2;
            DoubleAnimation dblAnimY = new();
            dblAnimY.By = 20;
            dblAnimY.Duration = new Duration(TimeSpan.FromSeconds(0.5));


            DoubleAnimation dblAnimX3 = new();
            dblAnimX3.By = -100;
            dblAnimX3.Duration = new Duration(TimeSpan.FromSeconds(0.5));
            TranslateTransform trnPrzesun3 = new();
            img[4].RenderTransform = trnPrzesun3;
            DoubleAnimation dblAnimY2 = new();
            dblAnimY2.By = -20;
            dblAnimY2.Duration = new Duration(TimeSpan.FromSeconds(0.5));


            //double animation - scale animation
            DoubleAnimation dblAnimS = new();
            dblAnimS.From = 1;
            dblAnimS.To = 0.75;
            dblAnimS.Duration = new Duration(TimeSpan.FromSeconds(0.5));
            ScaleTransform scaleTransform = new();
            img[3].LayoutTransform = scaleTransform;


            DoubleAnimation dblAnimS2 = new();
            dblAnimS2.From = 1;
            dblAnimS2.To = 1.333333;
            dblAnimS2.Duration = new Duration(TimeSpan.FromSeconds(0.5));
            ScaleTransform scaleTransform2 = new();
            img[4].LayoutTransform = scaleTransform2;

            DoubleAnimation dblAnimS3 = new();
            dblAnimS3.From = 1;
            dblAnimS3.To = 1;
            dblAnimS3.Duration = new Duration(TimeSpan.FromSeconds(0.5));
            ScaleTransform scaleTransform3 = new();
            img[0].LayoutTransform = scaleTransform3;
            img[1].LayoutTransform = scaleTransform3;
            img[2].LayoutTransform = scaleTransform3;
            img[5].LayoutTransform = scaleTransform3;
            img[6].LayoutTransform = scaleTransform3;


            trnPrzesun.BeginAnimation(TranslateTransform.XProperty, dblAnimX);
            trnPrzesun2.BeginAnimation(TranslateTransform.XProperty, dblAnimX2);
            trnPrzesun2.BeginAnimation(TranslateTransform.YProperty, dblAnimY);
            trnPrzesun3.BeginAnimation(TranslateTransform.XProperty, dblAnimX3);
            trnPrzesun3.BeginAnimation(TranslateTransform.YProperty, dblAnimY2);

            scaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, dblAnimS);
            scaleTransform.BeginAnimation(ScaleTransform.ScaleYProperty, dblAnimS);
            scaleTransform2.BeginAnimation(ScaleTransform.ScaleXProperty, dblAnimS2);
            scaleTransform2.BeginAnimation(ScaleTransform.ScaleYProperty, dblAnimS2);
            scaleTransform3.BeginAnimation(ScaleTransform.ScaleXProperty, dblAnimS3);
            scaleTransform3.BeginAnimation(ScaleTransform.ScaleYProperty, dblAnimS3);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if(curr == 0)
            {
                return;
            }
            myanim_Completed2();

            //dobule animation - translate transform x
            DoubleAnimation dblAnimX = new();
            //dblAnimX.Completed += new EventHandler(myanim_Completed2);
            dblAnimX.By = 50;
            dblAnimX.Duration = new Duration(TimeSpan.FromSeconds(0.5));
            
            TranslateTransform trnPrzesun = new();
            img[0].RenderTransform = trnPrzesun;
            img[1].RenderTransform = trnPrzesun;
            img[4].RenderTransform = trnPrzesun;
            img[5].RenderTransform = trnPrzesun;
            img[6].RenderTransform = trnPrzesun;

            DoubleAnimation dblAnimX2 = new();
            dblAnimX2.By = 100;
            dblAnimX2.Duration = new Duration(TimeSpan.FromSeconds(0.5));
            TranslateTransform trnPrzesun2 = new();
            img[3].RenderTransform = trnPrzesun2;
            DoubleAnimation dblAnimY = new();
            dblAnimY.By = 20;
            dblAnimY.Duration = new Duration(TimeSpan.FromSeconds(0.5));


            DoubleAnimation dblAnimX3 = new();
            dblAnimX3.By = 50;
            dblAnimX3.Duration = new Duration(TimeSpan.FromSeconds(0.5));
            TranslateTransform trnPrzesun3 = new();
            img[2].RenderTransform = trnPrzesun3;
            DoubleAnimation dblAnimY2 = new();
            dblAnimY2.By = -20;
            dblAnimY2.Duration = new Duration(TimeSpan.FromSeconds(0.5));


            //double animation - scale animation
            DoubleAnimation dblAnimS = new();
            dblAnimS.From = 1;
            dblAnimS.To = 1.333333;
            dblAnimS.Duration = new Duration(TimeSpan.FromSeconds(0.5));
            ScaleTransform scaleTransform = new();
            img[2].LayoutTransform = scaleTransform;


            DoubleAnimation dblAnimS2 = new();
            dblAnimS2.From = 1;
            dblAnimS2.To = 0.75;
            dblAnimS2.Duration = new Duration(TimeSpan.FromSeconds(0.5));
            ScaleTransform scaleTransform2 = new();
            img[3].LayoutTransform = scaleTransform2;

            DoubleAnimation dblAnimS3 = new();
            dblAnimS3.From = 1;
            dblAnimS3.To = 1;
            dblAnimS3.Duration = new Duration(TimeSpan.FromSeconds(0.5));
            ScaleTransform scaleTransform3 = new();
            img[0].LayoutTransform = scaleTransform3;
            img[1].LayoutTransform = scaleTransform3;
            img[4].LayoutTransform = scaleTransform3;
            img[5].LayoutTransform = scaleTransform3;
            img[6].LayoutTransform = scaleTransform3;


            trnPrzesun.BeginAnimation(TranslateTransform.XProperty, dblAnimX);
            trnPrzesun2.BeginAnimation(TranslateTransform.XProperty, dblAnimX2);
            trnPrzesun2.BeginAnimation(TranslateTransform.YProperty, dblAnimY);
            trnPrzesun3.BeginAnimation(TranslateTransform.XProperty, dblAnimX3);
            trnPrzesun3.BeginAnimation(TranslateTransform.YProperty, dblAnimY2);

            scaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, dblAnimS);
            scaleTransform.BeginAnimation(ScaleTransform.ScaleYProperty, dblAnimS);
            scaleTransform2.BeginAnimation(ScaleTransform.ScaleXProperty, dblAnimS2);
            scaleTransform2.BeginAnimation(ScaleTransform.ScaleYProperty, dblAnimS2);
            scaleTransform3.BeginAnimation(ScaleTransform.ScaleXProperty, dblAnimS3);
            scaleTransform3.BeginAnimation(ScaleTransform.ScaleYProperty, dblAnimS3);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (dirFiles.Count > 0)
            {
                s1.Add(new ImageSourceConverter().ConvertFromString(dirFiles.Last()) as ImageSource);
                dirFiles.RemoveAt(dirFiles.Count - 1);
                if (curr == 3)
                {
                    refresh();
                }
                else if (last)
                {
                    curr--;
                    refresh();
                    curr++;
                }
                else
                {
                    curr++;
                    refresh();
                    curr--;
                }
            }

        }

        private void myanim_Completed2()
        {
            img1.SetValue(Canvas.ZIndexProperty, 1);
            img2.SetValue(Canvas.ZIndexProperty, 2);
            img3.SetValue(Canvas.ZIndexProperty, 5);
            img4.SetValue(Canvas.ZIndexProperty, 4);
            img5.SetValue(Canvas.ZIndexProperty, 3);
            img6.SetValue(Canvas.ZIndexProperty, 2);
            img7.SetValue(Canvas.ZIndexProperty, 1);

            updateSources(false);

        }

        private void myanim_Completed()
        {
            img1.SetValue(Canvas.ZIndexProperty, 1);
            img2.SetValue(Canvas.ZIndexProperty, 2);
            img3.SetValue(Canvas.ZIndexProperty, 3);
            img4.SetValue(Canvas.ZIndexProperty, 4);
            img5.SetValue(Canvas.ZIndexProperty, 5);
            img6.SetValue(Canvas.ZIndexProperty, 4);
            img7.SetValue(Canvas.ZIndexProperty, 3);

            updateSources(true);
        }

        private void updateSources(Boolean left)
        {
            refresh();
            if (left)
            {
                curr++;
            }
            else
            {                
                curr--;
            }

            last = left;
        }

        private void refresh()
        {
            for (int i = -3; i <= 3; i++)
            {
                if (curr + i >= 0 && curr + i < s1.Count)
                {
                    //img[i + 3].Source = source[curr + i];
                    img[i + 3].Source = s1.ElementAt(curr + i);
                }
                else
                {
                    img[i + 3].Source = null;
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(s1.Count > 0) {
                s1.RemoveAt(curr);
                if (curr > s1.Count - 1)
                {
                    curr = 0;
                }
                refresh();
            }
            
        }
    }
}
