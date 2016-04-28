# CSharp-Advanced-Regular-Expressions
Advanced CSharp

Problem 1.	Series of Letters
Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
Input	Output
aaaaabbbbbcdddeeeedssaa	abcdedsa

Problem 2.	Replace <a> tag
Write a program that replaces in a HTML document given as string all the tags <a href=…>…</a> with corresponding tags [URL href=…]…[/URL]. Print the result on the console. 
The value of the href attribute can be enclosed in single or double quotes. The opening quotes must be the same as the closing closed (e.g. this is invalid: href='softuni.bg").
Examples:
Input	Output
"<ul>
 <li>
  <a href="http://softuni.bg">SoftUni</a>
 </li>
</ul>"	<ul>
 <li>
  [URL href=http://softuni.bg]SoftUni[/URL]
 </li>
</ul>
"<ul>
 <li>
  <a href='http://softuni.bg'>SoftUni</a>
 </li>
</ul>"	<ul>
 <li>
  [URL href=http://softuni.bg]SoftUni[/URL]
 </li>
</ul>
Note: The input may be read on a single line (unlike the example above) or from a file. Remove all new lines if you choose the first approach.

Problem 3.	Extract Emails
Write a program to extract all email addresses from a given text. The text comes at the only input line. Print the emails on the console, each at a separate line. Emails are considered to be in format <user>@<host>, where: 
•	<user> is a sequence of letters and digits, where '.', '-' and '_' can appear between them. Examples of valid users: "stephan", "mike03", "s.johnson", "st_steward", "softuni-bulgaria", "12345". Examples of invalid users: ''--123", ".....", "nakov_-", "_steve", ".info". 
•	<host> is a sequence of at least two words, separated by dots '.'. Each word is sequence of letters and can have hyphens '-' between the letters. Examples of hosts: "softuni.bg", "software-university.com", "intoprogramming.info", "mail.softuni.org". Examples of invalid hosts: "helloworld", ".unknown.soft.", "invalid-host-", "invalid-". 
•	Examples of valid emails: info@softuni-bulgaria.org, kiki@hotmail.co.uk, no-reply@github.com, s.peterson@mail.uu.net, info-bg@software-university.software.academy. 
•	Examples of invalid emails: --123@gmail.com, …@mail.bg, .info@info.info, _steve@yahoo.cn, mike@helloworld, mike@.unknown.soft., s.johnson@invalid-.
Examples:
Input	Output
Please contact us at: support@github.com.	support@github.com
Just send email to s.miller@mit.edu and j.hopking@york.ac.uk for more information.	s.miller@mit.edu
j.hopking@york.ac.uk
Many users @ SoftUni confuse email addresses. We @ Softuni.BG provide high-quality training @ home or @ class. –- steve.parker@softuni.de.	steve.parker@softuni.de

Problem 4.	Sentence Extractor
Write a program that reads a keyword and some text from the console and prints all sentences from the text, containing that word. A sentence is any sequence of words ending with '.', '!' or '?'. Examples:
Input	Output
is
This is my cat! And this is my dog. We happily live in Paris – the most beautiful city in the world! Isn’t it great? Well it is :)	This is my cat!
And this is my dog.
