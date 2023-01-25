# FinalTestWork
## Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.
## Описание решения задачи:
1. Объявляются два массива: первоначальный(array8) и второй((result) такой же длины);
2. Объявляется метод ArrayMas, в нём:
  - объявляется переменная count;
  - цикл For;
  - в цикле проверка условия на длину строки (<=3), если условие верно, то элемент записывается в переменную count второго массива(result);
  - после присвоения переменная увеличивается на 1.
 3. Объявляется метод PrintArray, а в нём цикл For для вывода элементов массива на экран.
 4. В конце происходит вызов двух методов.
 
 #
 В файле FinalTestWork.pdf расположена блок-схема алгоритма. 
