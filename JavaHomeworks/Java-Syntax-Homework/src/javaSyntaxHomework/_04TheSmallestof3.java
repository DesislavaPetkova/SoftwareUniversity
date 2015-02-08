package javaSyntaxHomework;
import java.util.Scanner;
public class _04TheSmallestof3 {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		float kontrolen = 999999;
		for (int i = 0; i < 3; i++) {
			float number = scanner.nextFloat();
			if (number < kontrolen) {
				kontrolen = number;
			}
		}
		System.out.println(kontrolen);	
		scanner.close();
	}

}
