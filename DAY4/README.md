# Multi-Threading Program with Lock 

## Overview
This program demonstrates the use of the lock statement in C# to prevent multiple threads from accessing a shared resource simultaneously. It ensures that only one thread can modify the shared resource at any given time, avoiding race conditions and ensuring data consistency.

## Features

- **Multi-Threading**: Implements multi-threading using the Thread class.
- **Lock**: Prevents simultaneous access to a shared resource using the lock keyword.
- **Shared Resource**: Simulates a critical section where the shared resource is updated and logged.

## Example Usage

### Code : Program.cs 
```
using DAY4;

TASK1 t1 = new TASK1();
t1.executeThread();
```

### Code : TASK1.cs
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4
{
    public class TASK1
    {
        private static int sharedCounter = 0;
        private static readonly object lockObject = new object();
        private void  increamentCounter()
        {
            lock (lockObject)
            {
                Thread currThread = Thread.CurrentThread;
                Console.WriteLine($"Name of thread updating the variable is : " +
                    $"{currThread.Name}");
                sharedCounter++;
                Console.WriteLine($"Updated value : {sharedCounter}\n");
            }
        }

        public void executeThread()
        {
            Thread t1 = new Thread(increamentCounter);
            Thread t2 = new Thread(increamentCounter);
            Thread t3 = new Thread(increamentCounter);

            t1.Name = "THREAD-1";
            t2.Name = "THREAD-2";
            t3.Name = "THREAD-3";

            t1.Start();
            t2.Start();
            t3.Start();

        }
    }
}
```

## How to Use
```
1. Open a C# development environment, such as Visual Studio or any text editor with a .NET compiler.
2. Copy the provided code into a new C# Console Application project.
3. Build and run the program.
```
## Example Usage

**Output:**  
```
Name of thread updating the variable is : THREAD-1
Updated value : 1

Name of thread updating the variable is : THREAD-2
Updated value : 2

Name of thread updating the variable is : THREAD-3
Updated value : 3
```

## Authors
```
 Shubh Kachhadiya

