package _1lvshop;

public final class PurchaseManager{

	public static void ProcessPurchase(Product product, Customer customer){
		if(product.quantity == 0){
			throw new IllegalArgumentException("Not enough minerals");
		}
		if(product instanceof FoodProduct){
			if(((FoodProduct)product).isExpired()){
				throw new IllegalStateException("Product is expired");
			}
		}
		if(customer.getBalance().compareTo(product.price) == -1)
		{
			throw new IllegalArgumentException("Not enough minerals");
		}
		if(product.age == Age.Adult &&
				customer.getAge() < 18) {
			throw new IllegalStateException("Too young to buy this product");
		}
		
		customer.setBalance(customer.getBalance().subtract(product.getPrice()));
		product.setQuantity(product.getQuantity() -1);
		
	}

}
