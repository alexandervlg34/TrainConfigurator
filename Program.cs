class Program
{
    static void Main(string[] args)
    {
        Terminal Terminal = new Terminal();
        Console.WriteLine($"Продано билетов: {Terminal.SellTickets()}");

        PassengerTrainConfigurator PassengerTrainConfigurator = new PassengerTrainConfigurator();
        Train NewTrain = PassengerTrainConfigurator.CreateTrain();

        
        Console.WriteLine($"Поезд создан. Вагонов: {NewTrain.TrainCars.Count}");

        Direction Direction = new Direction();
        string pointA = Direction.AddPointA("Волгоград");
        string pointB = Direction.AddPointB("Москва");
        Console.WriteLine($"Направление: {pointA} - {pointB}");

        

    }
}

public class PassengerTrainConfigurator
{
    
    Terminal Terminal = new Terminal();
    Train Train = new Train();
    public Train CreateTrain()
    {
        // Train Train = new Train();

        // метод должен добавлять вагон, елси мест в поезде все еще меньше, чем проданных билетов, но условие while останавливает программу
        // while
        if (Train.CountAllSeats() < Terminal.SellTickets()) // если в поезде мест (сумма мест текущего кол-ва вагонов) меньше чем проданных юилетов => добавить вагон
        {
            Train.AddTrainCar();
        }
        return Train;
    }
   
}

public class Direction
{
    
    public string PointA { get; private set; }
    public string PointB { get; private set; }

    // создается направление
    public string AddPointA(string pointA)
    {
        PointA = pointA;
        return pointA;
    }

    public string AddPointB(string pointB)
    {
        PointB = pointB;
        return pointB;
    }
}

public class Terminal
{
    public int Tickets {  get; private set; }
    

    Random random = new Random();
    public int SellTickets()
    {
        Tickets = random.Next(50, 300);
        return Tickets;
    }
}


public class Train
{
    private int seatsCount;

    private List<TrainCar> trainCars = new List<TrainCar>() { new TrainCar() }; // в дефолтном состоянии в поезде 1 вагон

    public List<TrainCar> TrainCars {  get { return trainCars; } }
    public int CountAllSeats()
    {
        for(int i = 0; i < trainCars.Count; i++)
        {
            seatsCount = trainCars[i].SeatsCount;
        }
        return seatsCount;
    }
    public void AddTrainCar()
    {
        trainCars.Add(new TrainCar());  
    }
}

public class TrainCar
{
    Random random = new Random();

    private int seatsCount;
    public int SeatsCount
    {
        get { return seatsCount = random.Next(10, 50); }
    }


}


