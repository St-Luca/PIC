﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIC.CatchingApp;

namespace PIC
{
    internal class CatchingApplicationController
    {

        public static bool CanAddCatchingApplication(int userPermissionCode)
        { //смотрим на код юзера, т.е. его права в системе.
            return true;
        }

        public static void AddCatchingApplication(CatchingApplication ca)
        {
            //connection with db and parsing fields
        }

        public void DeleteCatchingApplication(CatchingApplication ca)
        {

        }

        public void ChangeCatchingApplication(CatchingApplication ca)
        {

        }
    }
}
