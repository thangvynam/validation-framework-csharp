using System;
using System.Collections.Generic;
using System.Text;
using ValidationFramework.Interface;

namespace ValidationFramework.Show
{
    public class Alert : ShowBehavior
    {
        public Alert()
        {

        }
        TypeShow.TypeNotification ShowBehavior.Show()
        {
            return TypeShow.TypeNotification.Alert;
        }
        
    }
}
