
Console.WriteLine("Enter the text to get the character count");

//string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
string text = Console.ReadLine();
char[] charactersInString = text.ToLower().ToCharArray();

Dictionary<char, int> letterCount = new Dictionary<char, int>();



foreach (char c in charactersInString)
{

    if (char.IsLetter(c))
    {
        if (letterCount.ContainsKey(c))
            letterCount[c]++;
        else
            letterCount.Add(c, 1);
    }

}
foreach(KeyValuePair<char,int> letter in letterCount)
{
    Console.WriteLine(letter.Key + ":" + letter.Value);
}