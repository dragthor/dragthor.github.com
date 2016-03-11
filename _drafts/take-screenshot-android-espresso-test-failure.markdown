---
layout: post
title: "Take a Screenshot on Android Espresso Test Failure"
permalink: /take-screenshot-android-espresso-test-failure/
meta: android unit-testing espresso
---
Utilize [FailureHandler[(https://developer.android.com/reference/android/support/test/espresso/FailureHandler.html).

Non rooted phones.

Upon handling, most handlers will choose to propagate the error.  Capture screen shot, then rethrow the error.

