using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextScene : MonoBehaviour
{
    private void OnMouseDown()
    {
        FindObjectOfType<LevelLoader>().LoadNextScene();
    }
}
