package exercise._06_Pokémon_Trainer;

import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        Map<String, Trainer> trainerMap = new LinkedHashMap<>();  // Keeps insertion order

        String line = scanner.nextLine();
        while (!"Tournament".equals(line)) {
            String[] tokens = line.split(" ");
            String trainerName = tokens[0];
            String pokemonName = tokens[1];
            String pokemonElement = tokens[2];
            int pokemonHealth = Integer.parseInt(tokens[3]);

            Trainer trainer = trainerMap.getOrDefault(trainerName, new Trainer(trainerName));
            Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
            trainer.addPokemon(pokemon);
            trainerMap.put(trainerName, trainer);

            line = scanner.nextLine();
        }

        line = scanner.nextLine();
        while (!"End".equals(line)) {
            String element = line;
            checkPokemon(trainerMap, element);  // Process tournament phase
            line = scanner.nextLine();
        }

        // Sort trainers by number of badges in descending order
        trainerMap.values().stream()
                .sorted(Comparator.comparingInt(Trainer::getNumberOfBadges).reversed())
                .forEach(System.out::println);  // Print trainer details
    }

    private static void checkPokemon(Map<String, Trainer> trainerMap, String element) {
        for (Trainer trainer : trainerMap.values()) {
            boolean hasMatchingPokemon = trainer.getPokemonList().stream()
                    .anyMatch(pokemon -> pokemon.getElement().equals(element));



            if (hasMatchingPokemon) {
                trainer.increaseBadge();
            } else {
                trainer.getPokemonList().forEach(Pokemon::decreaseHealthPokemon);
                // Remove Pokémon with health ⇐ 0
                trainer.getPokemonList().removeIf(pokemon -> pokemon.getHealth() <= 0);
            }
        }
    }
}
