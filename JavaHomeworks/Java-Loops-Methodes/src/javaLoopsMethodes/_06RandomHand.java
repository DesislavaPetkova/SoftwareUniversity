package javaLoopsMethodes;
import java.util.Random;
import java.util.Scanner;
public class _06RandomHand {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int n = input.nextInt();
		String face = "2 3 4 5 6 7 8 9 10 J Q K A";
		String faces[] = face.split(" ");
		String suit = "♣ ♦ ♥ ♠";
		String suits[] = suit.split(" ");
		
		
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < 5; j++) {
				Random karta = new Random();
				Random boq = new Random();
				int kartite = karta.nextInt(13);
				int boite = boq.nextInt(4);
				System.out.printf("%s%s ", faces[kartite], suits[boite]);
				
			}
			System.out.println();
		}	
		input.close();
	}

}
