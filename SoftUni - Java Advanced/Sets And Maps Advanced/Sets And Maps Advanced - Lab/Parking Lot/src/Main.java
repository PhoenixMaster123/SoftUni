import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        HashSet<String> cars = new LinkedHashSet<>();
        String command = scanner.nextLine();
        while (!command.equals("END"))
        {
            String[] arr = command.split(", ");
            String direction = arr[0];
            String carNumber = arr[1];
            cars.add(carNumber);

            if(direction.equals("OUT") && cars.contains(carNumber))
            {
                cars.remove(carNumber);
            }

            command = scanner.nextLine();
        }

        if(cars.isEmpty())
        {
            System.out.println("Parking Lot is Empty");
        }
        else
        {
            for (String car : cars)
            {
                System.out.println(car);
            }
        }
    }
}