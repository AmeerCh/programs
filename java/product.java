import java.util.Scanner;
class Main 
{
  public static void main(String[] args) 
  {
    System.out.print("To print the product of three numbers, enter the first number:");
    Scanner scannerObject = new Scanner(System.in);  
    int Number1 = scannerObject.nextInt();
    System.out.print("Enter the second number:");
    int Number2 = scannerObject.nextInt();
    System.out.print("Enter the third number:");
    int Number3 = scannerObject.nextInt();
    int Product = Number1 * Number2 * Number3;
    System.out.print("The product of " + Number1 + ", " + Number2 + " and " + Number3 + " is " + Product + ".");
  }
}