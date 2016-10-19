using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectFramework
{
    class Program
    {
        public interface IWeapon
        {
            void sord();
        }
        public class Ninja : IWeapon
        {
            public void sord()
            {
                Console.WriteLine("I am using Sord");
            }
        }

        public class sourav
        {
            IWeapon ObjWeapon = null;
            public sourav(IWeapon tmpWeapon)
            {
                this.ObjWeapon = tmpWeapon;
            }

            public void Attack()
            {
                this.ObjWeapon.sord();
            }
        }
        static void Main(string[] args)
        {
            Ninject.IKernel kernal = new StandardKernel();
            kernal.Bind<IWeapon>().To<Ninja>();
            var instance = kernal.Get<sourav>();
            instance.Attack();
            Console.ReadLine();
        }
    }
}
