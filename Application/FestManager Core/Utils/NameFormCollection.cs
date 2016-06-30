using System;
using System.Collections;

namespace FestManager_Core.Utils
{
    /// <summary>
    /// </summary>
    [Serializable]
    public class NameFormCollection : SortedList
    {
        /// <summary>
        /// </summary>
        /// <param name="name">
        /// </param>
        /// <param name="value">
        /// </param>
        public virtual void Add(string name, System.Windows.Forms.Form value)
        {
            base.Add(name, value);
        }

        /// <summary>
        /// </summary>
        public virtual System.Windows.Forms.Form this[string name]
        {
            get
            {
                return Get(name);
            }
            set
            {
                Set(name, value);
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="name">
        /// </param>
        /// <returns>
        /// </returns>
        public virtual System.Windows.Forms.Form Get(string name)
        {
            return (System.Windows.Forms.Form) base[name];
        }

        /// <summary>
        /// </summary>
        /// <param name="name">
        /// </param>
        /// <param name="value">
        /// </param>
        public virtual void Set(string name, System.Windows.Forms.Form value)
        {
            base[name] = value;
        }

        /// <summary>
        /// </summary>
        /// <param name="name">
        /// </param>
        public virtual void Remove(string name)
        {
            base.Remove(name);
        }
    }
}
