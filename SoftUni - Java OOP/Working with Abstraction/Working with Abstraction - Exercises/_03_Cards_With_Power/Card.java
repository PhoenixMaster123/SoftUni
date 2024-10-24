package _03_Cards_With_Power;

public class Card {
    private CardRank cardRank;
    private SuitRank suitRank;

    public Card(CardRank cardRank, SuitRank suitRank) {
        this.cardRank = cardRank;
        this.suitRank = suitRank;
    }
    public int getCardPower() {
        return this.cardRank.getRankPowers() + this.suitRank.getSuitPower();
    }
    public String toString() {
        return String.format("Card name: %s of %s; Card power: %d",
                this.cardRank, this.suitRank, getCardPower());
    }
}
