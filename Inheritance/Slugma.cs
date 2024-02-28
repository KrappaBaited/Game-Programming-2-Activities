using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slugma : PokemonData
{
    // Start is called before the first frame update
    void Start()
    {
        pokemonName = "Slugma";
        types = Types.Fire;
        types2 = Types.None;
        gender = Gender.Female;

        stats = new Stats();
        stats.hp = 40;
        stats.atk = 40;
        stats.def = 40;
        stats.spatk = 70;
        stats.spdef = 40;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
