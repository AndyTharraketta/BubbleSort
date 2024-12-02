namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Korrektur();
            Aufgabe();
            static void Aufgabe()
            {
                // Erstellen Sie ein int Array mit den Werten 4, 33, 7, 1, 23, 12 in genau dieser Reihenfolge.
                // Schreiben Sie dann einen Bubblesort um die Zahlen aufsteigend, von der kleinsten bis zu größten Zahl, zu sortieren.
                // Lassen Sie sich zur Kontrolle dann das sortierte Array ausgeben.
                // Keine Verwendung der .Sort() Methode oder ähnlichen Methoden sind zulässig.

                //int[] zahlen = { 4, 33, 7, 1, 23, 12 }; // Array mit den jeweiligen Werten

                //for (int i = 0; i < zahlen.Length - 1; i++)
                //{
                //    for (int j = 0; j < zahlen.Length - 1 - i; j++)
                //    {
                //        if (zahlen[j] > zahlen[j + 1]) // Vergleichen benachbarter Elemente
                //        {

                //            int temp = zahlen[j];   // Vertauschen, wenn das linke Element größer ist
                //            zahlen[j] = zahlen[j + 1];
                //            zahlen[j + 1] = temp;
                //        }
                //    }
                //}
                //Console.Write("Sortiertes Array: ");    // Ausgabe des sortierten Arrays
                //foreach (int num in zahlen)
                //{
                //    Console.Write(num + " ");
                //}
            }       // Aufgabenstellung
            static void Korrektur()
            {



                int[] bubbleArray = { 4, 33, 7, 1, 23, 12 };
                Console.WriteLine($"Array vor der Sortierung: {string.Join('-', bubbleArray)}");

                for (int elementIndex = 0; elementIndex < bubbleArray.Length; elementIndex++)
                {
                    for(int sortierSchleife =0; sortierSchleife<bubbleArray.Length -1; sortierSchleife++)
                    {
                        if (bubbleArray[sortierSchleife] > bubbleArray[sortierSchleife+1])
                        {
                            Console.WriteLine("Der Wert von sortierschleife ist größer.");
                            int temp = bubbleArray[sortierSchleife+1];
                            bubbleArray[sortierSchleife+1] = bubbleArray[sortierSchleife];
                            bubbleArray[sortierSchleife] = temp;
                        }
                    }
                }
                Console.WriteLine($"Sortiert: {string.Join('-', bubbleArray)}");

            }       // Korrektur der Aufgabe
        }
    }
}


