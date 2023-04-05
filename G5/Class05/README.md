# Taxi Manager 9000 🚕

A taxi company wants an app that can manage their taxi cars and drivers. This app should be able to track license plates and driver's licenses expiry dates, list all cars and drivers as well as assign and unassign drivers from a car and a shift. It should have some fail-safe mechanisms when people enter undesirable input. It should also have users and different users should be able to do different stuff in the app.

## Use Cases

- Log in
- Create a user
- Check car expiry licenses
- List all vehicles / List all operational vehicles
- List all drivers
- Check driver's expiry licenses
- Assign a driver to a car
- Unassign driver to a car
- Change password
- Log out

## Models

- User
  - Id
  - Username
  - Password
  - Role
    - Administrator
    - Manager
    - Maintenance
- Car
  - Id
  - Model
  - LicensePlate
  - LicensePlateExpieryDate
  - AsignedDrivers
- Driver
  - Id
  - FirstName
  - LastName
  - Shift
    - Morning
    - Afternoon
    - Evening
  - Car
  - License
  - LicenseExpieryDate

## UI Tree

- Login Menu
  - Taxi Manager 9000
  - Log in:
  - Username: **\_\_\_** -> Read Username
  - Password: **\_\_\_** -> Read Password
    - Red text: Login unsuccessful. Please try again -> Restart the Login Menu
    - Green text: Successful Login! Welcome [Role] user! -> Redirects to Main Menu
- Main Menu
  - [Admin] New User
    - Create a new user for the app:
    - Username: **\_\_\_** -> Read Username ( Must contain at least 5 characters )
    - Password: **\_\_\_** -> Read Password ( Must contain at least 5 characters and 1 number )
    - Role: ( Multiple Choice of 3 roles ) -> Read choice
      - Red text: Creation unsuccessful. Please try again -> Restart the New User Section
      - Green text: Successful creation of an [Role] user! -> Redirects to Main Menu
  - [Admin] Terminate User
    - Remove existing user from the app:
      - List all users
      - Choose user from the list
      - Removes the chosen option
  - [Maintenance] List Vehicles
    - [Id]) [Model] with License Plate [LicensePlate] and utilized [Percentage of shifts covered]%
  - [Maintenance] List Vehicles Licence Plates (Statuses)
    - List all license plate statuses with Red, Green or Yellow ( Red -> Expired, Green -> Valid and Yellow -> 3 months to expiery )
      - [Status in color]) Car Id [Id] - Plate [LicensePlate] expiering on [ExpieryDate]
  - [Manager] List Drivers
    - [Id]) [Full Name] Driving in the [Shift] shift with a [Car.Model] car
  - [Manager] List Driver Licenses (Statuses)
    - List all license statuses with Red, Green or Yellow ( Red -> Expired, Green -> Valid and Yellow -> 3 months to expiery )
      - [Status in color]) Driver [Full Name] with license [License] expiering on [ExpieryDate]
  - [Manager] Driver Manager
    - Assign Unassigned Drivers
      - List of all unasigned drivers
      - Choose one of the drivers that are provided
      - Pick a shift: ( Multiple Choice of 3 shifts ) -> Read Choice
      - Pick Available Car:
        - List available cars ( Cars that have no driver for the picked shift and have a valid license )
        - Choose one of the cars that are provided
    - Unasign Assigned Drivers
      - List of all asigned drivers
      - Choose one of the drivers that are provided
  - [All] Change Password
    - Old Password: **\_\_\_** -> Read old password
    - New Password: **\_\_\_** -> Read new password
      - Red text: Password change unsuccessful. Please try again -> Restart the Change Password Section
      - Green text: Successful change password!
  - [All] Exit -> Close Console App
  - [All] Back to Main Menu -> Option available on EVERY menu except the Main Menu
