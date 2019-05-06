using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class TextBoxManager : MonoBehaviour
{

    public GameObject textBox;
    public UnityEngine.UI.Text theText;
    public TextAsset textFile;
    public string[] textLines;
    public int currentLine;
    public int endAtLine;

    // Start is called before the first frame update
    void Start()
    {
        if(textFile!=null)
        {
            textLines = (textFile.text.Split('\n'));
        }
        if (endAtLine == 0)
            endAtLine = textLines.Length-1;
    }

    // Update is called once per frame
    void Update()
    {
        theText = GetComponent<UnityEngine.UI.Text>();
        theText.text = textLines[currentLine];
        
    }
}
