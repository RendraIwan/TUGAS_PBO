using Motor;

Honda motor1 = new Honda();
motor1.kondisi();
Console.WriteLine("Mau tipe yang apa?");
Console.WriteLine("[1(Matic)/0(Manual)]");
int input = int.Parse(Console.ReadLine());
if (input == 1)
{
    motor1.desc(input);
}
else if (input == 0)
{
    motor1.desc();
}
else
{
    Console.WriteLine("Masukkan inputan yang benar. Silahkan coba ulang program");
}

class Honda : motor, iDesc
{
    public void setType()
    {
        this.merk = "====Honda Motorcycle====";
    }
    public void getType()
    {
        setType();
        Console.WriteLine($"{this.merk}");
        Console.WriteLine($"{this.merk}");
        Console.WriteLine($"{this.merk}");
    }
    public override void kondisi()
    {
        getType();
        Console.WriteLine();
        Console.WriteLine("Selamat Datang Di Brosur Online");
    }
    public void desc()
    {
        Console.WriteLine("Gold Wing 1833cc");
        Console.WriteLine("CRF 150cc");
        Console.WriteLine("CBR 150cc");
        Console.WriteLine("CBR RR 250cc");
        Console.WriteLine("MegaPro 150cc");
        Console.WriteLine("Supra GTR 150cc");
        Console.WriteLine("Supra fit 110cc");
        Console.WriteLine("Revo 110cc");
        Console.WriteLine("Revo Fit 110cc");
    }
    public void desc(int manual)
    {
        Console.WriteLine("Forza 250cc");
        Console.WriteLine("ADV 160cc");
        Console.WriteLine("ADV 150cc");
        Console.WriteLine("PCX !60cc");
        Console.WriteLine("PCX 150cc");
        Console.WriteLine("Scoopy 110cc");
        Console.WriteLine("Genio 110cc");
        Console.WriteLine("Beat 110cc");
    }
}