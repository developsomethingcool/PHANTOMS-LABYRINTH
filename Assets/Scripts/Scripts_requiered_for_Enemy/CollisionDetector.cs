using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This script is ised for the detection between loot and the player. 
 * When the player touches the loot this script adds the adequet states to the players attribute manager and deltes itself.
 */

public class CollisionDetector : MonoBehaviour
{
    private string attributName; // The name of the attribute affected by the collision
    private float change; // The amount of change to the attribute

    //Setfunktion used to set the name and value of the attribute represente by the lootobject this script is attached to
    public void setValues(string name, float value)
    {
        attributName = name;
        change = value;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collision involves the colliders you are interested in
        if ("Player".Equals(other.gameObject.tag))
        {
            GameObject player = other.gameObject.transform.root.gameObject; // Get the root game object of the collided player
            AttributeManager am = player.GetComponent<AttributeManager>(); // Get the AttributeManager component of the player
            am.variables[attributName] = am.variables[attributName] + change; // Update the attribute value in the AttributeManager
            am.UpdateVariables(); // Update the AttributeManager

            Destroy(gameObject); // Destroy the game object attached to this script
        }
    }
}
