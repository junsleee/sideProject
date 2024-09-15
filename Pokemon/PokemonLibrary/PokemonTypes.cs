using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.PokemonLibrary
{
    public enum PokemonType
    {
        Fire,
        Water,
        Grass,
        Normal
    }
    public static class TypeEffectiveness
    {
        public static readonly Dictionary<(PokemonType, PokemonType), double> EffectivenessMatrix = new Dictionary<(PokemonType, PokemonType), double>
        {
            {(PokemonType.Fire, PokemonType.Grass), 2.0 },
            {(PokemonType.Grass, PokemonType.Water), 2.0 },
            {(PokemonType.Water, PokemonType.Fire), 2.0},
            {(PokemonType.Fire, PokemonType.Water), 0.5},
            {(PokemonType.Water, PokemonType.Grass), 0.5},
            {(PokemonType.Grass, PokemonType.Fire), 0.5},
            {(PokemonType.Fire, PokemonType.Normal), 1.0},
            {(PokemonType.Grass, PokemonType.Normal), 1.0},
            {(PokemonType.Water, PokemonType.Normal), 1.0}
        };

        public static double GetEffectiveness(PokemonType attacker, PokemonType defender)
        {
            if (EffectivenessMatrix.TryGetValue((attacker, defender), out double effectiveness))
            {
                return effectiveness;
            }
            return 1.0;
        }
    }


}
