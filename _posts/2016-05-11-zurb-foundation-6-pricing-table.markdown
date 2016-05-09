---
layout: post
title: "Zurb Foundation 6 Pricing Table"
permalink: /zurb-foundation-6-pricing-table/
meta: zurb
published: false
description: "How to make a Zurb Foundation 6 pricing table.  They were removed from Zurb Foundation 5."
image: http://abe90238e3b628565257-c47b312812e6878374960f5d0b7661c9.r73.cf1.rackcdn.com/zurb-6.png
---
Zurb Foundation 6 no longer includes a pricing table component.  No problem.  Let's put one in as these are great for marketing landing pages, product signups, subscription comparisons, etc. 





At the end, will look like this: http://abe90238e3b628565257-c47b312812e6878374960f5d0b7661c9.r73.cf1.rackcdn.com/zurb6-pricing-table.PNG

HTML - https://gist.github.com/dragthor/bab15cbee60c42f682f2a292791f3a66

SCSS - https://gist.github.com/dragthor/6d4638eb28b6138054d7e619093710b2

Markdown Documentation - https://gist.github.com/dragthor/72db43cb4705a6ec0681edaf61d50614

Create `docs/pages/pricingtable.md`.

Create `scss/components/_pricingtable.scss`.

Add `@import 'components/pricingtable';` to `scss/foundation.scss`.


![alt text]({{ page.image }} "Zurb 6 Pricing Table")

Disclaimer: I am a Foundation fan, user, and minor open-source contributor.

{% include adsense.html %}

{% include disqus.html %}
