// See https://aka.ms/new-console-template for more information

public class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user.ToString());
    }

    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();

        Console.Write("Masukkan nama : ");
        string  namauser = Console.ReadLine();
        halo.SapaUser(namauser);
    }


}