using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI.UI
{
    class Program
    {
        /*
         * Your best friend is a Pokemon novice. They picked up one of the games and they are constantly asking you which types
         * are super effective aganst which other types. You decide to use your coding skills to build them a tool to determione which types their
         * pokemon team will be super effective against. Utilize the PokeAPI at https://pokeapi.co/
         * 
         * Build a console app that allows a user to type the name of a Pokemon and display the following information
         * about it:
         *      name,
         *      height,
         *      order number,
         *      type,
         *      and the type(s) it is most effective against
         */


        static async Task Main(string[] args)
        {
            ProgramUI ui = new ProgramUI();
            await ui.Run();
        }
    }
}
