using UnityEngine;
using System.Collections;

	public class ButtonNextLevel : MonoBehaviour 
	{
		public void NextLevelButton(int index)
	{
		int i = Application.loadedLevel;
		Application.LoadLevel (i+1);

	}
}