class ParOuImpar {
    public static int Main() {
        int num;

        do {
            Console.WriteLine("Digite um número positivo: ");
            num = Convert.ToInt32(Console.ReadLine());
            
            if (num % 2 == 0 && num > 0) {
                Console.WriteLine($"O número {num} é par!");
            } else {
                Console.WriteLine($"O número {num} é impar!");
            }
        } while (num > 0);

        return 0;
    }
}