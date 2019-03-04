
# react-native-perfect-components

## Getting started

`$ npm install react-native-perfect-components --save`

### Mostly automatic installation

`$ react-native link react-native-perfect-components`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-perfect-components` and add `RNPerfectComponents.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNPerfectComponents.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNPerfectComponentsPackage;` to the imports at the top of the file
  - Add `new RNPerfectComponentsPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-perfect-components'
  	project(':react-native-perfect-components').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-perfect-components/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-perfect-components')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNPerfectComponents.sln` in `node_modules/react-native-perfect-components/windows/RNPerfectComponents.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Perfect.Components.RNPerfectComponents;` to the usings at the top of the file
  - Add `new RNPerfectComponentsPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNPerfectComponents from 'react-native-perfect-components';

// TODO: What to do with the module?
RNPerfectComponents;
```
  