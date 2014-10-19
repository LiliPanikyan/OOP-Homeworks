package OneLevShop;

import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.concurrent.TimeUnit;

import OneLevShop.Interfaces.Expirable;

public class FoodProduct extends Product implements Expirable {
	private Date expirationDate;
	private long daysLeft ;
	
	public FoodProduct(String productName, double price, double quantity, AgeRestriction ageRestriction, String expirationDate) throws ParseException {
		super(productName, price, quantity, ageRestriction);
		
		SimpleDateFormat simpleFormat = (SimpleDateFormat) DateFormat.getDateInstance();
	    simpleFormat.applyPattern("yyyy-MM-dd");
		
		try {
			this.expirationDate = simpleFormat.parse(expirationDate);
		} catch (ParseException e) {
			throw new IllegalArgumentException("Invalid data!");
		}
				
		this.daysLeft= getDaysLeft();
		this.price = getPrice();
	}
	protected long getDaysLeft() {	
		Date now = new Date();
		long diff = this.expirationDate.getTime() - now.getTime();		
		long days = TimeUnit.DAYS.convert(diff, TimeUnit.MILLISECONDS);
		
		return days;		
		
	}
	
	
	@Override
	public double getPrice() {
		if(this.daysLeft < 15) {
			return this.price * 0.7;
		}
		
		return this.price;
	}


	@Override
	public Date getExpirationDate() throws ParseException {
		
		return this.expirationDate;
	}
	
	@Override
	public String toString() {
		
		return super.toString() + ", product expires in " + this.daysLeft + " days";
	}
}