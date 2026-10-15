using System;
using System.Collections.Generic;
using System.Linq;

// we are declaring the pokemon class
class Pokemon {
    // adding the attributes of the pokemon
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    public int Level { get; set; }
}


// we are creating the class for the list of Pokemon 
// and the LINQ query

class PokemonLINQLab {
    // it will automatically runs through the main method.
    static void Main(){
        // using the sample data to test the main()
        var pokemons = new List<Pokemon> {
            new Pokemon { Id= 1, Name = "Bulbasaur", Type = "Grass", Level = 15}, 
            new Pokemon { Id= 2, Name = "Charmander", Type = "Fire", Level = 36 },
            new Pokemon { Id= 3, Name = "Squirtle", Type = "Water", Level = 10},
            new Pokemon { Id= 4, Name = "Pikachu", Type = "Electric", Level = 22},
            new Pokemon { Id= 5, Name = "Eevee", Type = "Normal", Level = 25},
            new Pokemon { Id= 6, Name = "Blastoise", Type = "Water", Level = 40}
        };

        // using the LINQ query to find pokemon that is ready to evolve
        var readyToEvolve = from p in pokemons 
                            where p.Level >= 16
                            orderby p.Level
                            select p;

        // now executing the results. 
        Console.WriteLine("Pokemon ready to evolve: ");
        foreach (var p in readyToEvolve){
            // printing out the name, type and level 
            Console.WriteLine($"Name: {p.Name}, Type: {p.Type}, Level: {p.Level}");
        } // end of the first part
        
        // finding all water pokemons. 
        var findingAllWater = from p in pokemons
                            where p.Type == "Water"
                            select p;

        Console.WriteLine("Finding all water type pokemons: ");
        foreach (var p in findingAllWater){
            Console.WriteLine($"Name: {p.Name}, Type: {p.Type}, Level: {p.Level}");
        } // end of the second part.       

    }// end of the main method 
} // ending the pokemonLINQ

