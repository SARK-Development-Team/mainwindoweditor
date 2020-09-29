using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MainWindowEditor
{
    public static class Assets
    {
        public static Dictionary<int, IconSet> StagesIcons { get; private set; }
        public static Dictionary<string, IconSet> Icons { get; private set; }
        public static Dictionary<Client.ContactStatus, DataGridViewCellStyle> CellStyles { get; private set; }
        public static Dictionary<string, MessageData> MessageTemplates { get; private set; }

        static Assets()
        {
            string assetsPath = @"C:\Users\ramsi\source\repos\SARK Client Manager\Assets\";

            StagesIcons = new Dictionary<int, IconSet>()
            {
                {
                    0, new IconSet()
                    {
                        Name = "phone",
                        Image = Image.FromFile(assetsPath + "phone.png"),
                        BackColor = Color.OrangeRed
                    }
                },
                {
                    1, new IconSet()
                    {
                        Name = "plane",
                        Image = Image.FromFile(assetsPath + "plane.png"),
                        BackColor = Color.Gold
                    }
                },
                {
                    2, new IconSet()
                    {
                        Name = "quote",
                        Image = Image.FromFile(assetsPath + "quote.png"),
                        BackColor = Color.OrangeRed
                    }
                },
                {
                    3, new IconSet()
                    {
                        Name = "sale",
                        Image = Image.FromFile(assetsPath + "sale.png"),
                        BackColor = Color.RoyalBlue
                    }
                }
            };

            Icons = new Dictionary<string, IconSet>()
            {
                {
                    "add", new IconSet()
                    {
                        Name = "add",
                        Image = Image.FromFile(assetsPath + "add.png"),
                        BackColor = Color.WhiteSmoke
                    }
                },
                {
                    "delete", new IconSet()
                    {
                        Name = "delete",
                        Image = Image.FromFile(assetsPath + "delete.png"),
                        BackColor = Color.Red
                    }
                },
                {
                    "update", new IconSet()
                    {
                        Name = "update",
                        Image = Image.FromFile(assetsPath + "update.png"),
                        BackColor = Color.LightSeaGreen
                    }
                },
                {
                    "comments", new IconSet()
                    {
                        Name = "comments",
                        Image = Image.FromFile(assetsPath + "comments.png"),
                        BackColor = Color.LightYellow
                    }
                },
                {
                    "email", new IconSet()
                    {
                        Name = "email",
                        Image = Image.FromFile(assetsPath + "email.png"),
                        BackColor = Color.WhiteSmoke
                    }
                },
                {
                    "sms", new IconSet()
                    {
                        Name = "sms",
                        Image = Image.FromFile(assetsPath + "sms.png"),
                        BackColor = Color.White
                    }
                },
                {
                    "history", new IconSet()
                    {
                        Name = "history",
                        Image = Image.FromFile(assetsPath + "history.png"),
                        BackColor = Color.Wheat
                    }
                },
                {
                    "back", new IconSet()
                    {
                        Name = "back",
                        Image = Image.FromFile(assetsPath + "back.png"),
                        BackColor = Color.SkyBlue
                    }
                },
                {
                    "transfer", new IconSet()
                    {
                        Name = "transfer",
                        Image = Image.FromFile(assetsPath + "transfer.png"),
                        BackColor = Color.White
                    }
                },
                {
                    "select", new IconSet()
                    {
                        Name = "select",
                        Image = Image.FromFile(assetsPath + "select.png"),
                        BackColor = Color.White
                    }
                },
            };

            CellStyles = new Dictionary<Client.ContactStatus, DataGridViewCellStyle>()
            {
                {
                    Client.ContactStatus.Not_Contacted, new DataGridViewCellStyle()
                    {
                        BackColor = Color.White,
                        ForeColor = Color.Black
                    }
                },
                {
                    Client.ContactStatus.Not_Interested, new DataGridViewCellStyle()
                    {
                        BackColor = Color.FromArgb(222, 66, 91),
                        ForeColor = Color.White
                    }
                },
                {
                    Client.ContactStatus.Purchased_Policy, new DataGridViewCellStyle()
                    {
                        BackColor = Color.FromArgb(99, 177, 121),
                        ForeColor = Color.DarkBlue
                    }
                },
                {
                    Client.ContactStatus.Future_Prospect, new DataGridViewCellStyle()
                    {
                        BackColor = Color.FromArgb(25, 130, 196),
                        ForeColor = Color.White
                    }
                },
                {
                    Client.ContactStatus.Contact_Later, new DataGridViewCellStyle()
                    {
                        BackColor = Color.FromArgb(255, 172, 197),
                        ForeColor = Color.Black
                    }
                },
                {
                    Client.ContactStatus.Interested, new DataGridViewCellStyle()
                    {
                        BackColor = Color.FromArgb(249, 226, 130),
                        ForeColor = Color.DarkRed
                    }
                }
            };

            MessageTemplates = new Dictionary<string, MessageData>()
            {
                {"Send Introduction", new MessageData()
                {
                    SMSText = "Hello "
                } }
            };
        }
    }

    public class IconSet
    {
        public Image Image { get; set; }
        public Color BackColor { get; set; }
        public string Name { get; set; }
    }

    public class MessageData
    {
        public string SMSText { get; set; }
        public string EmailPath { get; set; }
        public string EmailSubject { get; set; }
        public string EmailPreview { get; set; }
    }
}