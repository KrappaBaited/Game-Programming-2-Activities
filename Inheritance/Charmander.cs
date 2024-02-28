using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charmander : PokemonData
{
    // Start is called before the first frame update
    void Start()
    {
        pokemonName = "Charmander";
        types = Types.Fire;
        types2 = Types.None;
        gender = Gender.Male;

        stats = new Stats();
        stats.hp = 39;
        stats.atk = 52;
        stats.def = 43;
        stats.spatk = 60;
        stats.spdef = 50;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
