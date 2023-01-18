﻿// Инициализация массива
int[] myArray = new int[5]; //массив на 5 элементов с 5ю 0ми
int[] myArray = new int[5] {5,6,2,5,2}; //задание конкретного числа элементов в массиве(ошибка если число элементов не соответствует заданному размеру массива)
int[] myArray = new int[] {4,3,1,4};//Создание массива без явного указания количества элементов(будет создан массив с количеством элементов указанных в '{}')
//int[] myArray = new int[]; //если ничего не указано в фигурных скобках, в квадратных нужно обязательно что то указать.
int[] myArray = new [] {4,3,1,4}; //если не нужно явно контролировать количество элементов
int[] myArray = {4,3,1,4};// если явно указанно количество элементов в массиве

int[] myArray = Enumerable.Repeat(5, 10).ToArray(); //если нужно инициализировать массив с элементами не включающих 0.
//повторение элемента(5) которое будет повторятся(10) раз

int[] myArray = Enumerable.Range(4, 5).ToArray();//позволяет заполнить массив определенным количеством элементов начиная с какого то числа