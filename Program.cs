namespace intro_kolleksjoner;

class Program
{
    static void Main(string[] args)
    {
        //Her definerer vi et array. Men siden vi kun har definert datatype, og ikke lengde, så kan ikke dette arrayet brukes til noe.
        //Vi har sagt til datamaskinen vår at vi skal lage en samling av strings, men samlingen skal ha ingen strings i seg.
        /* string[] names = [];
        names[0] = "John"; */
        //Vi kan definere et nytt, tomt array men med en spesifikk lengde som dette:
        string [] names = new string[10];
        names[0] = "John";
        //Her ser vi at vi kan gå inn i arrayet vårt og lagre verdier i arrayet vårt.

        //Her definerer vi et array av doubles, men med forhåndsdefinerte verdier i hver posisjon.
       double[] numbers = [1,2,3,4];
       //Her redefinerer vi verdien i index 3 (posisjon 4).
        numbers[3] = 5.89;
        Console.WriteLine(numbers[0]);
        Console.WriteLine(numbers[1]);
        Console.WriteLine(numbers[2]);
        Console.WriteLine(numbers[3]);

        //Her redefinerer vi et nytt array, og lagrer referansen til dette arrayet til numbers. Det gamle arrayet er nå utilgjengelig.
        numbers = [7,8,9,0,10,39];
        Console.WriteLine(numbers[0]);
        Console.WriteLine(numbers[1]);
        Console.WriteLine(numbers[2]);
        Console.WriteLine(numbers[3]);

        //Hvis vi trenger en mer dynamisk måte å lage kolleksjoner på, er lister en mer relevant måte å gjøre dette på.
        //Her definerer vi en tom liste av strenger.
        List<string> listNames = [];
        //Her legger vi til en ny "node" i listen over strenger. hver node representerer stringen som ligger der, pluss en referanse til neste posisjon i listen.
        //Da trenger vi ikke å tenke på "lengden" på en gitt samlingsblokk, men vi kan se på hver node i listen vår som en blokk i minnet som kun inneholder det den trenger.
        listNames.Add("John");
        //Lister kan indekses ut, på samme måte som et array.
        Console.WriteLine(names[0]);
        
        //Et dictionary fungerer mye likt som en liste, men isteden for å hente ut verdier med en index, så kan vi hente ut verdier via en selvdefinert nøkkel.
        //I eksemplet nedenfor så ser vi at vi må definere to datatyper, først hva datatype nøkkelen vår har, så hva datatype verdien bak nøkkelen har.
        Dictionary<string, string> myDictionary = new(){{"Hello", "World!"}};
        //Vi kan da hente ut verdien bak nøkkelen ved å "indexere" inn via nøkkelen.
        Console.WriteLine(myDictionary["Hello"]);
        //Vi har også tilgang til en Add metode her også, som tar inn to kommaseparerte verdier av datatypen dictionariet er definert som.
        myDictionary.Add(
            "mitt navn", "John"
        );
        Console.WriteLine(myDictionary["mitt navn"]);

        List<int> numbs = [0,2,3,4,5,10,18,21,4];
        /* var query = numbers.OrderBy(num => num); */
        /* Det kan være lurt å tenke på at når vi gjør filtrering, søking og orderingmetoder på operasjonene våre, 
        så har vi ikke ut en liste av dataen før operasjonene fakstisk blir konsumert. */

        //Her gjør vi to filtreringsoperasjoner på numbs. Vi sier den først skal filtrere ut alle tallene mindre enn 10
        var query = numbs.Where(num => num < 10);
        //Så filtrere vekk alle tallene større enn 5
        query = query.Where(num => num > 5);

        //Så bruker vi denne queryen for å generer ny data fra numbs listen vår.
        var filteredNums = query.ToList();
        //Dette er et eksempel på LinQ og IEnumerable interfacen. Disse skal vi snakke mer om i en senere modul.
        Console.WriteLine(query.GetType());
    }
}
