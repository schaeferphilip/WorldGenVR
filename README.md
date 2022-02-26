# WorldGenVR
Procedural World Generator for Stressreduction in VR

The app consists of two scenes.

The first scene is used to choose the terrain by playing around with the different world settings (e.g. seed, noise scale, octaves, offset, etc). You will also be able to switch between a 2D and 3D view in the first scene to get a better overview of your world.

There will also be an option between an island world generation and a continental world generation.

![alt text](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/92dd821c-26c0-4560-9104-814a52a7f280/Untitled.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220226%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220226T003252Z&X-Amz-Expires=86400&X-Amz-Signature=e5ca0dfa81cfbb0013e69c3b2dcea26af0d00265782054230602c2284c6d1973&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Untitled.png%22&x-id=GetObject)

Continental generation (chunks are made up of entire generated continents that flow into each other)

![alt text](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/e2981ad8-0cea-4be1-be88-ab7ac75c96b2/Untitled.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220226%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220226T003319Z&X-Amz-Expires=86400&X-Amz-Signature=a7119755d392fcdc4ac826eb8303524b6ab943ba98f6ca4402598aadc3013ed4&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Untitled.png%22&x-id=GetObject)

Island generation (each chunk has a landmass surrounded by water)

![alt text](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/b778aed5-fd4e-4ccf-9025-54d11c2493e0/Untitled.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220226%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220226T003339Z&X-Amz-Expires=86400&X-Amz-Signature=ad8a6e8f3106fd7004799db8a9d3eb3d59e51133d5ad6b61041057f3ce335d84&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Untitled.png%22&x-id=GetObject)

3D view of the world (continental)

![alt text](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/56cd6faa-9cad-4b80-a7c8-ff7b30dfb5e4/Untitled.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220226%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220226T003351Z&X-Amz-Expires=86400&X-Amz-Signature=a32c100a1e3475ace749e2975a8b640969f29733342b07a434fd3d242dd01376&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Untitled.png%22&x-id=GetObject)

3D view of the world (island world)

The menu:

![alt text](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/b7890f2c-c914-4981-8912-9ac7d3e00db0/Untitled.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220226%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220226T011850Z&X-Amz-Expires=86400&X-Amz-Signature=d0a4bdcc9de0f76220b4dc5652a2288b68991c19d349276c42bf6be6c40d0291&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Untitled.png%22&x-id=GetObject)

Clicking on the rear button of the right controller opens the upper menu. (The left controller is there to control, i.e. to run etc.)

Here you can choose the world type (island or continent) and the seed. The seed is random, and generates a new random seed with each click. The text of the button then also shows the seed number.

The picture below shows the World Settings menu. Here you can play around with different values to create your ideal world. With back you get back to the main menu.
![alt text](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/c481e2ba-f054-4442-9ad9-2c4cc837b457/Untitled.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220226%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220226T011926Z&X-Amz-Expires=86400&X-Amz-Signature=a2f34210bc99b29520968b48b447880f207228d7ccb115ea77967042c2326c55&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Untitled.png%22&x-id=GetObject)

The **second scene** then spawns the player in the world. Here you have the option to choose between a normal color texture (see the first image below) and a shader (second image).

![alt text](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/d635a2b7-e58c-4340-99f6-f269c18cc72d/Untitled.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220226%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220226T003445Z&X-Amz-Expires=86400&X-Amz-Signature=d552a75f072c515b7065cedf51d36e36a94c9fa70b0b5be84b6f2ed231706282&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Untitled.png%22&x-id=GetObject)

![alt text](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/c55867f0-a5cc-4787-9a5f-5c8b285ff759/Untitled.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220226%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220226T003606Z&X-Amz-Expires=86400&X-Amz-Signature=092bde368a67e651ddc9ce96568607b7337a90fce3dbc83b66194e104cd997d2&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Untitled.png%22&x-id=GetObject)

After the textures/shaders you will then have the option to assign the world to a climate zone (Arctic, Mild and Tropical). The climate zone then also determines which plants and trees are spawned. For example, the Arctic climate spawns fir trees and has snow at a lower altitude than the other climate types. The tropical climate, on the other hand, will have no snow and will spawn palm and acacia trees. The mild climate is a mix of both and can be compared to the climate here in Germany and then spawns tree species such as an oak.

The pictures below show this Sound Menu and also the end screen, which pops-up when the user is finished with his sound selection.

