package javaSyntaxHomework;

import java.util.Scanner;

public class _07BinaryCount {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		int n = scan.nextInt();
		int mask = 1;
		int counter = 0;
		for (int i = 0; i < 32; i++) {
			if (((n>>i) & mask) == 1) {
				counter++;
			}			
		}
		System.out.println(counter);
		scan.close();
	}

}
