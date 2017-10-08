using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IosIoC;

namespace DashboardSignalR.Dominio
{
    public abstract class Application
    {
        /// <summary>
        /// Initialize Domain App
        /// </summary>
        public static void Init()
        {
            //put here all checks and loading methods

        }

        internal static IContainer Container
        {
            get
            {
                return IosIoC.Container.Instance;
            }
        }
    }
}
