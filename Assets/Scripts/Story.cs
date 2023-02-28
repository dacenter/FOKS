using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Story : MonoBehaviour
{
    [SerializeField]
    private TextAsset InkJsonAsset = null;

    [SerializeField] private Ink.Runtime.Story story;

    // Start is called before the first frame update
    private void Start()
    {
        story = new Ink.Runtime.Story(InkJsonAsset.text);

        while (story.canContinue)
        {
            Debug.Log(story.Continue());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
