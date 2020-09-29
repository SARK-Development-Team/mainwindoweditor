using System;
using System.Drawing;
using System.Windows.Forms;

namespace MainWindowEditor
{
    public partial class SubmitPanel : UserControl
    {
        public int Stage { get; set; }
        public SubmitPanel()
        {
            InitializeComponent();
            InitializeButtons();
            foreach (Panel panel in Controls)
            {
                if (panel.Visible)
                {
                    panel.Visible = false;
                }
            }
        }

        public void InitializeButtons()
        {
            sendintroButton.Click += StageHandler;
            sendquoteButton.Click += StageHandler;
            sendreminderButton.Click += StageHandler;
        }

        private void StageHandler(object sender, EventArgs e)
        {
            StagesPanelOLD stagesPanel = (Parent.FindForm() as MainWindow).GetChild("stagesPanel") as StagesPanelOLD;
            stagesPanel.ProgressStage(++Stage);
            ProgressStagePanel(Stage);
        }

        public void ProgressStagePanel(int stage)
        {
            if (stage < 4)
            {
                Panel[] buttonPanels = { stage0panel, stage1panel, stage2panel, stage3panel };
                BackColor = Color.FromArgb(
                    alpha: Assets.StagesIcons[stage].BackColor.A - 100,
                    Assets.StagesIcons[stage].BackColor);
                buttonPanels[stage].BackColor = BackColor;
                foreach (Panel panel in Controls)
                {
                    if (panel.Visible)
                    {
                        panel.Visible = false;
                    }
                }
                buttonPanels[stage].Visible = true;
            }
        }
    }
}
