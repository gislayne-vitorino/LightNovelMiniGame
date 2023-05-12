using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MiniGameController : MonoBehaviour {

    public StoryScene currentScene;
    public BottomBarController bottomBar;
    public BackgroundController backgroundController;

    private State state = State.IDLE;

    private enum State {
        IDLE, ANIMATE, CHOOSE
    }

 //   void Start() {
    //    bottomBar.playScene(currentScene);
   // }

    void Update() {
        if(Input.GetKeyDown(KeyCode.Space) ||  
        Input.GetMouseButtonDown(0)) 
        {
                if(bottomBar.IsCompleted()) {

  //                  if(bottomBar.IsLastSentence()) {
//                    currentScene = currentScene.nextScene;
  //                     bottomBar.playScene(currentScene);
                   // }
                        bottomBar.PlayNextSentence();
                }
        }
    }

}