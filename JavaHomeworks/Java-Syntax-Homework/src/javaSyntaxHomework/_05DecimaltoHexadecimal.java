package javaSyntaxHomework;
import java.util.Scanner;
public class _05DecimaltoHexadecimal {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		int dec = scan.nextInt();
		String hex = Integer.toHexString(dec);
		System.out.println(hex);
		scan.close();
	}

}
