using UnityEngine;
using System.Collections;

//This class determines how th emenu bar is navigated
//enables one to go to the main menu, quit or play.
public class MenuNavigation : MonoBehaviour {

	public void MainMenu()
	{
		Application.LoadLevel("menu");
	}

	public void Quit()
	{
		Application.Quit();
	}
	
	public void Play()
	{
		Application.LoadLevel("game");
	}
	
	public void HighScores()
	{
		Application.LoadLevel("scores");
		
	}

    public void Credits()
    {
        Application.LoadLevel("credits");
    }

	public void SourceCode()
	{
		Application.OpenURL("https://github.com/liguohong657/pac-man.git");
	}
}
