package javaSyntaxHomework;
import java.util.Scanner;

public class _06FormattingNumbers {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		
		int a = scan.nextInt();
		float b = scan.nextFloat();
		float c = scan.nextFloat();
		 
		String ahex = Integer.toHexString(a).toUpperCase();
		String abin = Integer.toBinaryString(a).replace(" ", "0");
		System.out.printf("|%-10s|%10s|%10.2f|%-10.3f|",ahex,abin,b,c);
		scan.close();
		
	}

}
