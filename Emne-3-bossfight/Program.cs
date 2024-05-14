// See https://aka.ms/new-console-template for more information

using Emne_3_bossfight;

Console.WriteLine("bossfigth");

GameCharacter Hero = new("hero", 100, 20, 40, 40);
GameCharacter Boss = new("boss", 200, 0, 10, 10);


while (true)
{
    Hero.SimulateFight(Boss);
    Boss.SimulateFight(Hero);
}