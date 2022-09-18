# **Как это вообще работает?** 
	Для начала создаем массив, заполненный словами разной длинны. 
> Это выглядит так
>
>> string[] arrayWords = { "Hello", "How", "are", "you", "today", "I", "hope", "well" };
## **Count**
<ol>
<li>	Создаем метод, который будет считать количество слов, содержащих три буквы или менее, и вернет нам количество.
<li>	В методе задаем х который будет равен нулю и count тоже равный нулю. Х будет запоминать количество букв в словах массива, а count будет считать их количество.
<li>	Создаем for, который будет шагать по массиву предоставляя новые и новые слова.
<li>	If будет выполняться если слово содержит 3 или менее буквы, а count будет увеличиваться.
<li>	Когда цикл for будет завершен, мы получим точное количество слов.
</ol>

## **Merge**
<ol>
<li>	Создаем новый массив newWords размером с количество слов, содержащих 3 или менее букв, которые нам вернул Count. Присвоим его значение переменной size, для простоты восприятия.
<li>	Создаем новый метод Merge, который на входе принимает два текстовых массива и заполняет второй, словами, которые содержат 3 или менее букв.
<li>	Цикл for, как и прошлый раз, будет отсчитывать для нас элементы. 
<li>	Задаем переменную x и y. Как и в прошлый раз X будет контролировать количество букв в словах первого массива и Y что будет отсчитывать для нас положение принимаемых слов в новом массиве увеличиваясь при этом на 1 каждый раз, когда таковое слово было найдено
</ol>

## Show array
<ol>
<li>	Ну и заключительный шаг, это вывод нового массива с короткими словами на экран. Для этого создадим еще один метод showArray, принимающий на вход текстовый массив.
<li>	Так же как и прежде, пишем цикл for который отсчитывает значения I, топая по массиву.
<li>	Команда Console.WriteLine выводит на экран все новые и новые слова. 
<li>	Последний шаг, который, к слову, полностью опционален, красиво закрывает выведенный массив, убираю ненужную запитую и пробел после последнего элемента нового массива. Просто визуально приятнее.
</ol>

### **Напоследок скажу, что проект был выполнен методами, дабы добавить ему гибкости и универсальности, есть более простые методы, но предположим что слова вводил бы пользователь, в таком случае, данная программа, работала бы отлично.**