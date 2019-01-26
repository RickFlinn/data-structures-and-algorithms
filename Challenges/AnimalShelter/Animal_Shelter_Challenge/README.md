# Animal Shelter 

## Challenge
Create an `AnimalShelter` class that can take in only `Cat` or `Dog` objects. The AnimalShelter only lets Cats and Dogs leave in a First In, First Out basis.
The AnimalShelter must have three methods:
  - Enqueue(animal) - accepts an animal, and adds it to the shelter if it is a `Cat` or `Dog`
  - Dequeue(pref) - takes in a string representing a preference for a `Cat` or `Dog`. If the preference is for a `"cat"` or a `"dog"`, return the requested `Cat` or `Dog` that has been in the shelter the longest, respectively.
  - Dequeue() - return the `Cat` or `Dog` that has been in the shelter the longest (First In, First Out)
  
## Approach and Efficiency
First, I define a few classes to implement my solution.
I define class `Animal`, and classes `Dog` and `Cat`, which both inherit from `Animal`.
I also define class `CageNode`. `CageNodes` are a `Node` that hold animals, as well as an integer `SerialNumber`. 
I define a proprietary `CageQueue` class to contain these `CageNode`s.

My `AnimalShelter` contains two properties - a Queue called `Dogs`, and Queue called `Cats`, and an internal field called `NextSerial`.

#### Enqueue(Animal animal)
Enqueue accepts an animal as a parameter, then checks its type. If it `is` a `Cat` or `Dog`, it creates a new `CageNode` containing the given animal and the value of `NextSerial`, enqueues the `CageNode` into the respective `Cats` and `Dogs` internal queues, iterates `NextSerial`, and returns `true`.
Otherwise, returns `false`. 

#### Dequeue(string pref) 
Dequeue accepts a string indicating a preference for a `Dog` or `Cat` to be dequeued from the shelter. If `pref` is `"dog"`, it dequeues and returns from the `Dogs` queue; likewise if `pref` is `"cat"`.
Otherwise, returns `null`.

#### Dequeue()
Dequeue, without a given preference, should return the `Dog` or `Cat` that has been inside the `AnimalShelter` the longest. It does this by `Peek`ing the `Cats` and `Dogs` queues, and comparing the `SerialNumber` of the two `CageNode`s, and dequeueing and returning the animal in the cage with the smallest serial number.

## Solution 
![Animal Shelter Solution](https://github.com/RickFlinn/data-structures-and-algorithms/blob/master/assets/AnimalShelterWhiteboard.jpg)
