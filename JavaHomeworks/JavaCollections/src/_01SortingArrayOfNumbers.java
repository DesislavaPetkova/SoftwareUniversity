import java.util.Arrays;
import java.util.Scanner;
public class _01SortingArrayOfNumbers {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		
		int n = input.nextInt();
		int[] arr = new int[n];
		input.nextLine();		
		for (int i = 0; i < n; i++) {
		 int temp = input.nextInt();
		 arr[i] = temp;
		}
		Arrays.sort(arr);
		for (int i = 0; i < arr.length; i++) {
			System.out.printf("%d ", arr[i]);
		}
		input.close();
	}

}
