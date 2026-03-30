# Generic Color<T> Class (Java) (Generická třída Barva<T>)

This project illustrates the use of Generics in Java. The `Color<T>` class allows representing a color using any type — such as a String, a java.awt.Color object, or an integer RGB value.

## Key Concepts

- **Generic Class:** A class parameterized by a type using the `<T>` syntax.
- **Type Safety:** The compiler ensures that only the correct type is used, eliminating the need for casting.
- **Flexibility:** One generic class can handle multiple data types without code duplication.

## Source Files

### ColorRepresenter.java
A generic class that stores a color value of any type.

```java
// T is the type parameter — replaced with a concrete type during usage
class ColorRepresenter<T> {
    private T color;

    public ColorRepresenter(T color) {
        this.color = color;
    }

    public void setColor(T color) {
        this.color = color;
    }

    public T getColor() {
        return this.color;
    }
}
```

### Main.java
Demonstrating the generic class with different types.

```java
import java.awt.Color;

public class Main {
    public static void main(String[] args) {
        // Represented as a String
        ColorRepresenter<String> c1 = new ColorRepresenter<>("Yellow");
        System.out.println(c1.getColor());

        // Represented as a java.awt.Color object
        ColorRepresenter<Color> c2 = new ColorRepresenter<>(Color.RED);
        System.out.println(c2.getColor());

        // Represented as an Integer (RGB)
        ColorRepresenter<Integer> c3 = new ColorRepresenter<>(0xFF00FF);
        System.out.println(c3.getColor());
    }
}
```

---
[ Back to Overview](../../README.md)