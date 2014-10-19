package OneLevShop;

import ValidationMethods.Validation;

public abstract class ElectonicsProduct extends Product {
	protected int guaranteePeriod;
	
	public ElectonicsProduct(String productName, double price, double quantity, 
			AgeRestriction ageRestriction) {
			super(productName, price, quantity, ageRestriction);
			

	}

	public int getGuaranteePeriod() {
		return guaranteePeriod;
	}

	public void setGuaranteePeriod(int guaranteePeriod) {
		Validation.checkInetegerForNegativeOrZeroInput(guaranteePeriod);
		this.guaranteePeriod = guaranteePeriod;
	}

@Override
public String toString() {
	// TODO Auto-generated method stub
	return super.toString() + ", Guarantee Period " + this.guaranteePeriod;
}
	
	public  abstract double getPrice();

}
