namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
            // Напишите функцию склонения слова "рублей" в зависимости от предшествующего числительного count.
            var modcount = count % 10;
            var ending = "лей";
            if (modcount == 1)
            {
                ending = "ль";
            }
            else if (modcount > 1 && modcount < 5)
            {
                ending = "ля";
            }
            return "руб" + ending;
		}
	}
}