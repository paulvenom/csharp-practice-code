/*
For each suit
        for each card
                Add to deck - "{card} of {suit}"

Get a random number between 0 and 51

Select the card and write out "Drawn card: value "
*/

var suits = new List<string> {"Clubs", "Diamonds", "Hearts", "Spades"};
var cards = new List<string> {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"};

var deck = new List<string>();

foreach (var suit in suits) {
    foreach (var card in cards) {
        deck.Add($"{card} of {suit}");
    }
}

var random = new Random();
var selectedCard = deck[random.Next(0,deck.Count-1)];

Console.WriteLine($"The card drawn was {selectedCard}.");

Console.ReadKey();
