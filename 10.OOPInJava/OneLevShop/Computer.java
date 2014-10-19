package OneLevShop;

public class Computer extends ElectonicsProduct {
 
	

	public Computer(String productName, double price, double quantity,
			AgeRestriction ageRestriction) {
		super(productName, price, quantity, ageRestriction);
		
		this.guaranteePeriod = 24;
		this.price= getPrice();
	}

	@Override
	public double getPrice() {
		
		if(this.quantity > 1000){
			return  this.price * 0.95;
		}
		
		return this.price;
	}

}
