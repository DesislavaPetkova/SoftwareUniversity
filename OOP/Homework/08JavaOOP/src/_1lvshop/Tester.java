package _1lvshop;


import java.util.ArrayList;

import java.util.Comparator;
import java.util.stream.Collectors;



public class Tester {
	
	

	public static void main(String[] args) {
		Product cigars = new FoodProduct("420 Blaze it fgt", 6.90, 2, Age.Adult, 16){};
		Customer pecata = new Customer("Pecata", 18, 30.00){};
		
		
		System.out.println(pecata.getBalance());
		System.out.println(cigars.getQuantity());
		
		try {
			PurchaseManager.ProcessPurchase(cigars, pecata);
		} catch (IllegalArgumentException e) {
			System.err.println(e.getMessage());
		}
		
		System.out.println(pecata.getBalance());
		System.out.println(cigars.getQuantity());
		
		Customer gopeto = new Customer("Gopeto", 18, 0.44){};
		
		try {
			PurchaseManager.ProcessPurchase(cigars, gopeto);
		} catch (IllegalArgumentException e) {
			System.err.println(e.getMessage());
		}
		
		java.util.List<Product> products = new ArrayList<Product>();
		
		Product camels = new FoodProduct("Cigars Camel", 5.3, 2, Age.Adult, 45){};
		Product bread = new FoodProduct("Vita bread", 1.10, 2, Age.Adult, 12){};
		Product croissant = new FoodProduct("7Days", 0.79, 111, Age.Teenager, 11){};
		Product newComputer = new Computer("ExtraDelux XF 11", 699.90, 20, Age.None){};
		Product secondComputer = new Computer("TheBesto", 1699.90, 2, Age.Adult){};
		Product furnaProduct = new Appliance("Eldom Oven", 299.90, 60, Age.None){};
		
		products.add(camels);
		products.add(bread);
		products.add(croissant);
		products.add(newComputer);
		products.add(secondComputer);
		products.add(furnaProduct);
		
		
		Comparator<Product> byDateOfExpiry = (p1, p2) -> Boolean.compare(
				((FoodProduct) p1).getExpirationDate(), ((FoodProduct) p2).getExpirationDate());
		Comparator<Product> byPrice = (p1, p2) -> p1.getPrice().compareTo(p2.getPrice());
		
		Product expirableProduct = products.stream()
				.filter(p -> p instanceof Expirable)
				.sorted(byDateOfExpiry)
				.findFirst()
				.get();
		
		System.out.println(expirableProduct);
		System.out.println("\n ----------------");
		
		java.util.List<Product> adultAgerestrictionByPrice = products.stream()
				.filter(p -> p.getAge() == Age.Adult)
				.sorted(byPrice)
				.collect(Collectors.toList());
		
		for (Product product : adultAgerestrictionByPrice) {
			System.out.println(product + "\n");
		}
	}

}
