using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using TaskManager.Application.Services;
using TaskManager.Domain.Enums;
using TaskStatus = TaskManager.Domain.Enums.TaskStatus;

namespace TaskManager.WinForms.UI.Forms
{
    public partial class DashboardForm: XtraForm
    {
        private readonly TaskService _taskService;
        private Panel? cardPending, cardInProgress, cardDone;
        private Label? lblPending, lblInProgress, lblDone;
        private ChartControl? chart;
        public DashboardForm(TaskService taskService)
        {
            InitializeComponent();
            _taskService = taskService;
            BuildUI();
            LoadData();
        }
        private void BuildUI()
        {
            this.Text = "Dashboard";
            this.BackColor = Color.WhiteSmoke;
            this.Width = 900;
            this.Height = 900;

            FlowLayoutPanel panelTop = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 150,
                FlowDirection = FlowDirection.LeftToRight,
                Padding = new Padding(20),
                BackColor = Color.White
            };

            this.Controls.Add(panelTop);

            cardPending = CreateCard("Pendientes", Color.Gold);
            cardInProgress = CreateCard("En proceso", Color.LightSkyBlue);
            cardDone = CreateCard("Completadas", Color.LightGreen);

            panelTop.Controls.Add(cardPending);
            panelTop.Controls.Add(cardInProgress);
            panelTop.Controls.Add(cardDone);

            chart = new ChartControl
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };

            this.Controls.Add(chart);
        }
  
        private Panel CreateCard(string title, Color color)
        {
            Panel p = new Panel
            {
                Width = 250,
                Height = 120,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(0, 0, 0, 100),
            };

            Label lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            Label lblValue = new Label
            {
                Text = "0",
                Font = new Font("Segoe UI", 32, FontStyle.Bold),
                ForeColor = color,
                Location = new Point(10, 40),
                AutoSize = true
            };

            p.Controls.Add(lblTitle);
            p.Controls.Add(lblValue);

            if (title.Contains("Pend"))
                lblPending = lblValue;
            if (title.Contains("proceso"))
                lblInProgress = lblValue;
            if (title.Contains("Comple"))
                lblDone = lblValue;

            return p;
        }
        private void LoadData()
        {
            var tasks = _taskService.GetTasks(null).ToList();

            lblPending!.Text = tasks.Count(x => x.Status == TaskStatus.Pending).ToString();
            lblInProgress!.Text = tasks.Count(x => x.Status == TaskStatus.InProgress).ToString();
            lblDone!.Text = tasks.Count(x => x.Status == TaskStatus.Done).ToString();

            BuildChart(tasks);
        }
        private void BuildChart(System.Collections.Generic.List<TaskManager.Domain.Entities.TaskItem> tasks)
        {
            chart!.Series.Clear();

            Series series = new Series("Tareas por prioridad", ViewType.Bar);

            series.Points.Add(new SeriesPoint("Alta", tasks.Count(x => x.Priority == TaskPriority.High)));
            series.Points.Add(new SeriesPoint("Media", tasks.Count(x => x.Priority == TaskPriority.Medium)));
            series.Points.Add(new SeriesPoint("Baja", tasks.Count(x => x.Priority == TaskPriority.Low)));

            chart.Series.Add(series);

            ((XYDiagram)chart.Diagram).AxisX.Title.Text = "Prioridad";
            ((XYDiagram)chart.Diagram).AxisY.Title.Text = "Cantidad";
        }
    }
}
