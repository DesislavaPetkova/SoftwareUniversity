package javaLoopsMethodes;

import java.io.BufferedReader;

import java.io.FileReader;

public class _08SumNumbers4File {

	public static void main(String[] args) {
		BufferedReader bReader = null;
		try {
			
			bReader= new BufferedReader(new FileReader(
					"C:\\Users\\Ivaylo.Il\\Desktop\\input.txt"));
			int result = 0;
			String line;
			while ((line = bReader.readLine()) != null) {
				int a = Integer.parseInt(line);

				result += a;
			}
			System.out.println(result);
		} catch (Exception e) {
		}		
	}

}
