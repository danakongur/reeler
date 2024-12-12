using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Need to update grid to follow type of fish in each fishtank
public class FishGrid : MonoBehaviour
{
  public GameObject fishPrefab; // Reference to the fish prefab

  void Start()
  {
    // Go through all fish in the game categorized by habitat
    foreach (Fish fish in PlayerManager.instance.availableFish)
    {
      GameObject fishObj = Instantiate(fishPrefab, transform);
      FishBehaviour fishBehaviour = fishObj.GetComponent<FishBehaviour>();

      // set fish sprite and catch status and name
      fishBehaviour.caughtFishImage.sprite = fish.fishImage;
      fishBehaviour.fishNameText = fish.name;
      fishBehaviour.isCaught = PlayerManager.instance.IsCaught(fish);
      fishBehaviour.fish = fish;
      Debug.Log($"fish name: {fish.name}, fish catch status: {fishBehaviour.isCaught}");
    }
  }

  // Update is called once per frame
  void Update()
  {

  }
}
