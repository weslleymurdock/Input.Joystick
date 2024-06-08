# 🆕 Input.Joystick

.NET library that allows getting the button presses and axis value changes of a gamepad or a Joystick connected to Linux based OS's
(even raspberry) by reading /dev/input/js* files.

Check https://github.com/weslleymurdock/joystick for examples

<img src="./src/Input.Joystick/joystick.png">

## ❓ What is Input.Joystick?

Input.Joystick is a port of Gamepad nuget package to target .NET 8. 

## 🔧 Installing
```bash
dotnet add package Input.Joystick
```
### 🔨 Using

```csharp

﻿using System;

namespace Jpystick.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // You should provide the js file you want to connect to. /dev/input/js0 is the default
            using (var joystick = new Joystick("/dev/input/js0"))
            {
                Console.WriteLine("Start pushing the buttons/axis of your joystick/joystick to see the output");

                // Configure this if you want to get events when the state of a button changes
                joystick.ButtonChanged += (object sender, ButtonEventArgs e) =>
                {
                    Console.WriteLine($"Button {e.Button} Changed: {e.Pressed}");
                };

                // Configure this if you want to get events when the state of an axis changes
                joystick.AxisChanged += (object sender, AxisEventArgs e) =>
                {
                    Console.WriteLine($"Axis {e.Axis} Changed: {e.Value}");
                };

                Console.ReadLine();
            }
            //  Dispose the Joystick, so it can finish the Task that listens for changes in the joystick
            joystick.Dispose();
        }
    }
}

```