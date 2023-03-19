// See https://aka.ms/new-console-template for more information
using tpmodul5_1302210070;

class MainProgram
{
    static void Main(string[] args)
    {
        HaloGeneric<String> menyapa = new HaloGeneric<String>();

        String x = "Ashar Syahbudi S";

        menyapa.SapaUSer(x);

        DataGeneric<String> save_data = new DataGeneric<string>("1302210070");

        save_data.PrintData();
    }
}
