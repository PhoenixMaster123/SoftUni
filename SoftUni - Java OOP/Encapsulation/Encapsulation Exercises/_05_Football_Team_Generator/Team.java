package _05_Football_Team_Generator;

import java.util.ArrayList;
import java.util.List;
import java.util.NoSuchElementException;

public class Team {
    private String name;
    private List<Player> players;

    public Team(String name) {
        this.setName(name);
        players = new ArrayList<>();
    }
    public void addPlayer(Player player) {
        this.players.add(player);
    }
    public void removePlayer(String name) {
        boolean isRemoved = this.players.removeIf(player -> player.getName().equals(name));
        if(!isRemoved) {
            throw new NoSuchElementException(String.format("Player %s is not in %s team.", name, this.name));
        }
    }

    public double getRating() {
        return this.players.stream().mapToDouble(Player::overallSkillLevel).average().orElse(0.0);
    }


    private void setName(String name) {
        if(name == null || name.trim().isEmpty()) {
            throw new IllegalArgumentException("A name should not be empty");
        }
        this.name = name;
    }
}
