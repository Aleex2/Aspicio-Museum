# Aspicio Museum Application

## Description
Art2.0 is a Windows Forms application for managing an art gallery database. It allows you to manage exhibitions, artists, paintings, clients, and orders, with various queries to analyze sales, exhibitions, and artist statistics.

## Features
* Exhibition Management: Add, update, delete, and display exhibitions.
* Artist & Painting Queries: Run predefined queries showing artists, their paintings, sales, and clients.
* Complex Reports: Generate advanced reports like top-selling artists, clients attending popular exhibitions, and exhibitions filtered by theme or year.
* User-friendly UI: Interactive forms with DataGridViews and combo boxes for easy data selection.

## Structural and functional architecture

Classes :
* Cast -> class created to organize the people who are part of the cast and their occupations
* Roluri -> inherits the Cast class; its constructor randomly assigns a role and the price of the corresponding makeup
* Diete -> inherits the Cast class; its constructor randomly assigns a type of diet
* Meniu -> abstract class, used to generate the menu for each diet using 3 virtual methods that determine the type of soup, the main course, and the dessert
* ManancaOrice -> inherits the Meniu class; generates the menu without restrictions
* Vegetarian -> inherits the Meniu class; generates the vegetarian menu 
* Flexitarian -> inherits the Meniu class; generates the flexitarian menu
* Cheltuieli -> class in which expenses are determined based on the category; ultimately, total costs are realized; the class also has 2 methods (RO/EN) that generate the files that contain all the details about the necessary financial resources

Functions :
* preiaInfo() -> function that inserts the cast data into an array of Cast class objects after retrieving it from the previously mentioned file
* adaugaFiguratie() -> function that adds the background actors to the previously created array of Cast class objects
* scriereFisierNou() -> function that generates the new file containing the full cast and crew
* atribuireRoluriActori() -> uses an array of objects from the Roluri class to retrieve only the actors from the array of objects from the Cast class (thus assigning the roles and makeup prices for the actors)
* atribuireDiete() -> a new array of Diet class objects is created that contains all the people from the array of objects from the Cast class together with the randomly assigned diet and the corresponding price
* scriereMeniu() -> generates the files (RO/EN) containing the menu for 3 days respecting the 3 types of diets
* costCastel() -> uses a template element as a parameter to calculate the cost of renting the place where the series will be filmed



