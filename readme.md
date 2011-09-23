#[Atos javascript workshop][6]
This javascript workshop is composed by [Marco Franssen][1], [Jan Saris][2] and [Sander van de Velde][3].

#Contributors
* [Marco Franssen][1] - Founder
* [Jan Saris][2] - Founder
* [Sander van de Velde][3] - Founder

#How to fork
1. ## Install Git<br />
Install [Git Extensions][7]. This will provide you a good GUI to Git (easy for Git starters). 

#SSH Key for github repo access<br />
1. ## Generate a ssh key<br />
TODO: add manual text

1. ## Save private key<br />
TODO: add manual text

1. ## Paste public key on your github profile<br />
TODO: add manual text

1. ## Fork the `javascriptWorkshop` repo<br />
Fork the javascriptWorkshop repo by clicking the Fork button on [https://github.com/atosorigin/javascriptWorkshop][5]<br />

1. ## Clone the `javascriptWorkshop` project<br />
Navigate to the folder where you want to add the javascriptWorkshop folder. Right-Click this folder and choose for `Git Bash here`.
Run the following code: (replace username by your own Github username)<br />
`$ git clone git@github.com:username/javascriptWorkshop.git`<br />

1. ## Configure remotes<br />
When a repo is cloned, it has a default remote called origin that points to your fork on GitHub, not the original repo it was forked from. To keep track of the original repo, you need to add another remote named upstream:<br />
`$ cd javascriptWorkshop` the active directory in the prompt to the newly cloned "javascriptWorkshop" directory<br />
`$ git remote add upstream git@github.com:atosorigin/javascriptWorkshop.git` Assigns the original repo to a remote called "upstream"<br />
`$ git fetch upstream`<br />

1. ## Pushing<br />
Pushing is always done to your own fork<br />
`$ git push origin master`<br />

1. ## Fetch the upstream with your fork<br />
When you want to get the latest changes fetched from the upstream into your fork, you need to fetch the upstream.<br />
`$ git fetch upstream`<br />
`$ git merge upstream/master`<br />

1. ## Pull requests<br />
Don't forget to do a [pull request][4] when you have added value to the project.<br />

[1]: https://github.com/marcofranssen "Marco Franssen's Github profile"
[2]: https://github.com/jansaris "Jan Saris's Github profile"
[3]: https://github.com/sandervandevelde "Sander van de Velde's Github profile"
[4]: http://github.com/guides/pull-requests "Pull request guide"
[5]: https://github.com/atosorigin/javascriptWorkshop "Atos javascriptWorkshop Repository"
[6]: http://www.atos.net/ "Atos Homepage"
[7]: http://code.google.com/p/gitextensions/ "Git Extensions"