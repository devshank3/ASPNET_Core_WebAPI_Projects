## The Data Layer 

Benefits 

- Separation of concerns 
    - Data logic vs business logic 
- Factors out duplicated data code 
- Smaller mental model 
- Replaceable in pieces
- Testability 

Shared business code 

- Business Code 
    - SQLite Data layer - Mobile
    - SQL data layer - Web, Server 

Testability 

- Both business and data testability 
- Testing during development 

Interfaces 

- How layers communicate
- Dependency Injection 
- Back to testing 

- A monolithic interface (with lot of methods) can be a bad code 
- Logical surface area of module or layer
- Granular  


---

## The Repository Pattern 

The repository pattern is a way to isolate data retrieval and persistence into a single unit. This is just one pattern that we can use as part of the data layer with Entity Framework.

### Definition 

"The repository mediates between the data source layer and the business layers of the application. It queries the data source for the data, maps the data from the data source to business entity and persists changes in the business entity to the data source. A repository separates the business logic from the interactions with the underlying data source or web service."

Specifies the combination - Query- retrieval - mapping 

---