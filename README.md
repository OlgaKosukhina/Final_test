Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равно 3 символа. 

Решение:
1. Инициализация массива строк при помощи метода InitArray:
- Задаем размерность массива
- Вводим элементы массива с клавиатуры
2. Формирование нового массива строк согласно условиям при помощи метода GetNewArray
- Задаем цикл for
- Внутри цикла задаем условие, где проверяем если длина i-ого элемента массива меньше либо равна 3 символам
- Если условие является истиной, то присваиваем i-й элемент начального массива i-му элементу нового массива.
3. Использование метода PrintArray, которые выведет на экран новый массив.