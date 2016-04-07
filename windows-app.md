---
redirect_from: "/tag/windows-app/"
layout: page
title: Windows Universal Apps
permalink: /windows-app/
---
[Windows 10 Universal Font Icons](/windows-10-universal-font-icons/)

[Windows 10 Universal App WebView Transition Flicker Prevention](/windows-10-universal-app-webview-transition-flicker-prevention/)

<div class="home">
  <ul class="post-list">
    {% for post in site.posts %}
		{% if post.meta == 'windows-app' %}
		  <li>
			<span class="post-meta">{{ post.date | date: "%b %-d, %Y" }}</span>

			<h2>
			  <a class="post-link" href="{{ post.url | prepend: site.baseurl }}">{{ post.title }}</a>
			</h2>

			{{ post.excerpt }}
		  </li>
		{% endif %}
    {% endfor %}
  </ul>
</div>
