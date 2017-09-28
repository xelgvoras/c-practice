namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
            // Напишите функцию склонения слова "рублей" в зависимости от предшествующего числительного count.
            var ending = "лей";
            var modcount = count % 100;
            if (modcount < 5 || modcount > 20)
            {
                modcount = modcount % 10;
                if (modcount == 1)
                {
                    ending = "ль";
                }
                else if (modcount > 1 && modcount < 5)
                {
                    ending = "ля";
                }
            }
            return "руб" + ending;
		}
	}
}