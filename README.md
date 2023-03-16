# :globe_with_meridians: MSSS-Multi-Application-Project
A multi-form application for Malin Space Science Systems (MSSS) that will connect several clients with a remote server using Named Pipes from the Inter-Process Communication Technologies and runs the same version of the application at all locations. 

:dart: To run the project do the following:
1. Download project
2. Click on the server application and run the program
3. Go back to main directory and click Client Application
4. Run Client Application Program
5. Once the application is running you can select between three different language options (English, German, and French) and you can customize the UI by selcting different themes from the drop-down menu.

## H2 Project Description:

:pushpin: Malin Space Science Systems Console Application runs continuously on the main server and provides calculation services to clients connecting via a private network. The calculation services are provided through a custom third-party DLL with specific mathematical formula.

:white_small_square: A single client Windows Application will connect to the server program using Named Pipes from the Inter-Process Communication technologies. 

:white_small_square: The client/server will utilise the Windows Communications Foundation for communications between the Form client and Console server. 

:white_small_square: The client interface will provide the user with input text boxes for each astronomical calculation and read only output text boxes for the returned values. 

:white_small_square: Malin Space Science Systems has three major European operations and requires a language option so the teams at each of these locations can change the language during runtime. 

:white_small_square: The client application runs the same version of the application at all locations; this single client version will be distributed and must be customisable for language and UI display. 


:white_small_square: The user can select/click a menu option on the client Form that will change the language for all controls and labels. 

