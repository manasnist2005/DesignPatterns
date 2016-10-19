using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace UnityFramework
{
    public class Factory
    {
        public static IPlayer CreateInstance()
        {
            IUnityContainer _container = new UnityContainer();
            _container.RegisterType(typeof(IPlayer), typeof(Player));
            _container.RegisterType(typeof(IPlayer), typeof(FootballPlayer));
            
            IPlayer obj = _container.Resolve<IPlayer>();
            return obj;
        }
    }
}
