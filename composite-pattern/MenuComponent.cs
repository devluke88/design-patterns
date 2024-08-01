using System;

namespace CompositePattern
{
    public abstract class MenuComponent
    {
        public void add(MenuComponent menuComponent)
        {
            throw new UnsupportedOperationException();
        }
        public void remove(MenuComponent menuComponent)
        {
            throw new UnsupportedOperationException();
        }
        public MenuComponent getChild(int i)
        {
            throw new UnsupportedOperationException();
        }

        public string getName()
        {
            throw new UnsupportedOperationException();
        }
        public string getDescription()
        {
            throw new UnsupportedOperationException();
        }
        public double getPrice()
        {
            throw new UnsupportedOperationException();
        }
        public bool isVegetarian()
        {
            throw new UnsupportedOperationException();
        }
        public void print()
        {
            throw new UnsupportedOperationException();
        }
    }
}