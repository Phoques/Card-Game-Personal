using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Variable
{

    public class GenericVariable<T> : ScriptableObject
    {
        //This class literally just allows us to pass through the variable in the class line
        //for the different scriptable object data types.
        public T value; // This value needs to be present for all of the inhereted scripts
        // to have a value in the inspector. You MUST say 'T' before the variable name to show its a generic variable.
    }

}

