using System;
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

            var minDay = 2;
            var maxDay = int.MinValue;
            foreach (var day in names)
                maxDay = Math.Max(maxDay, day.BirthDate.Day);
            var days = new string[maxDay - minDay + 1];
            for (var i = 0; i < days.Length; i++)
            {
                days[i] = (i + minDay).ToString();
            }
            var birthCounts = new double[maxDay - minDay + 1];
            foreach (var day in names)
            {
                if (day.Name == name && day.BirthDate.Day > 1)
                    birthCounts[day.BirthDate.Day - minDay]++;
            }

			return new HistogramData(String.Format("Рождаемость людей с именем '{0}'", name), days, birthCounts);
		}
	}
}