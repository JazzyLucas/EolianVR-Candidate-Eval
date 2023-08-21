This repository serves as cheat-sheet for the coding part of a candidate evaluation I underwent at a lab for [EolianVR](https://eolianvr.com/), August of 2023.

Keep in mind that future evaluations may be different.

You may find a better solution to everything, and my Issues tab is open.

---

### Overview

The unedited assignment given to me:

> - Create a unity project deployable to HoloLens using MRTK that will:
>   - Compile and run
>   - Recognize hands and at least the click gesture
> - Stretch goal
>   - Fire a ball when the click gesture is recognized that interacts with spatially meshed terrain

There are several hidden discrepancies within the assignment that I was made aware of during/after completion. Let's dive in.

The "Unity project" itself (the source code), is not the actual deliverable.

While this is completable (by definition) without a physical HoloLens, here are the two unstated and expected deliverables:
- "The executable."
- "The app on a HoloLens 2."

Your code may compile, and it may deploy from Visual Studio successfully. However, none of that matters if you don't have the two unstated deliverables.

EolianVR did not provide any pipeline, build, or test service for my evaluation - get those working beforehand.

The assignment deadline was initially 24 hours, which you may use to the full extent if you aren't aware of the various unstated aspects.

---

### Hints, Errors, and Solutions

#### Get all of the necessary tools from [this page](https://learn.microsoft.com/en-us/windows/mixed-reality/develop/install-the-tools?tabs=unity). And make sure you're using the latest Visual Studio, regardless of what IDE you typically use with Unity.

#### Don't use the normal Unity Editor "Build" window, install and use MRTK's build window.

Open the [Mixed Reality Feature Tool](https://learn.microsoft.com/en-us/windows/mixed-reality/develop/unity/welcome-to-mr-feature-tool), and get `Mixed Reality Toolkit > Mixed Reality Toolkit Tools`.

Then access the build window in the Unity editor  `Mixed Reality > Toolkit > Utilities > Build Window`.

The build window gives you Multicore builds (much faster) and will try to configure your build the best it can.

#### If you go to build Appx and get...

`error MSB3774: Could not find SDK "WindowsMobile, Version=10.0.22621.0"`

Delete these similar lines of generated xml in the `.vcxproj` file of the built Visual Studio solution.
```xml
  <ItemGroup>
    <SDKReference Include="WindowsMobile, Version=10.0.19041.1" />
  </ItemGroup>
```
Retry, and the solution will still build without the WindowsMobile SDK.

#### Rebuild the solution file every time you make modifications for the deployed build.

The solution file contains your code and project changes, so you have to rebuild it every time you make the Appx build.

EolianVR wanted a "test everything" approach, but they test upon deployment. That's backwards compared to the industry standard.

---

### Know-Before

- I did not receive or sign any paperwork throughout the entire evaluation.
- EolianVR *did not* provide me with a computer, and I was only told "bring a computer with Unity on it."
  - I was informed *after* the coding assignment, that EolianVR would've provided a proper setup if requested.
  - [All of the tools for MRTK](https://learn.microsoft.com/en-us/windows/mixed-reality/develop/install-the-tools?tabs=unity) are quite large - install beforehand.
- EolianVR *did* provide a HoloLens 2 for the coding assignment upon request.
- There were no software engineers (or related subject employees) in office during my entire evaluation. 
- Be prepared for narcotics within the office to be involved second-hand.

Cheers.
