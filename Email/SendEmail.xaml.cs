using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;
using System.Windows.Controls.Primitives;
using System.Windows.Threading;

namespace Email
{
    /// <summary>
    /// Interaction logic for SendEmail.xaml
    /// </summary>
    public partial class SendEmail : Window
    {
        
        public SendEmail()
        {
            InitializeComponent();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public Message message = null;
        List<Attach> attachments = new List<Attach>();
        Attach selectedAtt = null;
        private bool userIsDraggingSlider = false;
        //MediaPlayer media;

        private void sendEmail_Click(object sender, RoutedEventArgs e)
        {
            TextRange range = new TextRange(body.box.Document.ContentStart, body.box.Document.ContentEnd);
            MemoryStream stream = new MemoryStream();
            range.Save(stream, DataFormats.Xaml);
            string richText = Encoding.UTF8.GetString(stream.ToArray());

            if (recipient.Text.Equals("") || subject.Text.Equals("") ||  richText.Equals(""))
            {
                error.Text = "Please fill in the fields";
                return;
            }


            DateTime d = DateTime.Now;
            
            message = new Message
            {
                Recieve = recipient.Text,
                Copy = copy.Text,
                Subject = subject.Text,
                Body = richText,
                Sender = "Nora Nikoloska",
                date = d.ToString(),
                attachments = this.attachments,
            };

            this.Close();
        }

        private void addAttachments_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.png;*.jpeg;*.gif;*.bmp)|*.png;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == true)
            {
                foreach (string filename in ofd.FileNames)
                {
                    Attach attachment = new Attach();
                    attachment.FileName = System.IO.Path.GetFileName(filename);
                    attachment.Path = System.IO.Path.GetFullPath(filename);
                    attachments.Add(attachment);
                }
                
            }

            lbAttachments.ItemsSource = attachments;
        }

        private void attachmentSelected(object sender, RoutedEventArgs e)
        {
            selectedAtt = (Attach)(sender as Button).DataContext;
            if (selectedAtt.Path.EndsWith("avi") || selectedAtt.Path.EndsWith("mp3") || selectedAtt.Path.EndsWith("mp4"))
            {
               
                media.Source = new Uri(selectedAtt.Path);
                media.Visibility = Visibility.Visible;
                play.Visibility = Visibility.Visible;
                pause.Visibility = Visibility.Visible;
                slider.Visibility = Visibility.Visible;

                DispatcherTimer timer = new DispatcherTimer();
                timer.Interval = TimeSpan.FromSeconds(1);
                timer.Tick += timer_Tick;
                timer.Start();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if ((media.Source != null) && (media.NaturalDuration.HasTimeSpan) && (!userIsDraggingSlider))
            {
                slider.Minimum = 0;
                slider.Maximum = media.NaturalDuration.TimeSpan.TotalSeconds;
                slider.Value = media.Position.TotalSeconds;
            }
        }


        private void play_Click(object sender, RoutedEventArgs e)
        {
            media.Play();
            media.Position = TimeSpan.FromSeconds(slider.Value);
        }

        private void sliProgress_DragStarted(object sender, DragStartedEventArgs e)
        {
            userIsDraggingSlider = true;
        }

        private void sliProgress_DragCompleted(object sender, DragCompletedEventArgs e)
        {
            userIsDraggingSlider = false;
            media.Position = TimeSpan.FromSeconds(slider.Value);
        }

        private void pause_Click(object sender, RoutedEventArgs e)
        {
            media.Pause();
        }
    }
}
