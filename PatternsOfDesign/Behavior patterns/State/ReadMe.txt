﻿State(Состояние)

Состояние - это поведенческий шаблон проектирования, который озводяет объектам меня свое поведение в зависимости от своего сотояния.
Извне создаётся впечатление, что изменился класс объекта.

Паттерн Состояние невозможно рассматривать в отрыве от концепции
машины состояний (также известной как стейт-машина или конечный
автомат).

Основная идея в том, что программа может находиться в одном из
нескольких состояний, которые всё время сменяют друг друга. Набор
этих состояний, а также переходов между ними предопределён и
конечен. Находясь в разных состояниях, программа может по-разному
реагировать на одни и те же события, которые происходят с ней.
Такой подход может быть применён и к отдельным объектам.
Например, объект Документ может принимать три состояния:
Черновик , Модерация или Опубликован . В каждом из них его метод
опубликовать будет работать по-разному:
В первом случае, он отправит документ на модерацию.
Во втором — отправит документ в публикацию, но при условии,
что это сделал администратор.
А в последнем — и вовсе ничего не будет делать.

Машину состояний чаще всего реализуют с помощью множества
условных операторов, if либо switch , которые проверяют текущее
состояние объекта и выполняют соответствующее поведение.
Путаница и нагромождение условий особенно сильно проявляется в
старых проектах. Набор возможных состояний бывает трудно
предопределить заранее, поэтому они всё время добавляются в
процессе эволюции программы. Таким образом, то, что выглядело
простым и эффективным в самом начале, может впоследствии стать
проекцией большого макаронного монстра.

Паттерн Состояние предлагает создать отдельные классы для каждого
состояния, в котором может пребывать контекстный объект, а затем
вынести туда поведения, соответствующие этим состоянию.
Вместо того чтобы хранить код всех состояний, первоначальный
объект (называемый «контекстом») будет содержать ссылку на один
из объектов-состояний и делегировать ему работу, зависящую от
состояния.
Благодаря тому, что состояния будут иметь общий интерфейс, контекст
сможет делегировать работу состоянию, не привязываясь к его классу.
Состояние и поведение контекста можно будет изменить в любой
момент, подключив к нему другой объект-состояние.

Очень важным нюансом, отличающим этот паттерн от Стратегии,
является то, что и контекст, и сами конкретные состояния могут знать
друг о друге и инициировать переходы от одного состояния к другому.

Аналогия из жизни

Ваш смартфон ведёт себя по-разному, в зависимости от текущего
состояния:
Когда телефон разблокирован, нажатие кнопок телефона
приводит к каким-то действиям.
Когда телефон заблокирован, нажатие кнопок приводит к экрану
разблокировки.
Когда телефон разряжен, нажатие кнопок приводит к экрану
зарядки.

Пример в коде.

В этом примере паттерн Состояние изменяет функциональность одних
и тех же элементов управления музыкальным проигрывателем, в
зависимости от того, в каком состоянии находится сейчас
проигрыватель.

Преимущества и недостатки
Избавляет от множества больших условных операторов машины
состояний.
Концентрирует в одном месте код, связанный с определённым
состоянием.
Упрощает код контекста.
Может неоправданно усложнить код, если состояний мало и они
редко меняются