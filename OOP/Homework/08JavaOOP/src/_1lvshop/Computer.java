package _1lvshop;

import java.math.BigDecimal;

public class Computer extends ElectonicsProduct{

	public Computer(String name, double price, int quantity, Age age,
			int waranty) {
		super(name, price, quantity, age, waranty = 24);
		
	}

	public Computer(String name, double price, int quantity, Age none) {
		this(name, price, quantity, none, 24);
	}

	@Override
	public BigDecimal getPrice() {
		// TODO Auto-generated method stub
		return super.getPrice();
	}

	@Override
	public void setPrice(BigDecimal price) {
		if(this.quantity > 1000){
			this.price = price.multiply(new BigDecimal(0.95));
		}else{
			this.price = price;
		}
		
	}
	
	

}
