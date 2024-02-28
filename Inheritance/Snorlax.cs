using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snorlax : PokemonData
{
    // Start is called before the first frame update
    void Start()
    {
        pokemonName = "Snorlax";
        types = Types.Normal;
        types2 = Types.Poison;
        gender = Gender.Male;

        stats = new Stats();
        stats.hp = 160;
        stats.atk = 110;
        stats.def = 65;
        stats.spatk = 65;
        stats.spdef = 110;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