![alt_text](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/1bec2b13-df15-454b-a45c-2d35d0ae8148/Untitled.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220226%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220226T012257Z&X-Amz-Expires=86400&X-Amz-Signature=ba4cb269224f6dc0bca70219d113531fde2a3da3f079213e57f6ac7888390224&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Untitled.png%22&x-id=GetObject)
![alt_text](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/57eed26e-a768-41ee-b8e2-bd314f1f87a3/Untitled.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220226%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220226T012316Z&X-Amz-Expires=86400&X-Amz-Signature=53abd503fb907d5e8bcb0eb5ca109bb5631613fadcdb271f010ac7a57770a5a1&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Untitled.png%22&x-id=GetObject)

 
  
-------------------------------------------------------------------------
 
  
   

# WorldGenVR User Study - Instructions
- We want to find out which elements of world generation can reduce stress
- First you will test the app and then fill out a questionnaire.
- For the app we use the Oculus Quest 2 VR glasses.
- During testing we work with the principle "Thinking out loud". So please speak your thoughts out loud during this time.
- With the left controller thumbstick (1) you can run, with the rear trigger button of the right controller (6) you can click buttons.
![alt_text](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/cb920292-8fc9-4c7e-a587-fdbceb890224/Untitled.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220226%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220226T004905Z&X-Amz-Expires=86400&X-Amz-Signature=93abb3ce3e6b64641e7ea85481a1b18fe617a65902efa5bc638a50b53e7b7273&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Untitled.png%22&x-id=GetObject)
- Put on the VR glasses and adjust them appropriately (head attachment with the white band and the distance between the lenses)
![alt_text](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/00b4ae8f-db81-415b-ad83-88e78048c669/Untitled.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220226%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220226T004934Z&X-Amz-Expires=86400&X-Amz-Signature=b8b2c9d56040168ccf646ad696e00b26428ce528cbb963f8c11659c8448f1f4e&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Untitled.png%22&x-id=GetObject)
- The "VRExperience Scene" is for the first experience in VR, try to walk around, look around and then when you're ready click on "Simulate Stress".

![alt_text](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/d8476f1f-fe47-45ee-9307-f9ecef367dab/Untitled.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220226%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220226T005124Z&X-Amz-Expires=86400&X-Amz-Signature=3404b3981dfab7caee16b296d10c0e9747f39ad20bf0bfef6ebeaf2de0548d16&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Untitled.png%22&x-id=GetObject)

- You will then be taken to the Stress Generation Scene where you will do the Stroop Test, a short video on how to generate stress.
- When you have finished watching the video, click the "WorldGenVR" button to enter the app.

![alt_text](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/5846ee42-31e8-4516-a136-096aae6eaa2f/Untitled.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220226%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220226T005159Z&X-Amz-Expires=86400&X-Amz-Signature=4dd12da524a8e0b181bf2f2f775a63b043b6823caab9c67a6837d0d4c5f3b7cc&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Untitled.png%22&x-id=GetObject)

- In the app you should play around with the values of the world generation until you have your preferred world that you feel comfortable in.

![alt_texz](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/5491cc3d-1f8a-4b06-a117-0d3ef2fa0313/Untitled.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220226%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220226T005440Z&X-Amz-Expires=86400&X-Amz-Signature=1dfffc91d498d2621a0de79cbc868868d0ac588caa2e6bd823445c63f7d18c72&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Untitled.png%22&x-id=GetObject)
![alt_text](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/0f48afd7-a6a7-4727-a8e5-e3244576f783/Untitled.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220226%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220226T005459Z&X-Amz-Expires=86400&X-Amz-Signature=95c58dcb9e8bdffb53395d4dc1a60d0001be447e79c44685b7d1c7533a33c02a&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Untitled.png%22&x-id=GetObject)

- Finally you will be teleported into the world where you can play around with a few sounds to find your favorite combination.
![alt_text](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/7891f877-eca2-48e9-8471-5636ba8be814/Untitled.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220226%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220226T010123Z&X-Amz-Expires=86400&X-Amz-Signature=3a7c97a542e1d442340bfc50f7ba9bcd50768598bf62ee9ed65e11be838d16b1&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Untitled.png%22&x-id=GetObject)
- When you are done, click the "Save Data" button to finish.

![alt_text](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/05e413df-fb9a-475d-9ab8-e76b5fd66948/Untitled.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220226%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220226T010210Z&X-Amz-Expires=86400&X-Amz-Signature=6713ce4e3b4a9b412bd0e84ceda9ccffbec53eacd4658bf6404a631be1bfa23f&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Untitled.png%22&x-id=GetObject)
- Then you take off the VR glasses and fill out the user study.

![alt_text](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/c55867f0-a5cc-4787-9a5f-5c8b285ff759/Untitled.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220226%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220226T010757Z&X-Amz-Expires=86400&X-Amz-Signature=2757b6422c581c407358a510e9336e223c8b0a4140c50ddf508f6251facf98f0&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Untitled.png%22&x-id=GetObject)

Thank you for participating! 🙂
