# Abstract Classes — Employees (Java) (Abstraktní třídy — Zaměstnanci)

This project demonstrates inheritance and polymorphic behavior using an abstract `Employee` base class. Each employee subtype implements its own version of the `work()` method.

## Key Concepts

- **Abstract Class:** Cannot be directly instantiated — serves as a template for subclasses.
- **Inheritance:** Using the `extends` keyword to inherit fields and methods from a parent class.
- **Method Overriding (@Override):** Redefining a parent's method in a subclass to provide specific behavior.
- **Polymorphism:** Using a parent type (`Employee`) to reference any subclass object (`Director`, `Secretary`).

## Source Files

### Employee.java
The abstract base class for all employee types.

```java
public abstract class Employee {
    protected String name;
    protected int age;

    public Employee(String name, int age) {
        this.name = name;
        this.age = age;
    }

    // Abstract method — no body, subclasses MUST implement this
    public abstract void work();

    // Shared implementation for all subclasses
    public void sayHello() {
        System.out.println("Hello, my name is " + name + " and I am " + age + " years old.");
    }

    public String getName() { return name; }
    public void setName(String name) { this.name = name; }
    public int getAge() { return age; }
    public void setAge(int age) { this.age = age; }
}
```

### Director.java
A director manages an array of other employees.

```java
public class Director extends Employee {
    private Employee[] employees;

    public Director(String name, int age, Employee[] employees) {
        super(name, age); // Call parent constructor
        this.employees = employees;
    }

    @Override
    public void work() {
        System.out.println("I am managing these employees: ");
        for (int i = 0; i < employees.length; i++) {
            if (i != 0) System.out.print(", ");
            System.out.print(employees[i].getName());
        }
        System.out.println();
    }
}
```

### Secretary.java
A secretary has a specific work implementation.

```java
public class Secretary extends Employee {

    public Secretary(String name, int age) {
        super(name, age);
    }

    @Override
    public void work() {
        System.out.println("I am preparing reports and scheduling meetings.");
    }
}
```

---
[ Back to Overview](../../README.md)