using UnityEngine;
using UnityEngine.Events;

public class MazeManager : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    public static UnityEvent OnGoal = new UnityEvent();

    private void Awake()
    {
        panel.SetActive(false);
        OnGoal.RemoveAllListeners();
        OnGoal.AddListener(() =>
        {
            panel.SetActive(true);
        });
    }
}
