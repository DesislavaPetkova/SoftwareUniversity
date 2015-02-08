package javaLoopsMethodes;
import java.util.Scanner;
public class _01SymmetricNumbers {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);		
		String vhod = input.nextLine();
		String arrayString[] =vhod.split(" ");
		int firstNum = Integer.parseInt(arrayString[0]);
		int secondNum = Integer.parseInt(arrayString[1]);
		for (int i = firstNum; i <= secondNum; i++) {
			
		String checker = Integer.toString(i);
		String reverserString = new StringBuffer(checker).reverse().toString();
		if (reverserString.equals(checker)) {
			System.out.printf("%s ",checker);
		}
		input.close();
		}		

	}

}
