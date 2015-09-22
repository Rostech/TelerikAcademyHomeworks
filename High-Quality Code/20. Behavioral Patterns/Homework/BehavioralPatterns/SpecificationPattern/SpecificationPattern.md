#Specification Pattern

## Мотивация (motivation)
 Specification patterns използваме за :
  * Улавяне на опита базиран на дизайнерите експерти
  * Пренасяне на опита между практикуващи 
  * Класификация на пропъртита:
    1. Предимство в имплементацията
    2. Позволява информативна комуникация за пропъртита
## Намерение (intent)
Да комбинира различни правила (and/or/not) 

## Приложимост (applicability)
 * Когато имаме сложна и растяща бизнес логика (Използваме булева логика)
 * Разделяне на индивидуални правила от обработващата логика (нови правила са добавени лесно)  

## Известни употреби (known uses)
 * Gamification (badges/points)
 * Клиентско намаление на изчисленията
 * Сложно търсене

## Имплементация (implementation)
 * Няколко предефинирани правила са имплементирани (And, Or, Not), които имплементират ISpecification
 * Други клиентски спецификации също могат да бъдат добавени 

## Участници (participants)
 * NotSpecification <TEntity>
 * AndSpecification <TEntity>
 * OrSpecification <TEntity>
 * ISpecification <TEntity>

## Структура (structure)
![alt tag](https://upload.wikimedia.org/wikipedia/commons/8/8b/Specification_UML_v2.png)

## Свързани модели (related patterns)
 * Composite Pattern