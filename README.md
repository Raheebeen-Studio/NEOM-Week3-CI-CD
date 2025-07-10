## Workflow:
- All development will occur in the **feature** branches.
- **Feature** branches are to be created to facilitate small feature additions for each branch.
- Changes in the **feature** branches will be moved to the **main** branch through a pull request.
- The CI/CD pipeline will automatically detect pull requests to **main** and run the test/build workflows.
- The game can be tested from these pull requests, and should the test/build pass, then the pull request can be merged into **main**.
- After the pull request is merged; a new **feature** will be created from main to develop the next feature.
- When enough features are implemented a relase tag will be used to signify a release.

## Setup:
A standard Unity project, no special setup needed so far.

## Build:
- Builds can be made remotely from a pull request as discussed in the **Workflow** section.
- Issued locally from inside the Unity editor via the BuildScript.cs, which exposes a **'Build'** menu bar entry on the top.

## Reasoning:
This workflow is sufficient for a smaller studio such as ours, where only 2 people will be dealing directly with Git.
It also leaves room to grow with the company's growth, such as:
- Moving the development work to feature branches.
- Running test/build workflows on **dev** branch.
- Implementing auto deployment on **main** branch.
