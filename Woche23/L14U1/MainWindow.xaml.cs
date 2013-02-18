using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace L14U1
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void btn2_1_Click(object sender, RoutedEventArgs e)
    {

      RotateTransform animatedTranslateTransform = new RotateTransform();
      btn2_1.RenderTransform = animatedTranslateTransform;
      RegisterName("animateButton2", animatedTranslateTransform);

      DoubleAnimationUsingKeyFrames translationAnimation = new DoubleAnimationUsingKeyFrames();
      translationAnimation.KeyFrames.Add(new EasingDoubleKeyFrame(0, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))));

      EasingDoubleKeyFrame doubleKeyFrame2 = new EasingDoubleKeyFrame(360, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(10)));

      ElasticEase ease = new ElasticEase();
      ease.Oscillations = 3;
      ease.Springiness = 8;
      ease.EasingMode = EasingMode.EaseOut;

      doubleKeyFrame2.EasingFunction = ease;
      translationAnimation.KeyFrames.Add(doubleKeyFrame2);

      Storyboard.SetTargetName(translationAnimation, "animateButton2");
      Storyboard.SetTargetProperty(translationAnimation, new PropertyPath(RotateTransform.AngleProperty));

      Storyboard strbStoryboard = new Storyboard();
      strbStoryboard.Children.Add(translationAnimation);

      strbStoryboard.Begin(this);
      UnregisterName("animateButton2");
    }
  }
}
