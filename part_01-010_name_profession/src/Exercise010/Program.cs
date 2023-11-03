namespace Exercise010
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {

      Console.Write("I will tell a story, but I need some information.\nGive a name for main character:\n");
      string name = Console.ReadLine();
    
      Console.Write("Give the character a profession:\n");
      string profession = Console.ReadLine();

      Console.Write("Here is the story:\n");

      
      Console. WriteLine ("Once upon a time there was a " + profession + " called " + name);
      Console.WriteLine ("On her way to work, " + name + " often pondered what being " + profession + " meant to them.");
      Console.WriteLine ("When you work as a " + profession + " you meet interesting people.");
      Console.WriteLine (name + " enjoys their work as " + profession + "," + " The end.");
  
     



    }
  }
}
