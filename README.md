# Week 10- Modeling
1. Feature- Create Customer and Reservation Entities
2. Goal- To assign customers to specific tables
3. Checklist Criteria- Customer table created, Reservation table created, relationship works
4. Write-up-
Models are completed once the Customer is able to reserve a table. The customer will include his name, email, and phone number and then book his reservation to the specified table. This information is useful in case employees need to contact them for any reason.
The reserved table would include the Customer info based on the Customer entity, the time the customer will arrive, the number of guests that will reserve the table, and any special requests if neccessary. This can improve effeciancy for employees since they would know exactly when the customers will arrive and how many seats will be needed. In case the customer cancels his reservation, an IsCanceled property will also be included along with IsConfirmed to ensure the reservation is applicable. This saves time for employees from preparing for their arrival. Hopefully I will be able to successfully create a database. The application will seed the database, dislaying the list of customers who reserved a table along with their info based on their properties. I also hope to create a database for a list of reservations, also providing the neccessary information based on the implemented reservation properties. Ovreall, the information should provide ease and efficiance for both customers and workers for a good time at any restaurant.
5. Test plan- Drop existing database, add migration, update database, then check if database exist
# Week 11– Separation of Concerns / Dependency Injection
