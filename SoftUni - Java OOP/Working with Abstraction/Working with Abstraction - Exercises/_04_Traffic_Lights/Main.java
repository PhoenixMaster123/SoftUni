package _04_Traffic_Lights;

import java.util.Arrays;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        Signal[] signals = Arrays.stream(scanner.nextLine().split(" "))
                .map(Signal::valueOf).toArray(Signal[]::new);

        int n = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i < n; i++) {
            Signal.updateSignal(signals);
            Signal.printSignals(signals);
        }


        /////////////////////////////// Variant 2 //////////////////////////////////////
        /*
        String[] lights = scanner.nextLine().split(" ");
        List<Signal> signalCurrent = new ArrayList<>();
        for (String sig : lights) {
           signalCurrent.add(Signal.valueOf(sig));
        }
        int n = Integer.parseInt(scanner.nextLine());
        for (int i = 0; i < n; i++) {
            signalCurrent = getSignals(signalCurrent);
            System.out.println();
           */
        }
    }

    /* private static List<Signal> getSignals(List<Signal> signalCurrent) {
        List<Signal> signalNew = new ArrayList<>();
        for (Signal signal : signalCurrent) {
            switch (signal) {
                case Signal.GREEN -> signal = Signal.YELLOW;
                case Signal.RED -> signal = Signal.GREEN;
                case Signal.YELLOW -> signal = Signal.RED;
            }
            signalNew.add(signal);
        }
        signalNew.forEach(s -> System.out.print(s + " "));
        return signalNew;
    }
}
         */
