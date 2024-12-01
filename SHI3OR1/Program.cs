class program
{
    static void Main(string[] args)
    {
        Car c0 = new Car("11-111-11");
        c0.IsCarAvail();
        
    }
}




class Car
{
    private string licenseNum;
    private string model;
    private int seat_num;
    private int km;
    private string color;
    private bool isAvail;
    private double dailyPrice;



    
    public Car(string licenseNum)
    {
        SetPlate(licenseNum);
    }

    public void IsCarAvail()
    {
        string s = $"car{this.licenseNum} is";
        if (!this.isAvail)
        {
            s+="NOT AVAILABLE";
        }

        
        s+= "Available";
            Console.WriteLine(s);
    }
    
    public void SetTaken()
    {
        this.isAvail = false;
    }

    public void SetPlate(string licenseNum)
    {
        this.licenseNum = licenseNum;
    }

}

