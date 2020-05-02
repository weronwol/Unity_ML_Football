using UnityEngine;

public class ball : MonoBehaviour
{

    public static bool complete;

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "goal")
        {
            complete = true;
        }
    }
}
