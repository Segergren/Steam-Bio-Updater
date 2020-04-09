# Steam Bio Updater

Makes it possible to update the steam bio automatically every minute.
![Image of Program](https://o11.dev/steamupdaterimage.PNG)

### Setup
Add a registry key of type REG_DWORD with name "Steam Updater.exe" and value 0x00002af9 (11001) in HKEY_CURRENT_USER\SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION.


### Formats
You can use the normal Steam formatting
Example: 
* [h1][/h1]
* [b][/b]
* [u][/u]
* [i][/i]
* [strike][/strike]
* [spoiler][/spoiler]
* [noparse][/noparse]
* [url=][/url]

Currenly supporting Corona cases and current time. **More to come** and let me know if you want a specific integration.

**Country**
* ({Country}|cases)
* ({Country}|critical)
* ({Country}|country)
* ({Country}|casesperonemillion)
* ({Country}|active)
* ({Country}|recovered)
* ({Country}|todaycases)
* ({Country}|todaydeaths)

**Total**
* (total|cases)
* (total|deaths)
* (total|recovered)

**Time**
* (time|hour)
* (time|minute)
* (time|second)
