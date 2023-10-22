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

# Create a Pull Request and check all passed

```sh
gh pr create --title "Descriptive PR title" --body "Detailed PR description."
gh pr view task/my-new-update --comments
gh pr checks task/my-new-update
```

# Rebase and Merge:

```sh
git switch main
git pull origin main
git switch task/my-new-update
git rebase main
git push origin task/my-new-update --force-with-lease
gh pr merge task/my-new-update --squash --delete-branch
```

# Release to production

```sh
gh release create
```
