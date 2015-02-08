import java.util.ArrayList;
import java.util.Scanner;


public class _04LongestIncreasingSequence {

	public static void main(String[] args) {
//		TO FIX
		try {
			Scanner input= new Scanner(System.in);
			String textString = input.nextLine();
			String array[] = textString.split(" ");
			ArrayList<Integer> increasingSequence = new ArrayList<>();
			int current = 0;
			int previous = 0;
			int counter = 0;
			int longestsequence = 1;
			
			for (int i = 0; i <= array.length; i++) {
				if (i < array.length) {
					current = Integer.parseInt(array[i]);
				}else {
					System.out.printf(array[i-1]);
					counter++;
				}
				if (counter >= longestsequence) {
					increasingSequence.add(current);
				}
				
				if (i>0) {
					previous= Integer.parseInt(array[i-1]);
				}
				if (current > previous && previous > 0) {
					System.out.print(previous + " ");
					increasingSequence.add(previous);
				}
				if (current < previous) {
					System.out.print(previous);
					System.out.println();
					increasingSequence.removeAll(increasingSequence);
					counter = 0;
				}
				
			}
			System.out.println();
			System.out.print("Longest : ");
			int i = 0;
			while (!increasingSequence.isEmpty()) {
				System.out.print(increasingSequence.get(i) + " ");
				i++;
			}
			input.close();
		} catch (Exception e) {
			// TODO: handle exception
		}
		
		
	}

}
