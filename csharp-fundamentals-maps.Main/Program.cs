// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Hello, World!");

// Define and initialize the planets dictionary
Dictionary<string, float> _planets = new Dictionary<string, float>
{
    {"Jupiter", 5.2f},
    {"Uranus", 19.2f},
    {"Pluto", 39f},
    {"Mercury", 0.39f},
    {"Saturn", 9.54f},
    {"Earth", 1f},
    {"Mars", 1.52f},
    {"Venus", 0.72f},
    {"Neptune", 30.06f}
};

// Define the OrderedPlanets method
Dictionary<string, float> OrderedPlanets()
{
    return _planets.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
}

// Call the OrderedPlanets method and print the result
var orderedPlanets = OrderedPlanets();
foreach (var planet in orderedPlanets)
{
    Console.WriteLine($"{planet.Key}: {planet.Value}");
}



Dictionary<string, float> OrderedPlanetsByDescending()
{
    return _planets.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
}


var OpByDes = OrderedPlanetsByDescending();
foreach (var p in OpByDes)
{
    Console.WriteLine( $"{p.Key}: {p.Value}");
}