import java.util.Scanner;
class Main 
{
  public static void main(String[] args)
  {
    System.out.print("How many natural numbers do you want to print?");
    Scanner scannerObject = new Scanner(System.in);
    int Count = scannerObject.nextInt();
    System.out.print("The natural numbers upto " + Count + " are");
    for(int Counter = 1; Counter <= Count; Counter++)
    {
      System.out.print(" " + Counter);
    }
    System.out.println(".");
  }
 
}