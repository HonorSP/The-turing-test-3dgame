using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * FinalStar - Handles when the level is over.
 */

public class FinalStar : MonoBehaviour
{
    [SerializeField] private string nextLevel;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        SceneManager.LoadScene(nextLevel);
    }
}
