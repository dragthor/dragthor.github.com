---
layout: post
title: "Windows 10 Universal Font Icons"
permalink: /windows-10-universal-font-icons/
meta: windows-app
image: http://abe90238e3b628565257-c47b312812e6878374960f5d0b7661c9.r73.cf1.rackcdn.com/fonts.jpg
---
Finding Windows 10 Universal font icons and viewing them visually can be difficult to locate.  [This page](https://msdn.microsoft.com/en-us/library/windows/apps/jj841126.aspx) provides a list of fonts (and their symbols) and guidelines for using the Segoe MDL2 icons for Windows 10 Store Apps. 

![alt text]({{ page.image }} "Fonts")

A ```Styles/FontSizes.xaml``` entry might look something like -

{% highlight xml %}
    <x:String x:Key="DefaultFontFamily">Segoe WP</x:String>
{% endhighlight %}

C# example code I am using with a [Navigation Pane](https://msdn.microsoft.com/en-us/library/windows/apps/dn997766.aspx) -

{% highlight c# %}
Nodes = new ObservableCollection<NavigationNode>();

var resourceLoader = new ResourceLoader();

Nodes.Add(new ItemNavigationNode { 

Title = @"My Cool App",
	Label = "Home",
	FontIcon = "\ue10f",
	IsSelected = true,
	NavigationInfo = NavigationInfo.FromPage("HomePage")
});
{% endhighlight %}

{% include amazon-books.html %}

If you work mostly offline (like I do), you can always pull up [Windows Character map](http://windows.microsoft.com/en-us/windows/using-special-characters-character-map-faq) and select Segoe MDL2 Assets -

![character map](http://abe90238e3b628565257-c47b312812e6878374960f5d0b7661c9.r73.cf1.rackcdn.com/character-map.PNG)


See that U+E001 value?  That translates to - ```FontIcon = "\ue001"```

{% include disqus.html %}
