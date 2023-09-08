using UnityEngine;

/**
 * CorruptionTrigger - Starts/ends movement randomization on trigger.
 */

public class CorruptionTrigger : MonoBehaviour
{
    public GameObject player;
    public bool isBeginning = true;

    void OnTriggerEnter()
    {
        if (isBeginning)
        {
            player.GetComponent<MovementCorruption>().enabled = true;
        }
        else
        {
            player.GetComponent<MovementCorruption>().enabled = false;
        }

    }
}
