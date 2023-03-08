
# Web API Test

This is a simple API that I made as a test and demonstration of my knowledge of software development using the .Net Platform.

This API was built to my understanding of the requirements, as there was no form of validation.

# Requirements

Background
You are working on a project for a company that provides a mobile app for users to find
nearby restaurants and make reservations. The company has decided to use the Yelp Fusion
API to obtain restaurant data.
Task
Your task is to build an ASP.NET Core API server that integrates with the Yelp Fusion API and
returns restaurant data to the mobile app. The mobile app will display restaurant
information, including images and content, based on the data returned from the API.
Requirements
1. Use the Yelp Fusion API to obtain restaurant data. You will need to sign up for a free
Yelp Fusion API key to complete this task.
2. Build an ASP.NET Core API server that exposes the following endpoints:
• GET /api/restaurants: Returns a list of restaurants based on the specified
location and search term. The endpoint should accept two query parameters:
location and term. The location parameter should be a string representing
the location to search (e.g. "New York City"). The term parameter should be a
string representing the search term (e.g. "sushi").
• GET /api/restaurants/{id}: Returns details about a specific restaurant based
on its ID. The endpoint should accept a single path parameter: id, which
should be a string representing the Yelp ID of the restaurant.
3. Use dependency injection to manage the Yelp Fusion API client. You should create an
interface for the Yelp Fusion API client and implement it using the Yelp Fusion API
SDK.
4. Use caching to improve performance. You should cache the results of the
/api/restaurants endpoint for a configurable period of time (e.g. 5 minutes).
5. Map the appropriate restaurant images and content from the Yelp Fusion API to your
API's output. The /api/restaurants endpoint should return an array of restaurant
objects, each containing the following information:
• id: A string representing the Yelp ID of the restaurant.
• name: A string representing the name of the restaurant.
• location: An object representing the location of the restaurant, with the
following properties:
• address1: A string representing the first line of the restaurant's street
address.
• address2: An optional string representing the second line of the
restaurant's street address (if applicable).
• city: A string representing the city where the restaurant is located.
• state: A string representing the state where the restaurant is located.
• zip: A string representing the ZIP code where the restaurant is
located.
• image_url: A string representing the URL of the restaurant's main image on
Yelp.
• review_count: An integer representing the number of reviews the restaurant
has on Yelp.
• rating: A decimal representing the average rating of the restaurant on Yelp.
• phone: A string representing the restaurant's phone number.
• categories: An array of objects representing the categories that the
restaurant belongs to, with each object containing the following properties:
• alias: A string representing the alias of the category (e.g. "japanese").
• title: A string representing the title of the category (e.g. "Japanese").
6. Write unit tests to ensure the functionality of the API server.
Evaluation
Your solution will be evaluated based on the following criteria:
1. Correctness: Does your solution meet the requirements outlined above?
2. Design: Is your code well-organized and easy to understand? Are you following best
practices for ASP.NET Core development?
3. Performance: Does your code perform well? Are you making efficient use of the Yelp
Fusion API and caching?
4. The code is easily maintainable and extensible.
5. The unit tests cover the key functionality of the API server and are easy to run.
Submission:
Please submit your code via a GitHub repository. Your repository should include the
following:
1. A Visual Studio solution containing your code.
2. A README.md file that explains how to build and run your code.
3. A .gitignore file that excludes any unnecessary files from your repository.
When you have completed your solution, please email the URL of your GitHub repository to
the person who provided you with this technical test prompt.

## API Reference

#### Test all items

```
  Test Browse https://localhost:7143/swagger/index.html
```

#### Get items

```
  GET https://localhost:7143/api/Restaurants/Vaq49W0ubGjuIc4h5_qQ0w}
```


| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `string` | **Required**. Id of item to fetch |

#### Get(location, term)

Response Restaurants list beasead on location.
Yelp Fusion API don't accept null location.


## Feedback

A test case was developed using Unit that can also be used to test the API.
Get requests are cached by default, a 5 minute cach has been set.

## Deployment

To deploy this project open with

```.net
  Visual Studio 2022 - c# 7.0 - Rest API 7.03
```


## Authors

```
- Frank Coelho
- Flcbh@hotmail.com
```
