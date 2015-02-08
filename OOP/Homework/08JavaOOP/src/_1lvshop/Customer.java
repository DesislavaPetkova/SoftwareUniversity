package _1lvshop;

import java.math.BigDecimal;





public abstract class Customer {

	protected String name;
	protected int age;
	protected BigDecimal balance;
	
	public Customer(String name, int age, double balance) {
		super();
		this.setName(name);
		this.setAge(age);
		this.setBalance(new BigDecimal(balance));
	}
	
	public String getName() {
		return name;
	}
	public void setName(String name) {
		if(name == null || name.length() == 0 || name.isEmpty()){
			throw new IllegalArgumentException(" Invalid Name");
		}
		this.name = name;
	}
	public int getAge() {
		return age;
	}
	public void setAge(int age) {
		if(age < 0 || age > 100){
			throw new IllegalArgumentException("invalid age");
		}
		this.age = age;
	}
	public BigDecimal getBalance() {
		return balance;
	}
	public void setBalance(BigDecimal balance) {
		if (balance.compareTo(new BigDecimal(0.0)) == -1) {
			throw new IllegalArgumentException("Invalid balance");
		}
		this.balance = balance;
	}
	
	
	@Override
	public String toString() {
		return "Customer [" + (name != null ? "name=" + name + ", " : "")
				+ "age=" + age + ", "
				+ "balance=" + balance + "]";
	}
	
	
	
	
}
