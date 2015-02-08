import java.util.Scanner;
public class _05CountAllWords {

	public static void main(String[] args) {
		Scanner input= new Scanner(System.in);
		String text= input.nextLine();
		String textArray[] = text.split("\\W+");
		System.out.println(textArray.length);
		input.close();
	}
	
}
