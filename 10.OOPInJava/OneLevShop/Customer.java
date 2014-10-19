package OneLevShop;

import ValidationMethods.Validation;

public class Customer {
	protected String name;
	protected int age;
	protected double balance;
		
	public Customer(String name, int age, double balance) {
		this.setName(name);
		this.setAge(age);
		this.setBalance(balance);
	}

	public String getName() {
		return name;
	}
	
	public void setName(String name) {
		Validation.validateCustomerName(name);
		this.name = name;
	}
	
	public int getAge() {
		
		return age;
	}
	public void setAge(int age) {
		Validation.checkInetegerForNegativeOrZeroInput(age);
		this.age = age;
	}
	
	public double getBalance() {
		return balance;
	}
	
	public void setBalance(double balance) {
		Validation.checkDoubleValueForNegativeOrZeroInput(balance);
		this.balance = balance;
	}
	
	@Override
	public String toString() {
		
		return "Customer:\n"+ this.name + "\nAge: " + this.age + "\nBalance: " + this.balance + "lv.";
	}
	
	
	
}
