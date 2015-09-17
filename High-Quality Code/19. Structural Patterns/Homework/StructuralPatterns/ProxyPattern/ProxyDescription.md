# Proxy Pattern

  *   Motivation
        Понякога се нуждаем от възможността да контролираме достъпът до обект. Например ако се нуждаем само от няколко метода на някой " скъпо струващ" обект, можем да инциализираме тези обекти само когато имаме нужда от тях.
  *   Intent  	
        Моделът предоставя заместител на обекза, за а контролира референците към него.
  *   Applicability
        * Virtual Proxies - забавя създаването и инициализацията на "скъпо-струващи"" обекти, докато не се повикат.
        * Remote Proxies - предоставя локално представяне на обекти, който се съхраняват на отдалечено място.
        * Projection Proxies - контролира достъпа до RealSubject методите, давайки достъп до някой обекти, докато забранява достъпа до други.
         Smart References - предоставя усъвършествуван достъп до даден обект, като например следи броят на референциите към него и забраняването на достъп ако определена бройка е достигната например.
  *   Known uses
       Използва се за контролиране достъпа до обектите в много обектно-ориантирани езици.
  *   Implementation
      [C# Example](https://github.com/Rostech/TelerikAcademyHomeworks/tree/master/High-Quality%20Code/19.%20Structural%20Patterns/Homework/StructuralPatterns/ProxyPattern)
  *   Participants
        * Subject - Интерфейс имплементиран от RealSubject и престявящ сървиси. Този интерфейс трябва да бъде имплементиран от Proxy-то.
        * Proxy
            * Потдържа референция която позволява на Proxy-то достъп до RealSubject.
            * Контролира достъпа до RealSubject.
            * Имплементира същия интерфейс като RealSubject.
            * Понякога има и други отговорности в зависимост от това както Proxy-то редставя.
        * RealSubject
  *   Consequences
  *   Structure
      ![alt tag](http://www.oodesign.com/images/design_patterns/structural/proxy-design-pattern-implementation-uml-class-diagram.png)
  *   Related patterns
        * Adapter Design pattern
        * Decorator Design Pattern
