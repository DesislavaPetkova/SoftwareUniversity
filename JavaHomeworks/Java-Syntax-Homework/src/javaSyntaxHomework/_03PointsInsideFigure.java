package javaSyntaxHomework;

import java.util.Scanner;

public class _03PointsInsideFigure {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		String firstlane = scan.nextLine();
		String firstarray[] = firstlane.split(" ");
		Float ax = Float.parseFloat(firstarray[0]);
		Float ay = Float.parseFloat(firstarray[1]);
		boolean x = false;
		boolean y = false;
		boolean c = false;
		if (ax >= 12.5 && ax <= 22.5) {
			x = true;
		}
		
		if (ay >= 6 && ay <= 13.5) {
			y = true;
		}
		if (ax >= 17.5 && ax <=20 && ay >=8.5 && ay<=13.5) {
			c = true;
		}
		if (x == true && y == true && c == false) {
			System.out.println("Inside");
		}
		else {
			System.out.println("Outside");
		}
		scan.close();
	}

}
