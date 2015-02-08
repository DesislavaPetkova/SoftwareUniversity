package javaLoopsMethodes;
import java.util.Scanner;
public class _02Generate3LetterWords {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String letter = input.nextLine();
		char letters[] = letter.toCharArray();
		if (letters.length == 3) {
			for (int i = 0; i < letters.length; i++) {
				for (int j = 0; j < letters.length; j++) {
					for (int j2 = 0; j2 < letters.length; j2++) {
						System.out.printf("%s%s%s ", letters[i], letters[j], letters[j2]);
					}
				}
			}
		}
		else if (letters.length == 2) {
			for (int i = 0; i < letters.length; i++) {
				for (int j = 0; j < letters.length; j++) {
					for (int j2 = 0; j2 < letters.length; j2++) {
						System.out.printf("%s%s%s ", letters[i], letters[j], letters[j2]);
					}
				}
			}
		}
		else {
			System.out.printf("%s%s%s ", letters[0], letters[0], letters[0]);
		}
		input.close();
	}

}
