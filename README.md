This is a repository forked from Outscal from which I Learnt Sinlgeton , Service Locator and Dependency Injection.

First We created multiple singletons to remove various serialized references from the script.

Then we created a Generic Singleton that inherits from mono behaviour and were able to reduce singleton code and remove monobehaviour from services.

After that we created a service locator which reduced every singleton to one singleton the service locator itself.

After this we used Dependency Injection(Method DI) in the entire code base for references and were able to remove Service Locator.
