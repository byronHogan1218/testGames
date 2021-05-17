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

    private bool IsMaxReached() {
        return currentAmount >= maxCollectable;
    }

    public void AddOne() {
        currentAmount++;
        if (IsMaxReached()) {
            //Call game over here
            print("The game is over");
        }
    }

    public int GetCurrentAmount() {
        return currentAmount;
    }
}
