using System.Collections.Generic;

namespace Iterator
{
   public interface Iterator
   {
      bool hasNext();
      object next();
   }

   public class DinnerMenuIterator : Iterator {
        MenuItem[] items;
        int position = 0;
    
        public DinnerMenuIterator(MenuItem[] items) {
             this.items = items;
        }
    
        public object next() {
             MenuItem menuItem = items[position];
             position = position + 1;
             return menuItem;
        }
    
        public bool hasNext() {
             if (position >= items.Length || items[position] == null) {
                return false;
             } else {
                return true;
             }
        }
   }

   public class PancakeHouseMenuIterator : Iterator {
        List<MenuItem> items;
        int position = 0;
    
        public PancakeHouseMenuIterator(List<MenuItem> items) {
             this.items = items;
        }
    
        public object next() {
             MenuItem menuItem = items[position];
             position = position + 1;
             return menuItem;
        }
    
        public bool hasNext() {
             if (position >= items.Count || items[position] == null) {
                return false;
             } else {
                return true;
             }
        }
   }
}