﻿namespace After010
{
    using System;

    internal interface IAnimal
    {
        int NumberOfLegs { get; }

        void Vocalize();
    }

    internal abstract class AnimalBase : IAnimal
    {
        private readonly string _sound;

        protected AnimalBase(int numberOfLegs, string sound)
        {
            this.NumberOfLegs = numberOfLegs;
            this._sound = sound;
        }

        public int NumberOfLegs { get; private set; }

        public void Vocalize()
        {
            Console.WriteLine(this._sound);
        }
    }

    internal class Dog : AnimalBase
    {
        public Dog()
            : base(4, "woof!")
        {
        }
    }

    internal class Monkey : AnimalBase
    {
        public Monkey()
            : base(2, "<monkey sound/>!")
        {
        }
    }
}