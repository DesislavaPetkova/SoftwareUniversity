import java.util.Scanner;


public class _07CountSubstringOccurrence {

	public static void main(String[] args) {
		Scanner input= new Scanner(System.in);
		String text= input.nextLine().toLowerCase();
		String matchWord= input.next().toLowerCase();
		String textArray[] = text.split(" ");
		int counter = 0;
		for (String word : textArray) {
			if (word.contains(matchWord)) {
				counter++;
			}
		}
		System.out.println(counter);
		input.close();
	}
}
