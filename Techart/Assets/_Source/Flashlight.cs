using UnityEngine;

public class Flashlight : MonoBehaviour
{
    [SerializeField] private GameObject flashlight;
    [SerializeField] private Door door;
    private bool _on;
    
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            if (!_on)
            {
                _on = true;
                flashlight.SetActive(true);
            }
            else if (_on)
            {
                _on = false;
                flashlight.SetActive(false);
            }
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            door.Use();
        }
    }
}
