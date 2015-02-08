package javaLoopsMethodes;

public class _03FullHouse {

	public static void main(String[] args) {
		String face = "2 3 4 5 6 7 8 9 10 J Q K A";
		String faces[] = face.split(" ");
		String suit = "♣ ♦ ♥ ♠";
		String suits[] = suit.split(" ");
		for (int i = 0; i < faces.length; i++) {
			for (int j = 0; j < faces.length; j++) {
				for (int j2 = 0; j2 < suits.length; j2++) {
					for (int k = 0; k < suits.length; k++) {
						for (int k2 = 0; k2 < suits.length; k2++) {
							for (int l = 0; l < suits.length; l++) {
								for (int l2 = 0; l2 < suits.length; l2++) {
									
									System.out.printf("(%s%s %s%s %s%s %s%s %s%s) ", faces[i], suits[j2], faces[i], suits[k], faces[i], suits[k2], faces[j], suits[l], faces[j], suits[l2]);
								}
								}
							}
						}
					}
				}
			}
		}

	}


