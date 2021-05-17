using UnityEngine;

public class CollectableManager : MonoBehaviour {
    public int maxCollectable = 1;
    private int currentAmount = 0;

    void Start() {
        currentAmount = 0;
        if (maxCollectable <= 0) {
            print("Set the max collectable to the number of collectables needed in the level");
        }
    }

    private bool isMaxReached() {
        return currentAmount >= maxCollectable;
    }

    public void addOne() {
        currentAmount++;
        if (isMaxReached()) {
            //Call game over here
            print("The game is over");
        }
    }

    public int getCurrentAmount() {
        return currentAmount;
    }
}
