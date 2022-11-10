**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Пример**

["Hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer scince"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []

#
Решение:

Создаем два массива. Первый заполняется с клавиатуры и второй длинна которого равна длине первого.

Проверяем все элементы первого массива. Если елементы больше или равны 3, то записываем их во второй массив.

Выводим оба массива в терминал.

**_P.S._** - Прошу  прощения если допустил синтаксические ошибки.

**_Код_** - TEST_WORK\Task\Program.cs

**_Блок-схема_** - Test_Work.drawio
