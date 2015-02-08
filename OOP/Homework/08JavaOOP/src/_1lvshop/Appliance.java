package _1lvshop;

import java.math.BigDecimal;

public class Appliance extends ElectonicsProduct {

	public Appliance(String name, double price, int quantity, Age age,
			int waranty) {
		super(name, price, quantity, age, waranty = 6);
		
	}

	public Appliance(String name, double price, int quantity, Age none) {
		this(name, price, quantity, none, 6);
	}

	@Override
	public BigDecimal getPrice() {
		// TODO Auto-generated method stub
		return super.getPrice();
	}

	@Override
	public void setPrice(BigDecimal price) {
		if(this.quantity < 50){
			this.price = price.multiply(new BigDecimal(1.05));
		}else{
			super.setPrice(price);
		}
	}

	
	
}
