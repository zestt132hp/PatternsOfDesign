﻿Посредник	
Посредник - это поведенческий шаблон проектирования, который позволяет уменьшить связанность множества классов между собой, благодаря перемещению этих связей в единственный класс-посредник.
Шаблон "посредник" заставляет общаться объекты между собой не напрямую, а через объект-посредник, который знает, кому нужно перенаправить тот или иной запрос.
Благодаря этому все элементы будут зависеть от посредника, а не от каких-либо других элементов.

Аналогия из жизни.

Примером может послужить коммуникация пилотов воздушного транстпорта. 
Пилоты, следуя своему маршруту, не связываются между собой, вместо этого, 
они связываются с диспетчером, который коорденирует действия нескольких пилотов одновременно.
Без диспетчера, пилотам приходилось бы часто связыватсья между друг другом, что в последствии, привело бы к частым катастрофам.

Важно понимать, что диспетчер не нужен во время всего полёта. Он
задействован только в зоне аэропорта, когда нужно координировать
взаимодействие многих самолётов.

Применимость.

-Когда существует множество хаотичных связей с другими классами и их сложно менять!
Посредник позволяет поместить все связи в один класс посредник, для дальнейшего рефакторинга и сделать их более понятными и гибкими
-Когда нет возможности повторного использования класса, поскольку он зависит от других классов.
После применения паттерна компоненты теряют связи между другими классами, а всё их общение зависит 
от посредника.
-Когда приходиться создавать множества подклассов для дальнейшего использования в других контекстах.
Если раньше нужно было создавать множество подклассов других компонентов, то сейчас необходимо всего лишь создать подкласс посредника и переопределить связи.

Преимущества и недостатки
Устраняет зависимости между компонентами, позволяя повторно их
использовать.
Упрощает взаимодействие между компонентами.
Централизует управление в одном месте.
Посредник может сильно раздуться.
