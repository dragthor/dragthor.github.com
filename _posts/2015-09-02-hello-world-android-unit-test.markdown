---
layout: post
title: "Hello World! Android Unit Testing"
permalink: /hello-world-android-unit-test/
categories: android unit-testing
---
Tackling android unit testing has more than one approach.  A library file or class file(s) without android dependencies can utilize [JUnit](http://www.junit.org) or any other Java unit testing framework.  However, as soon as the code that you want to test is dependent on [Activity Context](http://developer.android.com/reference/android/app/Activity.html) you write instrumentation tests that execute on actual devices or virtual devices.

Instrumentation tests save the developer time because the tests ~~should~~ run in seconds – and provide a safety net of regression testing.  You are actually testing your Android code.

Historically extending [ApplicationTestCase](http://developer.android.com/reference/android/test/ApplicationTestCase.html) can have UI timing (thread synchronization) issues – and getting around these issues involves the "guess  sprinkling" of ```sleep``` statements in your test code (reminiscent of the web browser automation tool [Selenium](http://docs.seleniumhq.org/)).

The latest version of [Android Studio](https://developer.android.com/sdk/index.html) provides the developer with [Espresso](http://developer.android.com/reference/android/support/test/package-summary.html) included in the [Android Testing Support Library](http://developer.android.com/tools/testing-support-library/index.html).  And yes no one is forcing you to stop using [Robolectric](http://robolectric.org) if desired.  However, I believe the fluid API of Espresso makes it (and feels) easier to find views, perform actions, and verify state.  

    onView(withId(R.id.txtHello))
		.check(matches(withText("")));

	onView(withId(R.id.btnHello))
		.check(matches(withText(R.string.clickme)))
		.perform(click());

	onView(withId(R.id.txtHello))
		.check(matches(withText(R.string.helloworld)));

	onView(withId(R.id.btnHello))
		.check(matches(not(isEnabled())));

And yes, JUnit tests tend to be faster than Espresso tests since they can avoid context and the android framework.

Important for your app's build.gradle -

	defaultConfig { 
		testInstrumentationRunner 'android.support.test.runner.AndroidJUnitRunner'
	}

And then utilize your project's Build Variants to toggle between JUnit tests and Espresso tests.

Get up and running with Espresso using a [sample Android Studio project](https://github.com/dragthor/HelloWorldAndroidUnitTesting).

Android Studio 1.5.1
JUnit 4.1.1
Espresso 2.+
Android Support Library 23.1.1

<a href="{{ site.post_source_root }}2015-09-02-hello-world-android-unit-test.markdown">Contibute and Fork</a>

{% include disqus.html %}