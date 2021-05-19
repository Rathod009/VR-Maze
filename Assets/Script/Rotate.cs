using UnityEngine;

public class Rotate : MonoBehaviour
{
    private bool isRotate = false;

    public void ChangeBool()
    {
        isRotate = !isRotate;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {       
        if(isRotate)
        {
            transform.Rotate(0, 3, 0);
        }
    }
}
