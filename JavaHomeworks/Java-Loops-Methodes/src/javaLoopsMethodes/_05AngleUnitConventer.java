package javaLoopsMethodes;

import java.util.Scanner;

public class _05AngleUnitConventer {

	public static void main(String[] args) {

		Scanner scan = new Scanner(System.in);
		int n = scan.nextInt();
		String[] numbersArray = new String[n];
		String[] measureArray = new String[n];

		scan.nextLine();
		String deg = "deg";
		String rad = "rad";

		for (int i = 0; i < n; i++) {
			numbersArray[i] = scan.next();
			measureArray[i] = scan.next();
			scan.nextLine();
		}
		for (int i = 0; i < measureArray.length; i++) {

			if (deg.equals(measureArray[i])) {
				double result = Double.parseDouble(numbersArray[i]);
				result = Math.toRadians(result);
				System.out.printf("%.6f %s", result, rad);
			}
			if (rad.equals(measureArray[i])) {
				double resultrad = Double.parseDouble(numbersArray[i]);
				resultrad = Math.toDegrees(resultrad);
				System.out.printf("%.6f %s", resultrad, deg);
			}
			System.out.println();
		}
		scan.close();

	}
}
