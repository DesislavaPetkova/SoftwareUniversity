import java.util.Arrays;
import java.util.Scanner;

public class _02SequencesOfEqualStrings {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String text = input.nextLine();
		String array[] = text.split(" ");
		String checker = null;

		Arrays.sort(array);
		for (String word : array) {
			
			if (word.equals(checker)) {
				System.out.printf("%s ", word);
			}else{	
				System.out.println();
				System.out.printf("%s ", word);
								
			}
			checker = word;
		}
		
		input.close();

	}

}
