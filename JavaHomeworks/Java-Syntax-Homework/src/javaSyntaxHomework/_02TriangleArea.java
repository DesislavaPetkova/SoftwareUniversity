package javaSyntaxHomework;
import java.util.Scanner;
public class _02TriangleArea {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String firstlane = scanner.nextLine();
		String firstarray[] = firstlane.split(" ");
		int ax = Integer.parseInt(firstarray[0]);
		int ay = Integer.parseInt(firstarray[1]);
		String secondlane = scanner.nextLine();
		String secondarray[] = secondlane.split(" ");
		int bx = Integer.parseInt(secondarray[0]);
		int by = Integer.parseInt(secondarray[1]);
		String thirdlane = scanner.nextLine();
		String thirdarray[] = thirdlane.split(" ");
		int cx = Integer.parseInt(thirdarray[0]);
		int cy = Integer.parseInt(thirdarray[1]);
		int result = (ax*(by-cy)+ bx*(cy-ay)+ cx*(ay-by))/2;			
		System.out.println(Math.abs(result));	
		scanner.close();
	}
}
