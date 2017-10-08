using System;

namespace Names
{
	internal static class HeatmapTask
	{

		public static HeatmapData GetHistogramBirthsPerDate(NameData[] names)
		{
            /*
			Подготовьте данные для построения карты интенсивностей, у которой по оси X — число месяца, по Y — номер месяца, 
			а интенсивность точки (она отображается цветом и размером) обозначает количество рожденных людей в это число этого месяца.
			Не учитывайте людей, родившихся первого числа любого месяца.

			В качестве подписей (label) по X используйте число месяца (начиная со второго), 
			а по Y — номер месяца (январь — 1, февраль — 2, ...)
			*/

            var minDay = 2;
            var maxDay = 31;
            var days = new string[maxDay - minDay + 1];
            for (var i = 0; i < days.Length; i++)
                days[i] = (i + minDay).ToString();

            var minMonth = 1;
            var maxMonth = 12;
            var months = new string[maxMonth];
            for (var i = 0; i < months.Length; i++)
                months[i] = (i + minMonth).ToString();

            var birthCounts = new double[days.Length, months.Length];

            foreach (var name in names)
            {
                if (name.BirthDate.Day > 1)
                    birthCounts[(name.BirthDate.Day - minDay), (name.BirthDate.Month - minMonth)]++;
            }

            /* return new HeatmapData("Пример карты интенсивностей",
				new double[,] { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 4 }, { 4, 4, 4 } }, new[] { "a", "b", "c", "d" }, new[] { "X", "Y", "Z" }); */
            return new HeatmapData("Карта интенсивностей рождаемости", birthCounts, days, months);
		}
	}
}