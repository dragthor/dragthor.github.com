---
layout: post
title: "Top 5 Signs You Are Working with a Cowboy Software Consultant"
permalink: /cowboy-software-consultant/
meta: dev-life
published: true
image: http://abe90238e3b628565257-c47b312812e6878374960f5d0b7661c9.r73.cf1.rackcdn.com/cowboy-consultant.jpg
---
Cowboy (or rogue) software consultants are not difficult to spot once you start working with them.  This applies to both small and large companies.  Gradually along the development life cycle you learn that cowboy code slingers require a lot of supervision, hand holding, and lassoing.  They come into a project riding on their horse full steam ahead with guns blazing in order to appear that they will get things done.  They get things done of course, usually the wrong things.  Unquestionably they will end up costing you money.  So how do we wrangle ourselves out of this position?  Yes, fire them.  Terminate the contract.  But how did we get here in the first place?

![alt text]({{ page.image }} "Cowboy Consultant")

The trick is to look for red flags before hiring them.  Yes, there are short-term consulting projects that last about a month (or two).  Look for patterns; try to decipher their client turnover rate or question them directly.  Contacting the potential consultant's previous clients can help.  But not everyone has time to follow up or care to respond honestly.  Lack of directness, not "corporate policy" to not disclose anything, may indicate the guy was a disaster.

> Lack of directness, not "corporate policy" to not disclose anything, may indicate the guy was a disaster.

Beware of the "sorry, they are no longer in business" story.  (I've had a manger give me this story when I casually asked about his mysterious previous experience, but that is another post).  Almost everyone has had a consulting gig turn bad for one reason or another.  And there are always two sides to a negative software consulting relationship.  Ask them about their side.  See if they are honest.  See what they learned from it (if anything).  If not, they may be a really [smart developer](/smartest-guy-in-the-room-not-the-best-developer/).

{% include adsense.html %}

Yes, the software cowboy disorder can apply to traditional employees too.  But traditional employees have more skin in the game.  They want their employer to do well as their success, potential stability, and long-term employment is tied to it.  Yes, success, stability, and long-term contracts apply to consultants too.  However, W-2 payroll employees prepare and plan to be intimate with the code long-term.  Cowboy consultants seem to come in, shoot it up, and then leave.  Afterwards it's the traditional employee who has to revisit the cowboy's code for bugs, performance, security flaws, and feature enhancements.  Code reviewers - please help.  Hiring managers - please help.

> Cowboy consultants seem to come in, shoot it up, and then leave. 

Protect yourself.  Protect your project.  Protect your architecture.  Protect your code.  Protect your business users and/or customers.  Have cowboy developers sign a list of your standard procedures, tie it to payment, and avoid the following (and never give an untrusted consultant access to your production environment):

## 1. Cowboy Shoot'em Up
 * Writes code first, then asks questions later.
 * Understands language syntax (C#, Java, Ruby) but not the problem or requirement.
 * Never admits mistakes, just keeps coding.
 * Never seeks advice or input from project peers, just keeps coding.

## 2. Cowboy Unit Testing
 * Deletes, skips, disregards, and [eats unit tests](/consultants-ate-my-unit-tests/) for breakfast.  Instead of being a safety net the unit tests are in the way.
 * Tests in production.
 * Writes trivial tests to make it seem like they are testing and have decent code coverage.  You know, testing for testing's sake.

## 3. Cowboy Source Control
 * Does not use client's source control (or use it correctly).  What's a branch?  What's a tag or label?
 * Works in a disconnected silo, then delivers a mess of disorganized non-synced code.  Let someone else merge.
 * Brings in own library or DLL without the source code.  Is it even legal?
 * Edits or pushes code directly to production outside normal process, then never updates source control.

## 4. Cowboy Rodeo
 * Creates a mess, then tries to charge to clean it up.
 * Never finishes, never dev complete, and never delivers.
 * Creates duplicate code for common or generic functions (i.e., string utilities) because they are not asking the right questions. 
 * Code formatting not in sync with the team (3 vs. 4 tab indentation, `{ }` placement, naming convention, etc.).  Thus when you view the changeset diff, pretty much everything has changed.  The consultant's change is lost in a sea of formatting changes.

## 5. Cowboy Refactor
 * Always comes into a project stating "this code sucks".
 * Over architects the solution.  And worse, wants to rip out your proven data access layer for something that they prefer.  And even worse, replace your [knockout.js](http://knockoutjs.com/) and [backbone.js](http://backbonejs.org/) solution with their all-encompassing [angular.js](https://angularjs.org/) preference.
 * Does not follow existing software patterns or project architecture decisions.
 * Rearranges code for the sake of rearranging code.  This "looks" like work, but it is not refactoring or helping much.
 * Poor time management.  Poor communication skills.  Poor [soft skills](/soft-skills/).

<span class="fi-page-edit size-21"></span> <a href="{{ site.post_source_root }}2016-04-13-cowboy-software-consultant.markdown" target="_blank">Contribute and Fork</a>

{% include disqus.html %}
