# ComControllerForHomeAutomation
The Windows Forms program is created in Visual Studio 2017 Enterprise with C# and .NET for controlling the power of home devices by using a USB connection through the COM 3 port with the Arduino UNO R3 card driver. The board controls an 8-channel shield relay that switches on or off the power supply on home appliances.

To successfully launch the program, you need to install Visual Studio 2015 or a later version of the program. To run correctly, you must have .NET Framework 4.6.1 installed and the C # compiler, which is usually installed with Visual Studio.
To start a project, you need to open the project using Visual Studio and run the project to run. The compiler will automatically generate the .exe program.

Then you need to connect Arduino Uno R3 via USB port and install the CH340 driver to support the bootloader. This process is described in detail here: http://www.dnatechindia.com/ch340g-drivers-download-installation-guide.html

With the help of Arduino IDE for Visual Studio it is necessary to select that USB port which corresponds to COM3.

Open the file "sketch_for_arduino_uno_r3_homehub.ino.ino" into "LavrovAndrii/ComControllerForHomeAutomation/sketch_for_arduino_uno_r3_homehub/sketch_for_arduino_uno_r3_homehub.ino/" and compile the project, then download the machine code to Arduino Uno R3.

Launch done compiled program with extension .exe.

The system is ready for use.

Enjoy!
Let's see!
