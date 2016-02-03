---
layout: post
title: "Hello World! Android Unit Testing with Espresso"
permalink: /hello-world-android-unit-test/
meta: android unit-testing espresso
---
Tackling android unit testing has more than one approach.  A library file or class file(s) without android dependencies can utilize [JUnit](http://www.junit.org){:target="_blank"} or any other Java unit testing framework.  However, as soon as the code that you want to test is dependent on [Activity Context](http://developer.android.com/reference/android/app/Activity.html){:target="_blank"} you write instrumentation tests that execute on actual devices or virtual devices.

Instrumentation tests save the developer time because the tests ~~should~~ run in seconds – and provide a safety net of regression testing.  You are actually testing your Android code.

Historically extending [ApplicationTestCase](http://developer.android.com/reference/android/test/ApplicationTestCase.html){:target="_blank"} can have UI timing (thread synchronization) issues – and getting around these issues involves the "guess  sprinkling" of ```sleep``` statements in your test code (reminiscent of the web browser automation tool [Selenium](http://docs.seleniumhq.org/){:target="_blank"}).

The latest version of [Android Studio](https://developer.android.com/sdk/index.html){:target="_blank"} provides the developer with [Espresso](http://developer.android.com/reference/android/support/test/package-summary.html){:target="_blank"} included in the [Android Testing Support Library](http://developer.android.com/tools/testing-support-library/index.html){:target="_blank"}.  And yes no one is forcing you to stop using [Robolectric](http://robolectric.org){:target="_blank"} if desired.  However, I believe the fluid API of Espresso makes it (and feels) easier to find views, perform actions, and verify state.  

{% highlight java linenos %}
onView(withId(R.id.txtHello))
	.check(matches(withText("")));

onView(withId(R.id.btnHello))
	.check(matches(withText(R.string.clickme)))
	.perform(click());

onView(withId(R.id.txtHello))
	.check(matches(withText(R.string.helloworld)));

onView(withId(R.id.btnHello))
	.check(matches(not(isEnabled())));
{% endhighlight %}

And yes, JUnit tests tend to be faster than Espresso tests since they can avoid context and the android framework.

Important for your app's build.gradle -

{% highlight json linenos %}
	defaultConfig { 
		testInstrumentationRunner 'android.support.test.runner.AndroidJUnitRunner'
	}
{% endhighlight %}

And then utilize your project's Build Variants to toggle between JUnit tests and Espresso tests.

Get up and running with Espresso using a [sample Android Studio project](https://github.com/dragthor/HelloWorldAndroidUnitTesting){:target="_blank"}.

Android Studio 1.5.1
JUnit 4.1.1
Espresso 2.+
Android Support Library 23.1.1

<a href="{{ site.post_source_root }}2015-09-02-hello-world-android-unit-test.markdown" target="_blank">Contibute and Fork</a>

{% include disqus.html %}