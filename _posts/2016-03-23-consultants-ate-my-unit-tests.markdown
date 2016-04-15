---
layout: post
title: "Consultants Ate My Unit Tests"
permalink: /consultants-ate-my-unit-tests/
meta: unit-testing dev-life
published: true
image: http://abe90238e3b628565257-c47b312812e6878374960f5d0b7661c9.r73.cf1.rackcdn.com/consultant-unit-testing.jpg
description: "It's been over five years since I last looked at the source code.  And when I finally looked.  The horror.  No more unit tests."
---
About six years ago I was working as a solo software developer consultant for a web-based product at a small company.  The backend piece involved some ETL from ancient 16-bit FoxPro into SQL Server which helped to provide an easier data schema and robust reporting.  This project was not seeking to replace FoxPro since it's been running the back office business for 10+ years without issue.  Rather we opted to perform a nightly data dump into SQL server, since the data would be a lot easier to work with using ASP.NET, a requirement determined by the business, a traditional .NET shop.  With this architecture the webserver was not directly dependent on FoxPro.  In the end each could be maintained individually.  Each could fail and not impact the other.  Hopefully neither fail but things happen.  On second thought things are going to happen, plan and be prepared. 

![alt text]({{ page.image }} "Consultants Ate Unit Tests")

> Things are going to happen, plan and be prepared. 

I worked directly with a project manager throughout each iteration/sprint.  I utilized unit testing and test-driven development to keep the code and myself in-check.  Did I have 100% code coverage?  Of course not.  Instead my tests mainly focused on difficult, important, and flat out weird (and sometimes vague) business rules.  The unit tests were something of value.  Something to fall back on for ever changing requirements. Something to document the vague.  Something to keep my sanity.

{% include adsense.html %}

A year later the project ended and was successful.  Perfect?  No.  But it shipped and the customer was happy.  I chalk most of the success up due to solid communication with project management, iterative steps, good PM planning, and unit testing the more complex feature areas.  On my way out the door I kind of knew that I was going to be replaced by less expensive labor. 

> On my way out the door I kind of knew that I was going to be replaced by less expensive labor. 

I kept in contact with the company owner as we exchanged one or two emails that subsequent year.  After all the project was successful, we are both happy, and they paid on time.  Plus I like to keep my eyes open for other opportunities.   

Fast forward five years later.   

I received an "urgent" email from the owner of the company stating they had a production bug/issue and asked if I could take a look.  I agreed to help,  but first needed some time to get my head around the project.  It's been over five years since I last looked at the source code.  And when I finally looked.  The horror.  Oh, the horror. 

> And when I finally looked.  The horror.  Oh,  the horror. 

Okay.  Maybe I am exaggerating a bit.  But all of the unit tests were gone!  And I am not simply talking about deleted and I could always restore from source control.  I am talking gone, gone.  Scorched.  Trashed.  Ghost town. Sure they could be resurrected but so much has changed they are utterly useless and don't even compile (yes, using C#).  Requirements changed (not all because I remember having unit test cases).  People have changed over.   

Several less expensive programmers disregarded and ignored the unit tests since the day after I left.  And it wasn't a hand off thing where I neglected to show them green passing unit tests.  It wasn't a matter of unit test maintenance and upkeep.  But more appreciating the value the unit tests brought to the project.  Unit tests are not the definitive panacea or the golden magic happy unicorn to solve all woes such as poor project management, bad design, and disorganized and thoughtless coding.  Buy maybe the more disorganized the code, the more "less expensive" consultant work there is to do (charge)? 

> Unit tests are not the definitive panacea or the golden magic happy unicorn to solve all woes such as poor project management, bad design, and disorganized and thoughtless coding.  

And now not one single new unit test (the old ones rendered meaningless). The code base is in an inconsistent state.  Everyone is afraid to make a code change.  I guess that's why I was called?  And yes, I helped to resolve the bug but kindly and gracefully declined to regularly get directly involved again. I wonder how less expensive they are now?  Surely the company is paying now. 

Disclaimer -  I am not anti-consultant.  And I am not anti-overseas consultant.

<span class="fi-page-edit size-21"></span> <a href="{{ site.post_source_root }}2016-03-23-consultants-ate-my-unit-tests.markdown" target="_blank">Contribute and Fork</a>

{% include disqus.html %}
