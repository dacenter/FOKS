using Delight;
using Ink.Runtime;
using JSAM;
using UnityEngine;

public class Story : MonoBehaviour
{
    public static Story Instance;
    [SerializeField] private TextAsset InkJsonAsset;

    [SerializeField] private Ink.Runtime.Story story;


    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    private void Start()
    {
        JSAM.AudioManager.PlayMusic(AudioLibraryMusic.OST);
        story = new Ink.Runtime.Story(InkJsonAsset.text);
        


        story.BindExternalFunction<float>("wait", time => { Invoke("Continue", time); });


        Continue();
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void OnTrigger(string triggerName)
    {
        Path path = new Path($"trigger_{triggerName}");
        Debug.Log(story.variablesState[$"trigger_{triggerName}_visits"]);
        story.variablesState[$"trigger_{triggerName}_visits"] = 
            (int) story.variablesState[$"trigger_{triggerName}_visits"] + 1;
        story.ChoosePath(path);
        MainGameView.IsShow = true;
        //HACK
        Continue();
        
        
    }

    public void Continue()
    {
        if (story.canContinue)
        {
            string text = "";
            do
            {
                if (story.canContinue)
                {
                    text = story.Continue();
                    Debug.Log(text);


                    if (story.currentTags.Count > 0)
                        switch (story.currentTags[0])
                        {
                            case "enableInput":
                                UsePlayerInput(true);
                                break;
                            case "disableInput":

                                UsePlayerInput(false);
                                break;
                            case "hide":
                                MainGameView.IsShow = false;
                                break;
                        }
                }
                else
                {
                    MainGameView.IsShow = false;
                    break;
                }
            } while (string.IsNullOrEmpty(text) || text == "\n");

            MainGameView.CurrentText = text;
        }
        else
        {
            MainGameView.IsShow = false;
        }
    }


    public void UsePlayerInput(bool use)
    {
        FindObjectOfType<Player>().RecieveInput = use;
    }
}