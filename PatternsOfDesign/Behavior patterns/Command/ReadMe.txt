﻿Command, Transaction

Команда-это поведенческий шаблон проектирования, который превращает запросы в обхекты, позволяя передавать их как аргументы при вызове методов,
ставить запросы в очередь и логировать их, а так же поддерживать отмену оперций.

Аналогия из жизни

Вы заходите в ресторан и садитесь у окна. К вам подходит вежливый
официант и принимает заказ, записывая все пожелания в блокнот.
Откланявшись, он уходит на кухню, где вырывает лист из блокнота и
клеит на стену. Сорвав лист со стены, шеф читает содержимое заказа
и готовит блюдо, которое вы заказали.
В этом примере, вы являетесь отправителем, официант с блокнотом
— командой, а шеф — получателем. Как и в паттерне, вы не
соприкасаетесь напрямую с шефом. Вместо этого, вы отправляете
заказ с официантом, который самостоятельно «настраивает» шефа на
работу.

Привидём пример в коде.
В этом примере, паттерн Команда служит для ведения истории
выполненных операций, позволяя, отменять их, если потребуется.

Преимущества и недостатки
Убирает прямую зависимость между объектами, вызывающими
операции и объектами, которые их непосредственно выполняют.
Позволяет реализовать простую отмену и повтор операций.
Позволяет реализовать отложенный запуск команд.
Позволяет собирать сложные команды из простых.
Реализует принцип открытости/закрытости.
Усложняет код программы за счёт дополнительных классов.
