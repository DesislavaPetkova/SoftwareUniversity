package introJavaHomework;
import java.util.Scanner;
public class SumTwoNumbers {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		int first = scan.nextInt();
		int second = scan.nextInt();
		System.out.println(first+second);
		scan.close();

	}

}
