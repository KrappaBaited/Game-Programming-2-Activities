using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cinderace : PokemonData
{
    // Start is called before the first frame update
    void Start()
    {
        pokemonName = "Cinderace";
        types = Types.Fire;
        types2 = Types.None;
        gender = Gender.Female;

        stats = new Stats();
        stats.hp = 80;
        stats.atk = 116;
        stats.def = 75;
        stats.spatk = 65;
        stats.spdef = 75;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
