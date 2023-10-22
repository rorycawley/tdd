# Trunk Based Dev

We don't run CI on feature branches, only on main.
We do CD to production.

While this workflow uses PRs, the key to TBD is to keep the lifecycle of branches and PRs short – ideally, a day or less. This ensures rapid integration and minimizes the overhead of managing long-lived branches.

Non-blocking review strategy
Fast clear feedback.
Go/No-go for release.
Minimise effort.

# Ensure Main Branch is Up-to-Date:

```sh
git checkout main
git pull origin main
```

# Create a short lived branch (bugfix, small update, refactor)

```sh
git switch -c task/my-new-update
```

# Implement, Commit, and Push:

```sh
git add .
git commit -m "Fixed the issue causing ..."
git push origin task/my-new-update
```

# Create a Pull Request

```sh
gh pr create --title "Descriptive PR title" --body "Detailed PR description."
```

In github create the PR and manage it.

git switch main
git pull origin main

git switch bugfix/descriptive-issue-name
git rebase main
git rebase --continue

git switch main
git merge bugfix/descriptive-issue-name

git push origin main

git branch -d bugfix/descriptive-issue-name
git push origin --delete bugfix/descriptive-issue-name

```

```
