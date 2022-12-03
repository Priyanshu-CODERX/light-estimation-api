# 💡 AR Core Light Estimation API
A key part for creating realistic AR experiences is getting the lighting right. When a virtual object is missing a shadow or has a shiny material that doesn't reflect the surrounding space, users can sense that the object doesn't quite fit, even if they can't explain why. This is because humans subconsciously perceive cues regarding how objects are lit in their environment. The Lighting Estimation API analyzes given images for such cues, providing detailed information about the lighting in a scene. You can then use this information when rendering virtual objects to light them under the same conditions as the scene they're placed in, keeping users grounded and engaged.

## 💡 Lighting Cues
The Lighting Estimation API provides detailed data that lets you mimic various lighting cues when rendering virtual objects. These cues are shadows, ambient light, shading, specular highlights, and reflections.

## 💡 Shadows
Shadows are often directional and tell viewers where light sources are coming from.

## 💡 Ambient Light
Ambient light is the overall diffuse light that comes in from around the environment, making everything visible.

## 💡 Shading
Shading is the intensity of the light. For example, different parts of the same object can have different levels of shading in the same scene, depending on angle relative to the viewer and its proximity to a light source.

## 💡 Specular Highlights
Specular highlights are the shiny bits of surfaces that reflect a light source directly. Highlights on an object change relative to the position of a viewer in a scene.

## 💡 Reflections
Light bounces off of surfaces differently depending on whether the surface has specular (highly reflective) or diffuse (not reflective) properties. For example, a metallic ball will be highly specular and reflect its environment, while another ball painted a dull matte gray will be diffuse. Most real-world objects have a combination of these properties — think of a scuffed-up bowling ball or a well-used credit card.

Reflective surfaces also pick up colors from the ambient environment. The coloring of an object can be directly affected by the coloring of its environment. For example, a white ball in a blue room will take on a bluish hue.

## ⚒️ Development Tools
- Unity Engine 2020.3.40f1
- AR Foundation 4.2.7
- AR Core XR Plugin 4.2.7

## ⚒️ Running Locally
Make sure to use Unity 2020 or higher versions for this project to work properly.
* Download [Unity Hub](https://unity3d.com/get-unity/download "Unity Hub")
* Install Unity version 2020 or higher<br>
<img alt="unity hub" width="500px" src="https://i.postimg.cc/tyf4TqW9/ss1.jpg" ></img>
* Install Android Build Support, OpenJDK, Android SDK & NDK Tools
<img alt="unity hub" width="500px" src="https://i.postimg.cc/YCDybnBV/ss2.jpg" ></img>
* Clone the repository `git clone https://github.com/Priyanshu-CODERX/light-estimation-api.git`
* Open the project with your Unity Engine
* Switch build platform to Android
* Go to project setting's and change the minimum api level to `Android 7.0 API Level 23`
* Build the apk

## 💡 Light Estimation Demo
[![Demo Video](https://developers.google.com/static/ar/develop/images/rocket-direct-spherical-cubemap.jpg)](https://youtube.com/shorts/miCkOAuJSvc?feature=share)