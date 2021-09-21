using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine;

public class SkinManager : MonoBehaviour
{
    public SpriteRenderer sr;
    public List<Sprite> skins = new List<Sprite>();
    public GameObject playerSkin;
    

    private int selectedSkin = 0;
    public void NextOption()
    {
        selectedSkin = selectedSkin + 1;
        if (selectedSkin == skins.Count)
        {
            selectedSkin = 0;
        }
        sr.sprite = skins[selectedSkin];
    }

    public void BackOption()
    {
        selectedSkin = selectedSkin - 1;
        if (selectedSkin < skins.Count)
        {
            selectedSkin = skins.Count -1;
        }
        sr.sprite = skins[selectedSkin];
    }

    public void PlayGame()
    {
        PrefabUtility.SaveAsPrefabAsset(playerSkin, "Assets/Assets/Prefabs/SelectedSkin.prefab");
        SceneManager.LoadScene("Test Scene");
    }
}
