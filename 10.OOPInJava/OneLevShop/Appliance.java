package OneLevShop;

public class Appliance extends ElectonicsProduct {

	public Appliance(String productName, double price, double quantity,
			AgeRestriction ageRestriction) {
		super(productName, price, quantity, ageRestriction);
		
		this.guaranteePeriod = 6;
		this.price=getPrice();
	}

	@Override
	public double getPrice() {
		
		if(this.quantity < 50) {
			return this.price * 1.05;
		}
		
		return this.price;
	}

}
