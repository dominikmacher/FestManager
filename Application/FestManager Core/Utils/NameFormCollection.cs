using System;
using System.Collections.Generic;

namespace FestManager_Core.Utils
{
    [Serializable]
    public class NameFormCollection : SortedList<string, System.Windows.Forms.Form>
    {

        public System.Windows.Forms.Form Get(string name)
        {
            return this[name];
        }

    }
}
