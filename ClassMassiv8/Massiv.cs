namespace ClassMassiv8
{
    public class Massiv
    {
        private int[] masNumbers;

        //свойство для определения длины массива
        public int countNumberMass
        {
            get { return masNumbers.Length; }
        }
        //индексатор для доступа к элементам массива
        public int this[int number]
        {
            get { return masNumbers[number]; }
            set { masNumbers[number] = value; }
        }
        //конструктор с одним параметром - длина массива
        public Massiv(int length)
        {
            masNumbers = new int[length];
        }
        //конструктор с одним параметром - массив целых чисел
        public Massiv(int[] mass)
        {
            this.masNumbers = new int[mass.Length];
            this.masNumbers = mass;
        }

        //перегруженный метод для поиска максимального элемента во всем массиве
        public int maxNumberOfMas(int[] mass)
        {
            int maxNum = 0;
            if (mass.Length > 0)
            {
                for (int i = 0; i < mass.Length; i++)
                {
                    if (mass[i] > maxNum & mass[i] != 0)
                    {
                        maxNum = mass[i];
                    }
                }

            }
            return maxNum;
        }

        //перегруженный метод для поиска максимального элемента в части массива, ограниченной начальным и конечным значениями индекса, передаваемых в метод в качестве параметров.
        public int MaxNumberOfMas(int startIndex, int endIndex)
        {
            if (startIndex < 0 || startIndex >= masNumbers.Length || endIndex < 0 || endIndex >= masNumbers.Length || startIndex > endIndex)
            {
                throw new ArgumentException("Невалидное значение начального или конечного индекса.");
            }

            int maxNum = masNumbers[startIndex];
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (masNumbers[i] > maxNum)
                {
                    maxNum = masNumbers[i];
                }
            }
            return maxNum;
        }
    }
}