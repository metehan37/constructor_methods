namespace constructor_methods;
 class Program
{
    static void Main(string[] args)
    {
        Worker worker1 = new Worker("Metehan","Metinoğlu",87713017,"IT");
        worker1.WorkerInformations();
        
        Console.WriteLine("************");
        Worker worker2 = new Worker("Ömer Talha","Metinoğlu",873213017,"Education");
        worker2.WorkerInformations();
        Console.WriteLine("************");
        Worker worker3=new Worker("Ümit Tufan","Metinoğlu");
        worker3.WorkerInformations();

    }

    
}

class Worker
{
    public string Name;
    public string Surname;
    public int No;
    public string Departmant;

    public Worker(string Name,string Surname,int no,string departmant){
        this.Name=Name;
        this.Surname=Surname;
        this.No=no;
        this.Departmant=departmant;
    }
    public Worker(string Name,string Surname){
        this.Name=Name;
        this.Surname=Surname;
    }
    public void WorkerInformations()
    {
        Console.WriteLine("Çalışan Adı:{0}",Name);
        Console.WriteLine("Çalışan SoyAdı:{0}",Surname);
        Console.WriteLine("Çalışan No:{0}",No);
        Console.WriteLine("Çalışan Departmanı:{0}",Departmant);
    }
  
}
