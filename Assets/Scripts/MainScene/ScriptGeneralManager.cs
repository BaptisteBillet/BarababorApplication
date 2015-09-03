using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class ScriptGeneralManager : MonoBehaviour 
{
	#region Members Declaration

	//_______________________________________________________________________________________________________________

	//Hour,Day,Month and year of the time when the player start the app

	int m_CurrentYear;
	int m_CurrentMonth;
	int m_CurrentDay;
	int m_CurrentHour;


	//_______________________________________________________________________________________________________________

	
	//Value of the Hunger,Thirst,Health,Social and Entertainment. Define the movement of the Meter's image.
	int m_Hunger;
	int m_Thirst;
	int m_Health;
	int m_Social;
	int m_Entertainment;

	//_______________________________________________________________________________________________________________


	//Hour,Day,Month and year of the last time the player (for now used one of the needbuttons) played a mini game 
	int m_LastTimeYearHunger;
	int m_LastTimeMonthHunger;
	int m_LastTimeDayHunger;
	int m_LastTimeHourHunger;

	//To Delete
	int m_LastTimeSecondHunger;


	int m_LastTimeYearThirst;
	int m_LastTimeMonthThirst;
	int m_LastTimeDayThirst;
	int m_LastTimeHourThirst;

	int m_LastTimeYearHealth;
	int m_LastTimeMonthHealth;
	int m_LastTimeDayHealth;
	int m_LastTimeHourHealth;

	int m_LastTimeYearSocial;
	int m_LastTimeMonthSocial;
	int m_LastTimeDaySocial;
	int m_LastTimeHourSocial;

	int m_LastTimeYearEntertainment;
	int m_LastTimeMonthEntertainment;
	int m_LastTimeDayEntertainment;
	int m_LastTimeHourEntertainment;
	

	//_______________________________________________________________________________________________________________

	//Value = to m_LastTime... used to compare with m_Year,m_Month...
	int m_ComparativeYearHunger;
	int m_ComparativeMonthHunger;
	int m_ComparativeDayHunger;
	int m_ComparativeHourHunger;



	int m_ComparativeYearThirst;
	int m_ComparativeMonthThirst;
	int m_ComparativeDayThirst;
	int m_ComparativeHourThirst;
	
	int m_ComparativeYearHealth;
	int m_ComparativeMonthHealth;
	int m_ComparativeDayHealth;
	int m_ComparativeHourHealth;
	
	int m_ComparativeYearSocial;
	int m_ComparativeMonthSocial;
	int m_ComparativeDaySocial;
	int m_ComparativeHourSocial;
	
	int m_ComparativeYearEntertainment;
	int m_ComparativeMonthEntertainment;
	int m_ComparativeDayEntertainment;
	int m_ComparativeHourEntertainment;



	//_______________________________________________________________________________________________________________

	
	//Image of the meters
	public Image m_HungerMeterImage;
	public Image m_ThirstMeterImage;
	public Image m_HealthMeterImage;
	public Image m_SocialMeterImage;
	public Image m_EntertainmentMeterImage;


	//_______________________________________________________________________________________________________________

	// GameObjects 
	public GameObject Captain;
	//_______________________________________________________________________________________________________________



	//Panels 
	public GameObject MainPanel;
    //_______________________________________________________________________________________________________________

    public int m_Coins;
    public int m_Diamonds;
	//_______________________________________________________________________________________________________________
	#endregion

	// Use this for initialization
	void Awake () 
	{
		m_CurrentYear = System.DateTime.Now.Year; //Set today's year to m_CurrentYear (today = the day when the player starts the application)
		m_CurrentMonth = System.DateTime.Now.Month;// Set today's month to m_CurrentMonth 
		m_CurrentDay = System.DateTime.Now.Day;
		m_CurrentHour = System.DateTime.Now.Hour;

        PlayerPrefs.SetInt("m_Coins", 100);
        PlayerPrefs.SetInt("m_Diamonds", 5);

		HungerMeter(); // Start the functions HungerMeter, ThirstMeter...
		ThirstMeter(); 
		HealthMeter();
		SocialMeter();
		EntertainmenthMeter();


	}

	#region MetersFunction

	public void HungerMeter ()
	{


		m_ComparativeYearHunger = PlayerPrefs.GetInt ("m_LastTimeYearHunger"); // m_ComparativeYearHunger takes the value of m_LastTimeYearHunger in the PlayersPrefs. PlayersPrefs cannot be used directly. At least I don't know how. 
		m_ComparativeMonthHunger = PlayerPrefs.GetInt ("m_LastTimeMonthHunger");
		m_ComparativeDayHunger = PlayerPrefs.GetInt ("m_LastTimeDayHunger");
		m_ComparativeHourHunger = PlayerPrefs.GetInt ("m_LastTimeHourHunger");

	

		int year = m_CurrentYear - m_ComparativeYearHunger;

		if ((year) > 1) // Check if the last time the player started his application was less than two years ago. 
		{
			m_Hunger = 10;

		} 


		else 
		{
			if (((m_CurrentMonth - m_ComparativeMonthHunger) > 1) || ((m_CurrentMonth - m_ComparativeMonthHunger) < 0) ) //If the last time the player launched the application was last year, check if it was last month (in case the last time was in december and we are on january)
			{
				m_Hunger = 10;

			} 

			else 
			{
				if ((m_CurrentDay - m_ComparativeDayHunger)>1|| ( ((m_CurrentDay - m_ComparativeDayHunger)<0 && (m_CurrentDay - m_ComparativeDayHunger)>-29)))
				{
					m_Hunger = 10;

				}

				else if ((m_CurrentDay - m_ComparativeDayHunger)==1) 
				{
					int DayChange;

					DayChange=24-m_ComparativeHourHunger;
					m_Hunger = DayChange+m_CurrentHour;

				}

				else 
				{
					m_Hunger = m_CurrentHour-m_ComparativeHourHunger;

				}
			}
		}		

	

		float ImageMove = m_Hunger * -4.8f; //Move the hungermeter's image with m_Hunger
			


		m_HungerMeterImage.transform.position+=new Vector3 (0,ImageMove,0);



	}


	public void ThirstMeter ()
	{
		m_ComparativeYearThirst = PlayerPrefs.GetInt ("m_LastTimeYearThirst");
		m_ComparativeMonthThirst = PlayerPrefs.GetInt ("m_LastTimeMonthThirst");
		m_ComparativeDayThirst = PlayerPrefs.GetInt ("m_LastTimeDayThirst");
		m_ComparativeHourThirst = PlayerPrefs.GetInt ("m_LastTimeHourThirst");
		
		
		if ((m_CurrentYear - m_ComparativeYearThirst) > 1) 
		{
			m_Thirst = 10;
		} 
		
		else 
		{
			if (((m_CurrentMonth - m_ComparativeMonthThirst) > 1) || ((m_CurrentMonth - m_ComparativeMonthThirst) < 0) ) 
			{
				m_Thirst = 10;
			} 
			
			else 
			{
				if ((m_CurrentDay - m_ComparativeDayThirst)>1|| ( ((m_CurrentDay - m_ComparativeDayThirst)<0 && (m_CurrentDay - m_ComparativeDayThirst)>-29)))
				{
					m_Thirst = 10;
				}
				
				else if ((m_CurrentDay - m_ComparativeDayThirst)==1) 
				{
					int DayChange;
					
					DayChange=24-m_ComparativeHourThirst;
					m_Thirst = DayChange+m_CurrentHour;
				}
				
				else 
				{
					m_Thirst = m_CurrentHour-m_ComparativeHourThirst;
				}
			}
		}		
		
		float ImageMove = m_Thirst * -4.8f;
		
		
		m_ThirstMeterImage.transform.position+=new Vector3 (0,ImageMove,0);

	}

	public void HealthMeter ()
	{
		m_ComparativeYearHealth = PlayerPrefs.GetInt ("m_LastTimeYearHealth");
		m_ComparativeMonthHealth = PlayerPrefs.GetInt ("m_LastTimeMonthHealth");
		m_ComparativeDayHealth = PlayerPrefs.GetInt ("m_LastTimeDayHealth");
		m_ComparativeHourHealth = PlayerPrefs.GetInt ("m_LastTimeHourHealth");
		
		
		if ((m_CurrentYear - m_ComparativeYearHealth) > 1) 
		{
			m_Health = 10;
		} 
		
		else 
		{
			if (((m_CurrentMonth - m_ComparativeMonthHealth) > 1) || ((m_CurrentMonth - m_ComparativeMonthHealth) < 0) ) 
			{
				m_Health = 10;
			} 
			
			else 
			{
				if ((m_CurrentDay - m_ComparativeDayHealth)>1|| ( ((m_CurrentDay - m_ComparativeDayHealth)<0 && (m_CurrentDay - m_ComparativeDayHealth)>-29)))
				{
					m_Health = 10;
				}
				
				else if ((m_CurrentDay - m_ComparativeDayHealth)==1) 
				{
					int DayChange;
					
					DayChange=24-m_ComparativeHourHealth;
					m_Health = DayChange+m_CurrentHour;
				}
				
				else 
				{
					m_Health = m_CurrentHour-m_ComparativeHourHealth;
				}
			}
		}		
		
	float ImageMove = m_Health * -4.8f;
		
		
		m_HealthMeterImage.transform.position+=new Vector3 (0,ImageMove,0);

	}

	public void SocialMeter ()
	{
		m_ComparativeYearSocial= PlayerPrefs.GetInt ("m_LastTimeYearSocial");
		m_ComparativeMonthSocial = PlayerPrefs.GetInt ("m_LastTimeMonthSocial");
		m_ComparativeDaySocial = PlayerPrefs.GetInt ("m_LastTimeDaySocial");
		m_ComparativeHourSocial = PlayerPrefs.GetInt ("m_LastTimeHourSocial");
		
		
		if ((m_CurrentYear - m_ComparativeYearSocial) > 1) 
		{
			m_Social = 10;
		} 
		
		else 
		{
			if (((m_CurrentMonth - m_ComparativeMonthSocial) > 1) || ((m_CurrentMonth - m_ComparativeMonthSocial) < 0) ) 
			{
				m_Social = 10;
			} 
			
			else 
			{
				if ((m_CurrentDay - m_ComparativeDaySocial)>1|| ( ((m_CurrentDay - m_ComparativeDaySocial)<0 && (m_CurrentDay - m_ComparativeDaySocial)>-29)))
				{
					m_Social = 10;
				}
				
				else if ((m_CurrentDay - m_ComparativeDaySocial)==1) 
				{
					int DayChange;
					
					DayChange=24-m_ComparativeHourSocial;
					m_Social = DayChange+m_CurrentHour;
				}
				
				else 
				{
					m_Social = m_CurrentHour-m_ComparativeHourSocial;
				}
			}
		}		
		
		float ImageMove = m_Social * -4.8f;
		
		
		m_SocialMeterImage.transform.position+=new Vector3 (0,ImageMove,0);

	}

	public void EntertainmenthMeter ()
	{
		m_ComparativeYearEntertainment= PlayerPrefs.GetInt ("m_LastTimeYearEntertainment");
		m_ComparativeMonthEntertainment = PlayerPrefs.GetInt ("m_LastTimeMonthEntertainment");
		m_ComparativeDayEntertainment = PlayerPrefs.GetInt ("m_LastTimeDayEntertainment");
		m_ComparativeHourEntertainment = PlayerPrefs.GetInt ("m_LastTimeHourEntertainment");
		
		
		if ((m_CurrentYear - m_ComparativeYearEntertainment) > 1) 
		{
			m_Entertainment = 10;
		} 
		
		else 
		{
			if (((m_CurrentMonth - m_ComparativeMonthEntertainment) > 1) || ((m_CurrentMonth - m_ComparativeMonthEntertainment) < 0) ) 
			{
				m_Entertainment = 10;
			} 
			
			else 
			{
				if ((m_CurrentDay - m_ComparativeDayEntertainment)>1|| ( ((m_CurrentDay - m_ComparativeDayEntertainment)<0 && (m_CurrentDay - m_ComparativeDayEntertainment)>-29)))
				{
					m_Entertainment= 10;
				}
				
				else if ((m_CurrentDay - m_ComparativeDayEntertainment)==1) 
				{
					int DayChange;
					
					DayChange=24-m_ComparativeHourEntertainment;
					m_Entertainment = DayChange+m_CurrentHour;
				}
				
				else 
				{
					m_Entertainment = m_CurrentHour-m_ComparativeHourEntertainment;
				}
			}
		}		
		
		float ImageMove = m_Entertainment * -4.8f;
		
		
		m_EntertainmentMeterImage.transform.position+=new Vector3 (0,ImageMove,0);

	}

#endregion
   
#region StorageFunction
	public void Hunger ()
	{
		m_Hunger = 0;
		float ImageMove = m_Hunger * -4.8f;
		
		
		m_HungerMeterImage.transform.position+=new Vector3 (0,ImageMove,0);

		PlayerPrefs.SetInt ("m_LastTimeYearHunger", System.DateTime.Now.Year);
		PlayerPrefs.SetInt ("m_LastTimeMonthHunger", System.DateTime.Now.Month);
		PlayerPrefs.SetInt ("m_LastTimeDayHunger", System.DateTime.Now.Day);
		PlayerPrefs.SetInt ("m_LastTimeHourHunger", System.DateTime.Now.Hour);

		//ToDelete

		PlayerPrefs.SetInt ("m_LastTimeSecondHunger", System.DateTime.Now.Second);


	}

	public void Thirst ()
	{
		PlayerPrefs.SetInt ("m_LastTimeYearThirst", System.DateTime.Now.Year);
		PlayerPrefs.SetInt ("m_LastTimeMonthThirst", System.DateTime.Now.Month);
		PlayerPrefs.SetInt ("m_LastTimeDayThirst", System.DateTime.Now.Day);
		PlayerPrefs.SetInt ("m_LastTimeHourThirst", System.DateTime.Now.Hour);
	}

	public void Health ()
	{
		PlayerPrefs.SetInt ("m_LastTimeYearHealth", System.DateTime.Now.Year);
		PlayerPrefs.SetInt ("m_LastTimeMonthHealth", System.DateTime.Now.Month);
		PlayerPrefs.SetInt ("m_LastTimeDayHealth", System.DateTime.Now.Day);
		PlayerPrefs.SetInt ("m_LastTimeHourHealth", System.DateTime.Now.Hour);
	}

	public void Social ()
	{
		PlayerPrefs.SetInt ("m_LastTimeYearSocial", System.DateTime.Now.Year);
		PlayerPrefs.SetInt ("m_LastTimeMonthSocial", System.DateTime.Now.Month);
		PlayerPrefs.SetInt ("m_LastTimeDaySocial", System.DateTime.Now.Day);
		PlayerPrefs.SetInt ("m_LastTimeHourSocial", System.DateTime.Now.Hour);
	}

	public void Entertainment ()
	{
		PlayerPrefs.SetInt ("m_LastTimeYearEntertainment", System.DateTime.Now.Year);
		PlayerPrefs.SetInt ("m_LastTimeMonthEntertainment", System.DateTime.Now.Month);
		PlayerPrefs.SetInt ("m_LastTimeDayEntertainment", System.DateTime.Now.Day);
		PlayerPrefs.SetInt ("m_LastTimeHourEntertainment", System.DateTime.Now.Hour);
	}
#endregion

public void ChangePanel (GameObject PanelToLoad) // Each button gives to the system wich panel must be loaded when pressed 
	{
		MainPanel.SetActive (false);// Set the MainPanel inactive
		Captain.SetActive (false);
		PanelToLoad.SetActive (true);// Load the panel said by the button

	}


public void Quit ()
	{
		Application.Quit();//Quit the Application when the quit button is pressed. 
	}



   
                      
                           
                        
                    






















}
