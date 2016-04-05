---
layout: post
title: "Windows 10 Universal App WebView Transition Flicker Prevention"
permalink: /windows-10-universal-app-webview-transition-flicker-prevention/
meta: windows-app zurb
---
Currently I am developing a Windows 10 Universal App that utilizes a [WebView](https://msdn.microsoft.com/en-us/library/windows/apps/windows.ui.xaml.controls.webview), [Knockout Js](http://knockoutjs.com), and [Zurb Foundation](http://foundation.zurb.com).  Yeah, I know nothing earth shattering.

[Xaml](https://msdn.microsoft.com/en-us/library/cc295302%28v=expression.40%29.aspx) is fine and probably preferred for a larger app (and this is a small app with less than six screens) using [Blend](https://en.wikipedia.org/wiki/Microsoft_Blend).  I am not a designer.  As a weekend warrior after hours programming hobbyist I have no problem offloading as much design as possible to the [Zurb](http://foundation.zurb.com/) framework.  And I want to personally prove that it can be done (and get another app in the store) while leveraging my existing knowledge of C#, Javascript, and [Zurb](http://foundation.zurb.com/).

<script async src="//pagead2.googlesyndication.com/pagead/js/adsbygoogle.js"></script>
<!-- AutoResponsive -->
<ins class="adsbygoogle"
     style="display:block"
     data-ad-client="ca-pub-6659123635600028"
     data-ad-slot="4624845196"
     data-ad-format="auto"></ins>
<script>
(adsbygoogle = window.adsbygoogle || []).push({});
</script>

I really like the idea of a [Zurb](http://foundation.zurb.com) frontend communicating with a C# backend utilizing -

`window.external.notify` in Javascript with the [WebView.ScriptNotify event in C#](https://msdn.microsoft.com/en-us/library/windows/apps/windows.ui.xaml.controls.webview.scriptnotify.aspx)

and calling Javascript methods via the `InvokeScriptAsync` [WebView.InvokeScriptAsync method in C#](https://msdn.microsoft.com/en-us/library/windows/apps/windows.ui.xaml.controls.webview.invokescriptasync.aspx).

Anyway, I noticed that transitions between Frames utilize an animation that causes a slight (yet noticeable) flicker once Zurb is loaded and the knockout model is bound.

One way to address the flicker is to explicitly pass a null [NavigationTransitionInfo](https://msdn.microsoft.com/en-us/library/windows/apps/windows.ui.xaml.media.animation.navigationtransitioninfo.aspx) into the [Frame.Navigate](https://msdn.microsoft.com/en-us/library/windows/apps/windows.ui.xaml.controls.frame.navigate.aspx) method. It controls how the transition animation runs (or in my app's case not run) during the navigation action. Some provided by the Windows runtime API are – 

* [CommonNavigationTransitionInfo](https://msdn.microsoft.com/en-us/library/windows/apps/windows.ui.xaml.media.animation.commonnavigationtransitioninfo.commonnavigationtransitioninfo.aspx) (roll in from the right)
* [SlideNavigationTransitionInfo](https://msdn.microsoft.com/en-us/library/windows/apps/windows.ui.xaml.media.animation.slidenavigationtransitioninfo.slidenavigationtransitioninfo.aspx) (slide up)
* [ContinuumNavigationTransitionInfo](https://msdn.microsoft.com/en-us/library/windows/apps/windows.ui.xaml.media.animation.continuumnavigationtransitioninfo.isentranceelementproperty.aspx) (short zoom-in)

Another way to prevent the flicker is set your ```frame.ContentTransitions = null``` programmatically. Or use a much cleaner way by removing the Frame.ContentTransitions element in the Xaml - 

{% highlight xml %}
<Frame x:Name="frame" Navigating="OnNavigatingToPage" Navigated="OnNavigatedToPage">
<!-- <Frame.ContentTransitions>
		<TransitionCollection>
			<NavigationThemeTransition>
				<NavigationThemeTransition.DefaultNavigationTransitionInfo>
					<EntranceNavigationTransitionInfo/>
				</NavigationThemeTransition.DefaultNavigationTransitionInfo>
			</NavigationThemeTransition>
		</TransitionCollection>
	</Frame.ContentTransitions> -->
</Frame>
{% endhighlight %}

<span class="fi-page-edit size-21"></span> <a href="{{ site.post_source_root }}2015-09-28-windows-10-universal-app-webview-transition-flicker-prevention.markdown" target="_blank">Contribute and Fork</a>

{% include disqus.html %}
