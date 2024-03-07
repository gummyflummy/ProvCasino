using System;
using System.Collections.Generic;

namespace ProvCasino
{
    public class SlotMachine
    {
        private List<IObserver> observers = new List<IObserver>();
        private Random random = new Random();
        private int[] symbols = { 0, 1, 2 }; 
        private int[] result = new int[3];

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(result);
            }
        }

        public void Spin()
        {
            
            for (int i = 0; i < 3; i++)
            {
                result[i] = symbols[random.Next(0, symbols.Length)];
            }

            
            NotifyObservers();
        }
    }
}
