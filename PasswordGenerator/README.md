# Password Generator

You can easily create a password to your liking by chosing an option on the generator. You can also manage the length of your password. 

There are different ways to build your password:
```cs
a) var pass = new Password(); // you'll get by default 32 characters long password with at least one digit and at least one special                                          character 

b) var p1 = new Password(PasswordOptions.OnlyAlphabet, 16); // you can chose both the password option you wish and your desired length

c) var p2 = new Password(25); // you can also check only the length you want and the programm will generate a password with at least one                                    digit and at least one special character

d) var p3 = new Password("askd;fasfshdfksj 'l323;kj;adsfjk;"); // thus, you can write a password on your own (why not?! :-))

e) var p4 = new Password(PasswordOptions.OnlyAlphabet); // finally, you can just select the password option you like and get a 32                                                                      characters long password
```

As a choice, you can run the windows form application:
<img width="625" alt="ce222997c6f2cd1336b9add511bb8212" src="https://cloud.githubusercontent.com/assets/25085025/22942677/e9c78aa8-f303-11e6-9f9d-dc84fa6d866e.png">

#### 1. Choose the password option you want
#### 2. Select the desired password length
#### 3. Click Generate button

<img width="630" alt="35105a4b787802eeb8e974b1974da59b" src="https://cloud.githubusercontent.com/assets/25085025/22942697/fa02f92a-f303-11e6-8e7a-baf1359674f2.png">

#### 4. Hit the "Copy to clipboard" button and paste it in your password storage
