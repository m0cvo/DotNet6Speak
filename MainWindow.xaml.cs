using System.Windows;
using System.Speech.Synthesis;

namespace DotNet6Speak
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

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            string Name = NameBox.Text;
            PromptBuilder builder = new PromptBuilder();
            builder.AppendText("Hello " + Name + " I hope you are having a good day.");
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Speak(builder);
        }
    }
}
