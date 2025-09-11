# Welcome to JOI Delivery
JOI Delivery is built for real life. For the young professional who gets home late and doesn’t have the energy to cook. For the student with an exam tomorrow and an empty fridge tonight. These aren’t exceptions — they’re everyday moments. That’s why JOI Delivery brings food and groceries to your door, fast, fresh, and right when you need them.

Customers struggle with:

- Cluttered browsing experiences that don’t understand their preferences.
- Limited customization when ordering meals or groceries.
- Unclear order status or delivery timelines.
- Poor payment experience, or failed checkouts.
- Lack of timely feedback channels to report a bad experience or appreciate a good one.

JOI Delivery was built not just as another delivery app, but as a thoughtful, technology-first platform that reimagines how essentials reach customers in the most seamless way.

# Introducing JOI Delivery

JOI Delivery, launched in 2024, is a hyperlocal delivery app designed to bring food and groceries to your doorstep in under 45 minutes. With the tagline "Speed meets convenience," it connects customers to nearby restaurants and stores through a seamless digital experience. The app solves the hassle of long wait times and limited local options by offering real-time tracking, instant order updates, and a wide network of trusted vendors.

## Why they need Thoughtworks help
As JOI Delivery continues to grow and serve more neighborhoods, we’re scaling our platform to handle increasing demand, enhance user experience, and support smarter delivery logistics. They're looking for passionate developers to help us build robust, efficient, and scalable solutions that power everything from order placement to real-time tracking.
Your expertise will directly impact how quickly and reliably customers receive their essentials—and how smoothly local vendors and delivery partners operate within our ecosystem.

## Domain/Models available


| Domain Name     | Attributes                                           |
|-----------------|------------------------------------------------------|
| Customer        | customerId, firstName, lastName, loyaltyPoints, tier |
| Delivery        | id, timeInMinutes, diatance                          |
| DeliveryPartner | id, name, deliveries                                 |
| Item            | id, name, description, price, category               |
| Store           | storeId, zone, items                                 |
| Order           | ** To be Implemented **                              |

## Static Data

**DistanceMap**

| Zone One | Zone Two | Distance | 
|----------|----------|----------|
| ZONEA    | ZONEA    | 0        |
| ZONEA    | ZONEB    | 3        |
| ZONEA    | ZONEC    | 6        |
| ZONEB    | ZONEC    | 3        |
| ZONEB    | ZONEB    | 0        |
| ZONEB    | ZONEC    | 8        |
| ZONEC    | ZONEC    | 0        |

**Stores**

| StoreId | ZoneId | Items               |
|---------|--------|---------------------|
|  1      | ZoneA  | [Milk, Eggs, Bread] |
|  2      | ZoneB  | [Bread, Milks ]     |
|  3      | ZoneC  | [Juice, Bread ]     |

**Items**

| ItemId | Name     | Description | Price |
|--------|----------|-------------|-------|
|  1     | Notebook | ""          | 15    |
|  2     | Keyboard | ""          | 50    |
|  3     | Mouse    | ""          | 25    |
|  4     | Monitor  | ""          | 75    |



## Technologies Used

- **C# 12 / .NET 8.0**: Core backend language and framework
- **xUnit / NUnit / MSTest**: For unit testing (choose based on your test framework)

## Local Setup

1. **Clone the repository**  
   ```bash
   git clone https://github.com/techops-recsys-grad-hiring/grad-joi-delivery-dotnet.git
   cd grad-joi-delivery-dotnet
   ```

2. **Build the project**  
   ```bash
   dotnet build
   ```

3. **Run the application**  
   ```bash
   dotnet run
   ```

4. **Run unit tests**  
   ```bash
   dotnet test
   ```

**Requirements:**

- .NET 8.0 SDK or later (https://dotnet.microsoft.com/download)
- Compatible IDE (e.g., Visual Studio, Rider, VS Code)

## Running SampleProblem Class
A sample problem class is provided as a reference to demonstrate the structure and approach for solving the given problems. Using this as guidance, one can create their own class and implement the business logic accordingly.
### Steps to run the SampleProblem
