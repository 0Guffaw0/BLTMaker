using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //I got this tutorial from a YouTube vid called "2D Sprites in 3D World - Unity Sprite Billboarding Tutorial"
    //by Paper Mouse Games
    [SerializeField] bool freezeXZAxis = true;
    // Update is called once per frame
    void Update()
    {
        if (freezeXZAxis)
        {
            transform.rotation = Quaternion.Euler(0f, Camera.main.transform.rotation.eulerAngles.y, 0f);
        }
        else
        {
            transform.rotation = Camera.main.transform.rotation;
        }
    }
}
