using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quagsire : PokemonData
{
    // Start is called before the first frame update
    void Start()
    {
        pokemonName = "Quagsire";
        types = Types.Water;
        types2 = Types.Ground;
        gender = Gender.Male;

        stats = new Stats();
        stats.hp = 95;
        stats.atk = 85;
        stats.def = 85;
        stats.spatk = 65;
        stats.spdef = 65;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
