using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void Scene(int Scene){
        SceneManager.LoadScene(Scene);
    }
}
