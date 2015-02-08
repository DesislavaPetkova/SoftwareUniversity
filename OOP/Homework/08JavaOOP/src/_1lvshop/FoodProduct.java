package _1lvshop;

import java.math.BigDecimal;
import java.time.LocalDateTime;





public abstract class FoodProduct extends Product implements Expirable{
	
	private int expirableDate; 
	protected boolean isExpired = false;

	public FoodProduct(String name, double price, int quantity, Age age, int expirableDate) {
		super(name, price, quantity, age);
		
		this.expirableDate = expirableDate;
		
	}	




	public int getExpirableDate() {
		return expirableDate;
	}
	public void setExpirableDate(int expirableDate) {
		
		this.expirableDate = expirableDate;
	}


	public Boolean isExpired() {
		return isExpired;
	}

	public void setExpired(boolean isExpired) {
		if(getExpirationDate()){
			this.isExpired = true;
		}else{
			this.isExpired = isExpired;
		}		
	}



	@Override
	public String toString() {
		String result =String.format("FoodProduct [name= %s, price=%.2f , quantity=%d, age=%s]", name, price, quantity, age);
		String dateString = " product expires";
		if (getExpirationDate()){
			return result + dateString;
			
		}
		return result ;
	}

	@Override
	public boolean getExpirationDate() {
		LocalDateTime now = LocalDateTime.now();
		LocalDateTime newDate = now.plusDays(this.expirableDate);
		now = LocalDateTime.now().plusDays(15);
		if(newDate.compareTo(now) == -1){
			return true;
		}		
		return false;
	}
	
	
	

	@Override
	public BigDecimal getPrice() {
		if(getExpirationDate()){
			return this.price.multiply(new BigDecimal(0.7));
		}
		return this.price;
	}



	@Override
	public void setPrice(BigDecimal price) {
		if(getExpirationDate()){
			this.price = price.multiply(new BigDecimal(0.7));
		}else{
			this.price = price;
		}
	}

	
	
	
}
