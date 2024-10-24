package _04_Traffic_Lights;

public enum Signal {
    RED,
    GREEN,
    YELLOW;

    public static void updateSignal(Signal[] signals){
        for (int i = 0; i < signals.length; i++) {
            switch (signals[i]){
                case RED -> signals[i] = GREEN;
                case GREEN -> signals[i] = YELLOW;
                case YELLOW -> signals[i] = RED;
            }
        }
    }
    public static void printSignals(Signal[] signals) {
        for (Signal signal : signals) {
            System.out.print(signal + " ");
        }
        System.out.println();
    }
}
