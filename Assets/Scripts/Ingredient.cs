using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable] public enum IngredientType{ Vegetable = 1, Fruit = 2, Cereals = 3, Meat = 4, Fish = 5, Spice = 6, Herb = 7}

[Serializable]
public class Ingredient : ScriptableObject
{
    [SerializeField]
    private IngredientType type;
    [SerializeField]
    private Sprite ingredientSprite;
    [SerializeField]
    private int id;
    public int GetHash()
    {
        return type.GetHashCode() * 100 + id;
    }
}