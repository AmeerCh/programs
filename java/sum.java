import java.util.Scanner;
class Main 
{
  public static void main(String[] args) 
  {
    System.out.print("To find the sum of two umbers, enter the first number:");
    Scanner scannerObject = new Scanner(System.in);
    int Number1 = scannerObject.nextInt();
    System.out.print("Enter the second number:");
    int Number2 = scannerObject.nextInt();
    int Sum = Number1 + Number2;
    System.out.println("The sum of " + Number1 + " and " + Number2 + " is " + Sum + ".");
  }
}