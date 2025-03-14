using POKEMONS.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POKEMONS.INFRAESRUCTURA
{
    internal class PokemonProvider
    {


        List<Pokemon> items; 
        
        public PokemonProvider() { 

            items = new List<Pokemon>(); 
            items.Add(new Pokemon("Pikachu", 55, 40, 90));
            items.Add(new Pokemon("Charmander", 52, 43, 65)); 
            items.Add(new Pokemon("Bulbasaur", 49, 49, 45)); 
            items.Add(new Pokemon("Squirtle", 48, 65, 43));
            items.Add(new Pokemon("Eevee", 55, 50, 55)); 
            items.Add(new Pokemon("Jigglypuff", 45, 20, 20)); 
            items.Add(new Pokemon("Meowth", 45, 35, 90)); 
            items.Add(new Pokemon("Pidgey", 45, 40, 56)); 
            items.Add(new Pokemon("Rattata", 30, 56, 72)); 
            items.Add(new Pokemon("Zubat", 45, 35, 40)); 
        }
        public IEnumerable<Pokemon> GetAll() { 
            return items; 
        }
    }
}
