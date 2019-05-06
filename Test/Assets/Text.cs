using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    public string txtFile = "test";
    string txtContents;
    // Start is called before the first frame update
    void Start()
    {
        TextAsset txtAssets = (TextAsset)Resources.Load(txtFile);
        txtContents = txtAssets.text;
    }

    // Update is called once per frame
    void OnGUI()
    {
        GUILayout.Label(txtContents);
    }
}
