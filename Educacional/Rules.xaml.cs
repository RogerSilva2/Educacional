using System;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=234238

namespace Educacional
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class Rules : Page
    {
        public Rules()
        {
            this.InitializeComponent();
        }

        private void Play_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            media.Play();
        }

        private void Stop_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            media.Stop();
        }
    }
}
