# Best Restaurant

#### C#/.NET MVC website that organizes restaurant based on cuisine. Current version: 03.18.20

#### By Sarah "Sasa" Schwartz, Andrew Philpott

---

## Table of Contents

1. [Description](#description)
2. [Setup/Installation Requirements](#installation-requirements)
3. [Specifications](#specs)
4. [Known Bugs](#known-bugs)
5. [Technologies Used](#technologies-used)
6. [License](#license)

---

<details>
  <summary>Click to expand!</summary>
| Route Name | URL Path | HTTP Method | Purpose |
| :--------- | :------- | :---------- | :------- |
| Index | / | GET | Homepage: displays welcome message & link to view restaurants |

| Index | /cuisines | GET | Displays list of all cuisines |

| Create | /cuisines/{id} | GET | Offers a form to create a cuisine |

| Create | /cuisines/{id} | POST | Create a new cuisine object |

| Details | /cuisines/{id} | GET | Displays details of a specific cuisine |

| Edit | /cuisines/{id}/edit | GET | Offers form to edit a specific cuisine |

| Update | /cuisines/{id} | PATCH (via POST) | Updates a specific cuisine |

| Destroy | /cuisines/{id} | POST | Deletes a specific cuisine |

| Index | /restaurants | GET | Displays list of all restaurants |

| Create | /restaurants/{id} | GET | Offers a form to create a restaurant |

| Create | /restaurtants/{id} | POST | Create a new restaurant object |

| Details | /restaurtants/{id} | GET | Displays details of a specific object |

| Edit | /restaurtants/{id}/edit | GET | Offers form to edit a specific restaurant |

| Update | /restaurtants/{id} | PATCH (via POST) | Updates a specific restaurant |

| Destroy | /restaurtants/{id} | POST | Deletes a specific restaurant |

</details>

## WHAT WE WORKED ON 03.18.20

- Best Restaurant project as described in today's exercise plan
- Updated Best Restaurant project to include many-to-many structure and migrations
- Updated Best Restaurant project to include authentication and logging in/accounts
- Research on authorization

## Description

C#/.NET MVC website that organizes restaurant based on cuisine. This application allows you to create cuisines and restaurants per type of cuisine. The website will prompt you to register an account and log in to view restaurants. Then you can view, create, delete, and update your cuisines and restaurants.

## Installation Requirements

- Clone the repository on Github
- Open the terminal on your desktop
- \$git clone "insert your cloned URL here"
- Change directory to the BestRestaurant directory, within the BestRestaurant.Solution directory
- \$dotnet restore
- \$dotnet run
- The app should be hosted on http://localhost:5000/
- Use the app at this URL in the browser!

## Known Bugs

- No known bugs

## Technologies Used

- C#
- .NET

### License

- This software is licensed under the MIT license.
