# Strategy Pattern

  *   Motivation
        Понякога има ситуации, в които класовете се различават само по тяхното поведение. В такива случаи е добра идея да се отделят алгоритмите в отделни класове, за да можем да избираме различни алгоритми runtime.
  *   Intent  	
        Дефинира група от алгоритми, енкапсулирани, и ги прави взаимозаменяеми. Също така позволява алгоритмите да варират независимо от клиентите които ги използват.
  *   Applicability
      ![alt tag](http://www.oodesign.com/images/design_patterns/behavioral/strategy_example_robot_-_uml_class_diagram.gif)
      * Application за симулиране на взаимодействие между работи.
        * IBehavioral (Strategy) - интерфейс който дефинира поведението на робот.
        * Concrete Strategies :
          * AggresiveBehaviour
          * DefensiveBehaviour
          * NormalBehaviour
        * Robot - има необходимата информация необходима на Strategy класът.
  *   Known uses
  *   Implementation
      [C# Example](https://github.com/Rostech/TelerikAcademyHomeworks/tree/master/High-Quality%20Code/19.%20Structural%20Patterns/Homework/StructuralPatterns/ProxyPattern)
  *   Participants
        * Strategy - дефинира общ за всички поддържани алгоритми интерфейс.
        * ConcreteStrategy - всяка конкретна стратегия имплементира алгоритъм.
        * Context - съдържа референция към strategy обект.
  *   Consequences
        * По лесно се тестват индивидуалните кокретни стратегии
        * Добавянето на стратегии не модифицира нищо. (Open/Closed principle)
  *   Structure
      ![alt tag](http://www.oodesign.com/images/design_patterns/behavioral/strategy_implementation_-_uml_class_diagram.gif)
  *   Related patterns
