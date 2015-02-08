
import java.util.ArrayList;

import java.util.Scanner;
public class _09CombineListOfLetters {

	public static void main(String[] args) {
		Scanner input= new Scanner(System.in);
		
		String one = input.nextLine();		
		String two = input.nextLine();
		ArrayList<Character> lineOne = new ArrayList<Character>();		
		ArrayList<Character> lineTwo = new ArrayList<>();
		for (Character character : one.toCharArray()) {
			lineOne.add(character);			
		}
		for (Character character : two.toCharArray()) {
			lineTwo.add(character);				
		}
		ArrayList<Character> print = new ArrayList<>();
		print.addAll(lineOne);
		for (int i = 0; i < lineTwo.size(); i++) {
			if (lineOne.contains(lineTwo.get(i))) {
				continue;
			}else {
				print.add(' ');
				print.add(lineTwo.get(i));
			}
		}
		for (int i = 0; i < print.size(); i++) {
			System.out.print(print.get(i));
		}
		input.close();
	}

}
