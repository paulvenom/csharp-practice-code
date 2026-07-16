/*
1. Declare a variable (the name is up to you) to store a cart amount of $99.99.
2. Create a second variable to store the tax value of 0.0875%.
3. Create a variable to store the tax result, and run the calculation ($99.99 * 0.0875)
4. Add the tax to the cart amount to get the final total, and display all values on the screen.
*/

var cart = 99.99F;
var taxPct = 0.0875F;
var taxTotal = cart * taxPct;
var finalTotal = cart + taxTotal;
string taxConverted = taxPct.ToString("P2");

Console.WriteLine($"Cart Amount:  $  {cart:F2}");
Console.WriteLine($"Tax ({taxConverted}):  $   {taxTotal:F2}");
Console.WriteLine($"Total Amount: $ {finalTotal:F2}");

/// I made it all pretty by messing around
/// Original doesn't have spaces in Write Lines
/// Also convereted taxPct to string for percent