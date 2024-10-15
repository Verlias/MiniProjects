import java.util.HashMap;
import java.util.Map;

public class Bank {
	private Map<String, Accounts> accounts;

	Bank() {
		accounts = new HashMap<>();
	}

	public Map<String, Accounts> getAccount() {
		return accounts;
	}

	public void addAccount(String ID, Accounts account) {
		accounts.put(ID, account);
	}

	public int getNumberOfAccounts() {
		return accounts.size();
	}

	public void addDeposit(String id, double amount) {
		getAccount().get(id).addDeposit(amount);
	}

	public void withdraw(String id, double amount) {
		getAccount().get(id).withdraw(amount);
	}
}
