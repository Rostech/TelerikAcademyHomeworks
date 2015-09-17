# Flyweight Pattern

  *   Motivation
      	Понякога нашата програма се нуждае от голям брой обекти, които имат много еднакви
	  	състояния. Например като войниците в някоя игра. Всеки войник има грефично представяне, позиция,
	  	оръжие и т.н. Да имаме голям брой такива обекти "струва скъпо" от към памет.
  *   Intent
      	Целта на този модел е да може да се потдържа голяма група от обекти,
	  	без това да е скъпа операция  и постига това, чрез използването на обща памет
	  	за общите черти групата от обекти.
  *   Applicability
      	Прилага се в програми използващи голям брой обекти с общо състояние.
  *   Known uses
  		Използва се в Игри, TextEditors и други.
  *   Implementation
      [C# Example](https://github.com/Rostech/TelerikAcademyHomeworks/tree/master/High-Quality%20Code/18.%20Creational%20Patterns/Homework/CreationalDesignPatterns/AbstractFactory)
  *   Participants

  *   Consequences
  	  Flyweight спестява памет споделяйки flyweight обекти между клиентите. Използваната памет засвиси от числото
      на flyweight категории.
  *   Structure
      ![alt tag](http://www.oodesign.com/images/design_patterns/structural/flyweight-design-pattern-implementation-uml-class-diagram.png)
  *   Related patterns
