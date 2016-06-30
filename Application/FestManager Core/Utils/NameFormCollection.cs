using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FestManager_Core.Utils
{
    /// <summary>
    /// </summary>
    [Serializable]
    public class NameFormCollection : SortedList
    {
        /// <summary>
        /// </summary>
        public NameFormCollection() : base() { }

        /// <summary>
        /// </summary>
        /// <param name="Name">
        /// </param>
        /// <param name="Value">
        /// </param>
        public virtual void Add(string Name, System.Windows.Forms.Form Value)
        {
            base.Add(Name, Value);
        }

        /// <summary>
        /// </summary>
        public virtual System.Windows.Forms.Form this[string Name]
        {
            get
            {
                return (System.Windows.Forms.Form)this.Get(Name);
            }
            set
            {
                this.Set(Name, value);
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="Name">
        /// </param>
        /// <returns>
        /// </returns>
        public virtual System.Windows.Forms.Form Get(string Name)
        {
            return (System.Windows.Forms.Form) base[Name];
        }

        /// <summary>
        /// </summary>
        /// <param name="Name">
        /// </param>
        /// <param name="Value">
        /// </param>
        public virtual void Set(string Name, System.Windows.Forms.Form Value)
        {
            base[Name] = Value;
        }

        /// <summary>
        /// </summary>
        /// <param name="Name">
        /// </param>
        public virtual void Remove(string Name)
        {
            base.Remove(Name);
        }
    }
}
