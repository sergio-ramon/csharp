char valCaractere;
int[] valBinario = [0, 0, 0, 0, 0, 0, 0, 0];
int valDecimal = 0;

Console.WriteLine("Digite uma letra entre a, b ou c: ");
valCaractere = Convert.ToChar(Console.Read());

switch (valCaractere) {
    case 'a':
        valDecimal = 65;
        break;
    case 'b':
        valDecimal = 66;
        break;
    case 'c':
        valDecimal = 67;
        break;
}

if (valDecimal != 0) {
    for (int i = 7; i >= 0; i--) {
        valBinario[i] = valDecimal%2;
        valDecimal /= 2;
    }

    for (int j = 0; j <= 7; j++) {
        Console.Write(valBinario[j]);
    }
}