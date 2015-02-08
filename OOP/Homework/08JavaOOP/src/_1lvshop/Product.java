package _1lvshop;

import java.math.BigDecimal;



public abstract class Product implements Buyable {

	protected String name;
	protected BigDecimal price;
	protected int quantity;
	protected Age age;
	
	public Product(String name, double price, int quantity, Age age) {
		
		this.setName(name);
		this.setPrice(new BigDecimal(price));
		this.quantity = quantity;
		this.age = age;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		if (name.isEmpty() || name == null ) {
			throw new IllegalArgumentException("Invalid Name");
		}
		this.name = name;
	}

	public BigDecimal getPrice() {
		return price;
	}

	public void setPrice(BigDecimal price) {
		if (price.equals(0) || price.compareTo(new BigDecimal(0.0)) == -1) {
			throw new IllegalArgumentException("Price cannot be negative");
		}
		this.price = price;
	}

	public int getQuantity() {
		return quantity;
	}

	public void setQuantity(int quantity) {
		if (quantity <0) {
			throw new IllegalArgumentException("Invalid quantity");
		}
		this.quantity = quantity;
	}

	public Age getAge() {
		return age;
	}

	public void setAge(Age age) {
		this.age = age;
	}
	
	
	
	
}
