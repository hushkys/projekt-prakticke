# Enum Day — Weekly Schedule (Java) (Enum Den — Rozvrh)

A demonstration of Java Enums featuring constructors and methods to represent a weekly schedule.

## Key Concepts

- **Enum:** A special class type used to define a collection of constants.
- **Enum Constructor:** Enums can have fields and private constructors to initialize those fields for each constant.
- **Enum Methods:** Enums can contain methods to provide functionality based on the current constant.

## Source Files

### Day.java
An enumeration representing days of the week with associated schedule data.

```java
public enum Day {
    MONDAY("", ""),
    TUESDAY("09:20", "11:30"),
    WEDNESDAY("10:00", "14:00"),
    THURSDAY("", ""),
    FRIDAY("08:00", "12:00"),
    SATURDAY("", ""),
    SUNDAY("", "");

    private final String startTime;
    private final String endTime;

    // Enum constructors are always private
    private Day(String start, String end) {
        this.startTime = start;
        this.endTime = end;
    }

    public String getSchedule() {
        if (startTime.isEmpty()) return "No classes scheduled.";
        return "From " + startTime + " to " + endTime;
    }
}
```

### ScheduleManager.java
Using the Enum to display the weekly schedule.

```java
public class ScheduleManager {
    public static void main(String[] args) {
        for (Day d : Day.values()) {
            System.out.println(d + ": " + d.getSchedule());
        }

        Day today = Day.TUESDAY;
        if (today == Day.TUESDAY) {
            System.out.println("Reminder: Training at 09:20!");
        }
    }
}
```

---
[ Back to Overview](../../README.md)