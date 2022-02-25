using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class SceneLoader: MonoBehaviour
{

    public MapGenerator mapGen;
    int min = -333333333;
    int max = 333333333;
    public static int rseed;

    public TerrainData terrainData;
	public NoiseData noiseData;
	public TextureData textureData;

    public EndlessTerrain endless;

    public GameObject menu;
    public GameObject worldsettings;

    public Material meshmaterial;
    public Material mapmaterial;

    public GameObject textureButton;

    public GameObject plane;
    public GameObject mesh;

    public GameObject menuCanvas;
    public GameObject soundCanvas;
    public GameObject endCanvas;

    public GameObject waves;
    public GameObject birds;
    public GameObject wind;
    public GameObject jungle;
    public GameObject desert;
    public GameObject rain;
    public GameObject polar;
    public GameObject storm;
    public GameObject city;

    public Button wavesbutton;
    public Button birdsbutton;
    public Button windbutton;
    public Button junglebutton;
    public Button desertbutton;
    public Button rainbutton;
    public Button polarbutton;
    public Button stormbutton;
    public Button citybutton;

    public GameObject ariamath;

    public GameObject shaderButton;
    public GameObject worldgen;

    bool win = false;
    bool wav = false;
    bool bir = false;
    bool jun = false;
    bool des = false;
    bool rai = false;
    bool pol = false;
    bool sto = false;
    bool cit = false;

    bool soundcanv = false;

    public Text endText;
    public Text seedText;
    public Text typeText;
    public Text heightText;
    public Text dataText;
    public Text soundText;

    List<string> sounds = new List<string>();
    

    public void Scene(string Scene) {
        ariamath.SetActive(false);
        SceneManager.LoadScene("WorldScene");
        generatetest();
        textureData.ApplyToMaterial(meshmaterial);
        terrainData.useFlatShading = false;
    }

    public void loadworld(string Scene){
        ariamath.SetActive(false);
        if(noiseData.worldscene==0){
            SceneManager.LoadScene("WorldScene");
            noiseData.worldscene=1;
        } else if(noiseData.worldscene==1){
            SceneManager.LoadScene("WorldScene1");
            noiseData.worldscene=2;
        } else if(noiseData.worldscene==2){
            SceneManager.LoadScene("WorldScene2");
            noiseData.worldscene=3;
        } else if(noiseData.worldscene==3){
            SceneManager.LoadScene("WorldScene3");
            noiseData.worldscene=4;
        } else if(noiseData.worldscene==4){
            SceneManager.LoadScene("WorldScene4");
            noiseData.worldscene=5;
        } else if(noiseData.worldscene==5){
            SceneManager.LoadScene("WorldScene5");
            noiseData.worldscene=6;
        } else if(noiseData.worldscene==6){
            SceneManager.LoadScene("WorldScene6");
            noiseData.worldscene=7;
        } else if(noiseData.worldscene==7){
            SceneManager.LoadScene("WorldScene7");
            //noiseData.worldscene=8;
        } /*else if(noiseData.worldscene==8){
            SceneManager.LoadScene("WorldScene8");
        }*/
        generatetest();
        textureData.ApplyToMaterial(meshmaterial);
        terrainData.useFlatShading = false;
    }

    public void sceneworld(string Scene){
        SceneManager.LoadScene("WorldScene");
        generatetest();
        textureData.ApplyToMaterial(meshmaterial);
        terrainData.useFlatShading = false;
    }

    public void finalScene(string Scene){
        SceneManager.LoadScene("FinalWorld");
        generatetest();
        textureData.ApplyToMaterial(meshmaterial);
        terrainData.useFlatShading = false;
    }
 
    public void StartScene(string Scene) {
        SceneManager.LoadScene("StartScene");
        GameObject.Find("SeedText").GetComponentInChildren<Text>().text = noiseData.seed.ToString();
        //noiseData.worldscene = 0;
        generatetest();
        terrainData.useFlatShading = true;
        //GameObject.Find("ViewText").GetComponentInChildren<Text>().text = "3D";
        //view();
    }

    public void reloadscene(string Scene){
        //worldgen.SetActive(false);
        SceneManager.LoadScene("StartScene");
        generatetest();
        terrainData.useFlatShading = true;
    }

    public void savedata(){
        Debug.Log("Seed: " + noiseData.seed);
        Debug.Log("World Type: " + terrainData.useFalloff);
        Debug.Log("Generation Height: " + terrainData.meshHeightMultiplier);
        Debug.Log("Noise Scale: " + noiseData.noiseScale);
        Debug.Log("Lacunarity: " + noiseData.lacunarity);
        Debug.Log("Persistance: " + noiseData.persistance);
        Debug.Log("Sounds: " + string.Join(" , ", sounds ));

        seedText.text = "Seed:  " + noiseData.seed.ToString();
        if(terrainData.useFalloff==true){
            typeText.text = "World Type: Island";
        }
        else{
            typeText.text = "World Type: Continent";
        }
        heightText.text = "Generation Height: " + "\n" + terrainData.meshHeightMultiplier.ToString() + "\n";
        dataText.text = "Noise Scale:  " + noiseData.noiseScale.ToString() + "\n" + "Lacunarity:  " + noiseData.lacunarity.ToString() + "\n" +  "Persistance:  " + noiseData.persistance.ToString();
        sounddata();
        soundCanvas.SetActive(false);
        menuCanvas.SetActive(false);
        endCanvas.SetActive(true);
    }

    void sounddata(){
        soundText.text = "Sounds:  " + string.Join(" , ", sounds );
    }

    public void newworldscene(){
        Scene newtestscene = SceneManager.CreateScene("NewWorldScene");
        SceneManager.LoadScene("NewWorldScene");
        GameObject newmapgen;
        GameObject newmesh;
        newmapgen = new GameObject("Map Generator");
        newmesh = new GameObject("New Mesh");
        newmapgen.AddComponent<MapGenerator>();
        newmapgen.AddComponent<EndlessTerrain>();
        newmapgen.AddComponent<MapDisplay>();
        newmapgen.AddComponent<SceneLoader>();
        newmesh.AddComponent<MeshFilter>();
        newmesh.AddComponent<MeshRenderer>();
        newmesh.AddComponent<MeshFilter>();
        newmesh.AddComponent<MeshCollider>();
        newmesh.AddComponent<HideOnPlay>();
    }


    public void Music(){
        if(soundcanv==false){
            soundCanvas.SetActive(true);
            soundcanv=true;
        }
        else{
            soundCanvas.SetActive(false);
            soundcanv=false;
        }
    }

    public void windaudio(){
        if(win==false){
            wind.SetActive(true);
            win=true;
            windbutton.GetComponent<Image>().color = Color.yellow;
            sounds.Add("Wind");
        }
        else{
            wind.SetActive(false);
            win=false;
            windbutton.GetComponent<Image>().color = Color.white;
            sounds.Remove("Wind");
        }
    }

    public void wavaudio(){
        if(wav==false){
            waves.SetActive(true);
            wav=true;
            wavesbutton.GetComponent<Image>().color = Color.yellow;
            sounds.Add("Waves");
        }
        else{
            waves.SetActive(false);
            wav=false;
            wavesbutton.GetComponent<Image>().color = Color.white;
            sounds.Remove("Waves");
        }
    }

    public void biraudio(){
        if(bir==false){
            birds.SetActive(true);
            bir=true;
            birdsbutton.GetComponent<Image>().color = Color.yellow;
            sounds.Add("Birds");
        }
        else{
            birds.SetActive(false);
            bir=false;
            birdsbutton.GetComponent<Image>().color = Color.white;
            sounds.Remove("Birds");
        }
    }

    public void junaudio(){
        if(jun==false){
            jungle.SetActive(true);
            jun=true;
            junglebutton.GetComponent<Image>().color = Color.yellow;
            sounds.Add("Jungle");
        }
        else{
            jungle.SetActive(false);
            jun=false;
            birds.SetActive(false);
            bir=false;
            junglebutton.GetComponent<Image>().color = Color.white;
            sounds.Remove("Jungle");
    }
    }

    public void desertaudio(){
        if(des==false){
            desert.SetActive(true);
            des=true;
            desertbutton.GetComponent<Image>().color = Color.yellow;
            sounds.Add("Desert");
        }
        else{
            desert.SetActive(false);
            des=false;
            birds.SetActive(false);
            bir=false;
            desertbutton.GetComponent<Image>().color = Color.white;
            sounds.Remove("Desert");
        }
    }

    public void rainaudio(){
        if(rai==false){
            rain.SetActive(true);
            rai=true;
            rainbutton.GetComponent<Image>().color = Color.yellow;
            sounds.Add("Rain");
        }
        else{
            rain.SetActive(false);
            rai=false;
            rainbutton.GetComponent<Image>().color = Color.white;
            sounds.Remove("Rain");
    }
    }

    public void polaraudio(){
        if(pol==false){
            polar.SetActive(true);
            pol=true;
            polarbutton.GetComponent<Image>().color = Color.yellow;
            sounds.Add("Polar");
        }
        else{
            polar.SetActive(false);
            pol=false;
            polarbutton.GetComponent<Image>().color = Color.white;
            sounds.Remove("Polar");
        }
    }

    public void stormaudio(){
        if(sto==false){
            storm.SetActive(true);
            sto=true;
            stormbutton.GetComponent<Image>().color = Color.yellow;
            sounds.Add("Storm");
        }
        else{
            storm.SetActive(false);
            sto=false;
            stormbutton.GetComponent<Image>().color = Color.white;
            sounds.Remove("Storm");
        }
    }

    public void cityaudio(){
        if(cit==false){
            city.SetActive(true);
            cit=true;
            citybutton.GetComponent<Image>().color = Color.yellow;
            sounds.Add("City");
        }
        else{
            city.SetActive(false);
            cit=false;
            citybutton.GetComponent<Image>().color = Color.white;
            sounds.Remove("City");
        }
    }
    
    public void view(){
        if(GameObject.Find("ViewText").GetComponentInChildren<Text>().text == "2D"){
            plane.SetActive(false);
            mesh.SetActive(true);
            GameObject.Find("ViewText").GetComponentInChildren<Text>().text = "3D";
            //mapGen.DrawMeshMapInEditor();
            mapGen.drawMode = MapGenerator.DrawMode.Mesh;
            generatetest();
            textureData.ApplyToMaterial(meshmaterial);
        }
        else{
            mesh.SetActive(false);
            plane.SetActive(true);
            GameObject.Find("ViewText").GetComponentInChildren<Text>().text = "2D";
            mapGen.drawMode = MapGenerator.DrawMode.ColourMap;
            generatetest();
        }
    }

    public void testtexture(){
        textureData.ApplyToMaterial(meshmaterial);
        //GameObject.Find("TextureText").GetComponentInChildren<Text>().text = "Shader";
        shaderButton.SetActive(false);
        //menu.SetActive(false);
    }

    public void ApplyTexture(){
        if( GameObject.Find("TextureText").GetComponentInChildren<Text>().text == "Texture"){
            textureData.ApplyToMaterial(meshmaterial);
            GameObject.Find("TextureText").GetComponentInChildren<Text>().text = "Shader";
        }
        else if( GameObject.Find("TextureText").GetComponentInChildren<Text>().text == "Shader"){
            textureData.ApplyToMaterial(mapmaterial);
            GameObject.Find("TextureText").GetComponentInChildren<Text>().text = "Colour";
        }
        else if( GameObject.Find("TextureText").GetComponentInChildren<Text>().text == "Colour"){
            textureData.ApplyToMaterial(meshmaterial);
            GameObject.Find("TextureText").GetComponentInChildren<Text>().text = "Shader";
        }
    }

    public void generatetest(){
        mapGen.DrawMapInEditor();
        textureData.ApplyToMaterial(meshmaterial);
    }


    public void adjustScale(float newscale){
        noiseData.noiseScale = newscale;
        generatetest();
        textureData.ApplyToMaterial(meshmaterial);
    }

    public void adjustOcts(float newocts){
        noiseData.octaves = (int) newocts;
        generatetest();
        textureData.ApplyToMaterial(meshmaterial);
    }

    public void adjustPers(float newpers){
        noiseData.persistance = (float) newpers;
        generatetest();
        textureData.ApplyToMaterial(meshmaterial);
    }

    public void adjustLac(float newlac){
        noiseData.lacunarity = (float) newlac;
        generatetest();
        textureData.ApplyToMaterial(meshmaterial);
    }

    public void heightslider(float newheight){
        terrainData.meshHeightMultiplier = newheight;
        generatetest();
        textureData.ApplyToMaterial(meshmaterial);
    }

    public void adjustHeight(){

        if( GameObject.Find("HeightTextButton").GetComponentInChildren<Text>().text == "Flat/Medium/High"){
            terrainData.meshHeightMultiplier = 10;
            GameObject.Find("HeightTextButton").GetComponentInChildren<Text>().text = "Flat";
        }
        else if( GameObject.Find("HeightTextButton").GetComponentInChildren<Text>().text == "Flat"){
            terrainData.meshHeightMultiplier = 40;
            GameObject.Find("HeightTextButton").GetComponentInChildren<Text>().text = "Medium";

        }
        else if( GameObject.Find("HeightTextButton").GetComponentInChildren<Text>().text == "Medium"){
            terrainData.meshHeightMultiplier = 60;
            GameObject.Find("HeightTextButton").GetComponentInChildren<Text>().text = "High";
        }
        else if( GameObject.Find("HeightTextButton").GetComponentInChildren<Text>().text == "High"){
            terrainData.meshHeightMultiplier = 10;
            GameObject.Find("HeightTextButton").GetComponentInChildren<Text>().text = "Flat";
        }
    }

    /*public void adjustOffset(Vector2 newvec){
        //(offx, offy)
        noiseData.offset = newvec;
        generatetest();
        textureData.ApplyToMaterial(meshmaterial);
    }*/

    /*public void changeMaterial(){
        GameObject.GetComponent
    }*/


    public void defaultdata(){
        noiseData.noiseScale = 51.5F;
        GameObject.Find ("NoiseSlider").GetComponent <Slider>().value = 51.5F;
        //noiseData.octaves = 3;
        //GameObject.Find ("OctSlider").GetComponent <Slider>().value = 3;
        noiseData.persistance = 0.471F;
        GameObject.Find ("PersSlider").GetComponent <Slider>().value = 0.471F;
        noiseData.lacunarity = 2;
        GameObject.Find ("LacSlider").GetComponent <Slider>().value = 2;
        terrainData.meshHeightMultiplier = 30;
        GameObject.Find ("HeightSlider").GetComponent <Slider>().value = 30;
        generatetest();
        textureData.ApplyToMaterial(meshmaterial);
    }

    public void backbutton(){
        menu.SetActive(true);
        worldsettings.SetActive(false);
        GameObject.Find("SeedText").GetComponentInChildren<Text>().text = noiseData.seed.ToString();
    }

    public void settingsbutton(){
        worldsettings.SetActive(true);
        menu.SetActive(false);
        plane.SetActive(false);
        mesh.SetActive(true);
        GameObject.Find("ViewText").GetComponentInChildren<Text>().text = "3D";
        mapGen.drawMode = MapGenerator.DrawMode.Mesh;
        generatetest();
        textureData.ApplyToMaterial(meshmaterial);
    }

    public void falloff(){
        if(terrainData.useFalloff){
            terrainData.useFalloff = false;
            GameObject.Find("TypeText").GetComponentInChildren<Text>().text = "Continent";
            generatetest();
        }
        else{
            terrainData.useFalloff = true;
            GameObject.Find("TypeText").GetComponentInChildren<Text>().text = "Island";
            generatetest();
        }
    }

     
    public void randomseed(){
        int randseed = Random.Range(min, max);
        GameObject.Find("SeedText").GetComponentInChildren<Text>().text = randseed.ToString();
        rseed = randseed;
        noiseData.seed = rseed;
        generatetest();
    } 
    
  
}