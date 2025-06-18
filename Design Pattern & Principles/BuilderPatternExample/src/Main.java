
public class Main {
    public static void main(String[] args) {
        Computer basicComputer = new Computer.Builder("Intel i5", "8GB")
                      .build();

        Computer gamingComputer = new Computer.Builder("AMD Ryzen 9", "32GB")
                .setStorage("1TB SSD")
                .setGraphicsCard("NVIDIA RTX 4080")
                .setOperatingSystem("Windows 11")
                .build();

        Computer officeComputer = new Computer.Builder("Intel i7", "16GB")
                .setStorage("512GB SSD")
                .setOperatingSystem("Windows 10")
                .build();

        // Display configurations
        System.out.println("Basic Computer Configuration:");
        basicComputer.showConfiguration();

        System.out.println("Gaming Computer Configuration:");
        gamingComputer.showConfiguration();

        System.out.println("Office Computer Configuration:");
        officeComputer.showConfiguration();

    }
}
