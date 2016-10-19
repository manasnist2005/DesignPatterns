using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityFramework
{
    public interface IPlayer
    {
        string PlayerName
        {
            get;
            set;
        }
        string TeamName
        {
            get;
            set;
        }

        string JerseyColour
        {
            get;
            set;
        }
        void DisplayDetails();
    }
}
