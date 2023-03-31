using UnityEngine;
using UnityEngine.EventSystems;

public class EventSystemLoader : MonoBehaviour
{
    public static EventSystemLoader eventSystemLoader;
    private void Awake()
    {
        if (eventSystemLoader == null)
        {
            eventSystemLoader = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
