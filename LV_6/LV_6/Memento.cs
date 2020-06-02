using System;
using System.Collections.Generic;
using System.Text;

namespace LV_6
{
    class Memento
    {
        public string Title { get; private set; }
        public string Text { get; private set; }
        public DateTime TimeDue { get; private set; }
        public DateTime CreationTime { get; private set; }
        public Memento(string title, string text, DateTime timeDue, DateTime creationTime)
        {
            this.Title = title;
            this.Text = text;
            this.TimeDue = timeDue;
            this.CreationTime = creationTime;
        }
        public class CareTaker
        {
            public Memento PreviousState { get; set; }
            public Dictionary<string, Memento> PreviousStates { get; set; }

            public CareTaker()
            {
                this.PreviousStates = new Dictionary<string, Memento>();
            }
            public void AddState(Memento memento)
            {
                PreviousStates.Add(memento.Title, memento);
            }

            public Dictionary<string, Memento> GetDictionary()
            {
                return this.PreviousStates;
            }

            public Memento GetByTitle(string title)
            {
                if (!PreviousStates.ContainsKey(title))
                {
                    Console.WriteLine("Cant find in dictionary!");
                    return null;
                }

                else
                {
                    Memento memento = PreviousStates[title];
                    return memento;
                }

            }
        }
        class BankAccount
        {
            private string ownerName;
            private string ownerAddress;
            private decimal balance;
            public BankAccount(string ownerName, string ownerAddress, decimal balance)
            {
                this.ownerName = ownerName;
                this.ownerAddress = ownerAddress;
                this.balance = balance;
            }
            public void ChangeOwnerAddress(string address)
            {
                this.ownerAddress = address;
            }
            public void UpdateBalance(decimal amount) { this.balance += amount; }
            public string OwnerName { get { return this.ownerName; } }
            public string OwnerAddress { get { return this.ownerAddress; } }
            public decimal Balance { get { return this.balance; } }
        }
    }
}
