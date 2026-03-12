APBD Git Tutorial

This is a simple console application that I made to practice using Git and GitHub.

Answers
1. When does Git perform a fast-forward and when is a merge commit created?

Git does a fast-forward when the main branch doesn't have any new commits after the feature branch was created.
A merge commit is created when both branches have their own commits.

2. What is the difference between merge and rebase?

Merge keeps the branch history and usually adds a merge commit.
Rebase moves the commits on top of another branch and makes the history more simple and linear.

3. How was the conflict resolved in your repository?

The conflict happened because the startup message was changed differently in main and feature-conflict.
I fixed it by combining both changes into one final message so the application still works.