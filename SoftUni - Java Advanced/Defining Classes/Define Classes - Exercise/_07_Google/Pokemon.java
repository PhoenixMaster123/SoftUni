package exercise._07_Google;

import java.util.ArrayList;
import java.util.List;

public class Pokemon {
    private String pokemonName;
    private String pokemonType;

    public Pokemon(String pokemonName, String pokemonType) {
        this.pokemonName = pokemonName;
        this.pokemonType = pokemonType;
    }
    public String toString() {
        return this.pokemonName + " " + this.pokemonType;
    }

    public String getPokemonName() {
        return pokemonName;
    }


    public void setPokemonType(String pokemonType) {
        this.pokemonType = pokemonType;
    }
}
