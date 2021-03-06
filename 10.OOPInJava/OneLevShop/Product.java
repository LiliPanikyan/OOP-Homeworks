package OneLevShop;

import OneLevShop.Interfaces.Buyable;
import ValidationMethods.Validation;

public abstract class Product implements Buyable {

	protected String productName;
	protected double price;
	protected double quantity;
	protected AgeRestriction ageRestriction;

	public Product(String productName, double price, double quantity, AgeRestriction ageRestriction) {
		this.setProductName(productName);
		this.setPrice(price);
		this.setQuantity(quantity);
		this.setAgeRestriction(ageRestriction);
	}

	public String getProductName() {
		return productName;
	}

	public void setProductName(String productName) {
		Validation.validateProductName(productName);
		this.productName = productName;
	}

	public double getQuantity() {
		return quantity;
	}

	public void setQuantity(double quantity) {
		Validation.checkDoubleValueForNegativeOrZeroInput(quantity);
		this.quantity = quantity;
	}

	public AgeRestriction getAgeRestriction() {
		return ageRestriction;
	}

	public void setAgeRestriction(AgeRestriction ageRestriction) {
		this.ageRestriction = ageRestriction;
	}

	public abstract double getPrice();
	
	public void setPrice(double price) {
		Validation.checkDoubleValueForNegativeOrZeroInput(price);
		this.price = price;
	}
	
	
	
	@Override
	public String toString() {
		
		return 
			this.productName + 
			": price " + this.price + "lv" +
			", quantity "+ this.quantity +
			", age restriction " + this.ageRestriction;
	}

}
