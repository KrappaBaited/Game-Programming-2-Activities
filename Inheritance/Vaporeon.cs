using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vaporeon : PokemonData
{
    // Start is called before the first frame update
    void Start()
    {
        pokemonName = "Vaporeon";
        types = Types.Water;
        types2 = Types.None;
        gender = Gender.Female;

        stats = new Stats();
        stats.hp = 130;
        stats.atk = 65;
        stats.def = 60;
        stats.spatk = 110;
        stats.spdef = 95;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
