---
layout: post
title: "Unit Testing Allowed Me to Pick Up My Kid Today"
permalink: /unit-testing-allowed-me-to-pick-up-my-kid-today/
meta: unit-testing
image: http://abe90238e3b628565257-c47b312812e6878374960f5d0b7661c9.r73.cf1.rackcdn.com/unit-testing-drive.jpg
description: "As a parent, I cannot afford to waste time at work (my employer does not want me too either).  Thus I try to automate as many tasks as possible.  I also unit test as much as possible."
---
As a parent, I cannot afford to waste time at work (my employer does not want me too either).  Thus, I try to automate as many tasks as possible.  I organize tasks with Trello and synchronize notes, ideas, questions, requirements, and documents using Github, OneNote, and SharePoint.  I schedule and run timely meetings.  And I try to not waste other people's time.  I also unit test as much as possible.  Wait.  What?  Doesn't unit testing take up too much time?  Doesn't it impact project timelines?

![alt text]({{ page.image }} "Unit Testing Kids")

The answer is **no**.  There I said it.  Unit testing saves time in the **beginning** and the **end** of a sprint (or iteration).  And yes, unit testing is not developer style or preference.  It actually produces positive results.  And helps you write and design good testable code.

{% include amazon-books.html %}

Today I needed to get my head around a feature.  The act of actually typing out unit test case scenarios helped to solve the problem.  And not just technically.  With these test cases in hand, I can verbally review and discuss the feature/change/issue with the Business Analyst/SME before writing or changing a single line code.  And yes, not altering code isn't 100% pure because I usually have to review (um... break and not check in) existing code (or features) to provide a general estimate.

Writing out test cases also formalizes the language between you (the developer) and the business.  In addition, the QA appreciates the upfront work too because we can compare notes, test scenarios, and review test coverage (micro and macro).

Once solidified (again nothing is 100% because things can and will change) the test cases turn into failing unit tests.  They are literally almost verbatim.  And at this point, I have a good grasp on the problem I am trying to code solve.  By days end my unit tests were all green (passing).  I even thought of a few more edge cases and scenarios to document with unit tests.

Not only is the next guy (or future self) and code reviewer going to appreciate my coding effort, I was further ahead of schedule than expected.  Fortunately, when the need to leave early arose to pick my kid up from an after school activity - I was able to walk out the door with confidence.  Confident of a decent days work.  And confident that I'll be able to handle the change up ahead the next morning.

Does unit testing save you time often?  More at the beginning or the end of an iteration/sprint?  Or both?  Still haven't convinced yourself they are worth the effort?  Godspeed.

{% include disqus.html %}