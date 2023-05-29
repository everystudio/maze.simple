using UnityEngine;

public class MazePlayer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        MazeManager.OnGoal.Invoke();
    }

}
