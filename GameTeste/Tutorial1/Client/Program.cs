using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using Tutorial1.Engine.Render;
using Tutorial1.Utils;

namespace Tutorial1.Client
{
    internal class Program : System.Windows.Application, IDisposable
    {
        #region // ctor
        private IReadOnlyList<IRenderHost> RenderHosts {  get; set; }

        public Program()
        {
            Startup += (sender, args) => Ctor();
            Exit += (sender, args) => Dispose();
        }

        private void Ctor()
        {
           RenderHosts = WindowFactory.SeedWindows();
        }

        public void Dispose()
        {
            RenderHosts.ForEach(x => x.Dispose());
            RenderHosts = default;
        }

        #endregion

    }
}
