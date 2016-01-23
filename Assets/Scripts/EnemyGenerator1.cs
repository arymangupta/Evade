using UnityEngine;
using System.Collections;

public class EnemyGenerator1 : MonoBehaviour {

    public GameObject enemy; // simple enemy 
    public GameObject enemy1; // enemy with flairs blue
    public GameObject enemy2;// enemy with red flairs
    public static bool stopEnemy;
    int counter;
    float x = 2.5f;
    float x1 = -2.4f;

    // color converter method
    Vector4 ColorConverter(int r, int g, int b, int a) {
        return new Vector4(r / 255.0f, g / 255.0f, b / 255.0f, a / 255.0f);
    }


	// Use this for initialization
	void Start () {
        counter = 0;
        stopEnemy = true;
        InvokeRepeating("Generator", 2, 2);
        //print ("enejefkj");
    }

    void Generator()
    {
       //print(counter);
        Vector2 position = new Vector2(Random.Range(-2, 2), 25);
        if (counter < 100000 && stopEnemy) {
            // CAMERA COLOR
            if (counter == 1) Camera.main.backgroundColor = ColorConverter(0, 161, 255, 80); // camera color
            if (counter == 12) Camera.main.backgroundColor = ColorConverter(123, 0, 255, 80);
            if (counter == 22) Camera.main.backgroundColor = ColorConverter(208, 0, 195, 80);
            if (counter == 32) Camera.main.backgroundColor = ColorConverter(255, 110, 0, 80);
            if (counter == 41) Camera.main.backgroundColor = ColorConverter(90, 86, 59, 80);
            if (counter == 51) Camera.main.backgroundColor = ColorConverter(123, 122, 122, 255);
            if (counter == 62) Camera.main.backgroundColor = ColorConverter(234, 207, 162, 80);
            if (counter == 72) Camera.main.backgroundColor = ColorConverter(51, 77, 38, 80);
            if(counter == 84)  Camera.main.backgroundColor = ColorConverter(47, 79, 79, 80); // dark grey blue
            if(counter == 94)  Camera.main.backgroundColor = ColorConverter(0, 0, 0, 80);//black
            if (counter == 104) Camera.main.backgroundColor = ColorConverter(123, 0, 255, 80);
            if (counter == 114) Camera.main.backgroundColor = ColorConverter(160, 82, 45, 80);
            if(counter == 124) Camera.main.backgroundColor = ColorConverter(105, 105, 105, 80);
            if(counter == 134) Camera.main.backgroundColor = ColorConverter(34, 139, 34, 80);
            if(counter == 144) Camera.main.backgroundColor = ColorConverter(244, 164, 96 ,80); // orange
            // flair color
            if (counter == 82)
            {
               
                enemy2.GetComponent<SpriteRenderer>().color = ColorConverter(100, 149, 237, 255);
                enemy2.GetComponent<ParticleSystem>().startColor = ColorConverter(70, 130, 180, 255);// steelBlue

            }
            if (counter == 92)
            { 
               
                enemy2.GetComponent<SpriteRenderer>().color = ColorConverter(205, 92, 92, 255);
                enemy2.GetComponent<ParticleSystem>().startColor = ColorConverter(153, 0, 0, 255);//red
            }
            if (counter == 102)
            {
                
                   
                enemy2.GetComponent<SpriteRenderer>().color = ColorConverter(255, 0, 195, 255); // pink
                enemy2.GetComponent<ParticleSystem>().startColor = ColorConverter(139, 0, 139, 200); 
            }
            if (counter == 112)
            {
                
                enemy2.GetComponent<SpriteRenderer>().color = ColorConverter(139, 69, 19, 255);
                enemy2.GetComponent<ParticleSystem>().startColor = ColorConverter(210, 105, 30, 255);
            }
            if (counter == 122)
            {
               
                enemy2.GetComponent<SpriteRenderer>().color = ColorConverter(255, 255, 255, 255);
                enemy2.GetComponent<ParticleSystem>().startColor = ColorConverter(245, 245, 245, 255);
            }
            if (counter == 132)
            {
               
                enemy2.GetComponent<SpriteRenderer>().color = ColorConverter(0, 250, 154, 255);
                enemy2.GetComponent<ParticleSystem>().startColor = ColorConverter(0, 255, 127, 255);
            }
            if (counter == 142)
            {
               
                enemy2.GetComponent<SpriteRenderer>().color = ColorConverter(205, 133, 63, 255);
                enemy2.GetComponent<ParticleSystem>().startColor = ColorConverter(210, 105, 30, 255); // chocolate
            }
            // one one can beat level
            if(counter > 160)
            {
                enemy2.GetComponent<ParticleSystem>().startColor = ColorConverter(218, 165, 32, 255);
               
                if (counter == 162) Camera.main.backgroundColor = ColorConverter(0, 161, 255, 80); // camera color
                if (counter == 163) Camera.main.backgroundColor = ColorConverter(123, 0, 255, 80);
                if (counter == 164) Camera.main.backgroundColor = ColorConverter(208, 0, 195, 80);
                if (counter ==165) Camera.main.backgroundColor = ColorConverter(255, 110, 0, 80);
                if (counter == 166) Camera.main.backgroundColor = ColorConverter(90, 86, 59, 80);
                if (counter == 167) Camera.main.backgroundColor = ColorConverter(123, 122, 122, 255);
                if (counter == 168) Camera.main.backgroundColor = ColorConverter(234, 207, 162, 80);
                if (counter == 169) Camera.main.backgroundColor = ColorConverter(51, 77, 38, 80);
                if (counter == 170) Camera.main.backgroundColor = ColorConverter(47, 79, 79, 80); // dark grey blue
                if (counter == 171) Camera.main.backgroundColor = ColorConverter(0, 0, 0, 80);//black
                
            }


            if (counter < 10) // level1
            {

                

                enemy.GetComponent<SpriteRenderer>().color = ColorConverter(0, 238, 255, 255);
                enemy.GetComponent<Rigidbody2D>().gravityScale = 0.2f;
                Instantiate(enemy, position, Quaternion.identity);
                counter++;
            }


            else if (counter >= 10 && counter < 20) // level 2
            {
              
                //change color and gravity scale and istantiate enemy
                enemy.GetComponent<Rigidbody2D>().gravityScale = 0.2f;
                enemy.GetComponent<SpriteRenderer>().color = ColorConverter(238, 0, 255, 255);
                Instantiate(enemy, position, Quaternion.identity);

                //change color, gravity scale, x position and then instantiate enemy
                position.x = Random.Range(-2, x);
                enemy.GetComponent<Rigidbody2D>().gravityScale = 0.25f;
                enemy.GetComponent<SpriteRenderer>().color = ColorConverter(238, 0, 255, 255);
                Instantiate(enemy, position, Quaternion.identity);
                counter++;



            }
            else if (counter >= 20 && counter < 30) // level 3
            {
               
                //change color and gravity scale and istantiate enemy
                enemy.GetComponent<Rigidbody2D>().gravityScale = 0.2f;
                enemy.GetComponent<SpriteRenderer>().color = ColorConverter(255, 0, 195, 255);
                Instantiate(enemy, position, Quaternion.identity);

                //change color, gravity scale, x position and then instantiate enemy
                position.x = Random.Range(-2, x);
                enemy.GetComponent<Rigidbody2D>().gravityScale = 0.25f;
                enemy.GetComponent<SpriteRenderer>().color = ColorConverter(255, 0, 195, 255);
                Instantiate(enemy, position, Quaternion.identity);

                //change color, gravity scale, x position and then instantiate enemy
                position.x = Random.Range(-2, x);
                enemy.GetComponent<Rigidbody2D>().gravityScale = 0.3f;
                enemy.GetComponent<SpriteRenderer>().color = ColorConverter(255, 0, 195, 255);
                Instantiate(enemy, position, Quaternion.identity);
                counter++;
            }

            else if (counter >= 30 && counter < 40) // level 4
            {
               
                //change color and gravity scale and istantiate enemy
                enemy.GetComponent<Rigidbody2D>().gravityScale = 0.2f;
                enemy.GetComponent<SpriteRenderer>().color = ColorConverter(255, 204, 0, 255);
                Instantiate(enemy, position, Quaternion.identity);

                //change color, gravity scale, x position and then instantiate enemy
                position.x = Random.Range(-2, x);
                enemy.GetComponent<Rigidbody2D>().gravityScale = 0.25f;
                enemy.GetComponent<SpriteRenderer>().color = ColorConverter(255, 204, 0, 255);
                Instantiate(enemy, position, Quaternion.identity);

                //change color, gravity scale, x position and then instantiate enemy
                position.x = Random.Range(-2, x);
                enemy.GetComponent<Rigidbody2D>().gravityScale = 0.3f;
                enemy.GetComponent<SpriteRenderer>().color = ColorConverter(255, 204, 0, 255);
                Instantiate(enemy, position, Quaternion.identity);
                position.y = 24f;
                //change color, gravity scale, x position and then instantiate enemy
                position.x = Random.Range(-2, x);
                enemy.GetComponent<Rigidbody2D>().gravityScale = 0.35f;
                enemy.GetComponent<SpriteRenderer>().color = ColorConverter(255, 204, 0, 255);
                Instantiate(enemy, position, Quaternion.identity);

                counter++;
            }



            else if (counter >= 40 && counter < 50) // level 5
            {
                
                //change color and gravity scale and istantiate enemy
                enemy.GetComponent<Rigidbody2D>().gravityScale = 0.2f;
                enemy.GetComponent<SpriteRenderer>().color = ColorConverter(238, 220, 148, 255);
                Instantiate(enemy, position, Quaternion.identity);

                //change color, gravity scale, x position and then instantiate enemy
                position.x = Random.Range(-2, x);
                enemy.GetComponent<Rigidbody2D>().gravityScale = 0.25f;
                enemy.GetComponent<SpriteRenderer>().color = ColorConverter(238, 220, 148, 255);
                Instantiate(enemy, position, Quaternion.identity);

                //change color, gravity scale, x position and then instantiate enemy
                position.x = Random.Range(-2, x);
                enemy.GetComponent<Rigidbody2D>().gravityScale = 0.3f;
                enemy.GetComponent<SpriteRenderer>().color = ColorConverter(238, 220, 148, 255);
                Instantiate(enemy, position, Quaternion.identity);
                position.y = 24f;
                //change color, gravity scale, x position and then instantiate enemy
                position.x = Random.Range(-2, x);
                enemy.GetComponent<Rigidbody2D>().gravityScale = 0.35f;
                enemy.GetComponent<SpriteRenderer>().color = ColorConverter(238, 220, 148, 255);
                Instantiate(enemy, position, Quaternion.identity);

                //change color, gravity scale, x position and then instantiate enemy
                position.x = Random.Range(-2, x);
                enemy.GetComponent<Rigidbody2D>().gravityScale = 0.4f;
                enemy.GetComponent<SpriteRenderer>().color = ColorConverter(238, 220, 148, 255);
                Instantiate(enemy, position, Quaternion.identity);
                counter++;
            }

            else if (counter >= 50 && counter < 60) // level 6(1)
            {
               
                //change color and gravity scale and istantiate enemy
                enemy.GetComponent<Rigidbody2D>().gravityScale = 0.2f;
                enemy.GetComponent<SpriteRenderer>().color = new Vector4(1, 1, 1, 1);
                Instantiate(enemy, position, Quaternion.identity);

                //change color, gravity scale, x position and then instantiate enemy
                position.x = Random.Range(-2, x);
                enemy.GetComponent<Rigidbody2D>().gravityScale = 0.25f;
                enemy.GetComponent<SpriteRenderer>().color = new Vector4(1, 1, 1, 1);
                Instantiate(enemy, position, Quaternion.identity);

                //change color, gravity scale, x position and then instantiate enemy
                position.x = Random.Range(-2, x);
                enemy.GetComponent<Rigidbody2D>().gravityScale = 0.3f;
                enemy.GetComponent<SpriteRenderer>().color = new Vector4(1, 1, 1, 1);
                Instantiate(enemy, position, Quaternion.identity);
                position.y = 24f;
                //change color, gravity scale, x position and then instantiate enemy
                position.x = Random.Range(-2, x);
                enemy.GetComponent<Rigidbody2D>().gravityScale = 0.35f;
                enemy.GetComponent<SpriteRenderer>().color = new Vector4(1, 1, 1, 1);
                Instantiate(enemy, position, Quaternion.identity);

                //change color, gravity scale, x position and then instantiate enemy
                position.x = Random.Range(-2, x);
                enemy1.GetComponent<Rigidbody2D>().gravityScale = 0.4f;
                enemy1.GetComponent<SpriteRenderer>().color = new Vector4(1, 1, 1, 1);
                Instantiate(enemy1, position, Quaternion.identity);
                counter++;
            }
            else if (counter >= 60 && counter < 70) // level 7(3)
            {
               
                enemy2.GetComponent<ParticleSystem>().startColor = ColorConverter(218, 165, 32, 255);// goldenrod
                //change color, gravity scale, x position and then instantiate enemy
                position.x = Random.Range(x1, x); position.y = 30f;
                enemy.GetComponent<Rigidbody2D>().gravityScale = 0.2f;
                enemy.GetComponent<SpriteRenderer>().color = ColorConverter(234, 207, 162, 255);
                Instantiate(enemy, position, Quaternion.identity);

                //change color, gravity scale, x position and then instantiate enemy
                position.x = Random.Range(x1, x);
                enemy.GetComponent<Rigidbody2D>().gravityScale = 0.25f;
                enemy.GetComponent<SpriteRenderer>().color = ColorConverter(234, 207, 162, 255);
                Instantiate(enemy, position, Quaternion.identity);

                //change color, gravity scale, x position and then instantiate enemy
                position.x = Random.Range(x1, x);
                enemy2.GetComponent<Rigidbody2D>().gravityScale = 0.3f;
                
                enemy2.GetComponent<SpriteRenderer>().color = ColorConverter(234, 207, 162, 255);
                Instantiate(enemy2, position, Quaternion.identity);
                position.y = 29f;
                //change color, gravity scale, x position and then instantiate enemy
                position.x = Random.Range(x1, x);
                enemy1.GetComponent<Rigidbody2D>().gravityScale = 0.35f;
                enemy1.GetComponent<SpriteRenderer>().color = ColorConverter(234, 207, 162, 255);
                Instantiate(enemy1, position, Quaternion.identity);

                //change color, gravity scale, x position and then instantiate enemy
                position.x = Random.Range(x1, x);
                enemy1.GetComponent<Rigidbody2D>().gravityScale = 0.4f;
                enemy1.GetComponent<SpriteRenderer>().color = ColorConverter(234, 207, 162, 255);
                Instantiate(enemy1, position, Quaternion.identity);
                counter++;
            }
            else if (counter >=70 && counter < 80) // level 8(5)
            {
                enemy2.GetComponent<ParticleSystem>().startColor = ColorConverter(218, 165, 32, 255);// goldenrod
                //change color, gravity scale, x position and then instantiate enemy
                //position.x = Random.Range(x1 ,x);
                position.y = 40f;
                //enemy1.GetComponent<Rigidbody2D>().gravityScale = 0.2f;
              //  enemy1.GetComponent<SpriteRenderer>().color = ColorConverter(179, 255, 140, 255);
                //Instantiate(enemy1, position, Quaternion.identity);

                //change color, gravity scale, x position and then instantiate enemy
                position.x = Random.Range(x1, x);
                enemy1.GetComponent<Rigidbody2D>().gravityScale = 0.25f;
                enemy1.GetComponent<SpriteRenderer>().color = ColorConverter(179, 255, 140, 255);
                Instantiate(enemy1, position, Quaternion.identity);

                //change color, gravity scale, x position and then instantiate enemy
                position.x = Random.Range(x1, x);
                enemy1.GetComponent<Rigidbody2D>().gravityScale = 0.3f;
                enemy1.GetComponent<SpriteRenderer>().color = ColorConverter(179, 255, 140, 255);
                Instantiate(enemy1, position, Quaternion.identity);
                position.y = 39f;
                //change color, gravity scale, x position and then instantiate enemy
                position.x = Random.Range(x1, x);
                enemy2.GetComponent<Rigidbody2D>().gravityScale = 0.35f;
                enemy2.GetComponent<SpriteRenderer>().color = ColorConverter(179, 255, 140, 255);
                Instantiate(enemy2, position, Quaternion.identity);

                //change color, gravity scale, x position and then instantiate enemy
                position.x = Random.Range(x1, x);
                enemy2.GetComponent<Rigidbody2D>().gravityScale = 0.4f;
                enemy2.GetComponent<SpriteRenderer>().color = ColorConverter(179, 255, 140, 255);
                Instantiate(enemy2, position, Quaternion.identity);
                counter++;
            }
            else if (counter >=80 && counter < 1000) // level 9(5)
            {
                
                //change color, gravity scale, x position and then instantiate enemy
                position.y = 40f;
                

                //change color, gravity scale, x position and then instantiate enemy
                position.x = Random.Range(x1, x);
                enemy2.GetComponent<Rigidbody2D>().gravityScale = 0.2f;
               
                Instantiate(enemy2, position, Quaternion.identity);

                //change color, gravity scale, x position and then instantiate enemy
                position.x = Random.Range(x1, x);
                enemy2.GetComponent<Rigidbody2D>().gravityScale = 0.25f;
            
                Instantiate(enemy2, position, Quaternion.identity);
                position.y = 39f;
                //change color, gravity scale, x position and then instantiate enemy
                position.x = Random.Range(x1, x);
                enemy2.GetComponent<Rigidbody2D>().gravityScale = 0.3f;
             
                Instantiate(enemy2, position, Quaternion.identity);

                //change color, gravity scale, x position and then instantiate enemy
                position.x = Random.Range(x1, x);
                enemy2.GetComponent<Rigidbody2D>().gravityScale = 0.35f;
                Instantiate(enemy2, position, Quaternion.identity);
                counter++;
                if(counter>162)
                {
                    position.x = Random.Range(x1, x);
                    enemy2.GetComponent<Rigidbody2D>().gravityScale = 0.4f;
                    Instantiate(enemy2, position, Quaternion.identity);
                }
            }
           
        }
       
    }

    

}
