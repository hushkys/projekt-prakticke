# Safe — Events and Delegates (C#) (Safe — Události a delegáty)

This project demonstrates key Object-Oriented Programming (OOP) concepts in C#, including inheritance, delegates, and events. The `Safe` class inherits from `Cabinet` and fires an `Attack` event when an incorrect password is entered.

## Key Concepts

- **Inheritance:** The `Safe` class inherits from `Cabinet` using the `:` syntax. It inherits properties like height, width, depth, and the `Volume()` method.
- **Delegate:** `delegate void Del1()` defines a type for methods with no parameters and no return value. It acts as a type-safe method pointer.
- **Event:** `public event Del1 Attack` — this event is triggered on an incorrect password. Multiple handlers can be subscribed using the `+=` operator.
- **Properties:** `public bool Unlocked { get { return unlocked; } }` — encapsulates a private field with read-only access.

## Source Files

### Cabinet.cs
Base class for a cabinet with dimensions and volume calculation.

```csharp
using System;

namespace Systems
{
    class Cabinet
    {
        protected int height;
        protected int width;
        protected int depth;

        public Cabinet(int height, int width, int depth)
        {
            this.height = height;
            this.width = width;
            this.depth = depth;
        }

        public int Height { get { return height; } }
        public int Width  { get { return width; } }
        public int Depth { get { return depth; } }

        public int Volume()
        {
            return this.height * this.width * this.depth;
        }
    }
}
```

### Safe.cs
Inherits from Cabinet, adds password logic and the Attack event.

```csharp
using System;

namespace Systems
{
    delegate void Del1();   // delegate definition

    class Safe : Cabinet    // inheritance: Safe IS-A Cabinet
    {
        public event Del1 Attack;   // event triggered on wrong password
        private string password;
        private bool unlocked;

        // Default constructor calls parent constructor via base()
        public Safe() : base(5, 3, 2)
        {
            this.unlocked = false;
            this.password = "airplane";
        }

        // Overloaded constructor with custom password
        public Safe(string password) : base(5, 3, 2)
        {
            this.unlocked = false;
            this.password = password;
        }

        public bool Unlocked
        {
            get { return unlocked; }
        }

        public void Unlock(string input)
        {
            if (input == password)
                unlocked = true;
            else
                Attack();   // Fire event - calls all subscribed handlers
        }
    }
}
```

### Program.cs
Main entry point - creates a safe, subscribes handlers, and tests password entry.

```csharp
using System;

namespace Systems
{
    class Program
    {
        static void Main(string[] args)
        {
            Safe model1236 = new Safe("SecurePass123");

            // Subscribe handlers to the Attack event
            model1236.Attack += new Del1(Alarm);
            model1236.Attack += new Del1(CallPolice);

            string input = null;
            do
            {
                Console.Write("Enter safe password: ");
                input = Console.ReadLine();
                model1236.Unlock(input);
            }
            while (!model1236.Unlocked);

            Console.WriteLine("Safe is unlocked.");
            Console.WriteLine("Safe volume is: " + model1236.Volume());
            Console.ReadKey();
        }

        static void Alarm()
        {
            Console.WriteLine("ALARM TRIGGERED!");
            Console.Beep(440, 1000);
        }

        static void CallPolice()
        {
            Console.WriteLine("Dispatching police...");
        }
    }
}
```

---
[ Back to Overview](../../README.md)