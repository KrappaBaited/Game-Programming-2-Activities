using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulbasaur : PokemonData
{
    // Start is called before the first frame update
    void Start()
    {
        pokemonName = "Bulbasaur";
        types = Types.Grass;
        types2 = Types.Poison;
        gender = Gender.Female;

        stats = new Stats();
        stats.hp = 45;
        stats.atk = 49;
        stats.def = 49;
        stats.spatk = 65;
        stats.spdef = 65;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
