---
layout: page
title: Archive
permalink: /archive/
---
<div class="home">

	<ul>
	  {% for post in site.posts %}
	  <li class="archive">
		<a href="{{ post.url }}" title="{{ post.title }}">
		  <span class="date">
			<span class="day">{{ post.date | date: '%d' }}</span>
			<span class="month"><abbr>{{ post.date | date: '%b' }}</abbr></span>
			<span class="year">{{ post.date | date: '%Y' }}</span>
		  </span> - 
		  <span class="title">{{ post.title }}</span>
		</a>
		<br/>{{ post.meta }}
	  </li>
	  {% endfor %}
	</ul>


  
  <p class="rss-subscribe">
	<span class="fi-rss size-21"></span> subscribe <a href="{{ "/feed.xml" | prepend: site.baseurl }}">via RSS</a>
  </p>

</div>