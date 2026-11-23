using Collections;

namespace Feladatok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1. Filmek hosszát tároló lista
             * - hozz létre egy filmek hosszát (percben) tároló listát az alábbi film hosszakkal:
             *      89, 125, 215, 102, 378, 101, 101, 86, 97, 187
             * - írd ki konzolra az összes filmhosszat a listából
             */



            List<int> filmHosszak = new List<int> { 89, 125, 215, 102, 378, 101, 101, 86, 97, 187 };



            foreach (int hossz in filmHosszak)
            {
                Console.WriteLine(hossz);
            }



            //2. írd ki, hogy hány 'film' van a lisitában



            Console.WriteLine($"A listában {filmHosszak.Count} film van.");



            //3. írd ki, hogy van-e 101 hosszú film a listában



            char van101 = filmHosszak.Contains(101) ? 'I' : 'N';
            Console.WriteLine($"Van 101 hosszú film: {van101}");



            //4. töröld ki a 101 hosszú filmet a listából és ezután írd ki újra a lista tartalmát és hogy jelenleg hány film van a listában



            filmHosszak.RemoveAll(hossz => hossz == 101);



            Console.WriteLine("A lista tartalma a 101 hosszú film(ek) törlése után:");
            foreach (int hossz in filmHosszak)
            {
                Console.WriteLine(hossz);
            }



            Console.WriteLine($"Jelenleg {filmHosszak.Count} film van a listában.");



            //5. illeszd be a 2. helyre a '123' számot



            filmHosszak.Insert(1, 123);



            //6. keresd meg a '123' hosszú film indexét a listában és irasd ki a konzolra



            int index123 = filmHosszak.IndexOf(123);
            Console.WriteLine($"A 123 hosszú film indexe: {index123}");



            //7. amit a 6-os feladatban kaptál indexet: töröld ki a számot ezen az indexen



            if (index123 != -1)
            {
                filmHosszak.Remove(index123);
            }



            //8. irasd ki a listában lévő elemeket



            foreach (int hossz in filmHosszak)
            {
                Console.WriteLine(hossz);
            }



            //9. fordítsd meg a listában lévő elemek sorrendjét és írasd ki a konzolra újra a lista elemeit
            Console.WriteLine();
            filmHosszak.Reverse();
            foreach (int hossz in filmHosszak)
            {
                Console.WriteLine(hossz);
            }



            //10. rendezd növekvő sorrendbe a lsta elemeit, és írd ki őkat a konzolra



            Console.WriteLine();
            filmHosszak.Sort();
            foreach (int hossz in filmHosszak)
            {
                Console.WriteLine(hossz);

            }

            Director jackson = new Director() { Name = "Jackson" };
            Director kurosawa = new Director() { Name = "Kurosawa" };
            Director scott = new Director() { Name = "Scott" };

            Movie abc = new Movie() { Title = "abc", Length = 123, Director = jackson };
            Movie abcd = new Movie() { Title = "abcd", Length = 230, Director = jackson };
            Movie samurai = new Movie() { Title = "samurai", Length = 89, Director = kurosawa };
            Movie alien = new Movie() { Title = "alien", Length = 117, Director = scott };
            Movie runner = new Movie() { Title = "runner", Length = 117, Director = scott };

            // Hozz létre egy 'Movies' listát, ami filmeket tartalmaz, és add hozzá az előbbi 5 filmet.

            List<Movie> Movies = new List<Movie>() { abc, abcd, samurai, alien, runner };

            //13. Feladat: Írd ki a listában minden film címét.

            foreach (var movie in Movies)
            {
                Console.WriteLine(movie.Title);
            }

            // 14. Feladat: Írd ki hány film van a listában.

            int movieCount = Movies.Count;
            Console.WriteLine($"A listában {movieCount} film van.");

            /*15.Feladat:
            Írd ki, hogy a samurai film benne van-e a listában
            Ha igen, töröld a listából
            Írd ki ismét minden film címét a listában*/

            bool containsSamurai = Movies.Contains(samurai);
            if (containsSamurai)
            {
                Movies.Remove(samurai);
            }

            foreach (var movie in Movies)
            {
                Console.WriteLine(movie.Title);
            }

            /*16.Feladat
            Hozz létre egy új filmet és illeszd meg a lista végére
            Írd ki minden, a listában lévő film címét.*/

            Movie newMovie = new Movie() { Title = "New Movie", Length = 150, Director = jackson };
            Movies.Add(newMovie);

            foreach (var movie in Movies)
            {
                Console.WriteLine(movie.Title);
            }

            /*17.Feladat
            Írd ki a listában lévő minden film címét és hosszát*/

            foreach (var movie in Movies)
            {
                Console.WriteLine($"Cím: {movie.Title}, hossz: {movie.Length} ");
            }

            /*18.Feladat:
            Keresd meg a legrövidebb filmet, és írd ki a címét a konzolra*/

            Movie shortestMovie = Movies.OrderBy(m => m.Length).FirstOrDefault();

            Console.WriteLine($"A legrövidebb film címe: {shortestMovie.Title}");

            /*19.Feladat:
            Keresd meg a leghosszabb filmet és írd ki a címét a konzolra*/

            Movie longestMovie = Movies.OrderByDescending(m => m.Length).FirstOrDefault();

            Console.WriteLine($"A leghosszabb film címe: {longestMovie.Title}");

            /*20. Feladat:
            Keresd meg a listában a 2. filmet és írd ki a konzolra a címét és a rendezőjének a nevét*/

            Movie secondMovie = Movies.ElementAt(1);
            Console.WriteLine($"Cím: {secondMovie.Title}, Rendező: {secondMovie.Director.Name}");

            /*21. Feladat
            Írd ki, hogy mennyi az átlag filmhossz a listában lévő filmeknél!*/


            /*21. Feladat  
            Írd ki, hogy mennyi az átlag filmhossz a listában lévő filmeknél!*/

            double averageLength = Movies.Average(movie => movie.Length);
            Console.WriteLine($"Az átlagos filmhossz: {averageLength} perc.");


            /*22. Feladat
            Keresd meg, hogy melyik filmnek van a leghosszabb címe és írd ki a címét!*/

            Movie longestTitleMovie = Movies.OrderByDescending(movie => movie.Title.Length).FirstOrDefault();
            Console.WriteLine(longestMovie.Title);

            /*23. Feladat
            Írd ki minden a listában lévő filmre:
            Film címe, hossza és rendező neve*/

            foreach (var movie in Movies)
            {
                Console.WriteLine($"Cím: {movie.Title}, Hossz: {movie.Length}, Rendező: {movie.Director.Name}");
            }
        }
    }
}
