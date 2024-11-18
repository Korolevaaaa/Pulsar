using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Pulsar
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            StartPulsarAnimation();
        }

        private void StartPulsarAnimation()
        {
            // Анимация радиуса
            DoubleAnimation radiusAnimation = new DoubleAnimation
            {
                From = 0.5,
                To = 1.2,
                Duration = new Duration(TimeSpan.FromSeconds(1)),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            // Анимация цвета
            ColorAnimation colorAnimation = new ColorAnimation
            {
                From = Colors.Yellow,
                To = Colors.Red,
                Duration = new Duration(TimeSpan.FromSeconds(1)),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            // Применяем анимацию к градиентной заливке
            PulsarGradient.BeginAnimation(RadialGradientBrush.RadiusXProperty, radiusAnimation);
            PulsarGradient.BeginAnimation(RadialGradientBrush.RadiusYProperty, radiusAnimation);
            PulsarGradient.GradientStops[0].BeginAnimation(GradientStop.ColorProperty, colorAnimation);
        }
    }
}
