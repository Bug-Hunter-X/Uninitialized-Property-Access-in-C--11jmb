# Uninitialized Property Access in C#

This repository demonstrates a common, yet subtle, error in C#: accessing a property before it's been explicitly initialized.  The code in `bug.cs` illustrates this issue, which can lead to unexpected behavior or runtime exceptions. The solution in `bugSolution.cs` shows how to avoid this problem.

## Problem
In C#, class properties have default values.  If a property is not initialized before accessing it the default value will be used, this might not be the intended behavior. To avoid unexpected values initialize the value during declaration or in the constructor.