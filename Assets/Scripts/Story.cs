using System.Collections;
using Delight;
using Ink.Runtime;
using JSAM;
using UnityEngine;

public class Story : MonoBehaviour
{
    public static Story Instance;
    [SerializeField] private TextAsset InkJsonAsset;

    [SerializeField] private Ink.Runtime.Story story;

    public bool CanContinue = true;


    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    private void Start()
    {
        story = new Ink.Runtime.Story(InkJsonAsset.text);
        
        story.BindExternalFunction<float>("wait", time => { Invoke("Continue", time); });


        story.BindExternalFunction<string>("wait_melody", melody =>
        {
            StartCoroutine(WaitMelody(melody));
        });
        
        story.BindExternalFunction<int>("set_form", num =>
        {
            FindObjectOfType<Player>().ChangeForm(num);
        });
        
        story.BindExternalFunction("cutscene_owl", () =>
        {
            StartCoroutine(OwlCutscene());
        });
        
        JSAM.AudioManager.PlayMusic(AudioLibraryMusic.OST);
        Continue();
    }

    private IEnumerator WaitMelody(string melody)
    {
        CanContinue = false;
        yield return new WaitUntil(() => FindObjectOfType<Flute>().GetLastMelody()==melody);
        CanContinue = true;
        Continue();
    }
    

    public void OnTrigger(string triggerName)
    {
        Path path = new Path($"trigger_{triggerName}");
        story.variablesState[$"trigger_{triggerName}_visits"] = 
            (int) story.variablesState[$"trigger_{triggerName}_visits"] + 1;
        story.ChoosePath(path);
        MainGameView.IsShow = true;
        //HACK
        Continue();
        
        
    }

    public void Continue()
    {
        if (!CanContinue) return;
        
        if (story.canContinue)
        {
            string text = "";
            do
            {
                if (story.canContinue)
                {
                    text = story.Continue();


                    if (story.currentTags.Count > 0) ParseTags();
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

    private void ParseTags()
    {
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


    private void UsePlayerInput(bool use)
    {
        var player = FindObjectOfType<Player>();
        
        player.RecieveInput = use;
        
        if(!use) player.StopMoving();
    }


    private IEnumerator OwlCutscene()
    {
        Debug.Log("CUTSCENE");
        GameObject.Find("cutscene_owl").GetComponent<CutsceneOwl>().enabled = true;
        yield break;
    }
}