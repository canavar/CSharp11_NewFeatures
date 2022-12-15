var players = new string[] { "Messi", "Ronaldo", "Mbappe" };

var text = players switch
{
    [] => 
        "No matches today",
    [ _ ] => // ignore the element
        $"Only one player, no matches today!",
    [string firstPlayer, string secondPlayer] => 
        $"The match is : {firstPlayer} vs. {secondPlayer}",
    [string firstPlayer, .. string[] substitutePlayers, string secondPlayer] => 
        $"The match is : {firstPlayer} vs. {secondPlayer} and Subtitutes : {string.Join(",", substitutePlayers)}",
    _ => 
        "We could not decide what to do."
};

Console.WriteLine(text);
