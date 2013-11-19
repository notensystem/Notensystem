using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Notensystem.Core;

namespace Notensystem.DataAccess
{
    [Serializable]
    public class DatabaseConnection
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool modified;
        public bool Modified
        {
            get { return modified; }
            set
            {
                modified = value;
                OnPropertyChanged();
            }
        }

        private string ip;
        [XmlElement]
        public string Ip
        {
            get { return ip; }
            set
            {
                ip = value;
                OnPropertyChanged();
                OnPropertyChanged("Modified");
            }
        }

        private int port;
        [XmlElement]
        public int Port
        {
            get { return port; }
            set
            {
                port = value;
                OnPropertyChanged();
                OnPropertyChanged("Modified");
            }
        }

        private string database;
        [XmlElement]
        public string Database
        {
            get { return database; }
            set
            {
                database = value;
                OnPropertyChanged();
                OnPropertyChanged("Modified");
            }
        }

        private string user;
        [XmlElement]
        public string User
        {
            get { return user; }
            set
            {
                user = value;
                OnPropertyChanged();
                OnPropertyChanged("Modified");
            }
        }

        private string password;
        [XmlElement]
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged();
                OnPropertyChanged("Modified");
            }
        }

        public string ConnectionString
        {
            get
            {
                return string.Format("server={0};port={1};database={2};user id={3};password={4};", Ip, Port, Database, User, Password);
            }
        }

        public DatabaseConnection(string ip, int port, string database, string user, string password)
        {
            Ip = ip;
            Port = port;
            User = user;
            Password = password;
            Database = database;
            Modified = false;
        }

        public DatabaseConnection() { }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var eventHandler = this.PropertyChanged;
            if (eventHandler != null)
            {
                eventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void Write()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DatabaseConnection));
            using (TextWriter writer = new StreamWriter(Const.ConfigFileName))
            {
                serializer.Serialize(writer, this);
            }
        }

        public static DatabaseConnection Read()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DatabaseConnection));
            using (TextReader writer = new StreamReader(Const.ConfigFileName))
            {
                return serializer.Deserialize(writer) as DatabaseConnection;
            }
        }
    }
}
