using UnityEngine;

public class PlayerConfiguration : MonoBehaviour
{
    //Normally I would separate these into regions from all the other methods and such, but this script is just gonna be a lookup for variables so yeah xd
    [Header("Config")]
    [SerializeField] private float moveSpeed;
    public float MOVESPEED => moveSpeed; //Another layer of variable protection, a public Getter referencing this script's private moveSpeed
    //TODO: moveSpeed is a placeholder for teaching purposes, we CAN have different movement speeds for different contexts
    //For example "moveSpeed" would later be probably turned into moveSpeedGround, or something along those lines
}
