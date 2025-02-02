# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property before it has been initialized.  Uninitialized properties will often default to 0 for numeric types or null for reference types, which might lead to unexpected application behavior or runtime exceptions.

## The Bug

The `bug.cs` file contains code that attempts to print the value of a property (`MyProperty`) before it has been assigned a value. This results in the property holding its default value (0 in this case). The `bugSolution.cs` shows how to assign a value to the property and then use its value.