char valCaractere;
int[] valBinario = [0, 0, 0, 0, 0, 0, 0, 0];
int valDecimal = 0;

Console.WriteLine("Digite uma letra do alfabeto: ");
valCaractere = Convert.ToChar(Console.Read());

switch (Char.ToUpper(valCaractere)) {
    case 'A':
        valDecimal = 65;
        break;
    case 'B':
        valDecimal = 66;
        break;
    case 'C':
        valDecimal = 67;
        break;
    case 'D':
        valDecimal = 68;
        break;
    case 'E':
        valDecimal = 69;
        break;
    case 'F':
        valDecimal = 70;
        break;
    case 'G':
        valDecimal = 71;
        break;
    case 'H':
        valDecimal = 72;
        break;
    case 'I':
        valDecimal = 73;
        break;
    case 'J':
        valDecimal = 74;
        break;
    case 'K':
        valDecimal = 75;
        break;
    case 'L':
        valDecimal = 76;
        break;
    case 'M':
        valDecimal = 77;
        break;
    case 'N':
        valDecimal = 78;
        break;
    case 'O':
        valDecimal = 79;
        break;
    case 'P':
        valDecimal = 80;
        break;
    case 'Q':
        valDecimal = 81;
        break;
    case 'R':
        valDecimal = 82;
        break;
    case 'S':
        valDecimal = 83;
        break;
    case 'T':
        valDecimal = 84;
        break;
    case 'U':
        valDecimal = 85;
        break;
    case 'V':
        valDecimal = 86;
        break;
    case 'W':
        valDecimal = 87;
        break;
    case 'X':
        valDecimal = 88;
        break;
    case 'Y':
        valDecimal = 89;
        break;
    case 'Z':
        valDecimal = 90;
        break;
    default:
        Console.WriteLine("Letra inválida");
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