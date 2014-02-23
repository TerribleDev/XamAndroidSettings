Xamarin Shared Preference Abstraction
==================

Abstraction around shared settings in Android Xamarin

## How to use:

New up a settingskey class

````c#

var sk = new SharedSettingsAbstraction.Setting.SettingsKey<string>("KeyName", "PreferenceName", "DefaultValuehere");
           var setting = sk.getSetting(Context con)
		   var setsetting = sk.SetSetting(Context con, "New Value!")

````
