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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;
using System.Xml.Serialization;
using System.Collections.ObjectModel;
using System.Xml;
using System.Windows.Markup;

namespace Email
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Message selectedEmail;
        List<Message> inbox;
        List<Message> sent;
        List<Message> trash;

        public MainWindow()
        {
            InitializeComponent();
            inbox = new List<Message>();
            sent = new List<Message>();
            trash = new List<Message>();

            //Message m1 = new Message()
            //{
            //    Sender = "Outlook",
            //    Subject = "Outlook Welcome Email",
            //    Body = "Dear user, welcome to our E-mail. Please follow the instructions in the previous message to activate your account!",
            //    date = "17 Jan 2018"
            //};

            //Message m2 = new Message()
            //{
            //    Sender = "Outlook",
            //    Subject = "Outlook Activation Email",
            //    Body = "Dear user, welcome to our E-mail. We are happy to have you. Please follow the link to activate your account!",
            //    date = "17 Jan 2018"
            //};

            //Message m3 = new Message()
            //{
            //    Sender = "Tasty Meals",
            //    Subject = "20 Qucik Recipes",
            //    Body = "Wow I can't believe it's already Friday!!!!!! Can you? We've put some of our favourite snack ideas on the blog. Check it out!",
            //    date = "17 Jan 2018"
            //};

            //Message m4 = new Message()
            //{
            //    Sender = "Merve Restaurant",
            //    Subject = "Gala Night Invitation",
            //    Body = "Hello dear customer. This year we are celebrating our 5th birtday and would like to invite you to our Gala evening. Please notify us of your attendance by e-mail.",
            //    date = "17 Jan 2018"
            //};

            //inbox.Add(m1);
            //inbox.Add(m2);
            //sent.Add(m3);
            //trash.Add(m4);

            list_view.ItemsSource = inbox;
        }

        private void Import_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "XML files (*.xml)|*.xml";
            opf.ShowDialog();

            XmlSerializer serializer = new XmlSerializer(typeof(List<Message>));
            List<Message> newList = new List<Message>();
            using (TextReader reader = new StreamReader(opf.FileName))
            {
                newList = (List<Message>)serializer.Deserialize(reader);
            }
            inbox.AddRange(newList);
            list_view.ItemsSource = newList;
        }

        private void Export_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML files (*.xml)|*.xml";
            sfd.ShowDialog();

            List<Message> all = new List<Message>();
            all.AddRange(inbox);
            all.AddRange(sent);
            all.AddRange(trash);

            XmlSerializer serializer = new XmlSerializer(typeof(List<Message>));
            TextWriter writer = new StreamWriter(@sfd.FileName);
            serializer.Serialize(writer, all);
            writer.Close();
        }

        private void Layout2_Click(object sender, RoutedEventArgs e)
        {
            Grid.SetRowSpan(email_list, 1);
            Grid.SetColumnSpan(email_list, 2);
            Grid.SetRow(email_view, 2);
            Grid.SetColumn(email_view, 1);
            Grid.SetRowSpan(email_view, 1);
            Grid.SetColumnSpan(email_view, 2);
        }

        private void Layout1_Click(object sender, RoutedEventArgs e)
        {
            Grid.SetRowSpan(email_list, 2);
            Grid.SetColumnSpan(email_list, 1);
            Grid.SetRow(email_view, 1);
            Grid.SetColumn(email_view, 2);
            Grid.SetRowSpan(email_view, 2);
            Grid.SetColumnSpan(email_view, 1);
        }

        private void Inbox_Selected(object sender, RoutedEventArgs e)
        {
            list_view.ItemsSource = inbox;
        }

        private void Sent_Selected(object sender, RoutedEventArgs e)
        {
            list_view.ItemsSource = sent;
        }

        private void Trash_Selected(object sender, RoutedEventArgs e)
        {
            list_view.ItemsSource = trash;
        }

        //Presenting the selected e-mail to the side richtextbox and title
        private void select_Email(object sender, RoutedEventArgs e)
        {
            selectedEmail = (Message)(sender as Button).DataContext;
            StringReader stringReader = new StringReader(selectedEmail.Body);
            XmlReader xmlReader = XmlReader.Create(stringReader);
            Section sec = XamlReader.Load(xmlReader) as Section;
            FlowDocument doc = new FlowDocument();
            while (sec.Blocks.Count > 0)
                doc.Blocks.Add(sec.Blocks.FirstBlock);
            message.Document = doc;

            title.Text = selectedEmail.Subject;
        }


        //Deleting an e-mail or moving to thrash
        private void delete_Email(object sender, RoutedEventArgs e)
        {
            if (trash.Contains(selectedEmail))
            {
                MessageBoxResult messageBoxResult = MessageBox.Show("Are you sure you want this e-mail to be deleted?", "Delete Confirmation", MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    trash.Remove(selectedEmail);

                    title.Text = "";
                    message.Document.Blocks.Clear();
                    message.Document.Blocks.Add(new Paragraph(new Run("Email Deleted!")));
                    list_view.ItemsSource = trash;
                }
            }
            else
            {
                trash.Add(selectedEmail);
                if (inbox.Contains(selectedEmail))
                {
                    inbox.Remove(selectedEmail);
                    list_view.ItemsSource = inbox;
                }
                if (sent.Contains(selectedEmail))
                {
                    sent.Remove(selectedEmail);
                    list_view.ItemsSource = sent;
                }

                title.Text = "";
                message.Document.Blocks.Clear();
                message.Document.Blocks.Add(new Paragraph(new Run("Email moved to trash!"))); 
            }
        }

        //Opening the send Email window
        private void Send_Email(object sender, RoutedEventArgs e)
        {
            SendEmail window = new SendEmail();
            window.Topmost = true;
            window.Closed += on_Send_Message;
            window.Show();
        }

        //Moving the message to sent
        private void on_Send_Message(object sender, System.EventArgs e)
        {
            SendEmail window = (SendEmail)sender;
            if(window.message != null)
            {
                sent.Add(window.message);
            }
        }
        
        //Opening the e-mail inside the new window
        private void open_Email(object sender, MouseButtonEventArgs e)
        {
            SendEmail window = new SendEmail();
            window.subject.Text = selectedEmail.Subject;
            window.subject.IsReadOnly = true;

            StringReader stringReader = new StringReader(selectedEmail.Body);
            XmlReader xmlReader = XmlReader.Create(stringReader);
            Section sec = XamlReader.Load(xmlReader) as Section;
            FlowDocument doc = new FlowDocument();
            while (sec.Blocks.Count > 0)
                doc.Blocks.Add(sec.Blocks.FirstBlock);
            window.body.box.Document = doc;  


            window.body.box.IsReadOnly = true;
            window.copy.IsReadOnly = true;
            window.recipient.IsReadOnly = true;
            window.addAttachments.Visibility = Visibility.Hidden;
            window.sendEmail.Visibility = Visibility.Hidden;
            window.sendImm.Visibility = Visibility.Hidden;
            window.sendLater.Visibility = Visibility.Hidden;

            window.lbAttachments.ItemsSource = selectedEmail.attachments;

            window.Topmost = true;
            window.Show();
        }
    }
}
