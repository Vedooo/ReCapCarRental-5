using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants.Message
{
    public class Messages
    {
        internal static string BrandAdded = "New Brand Added!";
        internal static string BrandNotAdded = "Invalid Process,Can't add new brand process";
        internal static string BrandDeleted = "Brand Deleted!";
        internal static string BrandUpdated = "Brand Info's Update";
        internal static string BrandsListed = "Brand Infos Listed!";
        internal static string MaintainanceTimeBrand = "Maintainance Time..";

        internal static string CarAdded = "New Car Added!";
        internal static string CarNotAdded = "Invalid Process,Can't add new car process";
        internal static string CarDeleted = "Car Info Deleted!";
        internal static string CarInfoUpdated = "Car Info Updated";
        internal static string CarsListed = "Car Infos Listed";
        internal static string CarListedByDailyPrice = "Cars listed by daily price";
        internal static string CarsListedByColorId = "Cars listed by color ID";
        internal static string CarsListedByBrandId = "Cars listed by brand ID";
        internal static string MaintainanceTimeCar = "Maintainance Time..";

        internal static string ColorAdded = "New Color Added!";
        internal static string ColorDeleted = "Color Deleted!";
        internal static string ColorUpdated = "Brand Updated";
        internal static string ColorsListed = "Color InfoListed";
        internal static string ColorsListedById = "Colors listed by ID";
        internal static string MaintainanceTimeColor = "Maintainance Time..";


        internal static string CustomerAdded = "New Customer Added!";
        internal static string CustomerDeleted = "Customer Deleted";
        internal static string CustomerUpdated = "Customer Updated!";
        internal static string CustomersListed = "Customers Listed";
        internal static string CustomersListedById = "Customers listed by ID";
        internal static string MaintainanceTimeCustomer = "Maintainance Time..";

        internal static string UserAdded = "New User Added!";
        internal static string UserDeleted = "User Infos Deleted";
        internal static string UserUpdated = "User Infos Updated";
        internal static string UsersListed = "Users Listed!";
        internal static string UsersListedById = "Users listed by ID";
        internal static string MaintainanceTimeUser = "Maintainance Time..";

        internal static string RentalInfoAdded = "New Rental Process Added!";
        internal static string RentalInfoDeleted = "Rental Process Deleted!";
        internal static string RentProcessUpdated = "Rental Process Updated";
        internal static string RentalInfosListed = "Rental Infos Listed";
        internal static string CarDetailsListed = "Car Details Listed";
        internal static string CarDetailsListedById = "Car Details listed by ID";
        internal static string UnavaibleRentProcess = "Unavaible Rent Process";
        internal static string CarRentedBefore = "The car you chose has been rented before";
        internal static string CarDidntRentBefore = "Car is avaible for renting";
        internal static string CarIsNotHere = "The vehicle you have chosen is currently rented. ";
        internal static string CarIsHere = "Car is here, avaible for renting";
        internal static string MaintainanceTimeRental = "Maintainance Time..";

        internal static string CarNameMinLengthTwo = "Car Name has minimum two character";
        internal static string InvalidPriceValue = "Car Price must be Bigger than zero";
        internal static string PostValidCarColor = "Please enter a valid color such as (Black, White, Gray..)";

        internal static string EnterValidUserId = "Please enter valid User ID";
        internal static string NameCanNotBeBlank = "Name can't be blank";
        internal static string LastNameCanNotBeBlank = "Lastname can't be blank";
        internal static string EmailCanNotBeBlank = "Email can't be blank";
        internal static string PasswordCanNotBeBlank = "Password can't be blank";

        internal static string PleaseEnterValidCarId = "Please enter valid Car ID";
        internal static string PleaseEnterValidCustomerId = "Please enter valid Customer ID";
        internal static string RentDateCanNotBeBlank = "Please select any date for rent. Rent date can't be blank";
        internal static string ReturnDateCanNotBeBlank = "Please select any date for return. Return date can't be blank";
        internal static string EnterCustomerId = "Enter Customer ID";
    }
}
