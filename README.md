## Workflow:
- All development will occur in the **dev** branch.
- Changes in the **dev** branch will be moved to the **main** branch through a pull request.
- Pull requests will be created by the tech lead after feature completion.
- The CI/CD pipeline will automatically detect pull requests to **main** and run the test/build workflows.
- The game can be tested from these pull requests, and should the test/build pass, then the pull request can be merged into **main**.

## Logic:
This workflow is sufficient for a smaller studio such as ours, where only 2 people will be dealing directly with Git.
It also leaves room to grow with the company's growth, such as:
- Moving the development work to feature branches.
- Running test/build workflows on **dev** branch.
- Implementing auto deployment on **main** branch.
