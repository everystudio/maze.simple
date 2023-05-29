using UnityEngine;

public class MazePlayer : MonoBehaviour
{
    public bool hasKey; // 持っている場合はTrue
    private void Start()
    {
        hasKey = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Goal"))
        {
            MazeManager.OnGoal.Invoke();
        }
        else if (other.CompareTag("Key"))
        {
            other.gameObject.SetActive(false);
            hasKey = true;
        }
        else if (other.CompareTag("Door"))
        {
            if (hasKey == true)
            {
                other.gameObject.SetActive(false);
            }
            Debug.Log(other.gameObject.name);
        }
    }
}
