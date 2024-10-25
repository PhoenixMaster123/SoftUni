package _03_Shopping_Spree;

import java.util.*;
import java.util.stream.Collectors;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        Map<String, Person> personMap = new LinkedHashMap<>();
        Map<String, Product> productMap = new LinkedHashMap<>();

        String[] persons = scanner.nextLine().split("[;=]");
        String[] products = scanner.nextLine().split("[;=]");


        for (int i = 0; i < persons.length; i+=2) {

            String personName = persons[i];
            double personMoney = Double.parseDouble(persons[i + 1]);
            Person person = new Person(personName, personMoney);

            personMap.putIfAbsent(personName, person);
        }
        for (int i = 0; i < products.length; i+=2) {
            String productName = products[i];
            double productCost = Double.parseDouble(products[i + 1]);
            Product product = new Product(productName, productCost);
            productMap.putIfAbsent(productName, product);
        }


        String line = scanner.nextLine();
        while (!"END".equals(line)) {

            String[] tokens = line.split(" ");
            String person = tokens[0];
            String product = tokens[1];

            Person currentPerson = personMap.get(person);
            Product productToBuy = productMap.get(product);

            currentPerson.buyProduct(productToBuy);

            line = scanner.nextLine();
        }
        for (Map.Entry<String, Person> entry : personMap.entrySet()) {
            Person current = entry.getValue();

            if(current.getProducts().isEmpty()) {
                System.out.printf("%s - Nothing bought\n", current.getName());
            } else {
                List<Product> productsPerson = current.getProducts();
                System.out.print(current.getName() + " - ");
                String str = productsPerson.stream().map(Product::getName).map(String::valueOf).collect(Collectors.joining(", "));
                System.out.print(str + "\n");

            }
        }
    }
}
