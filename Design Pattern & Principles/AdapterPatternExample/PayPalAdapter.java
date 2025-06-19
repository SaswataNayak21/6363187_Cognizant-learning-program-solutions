public class PayPalAdapter implements PaymentProcessor {
    private PayPalGateway payPal;

    @Override
    public void processPayment(double amount) {
        payPal.sendPayment(amount);
    }

    public PayPalAdapter(PayPalGateway payPal) {
        this.payPal = payPal;
    }

}