
// ----------- VARIABILI GLOBALI ------------
int numeroBambini = 0;
int massimoNumumeroBambini = 1;

string[] nomebambino = new string[massimoNumumeroBambini];
string[] cognomebambino = new string[massimoNumumeroBambini];
int[] etabambino = new int[massimoNumumeroBambini];

void aggiungiBimbo(string nome, string cognome , int eta)
{
    if (numeroBambini < massimoNumumeroBambini)
    {
        nomebambino[numeroBambini] = nome;
        cognomebambino[numeroBambini] = cognome;
        etabambino[numeroBambini] = eta;



    }
    else if(massimoNumumeroBambini > 1)
    {
        Console.WriteLine("Mi dispiace non puoi entrare in classe");
    }
}
/*
void decrementareAuto()
{
    if (numeroAutoADisposizione > 0)
    {
        numeroAutoADisposizione--;
        modelloAutoPosti[numeroAutoADisposizione] = "";
    }
    else
    {
        Console.WriteLine("Mi dispiace ma non hai più auto!");
    }
}*/

//----PROGRAMMA---//

Console.WriteLine("Numero bimbi"+ numeroBambini);

while (true)
{
    Console.Write("Vuoi inserire il bambino in classe? [SI/NO]");
    string risposta = Console.ReadLine();

    switch (risposta)
    {
        case "si":
            Console.WriteLine("Dimmi il nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Dimmi il cognome");
            string cognome = Console.ReadLine();
            Console.WriteLine("Dimmi l'età");
            int eta = int.Parse(Console.ReadLine());
            aggiungiBimbo(nome, cognome, eta);
            Console.WriteLine();
            break;
        case "NO":
        default:
            Console.WriteLine("Non hai completato tutti i parametri, arrivederci");
            break;
    }
}
Console.WriteLine("Il tuo numero di bimbi è: " + numeroBambini);
for (int i = 0; i < nomebambino.Length; i++)
{
    Console.Write("\t" + nomebambino+ cognomebambino + etabambino [i]);
}
Console.WriteLine();


