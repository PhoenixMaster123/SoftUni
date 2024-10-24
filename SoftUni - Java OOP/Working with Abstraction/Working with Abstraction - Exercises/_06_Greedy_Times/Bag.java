package _06_Greedy_Times;

import java.util.*;
import java.util.stream.Collectors;

public class Bag {
    private static final Comparator<Item> COMPARE_BY_NAME = Comparator.comparing(Item::getName).reversed();
    private static final Comparator<Item> COMPARE_BY_AMOUNT = Comparator.comparing(Item::getAmount);
    private long capacity;
    private List<Item> items;

    public Bag(long capacity) {
        this.capacity = capacity;
        items = new ArrayList<>();
    }
    public void add(Item itemToAdd) {
        if(canAdd(itemToAdd)) {
           Item item = getItem(itemToAdd);
           if(item == null) {
               this.items.add(itemToAdd);
           } else {
               item.setAmount(item.getAmount() + itemToAdd.getAmount());
           }
        }
    }
    // Map<ItemType, List<Item>>
    public void printBack() {
        LinkedHashMap<ItemType, List<Item>> itemsMap = this.items.stream()
                .collect(Collectors.groupingBy(Item::getItemType, // group by items and this is the key in this map
                       LinkedHashMap::new,
                        Collectors.toList()));

        itemsMap.entrySet().stream()
                .sorted((e1,e2) -> Long.compare(getTotalAmount(e2.getValue()), getTotalAmount(e1.getValue())))
                .forEach(entry -> {
                    System.out.printf("<%s> $%s\n", entry.getKey(), getTotalAmount(entry.getValue()));

                    entry.getValue().stream().sorted(COMPARE_BY_NAME.thenComparing(COMPARE_BY_AMOUNT))
                            .forEach(item -> System.out.println("##" + item.getName() + " - " + item.getAmount()));
                });
    }

    private Item getItem(Item itemToAdd) {

        return this.items.stream()
                .filter(item -> item.equals(itemToAdd)).
                findFirst().
                orElse(null);
    }

    private boolean canAdd(Item itemToAdd) {

        if (this.capacity < getTotalAmount(this.items) + itemToAdd.getAmount()) {
            return false;
        }
        if(itemToAdd.getItemType() == null) {
            return false;
        }

        switch (itemToAdd.getItemType()) {
            case Gem -> {
                if(itemToAdd.getAmount() + getTotalAmountByType(ItemType.Gem) >
                        getTotalAmountByType(ItemType.Gold)) {
                    return false;
                }
            }
            case Cash -> {
                if(itemToAdd.getAmount() + getTotalAmountByType(ItemType.Cash) >
                        getTotalAmountByType(ItemType.Gem)) {
                    return false;
                }
            }
        }

        return true;
    }

    private long getTotalAmountByType(ItemType itemType) {
        return this.items.stream()
                .filter(item -> item.getItemType().equals(itemType))
                .mapToLong(Item::getAmount)
                .sum();
    }
    private long getTotalAmount(List<Item> itemList) {
        return itemList.stream().mapToLong(Item::getAmount).sum();
    }

    public long getCapacity() {
        return capacity;
    }

    public void setCapacity(long capacity) {
        this.capacity = capacity;
    }

    public List<Item> getItems() {
        return Collections.unmodifiableList(items);
    }

    public void setItems(List<Item> items) {
        this.items = items;
    }
}
