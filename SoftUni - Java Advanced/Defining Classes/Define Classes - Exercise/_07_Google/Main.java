package exercise._07_Google;

import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        Map<String, Person> personMap = new LinkedHashMap<>();
        //List<Person> personList = new ArrayList<>();

        String line = scanner.nextLine();

        while (!"End".equals(line)) {
            String[] tokens = line.split(" ");
            String name = tokens[0];
            String value = tokens[1];

            Person person;
            // Variant 1:
            /*if (personMap.containsKey(name)) {
                // Retrieve the existing Person if they already exist
                person = personMap.get(name);
            } else {
                // Create a new Person if they don't exist
                person = new Person(name);
                personMap.put(name, person); // Add the new person to the map
            }
             */
            // Variant 2:
            // Retrieve the person if they already exist, otherwise create a new Person
            person = personMap.getOrDefault(name, new Person(name));

            if(value.equals("company")) {
                String companyName = tokens[2];
                String companyDepartment = tokens[3];
                double salary = Double.parseDouble(tokens[4]);
                Company company = new Company(companyName, companyDepartment, salary);
                person.setCompany(company);
            }
            else if (value.equals("pokemon")) {
                String pokemonName = tokens[2];
                String pokemonType = tokens[3];
                Pokemon pokemon = new Pokemon(pokemonName, pokemonType);
                person.addPokemon(pokemon);
            }
            else if(value.equals("parents")) {
                String parentName = tokens[2];
                String parentBirthday = tokens[3];
                Parent parent = new Parent(parentName, parentBirthday);
                person.addParent(parent);
            }
            else if(value.equals("children")) {
                String childrenName = tokens[2];
                String childrenBirthday = tokens[3];
                Child child = new Child(childrenName, childrenBirthday);
                person.addChild(child);
            }
            else if(value.equals("car")) {
                String carModel = tokens[2];
                int carSpeed = Integer.parseInt(tokens[3]);
                Car car = new Car(carModel, carSpeed);
                person.setCar(car);
            }
            personMap.put(name, person);
            line = scanner.nextLine();
        }

        String nameToPrint = scanner.nextLine();

        Person person = personMap.get(nameToPrint);
        System.out.println(person.toString());
    }
}
