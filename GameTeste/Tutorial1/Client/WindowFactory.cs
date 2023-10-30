using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using Tutorial1.Engine.Render;

namespace Tutorial1.Client
{
    public static class WindowFactory
    {
        public static IReadOnlyList<IRenderHost>  SeedWindows()
        {
            var size = new System.Drawing.Size(720, 480);


            var renderHosts = new[]
            {
                CreateWindowForm(size, "Game", h => new RenderHost(h))
            };

            return renderHosts;
        }

        private static IRenderHost CreateWindowForm(System.Drawing.Size size, string title, Func<IntPtr , IRenderHost> ctorRenderHost)
        {
            var window = new Form()
            {
                Size = size,
                Text = title,
            };
            var hostControl = new System.Windows.Forms.Panel
            {
                Dock = DockStyle.Fill,
                BackColor = System.Drawing.Color.Transparent,
                ForeColor = System.Drawing.Color.Transparent,
            };
            window.Controls.Add(hostControl);

            hostControl.MouseEnter += (sender, args) =>
            {
                if (Form.ActiveForm != window) window.Activate() ;
                if (!hostControl.Focused) hostControl.Focus() ;
            };
            window.Closed += (sender, args) => System.Windows.Application.Current.Shutdown();

            window.Show();

            return ctorRenderHost(hostControl.Handle);
        }

        //private static IRenderHost CreateWindowPf(System.Drawing.Size size, string title, Func<IntPtr, IRenderHost> ctorRenderHost)
        //{
        //    var window = new Window()
        //    {
        //        Height = size.Height,
        //        Width = size.Width,
        //        Title = title,
        //    };
        //    var hostControl = new Grid
        //    {
        //        Background = System.Windows.Media.Brushes.Transparent,
        //        Focusable = true,
        //    };
        //    window.Content = hostControl;

        //    hostControl.MouseEnter += (sender, args) =>
        //    {
        //        if (window.IsActive) window.Activate();
        //        if (!hostControl.IsFocused) hostControl.Focus();
        //    };

        //    window.Closed += (sender, args) => System.Windows.Application.Current.Shutdown();

        //    window.Show();

        //    return ctorRenderHost(hostControl.handle());
        //}
    }
}
