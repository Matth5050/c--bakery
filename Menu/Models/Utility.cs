using System.Threading.Tasks;


namespace Utility.Models
{
  public class Tasks
  {
    public static async Task UseDelay()
      {
        await Task.Delay(2000); 
        Console.WriteLine("test");
      }
  }
}