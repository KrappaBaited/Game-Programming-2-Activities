using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blaziken : PokemonData
{
    // Start is called before the first frame update
    void Start()
    {
        pokemonName = "Blaziken";
        types = Types.Fire;
        types2 = Types.Fighting;
        gender = Gender.Male;

        stats = new Stats();
        stats.hp = 80;
        stats.atk = 120;
        stats.def = 70;
        stats.spatk = 110;
        stats.spdef = 70;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
