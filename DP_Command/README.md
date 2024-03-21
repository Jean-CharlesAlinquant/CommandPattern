# Command Pattern Definition

The command design pattern turns a request into a stand-alone object that contains all information about the request. This decoupling allows for the following benefits:

- Requests can be parameterized and executed at a later time. This allows for queuing or logging of requests before execution.

- Requests can be undone via an undo operation on the command object.

- Commands can be executed by different invokers like menu items or buttons. The invoker does not need to know anything about the actual command logic.

- Extending the system by adding new commands is easy. Just create a new command object without having to change existing classes.

- Commands can be combined in macros or composite commands.
