public interface ICalc
{
    double Result { get; set; }

    void Sum(double x, double y);
    

    void Subtract(double x, double y);
  

    void Multiply(double x, double y);
 

    void Divide(double x, double y);
    

    event EventHandler<EventArgs> MyEventHandler;

    void CancelLast();
}
