using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jynx : PokemonData
{
    // Start is called before the first frame update
    void Start()
    {
        pokemonName = "Jynx";
        types = Types.Ice;
        types2 = Types.Psychic;
        gender = Gender.Male;

        stats = new Stats();
        stats.hp = 65;
        stats.atk = 60;
        stats.def = 35;
        stats.spatk = 115;
        stats.spdef = 95;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
