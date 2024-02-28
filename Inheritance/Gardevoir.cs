using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gardevoir : PokemonData
{
    // Start is called before the first frame update
    void Start()
    {
        pokemonName = "Gardevoir";
        types = Types.Psychic;
        types2 = Types.Fairy;
        gender = Gender.Female;

        stats = new Stats();
        stats.hp = 68;
        stats.atk = 65;
        stats.def = 65;
        stats.spatk = 125;
        stats.spdef = 115;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
