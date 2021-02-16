using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Model
{
    public class Item<T>
    {
        private T data = default(T);
        public T Data
        {
            get => data;
            set
            {
                if (value == null) 
                    throw new ArgumentNullException(nameof(value));
                else
                    data = value;
            } 
        }
        public Item<T> Next { get; set; }

        public Item(T data)
        {
            this.data = data;
        }

        public override string ToString() => Data.ToString();


    }
}
