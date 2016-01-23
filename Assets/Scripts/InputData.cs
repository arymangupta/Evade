using UnityEngine;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;
using System.Collections.Generic;
using UnityEngine.UI;

public class InputData : MonoBehaviour {

    public string Name="Aryaman";
    public string Country = "India";
    public static int PlayerKaScore=0;

    public static int highscore;    // to get the highscore

    public UnityEngine.UI.InputField inputName;
    //public UnityEngine.UI.InputField inputCountry;
    public Text showData, showName;
    String scoreTable , NameTable ;
    public List<Score> scoreClass;
    bool check = true;
    private ScoreSystem storeScore;

    void Awake()
    {
       
        Environment.SetEnvironmentVariable("MONO_REFLECTION_SERIALIZER", "yes");
    }
    void Start()
    {
        Show();// call show initially for highscore
        highscore = scoreClass[scoreClass.Count-1].PlayerScore;
        storeScore = FindObjectOfType<ScoreSystem>();
        showName.text = "Aryaman";

        
    }
    void Update()
    {
        
        showData.text = scoreTable;
        showName.text = NameTable;
    }
	
	public void Submit()
    {
        if (GoogleMobileAdsDemoScript.isAdPresent)
        {
            GoogleMobileAdsDemoScript.destrotAdd();
            GoogleMobileAdsDemoScript.isAdPresent = false;
        }

        // Name = inputName.text;
        //  Country = inputCountry.text;

        // print(inputName.text);
        // print(inputCountry.text);
        Name = inputName.text;
        
       
        

        if (!File.Exists(Application.persistentDataPath + "/scoreSystem.dat"))
        {
           // print("created");
            FileStream file1 = new FileStream(Application.persistentDataPath + "/scoreSystem.dat", FileMode.Create);
        }
        BinaryFormatter toBinary = new BinaryFormatter();
        FileStream file = new FileStream(Application.persistentDataPath + "/scoreSystem.dat", FileMode.Append);


        Score obj = new Score();
        obj.Country = Country;
        obj.Name = Name;
        obj.PlayerScore = PlayerKaScore;
       // print(Name);
       // print(PlayerKaScore);
        toBinary.Serialize(file, obj);
        file.Close();
        Destroy(GameObject.Find("ScoreSystem")); // for correct scoring otherwise missing object expection
       
        Application.LoadLevel(3);
    }
    public void Show()
    {
        
        if (File.Exists(Application.persistentDataPath + "/scoreSystem.dat") && check) {
             
            FileStream file = File.Open(Application.persistentDataPath + "/scoreSystem.dat",FileMode.Open);
            BinaryFormatter toBinary = new BinaryFormatter();

            Score obj = new Score(); // Score object to hold score data
            
            while (file.Position != file.Length)
            {
                obj = (Score)toBinary.Deserialize(file);
               // print(obj.Name); print(obj.Country);
               
                scoreClass.Add(obj); //
            }
            CustomerScoreSort esort = new CustomerScoreSort();
            scoreClass.Sort(esort); // sort the objct list
            for(int i=scoreClass.Count-1; i>=0; --i)
            {
                
                scoreTable += scoreClass[i].PlayerScore + "\n";
                NameTable += (scoreClass.Count - i) + ".      "+scoreClass[i].Name + "\n";
               // Display += " Name: " + scoreClass[i].Name +" | Score: "+scoreClass[i].PlayerScore + "\n";
            }
          
            file.Close();
            check = false;
            
        }
    }   
}
[Serializable]
public class Score
{
    public string Name { get; set; }
    public string Country { get; set; }
    public int PlayerScore { get; set; }
}
class CustomerScoreSort : IComparer<Score>
{
    public int Compare(Score c1, Score c2)
    {
        return c1.PlayerScore.CompareTo(c2.PlayerScore);
    }
}