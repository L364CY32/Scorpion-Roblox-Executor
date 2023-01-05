using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KrnlAPI;

namespace KrnlAPIWinForms
{
    internal class KrnlAPI
    {
        internal static void Start()
        {
            MainAPI.Load();
            
            MainAPI.AutoAttach(true);
            MainAPI.RemoveInstaller = false; 
        }
    }
}
