# Vendor Tracker


#### Pierre's personal vendor tracker for his budding croissant business.

#### _By Nathan Fletcher_

* This app uses restful routing to track vendors and the orders from each vendor using create, read, and update operations.

## Technologies Used

* C#
* Object Oriented Programming
* ASP.NET Core MVC Framework
* Restful Routing Conventions
* MSTest
* Test Driven Development

## Setup

<details>
<summary>Setup & Installation Instructions</summary>

* Clone this repository to your local machine
* Install C# and .NET using the [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-5.0.100-macos-x64-installer) if necessary
* Inside the project folder, navigate to the VendorTracker.Tests folder in your terminal
* Type `dotnet restore` and press enter.
* Type `dotnet test`and press enter to run the tests.
* Navigate to the VendorTracker folder
* Type `dotnet build` and press enter to compile the project.
* Type `dotnet run` to start the server.
* Enter localhost:5000 in your browser to start tracking. 
</details>

## Known Issues
* There are no known issues at this time.
* Please contact me if you find any bugs or have suggestions. 

## Future Plans
* Add a BakeryItem class to add various baked goods to orders.
* Add delete operations for vendors and orders.
* Make displays sortable by date or other properties. 
* Make the site searchable.

## How This Project Was Made
* I tracked my tasks using notes similar to a Trello board.
* You can view the notes at each commit in a commented section of the Vendor.cs file.
<details>
<summary>View the final version here</summary>

### Extras: 

delete - delete breaks the find function as currently implemented because it's linked to the index

order items class - import and integrate last week's project

Done extras:
build Order show

sort/filter buttons

edit/update:
*    done: -test/write method to update 
*    done: -make a get link from show page /vendors/{id}/orders/{id}/update
*    done: -make controller edit route to go to form
*    done: -make edit form
*    done: -call post submit route
*    done: -make controller update route

### MVP Done: 

build logic files w/ tests - just utility/constructors at this point
  Order: title, the description, the price, the date

build out MVC for the required stuff: 
done: Splash

Vendor: 
done: index
goto form
create
show

Order:
goto form
create

styling

Readme
</details>


## License

_[MIT](https://opensource.org/licenses/MIT)_  

Copyright (c) 2021 Nathan Fletcher 

## Contact Information

_Nathan Fletcher @ github.com/nathanfletch_  