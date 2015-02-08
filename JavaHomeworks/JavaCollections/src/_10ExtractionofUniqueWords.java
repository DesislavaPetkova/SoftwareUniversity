
import java.util.Scanner;
import java.util.TreeSet;
import java.util.Set;
public class _10ExtractionofUniqueWords {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String textString  = input.nextLine().toLowerCase();
		String textArray[] = textString.split("\\W+");
		Set<String> set = new TreeSet<>();
		for (int i = 0; i < textArray.length; i++) {
			set.add(textArray[i]);
		}
		for (String string : set) {
			System.out.printf(string+ " ");
		}
		input.close();
	}

}
