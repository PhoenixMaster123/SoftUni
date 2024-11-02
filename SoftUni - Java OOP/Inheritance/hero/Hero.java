package hero;

public abstract class Hero {
        private String username;
        private int level;

        public Hero(String username, int level) {
            this.setUsername(username);
            this.setLevel(level);
        }

        public String getUsername() {
            return username;
        }

        public int getLevel() {
            return level;
        }

    public void setUsername(String username) {
        this.username = username;
    }

    public void setLevel(int level) {
        this.level = level;
    }

    @Override
        public String toString() {
            return String.format("Type: %s Username: %s Level: %s",
                    this.getClass().getName(),
                    this.getUsername(),
                    this.getLevel());
        }
}

