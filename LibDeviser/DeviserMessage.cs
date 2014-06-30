namespace LibDeviser
{
  public class DeviserMessage
  {
    public string Message { get; set; }
    public DeviserBase Element { get; set; }

    public override string ToString()
    {
      return Message;
    }
  }
}