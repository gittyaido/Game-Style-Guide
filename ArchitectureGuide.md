# Code-Architecture-Guide

Here is a quick outline of general code architecture practices we will try to abide by. Probably missing a lot.

I will not be overly strict about code architecture, but try to make things easy for your teammates and yourself in the future.

First, see [Code Style Guide](C#StyleGuideExample.cs) for general code best practices.


_As Always, let me know if you have questions, concerns, or suggestions. I want everyone to feel good with the workflow of this project._


## General Principles

 in general **try to make your code...**

### Readable
- Write descriptive variable and function names. _(written in such a way that makes comments redundant)_
  
- Avoid messy dependencies. Ideally the dependencies of a function are included in its signature

### and

### Refactorable
- Single responsibility per class
- Avoid tight coupling
- Prefer Composition > Inheritance 


Code and systems will have to be refactored throughout development. When writing code for the first time, set yourself up for this future. If you have to change a system, you should only have to rewrite the system itself and/or its entry point. If a rewrite has you digging through multiple classes, you are sad.

You should write classes in such a way that they can be freely added or removed from the codebase, and nothing breaks. If you find this is not the case for a class you have written, consider ways it could be refactored. Obviously sometimes this kind of thing isn't feasible, but try your best.



## Scene Structure

Any given scene should be made of modular pieces. Avoid dependencies between objects. e.g. The inventory UI shouldn't rely on the player object. We should be able to add and remove prefabs freely from the scene and nothing should break.

Try to connect prefabs through events instead of hardcoded object references.

_Note. Apparently theres support for additive scenes in Unity. I've never used it but it seems very useful. Ill look into it. *If you are familiar with it lmk please*_


## System Communication and Events


For global events and game state changes, We will be using a *scriptable-object driven event system* _(similar to the resource approach in godot)_

For local communication between generic components and actors, we can use *UnityEvents* _(which can be serialized in the inspector)_


For S.O Events:

A created GameEvent scriptable object will serve as a "channel" for event listeners to tune in to, by serializing a GameEvent reference in the inspector

 

## Function Design

Try your best to write [Honest Functions](https://www.youtube.com/watch?v=2OMRWPOSw9s). 

- Limit external dependencies. Prefer to inject dependencies over getting them from class scoped references.

- Separate functions that calculate data and ones that mutate data

- Functions should only operate on one level of abstraction. _(add helper functions for substeps in a problem)_

_Note. these concepts are kinda hard to communicate in bullet points. I highly recommend watching the video above if you have the time._


## MonoBehavior Lifecycle Uses

Awake() -> used for initialization only. GetComponent() etc

Start() -> interface with external dependencies/runtime setup

Update() -> avoid adding logic here directly. Delegate behavior into helper methods

FixedUpdate() -> for physics processes only 








## AI Use

AI is a tool, not the guy you paid to do your homework. 

Here's the problem(s) I have with the overuse of AI:

The code you write is less personal to you, as you did not create everything with intention. This makes the code harder to work with and expand, both for you and your teammates. We ran into this issue a couple times with Sand of Souls. AI is also not perfect at designing systems that fit your needs. I find it has a habit of atrocious overengineering.

Games are complicated pieces of software. Sometimes its not enough for a system to "just work". You may have to reuse that system in the context of many other game pieces, and at that point, its not just about it working, but you having a clear understanding of _how_ it works and how to use it. If you get a robot to write the code for you, you miss that piece.

Now that being said. It has its uses, just be generally mindful.


### Good Uses 

- Prompting AI to kickstart the ideation phase of some new system. Have it brainstorm architecture/structure ideas, instead of having it implement whole systems.
- Filling out boiler plate
- Complete algorithms that are already well documented and do not require creativity to implement.
- Tedious renaming and (simple) refactors 
- Debugging

### Bad Uses
- "vibe coding" 
- Prompting high level requests and having ai write all the code for you 
- Anything art, animation, or writing related. 
- ctr A, ctr C, ctr V

_Note. If you have an AI agent built into your IDE (which you most definitely do), I strongly recommend against letting it modify your codebase directly (barring inline code suggestions ig). Instead, if you are going to use AI to write any code, have it write it separate from the code base, at which point you can thoughtfully include what you want._




## Resources

[Honest Functions](https://www.youtube.com/watch?v=2OMRWPOSw9s)
[Dependency Injection]()
[SOLID Principles]()


