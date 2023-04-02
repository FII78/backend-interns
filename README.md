# Simple Blog API

This project is a simple backend API for a blog application. It was implemented using .NET Core 6.0 and MongoDB as the database.

## Setup

To run this project, you will need to have .NET Core 6.0 and MongoDB installed on your machine.

## Clone the repository
  1. Open the project in your preferred IDE
  2. Rename the appsettings.example.json file to appsettings.json
  3. In the appsettings.json file, update the connection string to your MongoDB database
  4. Run the project by typing dotnet run in your terminal or using your IDE's built-in run command

## Endpoints

  The API has the following endpoints:

  ## GET /api/blogs
  Returns a list of all blog posts.

  ## GET /api/blogs/{id}
  Returns a single blog post by ID.

  ## POST /api/blogs
  Creates a new blog post.

  ## PUT /api/blogs/{id}
  Updates an existing blog post's tag by ID.

  ## DELETE /api/blogs/{id}
  Deletes an existing blog post by ID.

## Data Model

The blog post data model consists of the following fields:

  * Id: The unique identifier of the blog.
  * Title: The title of the blog.
  * Content: The content of the blog.
  * Author: The name of the author of the blog.
  * Tag: The category/tag of the blog.

## License

This project is licensed under the MIT License - see the LICENSE file for details.
