package OneLevShop.Interfaces;

import java.text.ParseException;
import java.util.Date;

public interface Expirable {
	public Date getExpirationDate() throws ParseException;
}
