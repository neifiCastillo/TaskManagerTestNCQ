using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors.Repository;


namespace TaskManager.WinForms.UI.Helpers
{
    public static class LegendBuilder
    {
        public static void BuildLegend(PanelControl panel, (Image Icon, string Text)[] items, string title = "LEYENDA DE ACCIONES")
        {
            panel.Controls.Clear();
            panel.BorderStyle = BorderStyles.Default;
            panel.Appearance.BackColor = Color.WhiteSmoke;
            panel.Dock = DockStyle.None;

            // Title
            LabelControl lblTitle = new LabelControl();
            lblTitle.Text = title;
            lblTitle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Padding = new Padding(5, 0, 0, 10);
            panel.Controls.Add(lblTitle);

            // Conteiner
            FlowLayoutPanel container = new FlowLayoutPanel();
            container.FlowDirection = FlowDirection.TopDown;
            container.Dock = DockStyle.Fill;
            container.WrapContents = false;
            container.AutoScroll = true;
            container.Padding = new Padding(5, 25, 0, 0);

            panel.Controls.Add(container);

            // Items
            foreach (var item in items)
            {
                container.Controls.Add(CreateLegendItem(item.Icon, item.Text));
            }
        }
        public static Panel CreateLegendItem(Image icon, string text)
        {
            Panel p = new Panel
            {
                Width = 230,
                Height = 40,
                Margin = new Padding(5, 5, 0, 5)
            };

            PictureEdit pic = new PictureEdit
            {
                Image = icon,
                Properties =
                {
                    BorderStyle = BorderStyles.NoBorder,
                    Appearance = { BackColor = Color.Transparent },
                    SizeMode = PictureSizeMode.Squeeze
                },
                Size = new Size(32, 32),
                Location = new Point(5, 4)
            };

            LabelControl lbl = new LabelControl
            {
                Text = text,
                Location = new Point(45, 10),
                Font = new Font("Segoe UI", 10)
            };

            p.Controls.Add(pic);
            p.Controls.Add(lbl);

            return p;
        }
    }
}
