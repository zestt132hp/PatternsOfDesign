﻿В продолжение темы "Фабрики и фабричные методы" воспользуемся более абстрактным понятием типа "абстрактная фабрика"
Для примера используются элементы user интерфейса


1. Определяем наши элементы в виде абстрактного понятия через интерфейс
2. Определяем нашу абстрактную фабрику, которая будет выполнять действия по созданию элементов
3. Далее, мы хотим рисоваться элементы в зависимости от интерфейса операционной системы
4. Определяем классы создания юзер интерфейсов ос и наследуемся от абстрактной фабрики
5. Создаем классы юзер интерфейсов для каждой из ОС и наследуемся от асбтрактного понятия элементы
6. определяем мастера по созаднию элементов в зависимости от GUI
7. затем в Main, в зависимости от переданной строки с именем ОС, опеределяем нашу фабрику и создаем мастера
8. Инициализируем элементы
9. Прорисовываем

Почему не расширили Абстрактный метод? Для того, чтобы наглядно показать, недостаток "Асбтрактного метода"
Абстрактная фабрика используется тогда, когда в фабричном методе появляется необходимость добавить несколько последующих продуктов, в нашем примере, таки как Transport

