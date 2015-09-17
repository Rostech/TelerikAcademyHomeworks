# Decorator Pattern

  *   Motivation
      	Понякога се налага да се увеличава функциалността на даден обект динамично (at runtime).
  *   Intent
        Целта на този модел е да се позволи добавянето на допълнителни функционалности към даден обект.   	
  *   Applicability

  *   Known uses
        GUI инструменти.
  *   Implementation
      [C# Example] (https://github.com/Rostech/TelerikAcademyHomeworks/tree/master/High-Quality%20Code/19.%20Structural%20Patterns/Homework/StructuralPatterns/DecoratorPattern)
  *   Participants
        * Component - интерфейс за обекти, на които могат да се добавят функционалности динамично.
        * ConcreteComponent - Дефинира обекта, към който ще се добавят функционалности.
        * Decorator - Съдържа референция към Component обект и дефинира интерфейс, който се отнася към интерфейса на ConcreteComponent.
        * ConcreteDecorators - Разширяват функционалноста на обекта чрез добавянето на  състояние или поведение.
  *   Consequences
        Този модел улеснява добавянето на функционалности runtime и по този начин затруднява дебъгването.
  *   Structure
      ![alt tag](http://www.oodesign.com/images/design_patterns/structural/decorator-design-pattern-implementation-uml-class-diagram.png)
  *   Related patterns
      * Adapter Pattern
      * Composite Pattern
