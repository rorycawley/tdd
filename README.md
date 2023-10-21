# Why

Decide that will provide the most value or that we can tackle as a risky area to explore.

Break work into small chunks that are easier to solve.

Start with the end in mind, if you stop in order to articulate what it is you're trying to achieve before trying to achieve it then you can be focused in your work.

Fast feedback, at every stage in your work to achieve your goal, you are able to see if you are there yet.

We get into a focused flow on delivering valuable work, continuously able to check whether we've gotten there yet.

Design software that is easy to understand by presenting a clear abstraction.

Design software that is testable.

Create tests that run quickly.

Design software with a stable contract and an implementation that can be refactored.

Design software that is isolated, hightly cohesive, low coupled.

We're always able to show progress, when we check and we've achieved our goal then that is progress. We can forget about 2 week sprints and instead continuously deliver production code, i.e. we know that everything works proof from your TDD test suite.

# Mindset promoted

Confidence rather than fear.
Patience to focus on doing the right work correctly.
Focus, on one thing at a time and ensure it's done correctly and isolated.
Control, always know the state of the software.

# Notes

Don't create tests that are coupled to implementation details, only test the contract (no mocks)
We should be able to change the implementation details without any tests being broken.
We don't want tests that are hard to understand when we read them later.

# Actions

Create a test

# To Watch

.NET clean arch with functional core:
https://www.youtube.com/watch?v=S100FP9piGs&t=12s
https://news.ycombinator.com/item?id=18043058
https://www.youtube.com/watch?v=SAjsP2igBNk
https://www.youtube.com/watch?v=qtX7-OFh7-A
https://www.youtube.com/watch?v=bDWApqAUjEI

https://www.destroyallsoftware.com/screencasts/catalog/functional-core-imperative-shell
https://www.destroyallsoftware.com/talks/boundaries
https://www.youtube.com/watch?v=CeoZX7Sltk0&list=PLnJ-s3o7NWtSIoHFTNrDHfN_HiHicflVn&index=7

https://www.youtube.com/watch?v=lv7AFBst_70&list=PLnJ-s3o7NWtSIoHFTNrDHfN_HiHicflVn&index=3
https://www.youtube.com/watch?v=EZ05e7EMOLM
https://www.youtube.com/watch?v=SxJPQ5qXisw&t=1908s

# Developing

Checks the functional core, the business rules. The functionality controlled by the domain.
Requires embracing evolutionary design, the design is evolving, it allows us to delivery sooner.
Use trial and error, have a go, see how it goes, get feedback and then improve.
Objects are collections are partially applied functions.
Use DDD to improve naming.
Attempt to remove duplication.
Names that are similar should be close together, and vice versa - for cohesion.
Add abstractions to be able to ignore most of the code.
Focus on one small improvement at a time.
We develop towards an abstraction, a protocol. A collection of functions but not their implementations. It describes 'what can I do' without describing 'how I do it'.
The contract is the set of behaviours of those functions.
TDD approach involves keeping a focus on one thing at a time, one behaviour that you want to implement, then to write code to check that behaviour before writing code that implements that behaviour.
TDD helps evolve the design, getting towards the end behaviour sought.
TDD checks all the acceptance criteria of the behaviour is working.
TDD checks the behaviour stays correct even after the implementation has been updated.
TDD checks are not brittle since they only check for the desired behaviour.
TDD is a positive feedback loop.
Code is stateless
Code uses immutable data structures.
DDD domain model.

# Testing

Developers don't write tests, the testers write the tests.
No-one knows what % of application will be tested.

# Observability

https://www.youtube.com/watch?v=prLRI3VEVq4

# tdd

A developer can make progress when they have functionality to deliver with an articulated acceptance criteria. Their sole job is to work on delivering that functionality and check that it delivers on all the acceptance criteria.

Testing vs. checking
https://developsense.com/blog/2009/08/testing-vs-checking
https://www.infoq.com/news/2009/12/testing-or-checking/#:~:text=According%20to%20Michael%2C%20checks%20are,'.
https://www.satisfice.com/blog/archives/856

Developer tests (aka unit tests, isolated tests, TDD tests) - this is really checking
TDD is used to learn about the quality of our design - if the design has problems then it will be hard to check
Fast feedback
To find design problems we must have isolated tests
Isolated
Only tests the domain
Checks a contract
Doesn't check an implementation

Checking is something that we do with the motivation of confirming existing beliefs. Checking is a process of confirmation, verification, and validation. When we already believe something to be true, we verify our belief by checking. We check when we've made a change to the code and we want to make sure that everything that worked before still works.

Checks are machine dependent because they give a binary response of pass or fail.

A person who needs a clear, complete, up-to-date, unambiguous specification to proceed is a checker, not a tester. A person who needs a test script to proceed is a checker, not a tester. A person who does nothing but to compare a program against some reference is a checker, not a tester.

Mere checks aren't important; but checking—the activity required to build, maintain, and analyze the checks—is.

Integrated tests (aka e2e, integration tests, ui tests i.e. anything that isn't a Developer tests) - this is not the developers job, this is the testers job, this is testing.
Testing is something that we do with the motivation of finding new information. Testing is a process of exploration, discovery, investigation, and learning. When we configure, operate, and observe a product with the intention of evaluating it, or with the intention of recognizing a problem that we hadn't anticipated, we're testing.
Test on the other hand requires sapience. They are an exploratory way of learning the system and answering the question, 'Is there a problem here?'.

Agile projects require true generalists as testers: people who have requirements-, design-, and code-understanding skills. Without those skills, they can't think critically enough about the product under development, and they might not be able to create enough variety of tests. If they understand the requirements, design, and code, they can turn that understanding into crafty tests. Some of those tests will be exploratory. Even some of the exploratory tests will need to be automated in order to repeat them. And, I've seen great testers on agile projects who can quickly create automated tests to do some of their exploration.

Testers can automate tests and they have an amazing mindset to try to find bugs in systems.

Integration Tests are a scam
https://www.youtube.com/watch?v=VDfX44fZoMc
