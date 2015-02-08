import java.util.Arrays;
import java.util.Scanner;


public class _03LargestSequenceofEqualStrings {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String text = input.nextLine();
		String array[] = text.split(" ");
		String checker = null;
		int maxsequence = 1;
		String value = null;
		int counter = 0;
		Arrays.sort(array);
		for (String word : array) {
		if (word.equals(checker)) {
			counter++;
			if (counter >= maxsequence) {
				maxsequence += counter;
				value = word;
			}
		}else {
			counter = 0;
		}
		
		checker = word;
		}
		if (maxsequence == 1) {
			value = array[0];
		}
		for (int i = 0; i < maxsequence; i++) {
			System.out.printf("%s ", value);
		}
		input.close();
	}

}
