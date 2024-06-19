# Sous Chef App EF Core & JS Project Plan

## User functionality
- Create, read, update, & delete user profile
- Create, read, update, & delete user meal plan
- Read recipes
- Create & read grocery list
- Admin user
    - Create, read, update, & delete recipes


## Additional goals
- User passwords with protections
- xUnit testing
- Admin user type vs. normal user type


## Steps
1. Plan out models
    - Including admin user type vs. normal user type
    - Including password protections
2. Set up EF Core stuff
3. Build user CRUD operations


## Models

### Users
- Passwords
- Dietary preferences (gf/df)
- How many people they're cooking for?  Eh 

### Meal Plans
- Vary number of meals to cook


## Ideas
### Passwords
- Option 1
    - Salting - where to store the salt
    - Hashing
    - Peppering
- Option 2
    - Authentication via ASP.NET

## Organization
- Instead of different projects/folders for EF Core vs. ADO.NET, just have them in the same overarching project but then put ADO.NET stuff in a folder?

## What I want to learn with this
- Practice building an ASP.NET application
- Practice using EF Core
- Practice using ADO.NET
- Practice using JS
- Practice using React
- Practice using TypeScript
- Practice designing a pretty UI with HTML/CSS
- Authentication (passwords/different types of roles)
- Xunit - maybe just try this for my project 1 C# Console app first too
- Learn how to integrate with an external API
