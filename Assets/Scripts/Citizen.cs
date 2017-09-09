using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Citizen : Unit
{
    // Citizen Wandering Behavior
    // If the citizen has not had some stimulus after X amount of time -- idleTime
    // then they pick a random target destination
    // Perhaps reset the idleTime and increment it as they move
    // On idleTime threshold, repeat.

    // Observation behavior
    // I need to add in behavior so that the citizen can "see" the rat.
    // What does sight entail?
    // * The citizen has line of sight in order to see.
    // * Other objects exist which the citizen may see
    // * lighting/ darkness?

    // Couple of immediate ideas
    // * Scan against all objects of a certain layer. Run a raycast between the two objects to determine if they are within view
    // * Have a trigger sphere around all units. Only Check against objects within the sphere. Otherwise, use above.



    void Start()
    {
        OnStart();

    }

    void FixedUpdate()
    {
        OnFixedUpdate();
    }

    void Update()
    {
        OnUpdate();

    }
    protected override void OnStart()
    {
        base.OnStart();
        maxIdle = 2.0f;
    }

    protected override void OnFixedUpdate()
    {
        //float zMove = 7.0f;
        // myRigidbody.AddForce(new Vector3(0, 0, zMove));
        base.OnFixedUpdate();

    }
    protected override void OnUpdate()
    {
        base.OnUpdate();
        // Debug.Log(hasTarget + " " + isIdle + " " + curIdle + " " + target);
        // Debug.Log(curIdle + " " + isResting);
    }

}
