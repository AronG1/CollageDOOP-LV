using System;
using System.Collections.Generic;
using System.Text;

namespace LV_6
{
    interface IAbstractIterator
    {
        Note First();
        Note Next();
        bool IsDone { get; }
        Note Current { get; }
    }
    interface IAbstractCollection
    {
        IAbstractIterator GetIterator();
    }
    class Notebook
    {
        public Note this[int index] { get { return this.notes[index]; } }

        private List<Note> notes;
        public Notebook() { this.notes = new List<Note>(); }
        public Notebook(List<Note> notes)
        {
            this.notes = new List<Note>(notes.ToArray());
        }
        public void AddNote(Note note) { this.notes.Add(note); }
        public void RemoveNote(Note note) { this.notes.Remove(note); }
        public void Clear() { this.notes.Clear(); }
        public int Count { get { return this.notes.Count; } }
        
        public IAbstractIterator GetIterator() { return new Iterator(this); }

    }
    class Product
    {
        public string Description { get; private set; }
        public double Price { get; private set; }
        public Product(string description, double price)
        {
            this.Description = description;
            this.Price = price;
        }
        public override string ToString()
        {
            return this.Description + ":\n" + this.Price;
        }
    }
    class Box
    {
        private List<Product> products;
        public Box() { this.products = new List<Product>(); }
        public Box(List<Product> products)
        {
            this.products = new List<Product>(products.ToArray());
        }
        public void AddProduct(Product product) { this.products.Add(product); }
        public void RemoveProduct(Product product) { this.products.Remove(product); }
        public int Count { get { return this.products.Count; } }
    }


}
