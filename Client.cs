using System;
using System.Collections.Generic;

namespace MainWindowEditor
{
    public class Client
    {
        public enum ContactStatus
        {
            Not_Contacted,
            Purchased_Policy,
            Not_Interested,
            Interested,
            Contact_Later,
            Future_Prospect
        }

        public enum ClientType
        {
            CA_Proportional,
            Other,
            Custom
        }

        public enum Stage
        {
            Intro,
            Quote,
            Interval,
            Completed
        }

        //General Client details.
        public string DOT { get; set; }

        public string MC { get; set; }
        public string Name { get; set; }
        public string DBAName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string MailingAddress { get; set; }
        public string SAFERType { get; set; }
        public int PowerUnits { get; set; }
        public int Drivers { get; set; }
        public bool Authorized { get; set; }
        public DateTime DateAdded { get; set; }

        public AppData Data { get; set; } = new AppData();

        public class AppData
        {
            public int StaffID { get; set; }
            public string Comments { get; set; }
            public string History { get; set; }
            public ClientType Schema { get; set; }
            public ContactStatus Status { get; set; }
            public Stage Stage { get; set; }

            public List<LogItem> StatusLog { get; set; }
        }

        public class UpdateInfo
        {
            public Int64? Sync_Change_Version { get; set; }
            public Int64? Sync_Creation_Version { get; set; }
            public string Change_Operation { get; set; }
        }
    }

    public class LogItem
    {
        public enum Event
        {
            Client_Added,
            Client_Deleted,
            Client_Updated,
            Email_Sent,
            SMS_Sent,
            Comment,
            Transfer,
            Stage_0,
            Stage_1,
            Stage_2,
            Stage_3,
            Placeholder
        }

        public Event StatusEvent { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
    }
}