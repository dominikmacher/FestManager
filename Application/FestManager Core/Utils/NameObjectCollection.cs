using System;
using System.Collections;

namespace FestManager_Core.Utils
{
	/// <summary>
	/// </summary>
    [Serializable]
    public class NameObjectCollection : SortedList
    {
	    /// <summary>
        /// </summary>
        /// <param name="name">
        /// </param>
        /// <param name="value">
        /// </param>
        public virtual void Add(string name, object value)
        {
            base.Add(name.ToLower(), value);
        }

        /// <summary>
        /// </summary>
        public virtual object this[string name]
        {
            get
            {
                return Get(name.ToLower());
            }
            set
            {
                Set(name.ToLower(), value);
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="name">
        /// </param>
        /// <returns>
        /// </returns>
        public virtual object Get(string name)
        {
            return base[name.ToLower()];
        }

        /// <summary>
        /// </summary>
        /// <param name="name">
        /// </param>
        /// <param name="value">
        /// </param>
        public virtual void Set(string name, object value)
        {
            base[name.ToLower()] = value;
        }

        /// <summary>
        /// </summary>
        /// <param name="name">
        /// </param>
        public virtual void Remove(string name)
        {
            base.Remove(name.ToLower());
        }
    }
}
