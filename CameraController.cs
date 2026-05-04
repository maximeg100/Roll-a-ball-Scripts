using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = transform.position - player.transform.position; 
        
    }
    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.rKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    // Update is called once per frame
    void LateUpdate()
    {
        
        if (player != null) 
        {
            transform.position = player.transform.position + offset;
        }
    }
}
