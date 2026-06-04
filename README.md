# SOLID
A simple explanation of each SOLID principle.

### SRP - Single Responsibility Principle
> A module should have only one reason to exist.

This may sound simple, but it is often misunderstood.

A function, class, or module should have a single responsibility. This is not always obvious, especially when designing code for the first time. A useful rule of thumb is: code that changes for the same reason should stay together.

### OCP - Open/Closed Principle
> A module should be open to extension but closed to modification.

This does not mean existing code should never be changed. It means software should be designed so that new behavior can be added with minimal changes to existing code. The Strategy Pattern is a good example of this.

### LSP - Liskov Substitution Principle
> Subtypes should be substitutable for their base types.

If a class `A` extends `B`, objects of type `A` should be usable wherever objects of type `B` are expected, without breaking the correctness of the program.

### ISP - Interface Segregation Principle
> Many client-specific interfaces are better than one general-purpose interface.

If different clients use different parts of a class, prefer smaller and more focused interfaces. This prevents clients from depending on methods they do not need.

### DIP — Dependency Inversion Principle
> Depend upon abstractions, not concrete implementations.

This is a key principle of modular design. By depending on abstractions instead of concrete implementations, you promote decoupling, easier refactoring, and plug-and-play components.
