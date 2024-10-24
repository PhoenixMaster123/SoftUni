package _06_Greedy_Times;

public enum ItemType {
    Gold,
    Gem,
    Cash;

    public static ItemType getItem(String name) {
        //name.equals(ItemType.CASH.name()); -> we can compare strings with enums
        // ItemType.getItem(CASH.name()).equals(name); -> better because name can be null

        ItemType itemType = null;
        if(name.length() == 3) {
            itemType = ItemType.Cash;
        } else if(name.toUpperCase().endsWith("GEM")) {
            itemType = ItemType.Gem;
        } else if(name.equalsIgnoreCase("GOLD")) {
            itemType = ItemType.Gold;
        }
        return itemType;
    }
}
