# Amortization

## Index

- [About](#about)

- [Getting Started](#getting-started)
- [Build using](#build-using)
- [Features](#features)
- [Author](#author)

## About

Amortization is an app prototype to calculate a loan amortization schedule for use by car dealerships, in collaboration with a (hypothetical) automotive industry. The app is built using C# .Net application which will allow employees of a car dealership to calculate and display an amortization schedule for various customer car loans. This dealership specializes in extending small loans over short time periods limited to 6  months, 12 months, 18 months, and 24 months. During certain times of the year, the car dealership also offers  a rebate to the customer as an incentive. The amount of the rebate is subtracted from the loan amount. There  are no additional financing fees charged by this dealership.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

#### Prerequisites

To be able to run the application, **.Net Framework** is required.(Recommended version: .Net Framework SDK 4.7)

## Build using

- C# .Net Windows Application(WinForms)

## Features

- Loan Calculation

  - Calculate Loan

    The **Calculate Loan button** allows the dealership employee to experiment with various inputs and loan times  to arrive at the best option for the customer. The amount of the rebate (if applicable) is subtracted from the loan amount before the amortization  calculations. For each month, the list box shows the interest amount due, the principal amount due,  the monthly payment amount, and the balance due at the end of the month. After each month’s amounts are  listed, a blank line and totals for interest, principal, and payment appear.

    Formula for the principal payment :

    ```c#
    principalPayment = rate / 12 * (loan + 0 * Math.Pow(1 + rate / 12, months)) / ((Math.Pow(1 + rate /  12, months) - 1) * (1 + rate / 12 * 0));
    ```

  - Accept Loan

    When the customer is ready to accept the loan for  their purchase, the employee clicks the **Accept Loan button**. This event adds the “accepted loan” amount to the daily loan totals for all customers and adds the interest amount to the interest totals for the day. Thus, the app tracks (in variables stored in RAM) the total loan amounts completed for all customers each day

  - Total Loans/Interest

    At any point, the employee may click the **Display All Loans** button to display the total loans and total interest variable values in the Total loans and Total interest labels, respectively.

## Author

- [Wang Yang](https://github.com/NorthstarWang)
