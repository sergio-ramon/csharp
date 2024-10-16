class CalculoFatorial {
    public static int Fatorial(int x) {
        if (x == 0) {
            return 1;
        } else {
            return x * Fatorial(x-1);
        }
    }

    public static int Main() {
        int num;

        Console.WriteLine("Digite um número: ");
        num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Fatorial(num));

        return 0;
    }
}