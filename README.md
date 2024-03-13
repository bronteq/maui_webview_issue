# Maui Webview Issue 
The app is composed of two pages, MainPage and NewPage.
MainPage contains two buttons that allow to navigate to NewPage and call the Garbage Collector.
NewPage contains a Webview. Every time that NewPage is shown, the ram memory usage increases and the previous Webviews seem to be never GC collected.
The manual request to Garbage Collector does not remove any previous instantiated Webview.
