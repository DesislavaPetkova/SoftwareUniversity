import java.util.Scanner;
public class _06CountSpecifiedWord {

	public static void main(String[] args) {
		Scanner input= new Scanner(System.in);
		String text= input.nextLine().toLowerCase();
		String matchWord= input.next().toLowerCase();
		String textArray[] = text.split("\\W+");
		int counter = 0;
		for (String word : textArray) {
			if (word.equals(matchWord)) {
				counter++;
			}
		}
		System.out.println(counter);
		input.close();
	}
	
}
