- Learn Csharp With Debasis Paul!
- Show notes, slides, and samples.

# How To run a program in Visual studio Code
Create a Prject folder. Then open the folder with powerShell. type `dotnet new console` It create the C sharp project file. Then type `dotnet restore` For run the program type `dotnet run` & go :)
- internet: https://youtu.be/Y7GMBmd1EAk

# Basic Structure of a C# Program

# Problem : Another git process seems to be running in this repository
Src : https://stackoverflow.com/questions/38004148/another-git-process-seems-to-be-running-in-this-repository

`Another git process seems to be running in this repository, e.g.
an editor opened by 'git commit'. Please make sure all processes
are terminated then try again. If it still fails, a git process
may have crashed in this repository earlier:
remove the file manually to continue.`
- Do notice that your branch name might be different than mine. You can delete this lock file by doing;

`rm .git/refs/heads/[your-branch-name].lock`