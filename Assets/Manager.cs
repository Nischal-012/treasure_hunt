using UnityEngine;
using Vuforia;
using TMPro;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
	public TMP_Text score;
	public TMP_Text timer;
	public Button shootButton;
	public TMP_Text youKilled;
	private float time = 10;

	private void Update()
	{
		if (time > 0)
		{
			time -= Time.deltaTime;
		}
		DisplayTime(time);
	}

	void DisplayTime(float timeToDisplay)
	{
		if (timeToDisplay < 0)
		{
			timeToDisplay = 0;
		}
		float minutes = Mathf.FloorToInt(timeToDisplay / 60);
		float seconds = Mathf.FloorToInt(timeToDisplay % 60);
		timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
	}


}
