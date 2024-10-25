package _05_Football_Team_Generator;

import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String line = scanner.nextLine();
        Map<String, Team> teamMap = new LinkedHashMap<>();
        while (!"END".equals(line)) {

            String[] tokens = line.split(";");
            String command = tokens[0];

            String teamName = tokens[1];

            switch (command) {
                case "Team":
                    teamMap.putIfAbsent(teamName, new Team(teamName));
                    break;
                case "Add":
                    try {
                        if(checkIfTeamExist(teamMap, teamName)) {
                            break;
                        }

                        Team team = teamMap.get(teamName);

                        String playerName = tokens[2];

                        int endurance = Integer.parseInt(tokens[3]);
                        int sprint = Integer.parseInt(tokens[4]);
                        int dribble = Integer.parseInt(tokens[5]);
                        int passing = Integer.parseInt(tokens[6]);
                        int shooting = Integer.parseInt(tokens[7]);

                        Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                        team.addPlayer(player);
                    } catch (IllegalArgumentException ex) {
                        System.out.println(ex.getMessage());
                    }

                    break;
                case "Remove":
                    try {
                        String playerName = tokens[2];
                        teamMap.get(teamName).removePlayer(playerName);
                    } catch (NoSuchElementException ex) {
                        System.out.println(ex.getMessage());
                    }
                    break;
                case "Rating":
                    if(checkIfTeamExist(teamMap, teamName)) {
                        break;
                    }

                    System.out.printf("%s - %.0f\n", teamName, teamMap.get(teamName).getRating());
                    break;
            }

            line = scanner.nextLine();
        }
    }

    private static boolean checkIfTeamExist(Map<String, Team> teamMap, String teamName) {
        if(!teamMap.containsKey(teamName)) {
            System.out.printf("Team %s does not exist.\n", teamName);
            return true;
        }
        return false;
    }

}
