﻿using System;
using System.Linq;

namespace Names
{
	internal static class HistogramTask
	{

		public static HistogramData GetHistogramBirthsPerDay(NameData[] names, string name)
		{
			/*
			Напишите код, готовящий данные для построения гистограммы 
			— количества людей в выборке c заданным именем в зависимости от числа (то есть номера дня в месяце) их рождения.
			Не учитывайте тех, кто родился 1 числа любого месяца.
			Если вас пугает незнакомое слово гистограмма — вам как обычно в википедию! 
			http://ru.wikipedia.org/wiki/%D0%93%D0%B8%D1%81%D1%82%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D0%BC%D0%B0
			Посмотрите пример выше с годами рождения.

			В качестве подписей (label) по оси X используйте число месяца.

			Объясните наблюдаемый результат!

			Пример подготовки данных для гистограммы смотри в файле HistogramSample.cs
			*/

			return new HistogramData(String.Format("Рождаемость людей с именем '{0}'", name), new string[0], new double[0]);
		}
	}
}