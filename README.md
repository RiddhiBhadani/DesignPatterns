# DesignPatterns
 
### Object Pooling 
Object pooling is a design pattern that manages the efficient creation and reuse of objects. 
It improves performance, optimizes memory management, and eliminates the overhead caused by continuous instantiation and destruction of game objects.

1. Initialize Pool: Pre-instantiate a fixed number of objects and store them in a collection (e.g., a list or queue).
2. Request Object: Retrieve an inactive object from the pool when needed.
3. Activate Object: Enable and use the object as required.
4. Return to Pool: Deactivate the object and return it to the pool for future use.
5. Handle Shortages: Optionally expand the pool if all objects are in use.


### Singleton Pattern
The Singleton pattern ensures that a class has only one instance and provides a global point of access to it. 
It simplifies the management of shared resources and avoids the creation of multiple instances.

1. Create Static Instance: Declare a static variable to hold the instance of the class.
2. Ensure Single Instance: In the Awake or Start method, check if the instance is null. If it is, assign the current object to the instance; if not, destroy the duplicate.
3. Global Access: Provide a public static property or method to access the instance from other parts of the application.
4. Persist Across Scenes: Optionally, use DontDestroyOnLoad to retain the instance between scene transitions.
5. Access Instance: Access the singleton instance whenever needed, without creating new instances.
#### Real-life example in Game Designs:  SceneManager Or LevelManger, SoundManager, 
