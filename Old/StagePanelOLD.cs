using System.Drawing;
using System.Windows.Forms;

namespace MainWindowEditor
{
    public partial class StagesPanelOLD : UserControl
    {
        public MainWindow Main { get; set; }
        public StagesPanelOLD()
        {
            InitializeComponent();
            InitializeStages();
        }

        public void InitializeStages()

        {
            //Goal: Make a progress wizard out of the stagesPanel.
            int iconSize = 43;
            int ogwidth = mainPanel.Width;
            mainPanel.BackColor = Color.FromArgb(220, 240, 245);
            MakeIcons(iconSize, mainPanel.BackColor, Color.White);
            FormatStages(30, 5);

            this.mainPanel.SizeChanged += (s, l) =>
            {
                Panel[] lines = { line1, line2, line3 };
                foreach (var line in lines)
                {
                    FormatStages((int)(30.0 * ogwidth / mainPanel.Width), 5);
                }
            };
        }

        public void FormatStages(int stagesPadding, int linePadding)
        {
            //Ok, first lets position all the outer panels to be vertically center and spread in the stagesPanel.
            Panel[] outerPanels = { phoneouterPanel, quoteouterPanel, saleouterPanel, policyouterPanel };
            Panel[] lines = { line1, line2, line3 };

            //Center-left and center-right points of a padded panel.
            Point start = new Point(0, 0);
            Point end = new Point(start.X + mainPanel.Width - stagesPadding, start.Y + mainPanel.Height / 2);
            start.Offset(stagesPadding, mainPanel.Height / 2);

            //Split the distance between start and end depending on number of elements. In this case x = 4
            //(x-1)y + outerPanel.Length*x = end.X - start.X = 3Y + outPanel.Length * 4
            int spacebetween = ((end.X - start.X) - outerPanels[0].Width * 4) / 3;

            for (int i = 0; i < outerPanels.Length; i++)
            {
                if (i == 0)
                {
                    outerPanels[i].Location = new Point(start.X, start.Y - outerPanels[i].Height / 2);
                }
                else
                {
                    Point prev = outerPanels[i - 1].Location;
                    lines[i - 1].Location = new Point(prev.X + outerPanels[i - 1].Width + linePadding,
                                                    start.Y - lines[i - 1].Height / 2);
                    lines[i - 1].Width = spacebetween - 2 * linePadding;
                    outerPanels[i].Location = new Point(prev.X + outerPanels[i - 1].Width + spacebetween,
                                                        prev.Y);
                }
            }
        }

        public void MakeIcons(int iconSize, Color borderColor, Color iconColor)
        {
            //Great. Now that all the icons have been taken care of. Let's color these suckers up.
            //Step 1: Replace the generic icon with its proper stage icon.
            phoneinnerPanel.BackgroundImage = Assets.StagesIcons[0].Image;
            quoteinnerPanel.BackgroundImage = Assets.StagesIcons[1].Image;
            policyinnerPanel.BackgroundImage = Assets.StagesIcons[2].Image;
            saleinnerPanel.BackgroundImage = Assets.StagesIcons[3].Image;

            Panel[] outerPanels = { phoneouterPanel, quoteouterPanel, saleouterPanel, policyouterPanel };
            Panel[] innerPanels = { phoneinnerPanel, quoteinnerPanel, saleinnerPanel, policyinnerPanel };
            Panel[] lines = { line1, line2, line3 };

            //Draws the background circle for the icons.
            foreach (var pan in outerPanels)
            {
                pan.Size = new Size((int)(iconSize * 1.41), (int)(iconSize * 1.41));
                pan.Padding = new Padding(17);
                pan.Paint += (s, pevent) =>
                {
                    var gfx = pevent.Graphics;
                    gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    var brush = new SolidBrush(iconColor);
                    gfx.FillEllipse(brush, pevent.ClipRectangle);

                    Pen borderpen = new Pen(borderColor, 5);
                    gfx.DrawEllipse(borderpen, WinformsHelper.ShrinkBorder(pevent.ClipRectangle, 10));
                };
            }


            foreach (var pan in innerPanels)
            {
                pan.Size = new Size(iconSize, iconSize);
                pan.BackColor = iconColor;
            }

            foreach (var line in lines)
            {
                line.BackColor = Color.White;
            }
        }

        //Each stage of progress causes a few things to occur:
        //a) Colors all change appropriately for the bottom half of the screen.
        //b) Panel buttons and labels now change.
        public void ProgressStage(int stage)
        {
            Panel[] outerPanels = { phoneouterPanel, quoteouterPanel, saleouterPanel, policyouterPanel };
            Panel[] innerPanels = { phoneinnerPanel, quoteinnerPanel, saleinnerPanel, policyinnerPanel };
            Panel[] lines = { line1, line2, line3 };

            if (stage < outerPanels.Length)
            {
                innerPanels[stage].BackColor = Assets.StagesIcons[stage].BackColor;
                outerPanels[stage].Paint += (s, pevent) =>
                {
                    var gfx = pevent.Graphics;
                    gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    var brush = new SolidBrush(Assets.StagesIcons[stage].BackColor);
                    gfx.FillEllipse(brush, pevent.ClipRectangle);

                    Pen borderpen = new Pen(Color.White, 5);
                    gfx.DrawEllipse(borderpen, WinformsHelper.ShrinkBorder(pevent.ClipRectangle, 10));

                    if (stage > 0)
                    {
                        lines[stage - 1].BackColor = Assets.StagesIcons[stage - 1].BackColor;
                    }

                };
                Refresh();
            }

        }
    }
}
