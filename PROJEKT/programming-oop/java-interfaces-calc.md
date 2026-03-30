# Interface Calculations (Java) (Interface — Výpočty)

This project demonstrates the use of Interfaces in Java to define a contract for calculation operations.

## Key Concepts

- **Interface:** Defines a contract (what a class must do) without providing the implementation.
- **Implements:** The keyword used by a class to fulfill an interface contract.
- **Polymorphism:** An interface variable can reference any class that implements that interface.

## Source Files

### ICalculation.java
The interface defining the calculation contract.

```java
public interface ICalculation {
    // Methods are implicitly public and abstract
    int execute(int x, int y);
}
```

### Addition.java
Concrete implementation for adding two numbers.

```java
public class Addition implements ICalculation {
    @Override
    public int execute(int x, int y) {
        return x + y;
    }
}
```

### Subtraction.java
Concrete implementation for subtracting two numbers.

```java
public class Subtraction implements ICalculation {
    @Override
    public int execute(int x, int y) {
        return x - y;
    }
}
```

### Calculator.java
Using polymorphic behavior to execute different calculations.

```java
public class Calculator {
    public static void main(String[] args) {
        ICalculation op1 = new Addition();
        ICalculation op2 = new Subtraction();

        System.out.println("10 + 5 = " + op1.execute(10, 5));
        System.out.println("10 - 5 = " + op2.execute(10, 5));
    }
}
```

---
[ Back to Overview](../../README.md)