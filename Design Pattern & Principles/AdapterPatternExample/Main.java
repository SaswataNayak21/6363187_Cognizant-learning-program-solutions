public class Main {
    public static void main(String[] args) {
        System.out.println("Ex - 04 : Payment Adapter Test");
        PaymentProcessor paypalProcessor = new PayPalAdapter(new PayPalGateway());
        paypalProcessor.processPayment(150.75);

        PaymentProcessor stripeProcessor = new StripeAdapter(new StripeGateway());
        stripeProcessor.processPayment(299.99);

    }
}
