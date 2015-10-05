# C#-Email-Obfuscator
A simple and effective email obfuscator written in C#

Pass a plaintext email address in, and it will return an obfuscated email address.  Based on the tested methods here: http://superuser.com/questions/235937/does-e-mail-address-obfuscation-actually-work


##Examples##

`ObfuscateEmailAddress("test_address+email@example.com")`

Will return

`<span class="emailAddress" style="unicode-bidi:bidi-override; direction: rtl;">moc&#46;elpmaxe<span style="display:none">oof</span>&commat;liame&#x0002B;sserdda_tset</span>`

##Limitations##

Will not work for `mailto:` links.
