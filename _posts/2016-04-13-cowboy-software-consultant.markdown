---
layout: post
title: "Top 5 Signs You Are Working with a Cowboy Software Consultant"
permalink: /cowboy-software-consultant/
meta: dev-life
published: false
---
Cowboy (or rogue) software consultants are not difficult to spot once you start working with them.  This applies to both small and large companies.  Gradually along the development life cycle you learn that cowboy code slingers require a lot of supervision, hand holding, and lassoing.  They come into a project riding on their horse full steam ahead in order to appear that they will get things done.  They get things done of course, usually the wrong things.  Unquestionably they will end up costing you money.  So how do we wrangle ourselves out of this position?  Yes, fire them.  Terminate the contract.  But how did we get here in the first place?

The trick is to look for red flags before hiring them.  Yes, there are short-term consulting projects out there that last about a month (or two).  Look for patterns; try to decipher their client turnover rate or question them directly.  Contacting the potential consultant's previous clients can help.  But not everyone has time to follow up or care to respond honestly.  This is especially true when the guy sucked. Also look out for the "sorry, they are no longer in business" story.  (I've had a manger give me this story when I asked about his previous experience, but that is another post).  Almost everyone has had a consulting gig turn bad.  There are always two sides of a software consulting story.  Ask them about their side.  See if they are honest.  See what they learned from it (if anything).  If not, they may be a really [smart developer](/smartest-guy-in-the-room-not-the-best-developer/).

{% include adsense.html %}

Yes, the software cowboy disorder can apply to traditional employees too.  But traditional employees have more skin in the game.  They want their employer to do well as their success is tied to it.  More importantly they plan to be intimate with the code long-term.  Cowboy consultants seem to come in, shoot it up, and leave.  Afterwards it's the traditional employee who has to revisit the cowboy's code for bugs, performance, security flaws, and feature enhancements.  Code reviewers - please help.  Hiring managers - please help.

> Cowboy consultants seem to come in, shoot it up, and leave. 

Protect yourself.  Protect your project.  Protect your architecture.  Protect your code.  Protect your business users or customers.  Have cowboy developers sign a list of your standard procedures, tie it to payment, and avoid the following (and never give an untrusted consultant access to your production environment):

## 1. Cowboy Shoot'em Up
 * Write code first, then ask questions later.
 * Understands language syntax but not the problem.
 * Never admits mistakes.

## 2. Cowboy Unit Testing
 * Deletes, skips, disregards, and [eats unit test](/consultants-ate-my-unit-tests/).
 * Tests in production.
 * Tests trivial things to make it seem like they are testing and have code coverage.  You know, testing for testing's sake.

## 3. Cowboy Source Control
 * Does not use client's source control (or use it correctly).  What's a branch?
 * Works in a silo, then delivers a mess of disorganized non-synched code.
 * Brings in own library or DLL without the source code.  Is it even legal?
 * Edits or pushes code directly to production outside normal process, then never updates source control.

## 3. Cowboy Rodeo
 * Creates a mess, then tries to charge to clean it up.
 * Never finishes, never dev complete, and never delivers.
 * Creates duplicate code for common or generic functions (i.e., string utilities) because they are not asking the right questions. 
 * Code formatting not in sync with the team (3 vs. 4 tab indentation, `{ }` placement).  Thus when you view the diff pretty much everything has changed.

## 4. Cowboy Refactor
 * Always comes into a project stating "this code sucks".
 * Over architects the solution.  And worse, wants to rip out your proven data access layer for something that they prefer.  And even worse, replace your knockout.js & backbone.js solution with their angular.js preference.
 * Does not follow existing software patterns.
 * Rearranges code for the sake of rearranging code.  This is not refactoring.
 * Poor time management.  Poor communication skills.  Poor [soft skills](/soft-skills/).

<span class="fi-page-edit size-21"></span> <a href="{{ site.post_source_root }}2016-04-13-cowboy-software-consultant.markdown" target="_blank">Contribute and Fork</a>

{% include disqus.html %}
