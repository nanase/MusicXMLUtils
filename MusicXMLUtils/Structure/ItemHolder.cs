using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MusicXMLUtils.Structure
{
    public abstract class ItemHolder<T>
    {
        private List<Tuple<T, object>> items = null;

        [XmlIgnore]
        public abstract object[] Items { get; set; }

        [XmlIgnore]
        public abstract T[] ItemsElementName { get; set; }

        public void InitalizeItems()
        {
            if (this.items == null)
                this.items = new List<Tuple<T, object>>();
            else
                this.items.Clear();
        }

        public void AddItem(T elementName, object item)
        {
            if (this.items == null)
                this.InitalizeItems();

            this.items.Add(new Tuple<T, object>(elementName, item));
        }

        public void ApplyItems()
        {
            if (this.items == null)
                this.InitalizeItems();

            int count = this.items.Count;
            this.Items = new object[count];
            this.ItemsElementName = new T[count];

            for (int i = 0; i < count; i++)
            {
                var item = this.items[i];
                this.Items[i] = item.Item2;
                this.ItemsElementName[i] = item.Item1;
            }

            this.items.Clear();
            this.items = null;
        }
    }
}
