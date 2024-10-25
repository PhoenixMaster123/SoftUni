package _05_Football_Team_Generator;

public class Player {
    private String name;
    private int endurance;
    private int sprint;
    private int dribble;
    private int passing;
    private int shooting;

    public Player(String name, int endurance, int sprint, int dribble, int passing, int shooting) {
        this.setName(name);
        this.setEndurance(endurance);
        this.setSprint(sprint);
        this.setDribble(dribble);
        this.setPassing(passing);
        this.setShooting(shooting);
    }
    public Player() {}

    public double overallSkillLevel() {
        return (this.endurance + this.sprint + this.passing + this.dribble + this.shooting) / 5.0;
    }


    private void validateStat(int statValue, String statName) {
        if(statValue < 0 || statValue > 100) {
            throw new IllegalArgumentException("%s should be between 0 and 100.".formatted(statName));
        }
    }

    public String getName() {
        return this.name;
    }

    private void setName(String name) {
        if(name == null || name.trim().isEmpty()) {
            throw new IllegalArgumentException("A name should not be empty");
        }
        this.name = name;
    }

    public int getEndurance() {
        return endurance;
    }

    private void setEndurance(int endurance) {
        validateStat(endurance, "Endurance");
        this.endurance = endurance;
    }

    public int getSprint() {
        return sprint;
    }

    private void setSprint(int sprint) {
        validateStat(sprint, "Sprint");
        this.sprint = sprint;
    }

    public int getDribble() {
        return dribble;
    }

    private void setDribble(int dribble) {
        validateStat(dribble, "Dribble");
        this.dribble = dribble;
    }

    public int getPassing() {
        return passing;
    }

    private void setPassing(int passing) {
        validateStat(passing, "Passing");
        this.passing = passing;
    }

    public int getShooting() {
        return shooting;
    }

    private void setShooting(int shooting) {
        validateStat(shooting, "Shooting");
        this.shooting = shooting;
    }
}
