
# react-native-react-native-poly-chat

## Getting started

`$ npm install react-native-react-native-poly-chat --save`

### Mostly automatic installation

`$ react-native link react-native-react-native-poly-chat`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-react-native-poly-chat` and add `RNReactNativePolyChat.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNReactNativePolyChat.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNReactNativePolyChatPackage;` to the imports at the top of the file
  - Add `new RNReactNativePolyChatPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-react-native-poly-chat'
  	project(':react-native-react-native-poly-chat').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-react-native-poly-chat/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-react-native-poly-chat')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNReactNativePolyChat.sln` in `node_modules/react-native-react-native-poly-chat/windows/RNReactNativePolyChat.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Com.Reactlibrary.RNReactNativePolyChat;` to the usings at the top of the file
  - Add `new RNReactNativePolyChatPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNReactNativePolyChat from 'react-native-react-native-poly-chat';

// TODO: What to do with the module?
RNReactNativePolyChat;
```
  