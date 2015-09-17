# C-Email-Obfuscator
A simple and effective email obfuscator written in C#

Pass a plaintext email address in, and it will return an obfuscated email address.


##Example##

`ObfuscateEmailAddress("test@example.com")`

Will return

`<span class="emailAddress" style="unicode-bidi:bidi-override; direction: rtl;">moc.elpmaxe<span style="display:none">kyz</span>@tset</span>`

##Limitations##

Will not work for `mailto:` links.
