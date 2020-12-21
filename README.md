# Unity_GAME

###### Made in the first version: 

- [x] Prefabs with physical laws
- [x] Van moving in z axis

The game looks like this in the first version:

<img src="/img/img1.png" width="630" height="344">

The course I have taken to learn unity is this [link here](https://youtu.be/Xg6TOtrmioA).


###### Challenge 1 (plane): 

 ![Demo CountPages alpha](/img/Hnet-image.gif)
 
 - [x] ctrl or left mouse: run plane and rotate propeller
 - [x] w or up arrow/s or down arrow: up and down plane
 - [x] a or left arrow/d or right arrow: left and right plane 

### Solve the errors

- You need to install the unity component in visual studio 2019 for the suggestions to appear, this [Link](https://www.youtube.com/watch?v=g3sHbFmzq3I&ab_channel=qubodupDev) explains it.
- Error importing assert: Library\PackageCache\com.unity.package-manager-ui@2.0.7\Editor\AssemblyInfo.cs(7,12): error CS0246: The type or namespace name 'UxmlNamespacePrefixAttribute' could not be found (are you missing a using directive or an assembly reference?) Solution [Link](https://answers.unity.com/questions/1677387/why-am-i-getting-this-error-after-importing-a-tuto.html) : 
  - Go to Window-> Package Manager
  - Find the Package Manager UI package, and click remove.
