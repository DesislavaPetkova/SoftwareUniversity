package _1lvshop;



public abstract class ElectonicsProduct  extends Product{

	protected int waranty;	
	
	public ElectonicsProduct(String name, double price, int quantity,
			Age age, int waranty) {
		super(name, price, quantity, age);
		
	}

	public int getWaranty() {
		return waranty;
	}

	public void setWaranty(int waranty) {
		this.waranty = waranty;
	}
	
	
	
}
