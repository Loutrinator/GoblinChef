using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Recipe
{

    [SerializeField] private List<Ingredient> mainIngredients;
    [SerializeField] private List<IngredientType> secondaryIngredients;

    public int GetHash()
    {
        return 0;
    }
}
