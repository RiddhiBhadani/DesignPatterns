# Design Patterns in Game Design
 
### Object Pooling 
Object pooling is a design pattern that manages the efficient creation and reuse of objects. 
It improves performance, optimizes memory management, and eliminates the overhead caused by continuous instantiation and destruction of game objects.

*Steps of the Object Pooling Pattern:*
1. Initialize Pool: Pre-instantiate a fixed number of objects and store them in a collection (e.g., a list or queue).
2. Request Object: Retrieve an inactive object from the pool when needed.
3. Activate Object: Enable and use the object as required.
4. Return to Pool: Deactivate the object and return it to the pool for future use.
5. Handle Shortages: Optionally expand the pool if all objects are in use.
**Real-life example in Game Designs:  ObjectPool Class for Bullets**

### Singleton Pattern
The Singleton pattern ensures that a class has only one instance and provides a global point of access to it. 
It simplifies the management of shared resources and avoids the creation of multiple instances.

*Steps of the Factory Singleton Pattern:*
1. Create Static Instance: Declare a static variable to hold the instance of the class.
2. Ensure Single Instance: In the Awake or Start method, check if the instance is null. If it is, assign the current object to the instance; if not, destroy the duplicate.
3. Global Access: Provide a public static property or method to access the instance from other parts of the application.
4. Persist Across Scenes: Optionally, use DontDestroyOnLoad to retain the instance between scene transitions.
5. Access Instance: Access the singleton instance whenever needed, without creating new instances.
**Real-life example in Game Designs:  SceneManager, LevelManger, SoundManager**

### Factory Method Pattern
The Factory Method Pattern is a way to create objects without specifying the exact class. 
It lets subclasses decide which type of object to create, making the code more flexible and easier to maintain. 
This keeps the client code simple and decoupled from the object creation process.

*Steps of the Factory Method Pattern:*
1. Define Creator: Create an abstract class or interface with a method (factory method) to create objects.
2. Implement Concrete Creators: Subclasses override the factory method to create specific objects.
3. Define Product: Create a common interface for all products (objects).
4. Create Concrete Products: Implement concrete classes that represent specific products.
5. Use Creator: The client interacts with the creator class to instantiate objects without knowing the exact type of product being created.
**Real-life example in Game Designs:  Weapon Factory**

### Observer Pattern
The Observer Pattern is a behavioral design pattern that defines a one-to-many dependency relationship between objects.
When the state of one object (the subject) changes, all its dependent objects (the observers) are notified and updated automatically.

*Steps of the Observer Pattern:*
1. Define Subject: Create a subject class that maintains a list of observers and notifies them of state changes.
2. Attach Observers: Observers register themselves to the subject to receive updates.
3. Change State: When the subject’s state changes, it triggers the notification process.
4. Notify Observers: The subject notifies all registered observers about the state change.
5. Update Observers: Each observer reacts to the state change and updates itself accordingly.
**Real-life example in Game Designs:  To update UI element; like Healthbar Observer**
