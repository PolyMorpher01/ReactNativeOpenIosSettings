
# react-native-open-ios-settings

## Getting started

`$ npm install react-native-open-ios-settings --save`

### Mostly automatic installation

`$ react-native link react-native-open-ios-settings`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-open-ios-settings` and add `RNOpenIosSettings.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNOpenIosSettings.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNOpenIosSettingsPackage;` to the imports at the top of the file
  - Add `new RNOpenIosSettingsPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-open-ios-settings'
  	project(':react-native-open-ios-settings').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-open-ios-settings/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-open-ios-settings')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNOpenIosSettings.sln` in `node_modules/react-native-open-ios-settings/windows/RNOpenIosSettings.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Open.Ios.Settings.RNOpenIosSettings;` to the usings at the top of the file
  - Add `new RNOpenIosSettingsPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNOpenIosSettings from 'react-native-open-ios-settings';

// TODO: What to do with the module?
RNOpenIosSettings;
```
  