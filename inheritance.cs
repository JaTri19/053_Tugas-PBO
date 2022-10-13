using System;

namespace inheritance
{
    public class Enemy
    {
        public string nama;
        public int Hp;
        public int attackPoint;
        public string caraSerang;

        public void readers(string nama, int Hp, int attackPoint)
        {
            this.nama = nama;
            this.Hp = Hp;
            this.attackPoint = attackPoint;
            this.caraSerang = caraSerang;
            Console.WriteLine("Nama Monster = " + nama);
            Console.WriteLine("HP Monster = " + Hp);
            Console.WriteLine("Attack Point = " + attackPoint);
        }
        public void attack()
        {
            Console.WriteLine("Serangg!!");
        }
    }

    public class zombie : Enemy
    {
        public zombie()
        {           
            attack();
            Console.WriteLine();
            Console.WriteLine("Zombie jalan-jalan");
        }

    }
    public class pocong : Enemy
    {
        public pocong()
        {
            Console.WriteLine();
            Console.WriteLine("Pocong lompat-lompat");
            Console.WriteLine("Pocong terbang");
        }
    }
    public class burung : Enemy
    {
        public burung()
        {
            Console.WriteLine();
            Console.WriteLine("Burung jalan-jalan");
            Console.WriteLine("Burung Lompat-lompat");
            Console.WriteLine("Burung Terbang");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            zombie a = new zombie();
            a.readers("zumbi", 4000, 100);

            pocong b = new pocong();
            b.readers("otong", 3000, 500);

            burung c = new burung();
            c.readers("buwung", 2500, 1000);
        }
    }
}
