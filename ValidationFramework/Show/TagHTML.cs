using System;
using System.Collections.Generic;
using System.Text;
using ValidationFramework.Interface;

namespace ValidationFramework.Show
{
    public class TagHTML : ShowBehavior
    {
        public TagHTML()
        {

        }
        TypeShow.TypeNotification ShowBehavior.Show()
        {
            return TypeShow.TypeNotification.TagHTML;
        }
    }
}
