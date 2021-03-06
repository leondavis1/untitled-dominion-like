﻿using UnityEngine;
using System;


/// <summary>
/// Classes representing the different discrete effects
/// that objects can have on the game state
/// 
/// </summary>
namespace Effects
{
    public abstract class Effect: MonoBehaviour {

        public abstract void Apply();

        public override string ToString()
        {
            return base.ToString();
        }

        public static Effect FromText(string input)
        {
            throw new NotImplementedException();
        }

    };
    


    
}