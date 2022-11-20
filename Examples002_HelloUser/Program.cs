﻿Console.Write("write your name");
string username = Console.ReadLine();
Console.Write("Hello,");
Console.Write(username);
/*
для хранения данных применяются переменные
Переменная имеет тип, имя и значение. 
Тип определяет какого рода инфо может хранить переменная например строки
Синтаксис переменной выглядит так: тип имя_переменной: string name;
так как определение переменной это инструкция, то после ставим ;
После определения переменной можно присвоить значение:
string name;
name = "Tom";
так как это строка то присваиваем ей строку в ""
запись можно сократить:
string name = "Tom";
В программе можно многократно менять значения переменной
*/

string name = "Tom"; //определяем переменную и инициализируем ее
Console.Write(name); //Tom
name = "Bob"; //меняем значение переменной
Console.WriteLine(name); //Bob

/*const = константа
предназначена для описания значений которые не должны меняться в программе
*/

const string NAME = "Tom"; // определяем константу, часто для констант пользуют именно верхний регистр
//если константу не определить будет ошибка
const string NAME; // ошибка - НЕ инициализрованна константа!!!
const string NAME = "Tom"; //определена константа
NAME = "Bob"; // ошибка!!!! у константы нельзя изменить значение!!!