using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour {

    public Constants.Levels levelToLoad;

    private void Start() {
        if (levelToLoad == Constants.Levels.NONE_SELECTED) {
            print(gameObject.name + " does not have a level selected to load");
        }
    }

    public void LoadLevel() {
        string sceneKey = GetLevelToLoad();
        if (sceneKey != null) {
            SceneManager.LoadScene(sceneKey);
        }
    }

    private string GetLevelToLoad() {
        switch (levelToLoad) {
            case Constants.Levels.NONE_SELECTED:
                print("Must select a level to load");
                break;
            case Constants.Levels.COLLECT_LEVEL_1:
                return Constants.COLLECT_LEVEL_1;
            case Constants.Levels.COLLECT_LEVEL_2:
                return Constants.COLLECT_LEVEL_2;
            case Constants.Levels.COLLECT_LEVEL_3:
                return Constants.COLLECT_LEVEL_3;
            case Constants.Levels.COLLECT_LEVEL_4:
                return Constants.COLLECT_LEVEL_4;
            case Constants.Levels.COLLECT_LEVEL_5:
                return Constants.COLLECT_LEVEL_5;
            case Constants.Levels.OBSTACLE_LEVEL_1:
                return Constants.OBSTACLE_LEVEL_1;
            case Constants.Levels.OBSTACLE_LEVEL_2:
                return Constants.OBSTACLE_LEVEL_2;
            case Constants.Levels.OBSTACLE_LEVEL_3:
                return Constants.OBSTACLE_LEVEL_3;
            case Constants.Levels.OBSTACLE_LEVEL_4:
                return Constants.OBSTACLE_LEVEL_4;
            case Constants.Levels.OBSTACLE_LEVEL_5:
                return Constants.OBSTACLE_LEVEL_5;
            default:
                print("Level does not exist for sleection");
                return null;
        }
        return null;
    }
}
