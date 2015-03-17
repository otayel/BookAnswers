using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3CSharp
{
    class AnimalShelter
    {
        Queue<Animal> dogs;
        Queue<Animal> cats;

        public AnimalShelter()
        {
            dogs = new Queue<Animal>();
            cats = new Queue<Animal>();
        }

        public void Enqueue(AnimalType animalType)
        {
            switch (animalType)
            {
                case AnimalType.Cat:
                    cats.Enqueue(new Animal(animalType));
                    break;
                case AnimalType.Dog:
                    dogs.Enqueue(new Animal(AnimalType.Dog));
                    break;
                default:
                    break;
            }
        }


        public Animal DequeueDog()
        {
            if (dogs.Count == 0)
            {
                throw new Exception("There are no Dogs in the shelter");
            }
            else
            {
                return dogs.Dequeue();
            }
        }

        public Animal DequeueCat()
        {
            if (cats.Count == 0)
            {
                throw new Exception("There are no Dogs in the shelter");
            }
            else
            {
                return cats.Dequeue();
            }
        }

        public Animal DequeueAny()
        {
            if(cats.Count == 0 && dogs.Count == 0)
            {
                throw new Exception("There are no Dogs nor Cats in the shelter");
            }
            else if (cats.Count == 0)
            {
                return DequeueDog();
            }
            else if (dogs.Count == 0)
            {
                return DequeueCat();
            }
            else
            {
                var cat = cats.Peek();
                var dog = dogs.Peek();

                if (cat.TimeStamp < dog.TimeStamp)
                {
                    return cats.Dequeue();
                }
                else
                {
                    return dogs.Dequeue();
                }
            }
        }
    }

    class Animal
    {
        AnimalType type;
        DateTime timeStamp;

        public DateTime TimeStamp { get { return this.timeStamp; } }
        public AnimalType Type { get { return this.type; } }

        public Animal(AnimalType _type)
        {
            this.type = _type;
            timeStamp = DateTime.Now;
        }
    }

    enum AnimalType
    {
        Cat,
        Dog
    }
}
