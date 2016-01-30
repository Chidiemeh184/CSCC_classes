
import java.util.Scanner;

public class UseBMIClass {
  public static void main(String[] args) {

	String myName;
	int myAge;
	double myWeight, myHeight;
	Scanner input = new Scanner(System.in);

    BMI bmi1 = new BMI("John Doe", 18, 145, 70);
    System.out.println("The BMI for " + bmi1.getName() + " is "
      + bmi1.getBMI() + " " + bmi1.getStatus());

    BMI bmi2 = new BMI("Peter King", 215, 70);
    System.out.println("The BMI for " + bmi2.getName() + " is "
      + bmi2.getBMI() + " " + bmi2.getStatus());

      System.out.print("Enter your name: ");
      myName = input.next();
      System.out.println();

      System.out.print("Enter your age: ");
	  myAge = input.nextInt();
      System.out.println();

            System.out.print("Enter your height: ");
	        myHeight = input.nextDouble();
      System.out.println();

            System.out.print("Enter your weight: ");
	        myWeight = input.nextDouble();
      System.out.println();

      BMI bmi3 = new BMI(myName, myAge, myWeight, myHeight);
        System.out.println("The BMI for "+ bmi3.getName()+" is "+bmi3.getBMI()+" "+bmi3.getStatus());
  }
}