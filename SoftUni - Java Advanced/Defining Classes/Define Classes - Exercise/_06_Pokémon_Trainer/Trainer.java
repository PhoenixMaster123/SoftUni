package exercise._06_Pokémon_Trainer;

import java.util.ArrayList;
import java.util.List;

public class Trainer {
    private String name;
    private int numberOfBadges;
    private List<Pokemon> pokemonList;

    public Trainer(String name) {
        this.name = name;
        numberOfBadges = 0;
        pokemonList = new ArrayList<>();
    }

    public void addPokemon(Pokemon pokemon) {
        pokemonList.add(pokemon);
    }
    public void increaseBadge() {
        this.numberOfBadges++;
    }
    public String toString() {
        return this.name + " " + this.numberOfBadges + " " + this.pokemonList.size();
    }
    public int getNumberOfBadges() {
        return numberOfBadges;
    }

    public void setNumberOfBadges() {
        this.numberOfBadges++;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }
    public List<Pokemon> getPokemonList() {
        return this.pokemonList;
    }
    public void setPokemonList(List<Pokemon> pokemonList) {
        this.pokemonList = pokemonList;
    }
}
