# MVC-Movie-Review-Website

## My Role as a Developer
My role in the team was a developer. My job was to assist my team mates in developing a Film review website using MVC and C#. I started off by writing on my wiki page, what my role was and what I was going to do within my team. I then started off by working on the home page of the website. I added all the links that we needed on to the navbar, I also added the name logo on to the navbar. I then moved on to adding a new stylesheet on to the home page by getting a new bootstrap theme. I then added an image on to the home page. 

After working on styling the home page, I moved on to creating the data models. I started off by adding all 5 data models which are, Actors, Directors, Films, Genre, and Reviews. After completing the data models, I moved on to adding an actor’s controller. The way I added it was by using scaffolding where it then created the CRUD method. This enables the user to create, read, update and delete an actor from the system. I then moved on to working with my Context which was called RunnersContext. 

I then moved on to adding the seed for initialising the data. We called the initialiser RunnerIni. I started off by adding 6 different genres by populating some data into it. I then moved on to adding and populating data into 6 different directors and actors. I then moved on to Films index page, where I changed the names of the table headers into more suitable names. 

I then started working and assisting with my developer team members Faisal and Nahidul to create the remaining controllers.  We wanted to create more data initialisers. We started of first with the films where we figured out how to populate data into films. They then managed to do the rest of the data. 

I then moved on to creating the sorting for the films webpage, this enables the user to sort ratings and films, I worked on the films controller and added the code that enables the function of sorting. I then moved on to adding the paging for each web page. I added the code on the films controller. Finally, I added a search filter where the user would be able to either search for genres or films. 

 I then moved on to creating an application user, this function makes sure that the users cannot not add or delete any movies or actors without being a member with an email account. I added the code function for displaying movies on the actors and directors page.
 
I then moved on to the films index page, where I added a search box html form, this allows the users to search for movies or genres. I also had to add an html action link that enables the users to sort either the movies or ratings. Finally, I had to make sure to hide the create new, edit, and delete action links on the films index page whenever the user was not logged in. 

As a team, we decided that we needed more data on films, actors and directors. Therefore, I started off working on the RunnerIni class, where I populated data by adding more genres onto the system. I also added two more actors and populated data on to those actors. After completing my tasks, I informed my team mates of the changes that I made so that there won’t be any GitHub conflicts. 

## Team Work
We managed to work as a team well. Our team consisted of 5 members, 3 of the members were developers and the other two were analysts. We decided as a team to choose and work on the film review project. We then started off by choosing a project manager. After we chose the project manager, we discussed as a team what each person was good at and what role he would want to take on. We started off working on the documentations. We developers worked with the analyst when deciding the data models, the screen designs, and the use case diagrams. Whenever we needed to have a meeting, we would use WhatsApp to communicate with each other and set a meeting place and time. 

It was important for us developers to work as a team efficiently. We had to make sure that we informed one another whenever we made a change to the system. This was important because we were working with GitHub, and therefore we had to make sure that there were no conflicts. We us developers discussed on which part of the system each of us was going to work on. 

Overall, we managed to work as team successfully by making sure we were constantly keeping in touch, communicating through social media, and informing one another of our situation concerning the system.  

On the other hand, there were some problems we faced as a team. At the start of the project we found it difficult to decide on our meeting dates, as everyone was busy. We however managed to solve this problem by making a specific meeting date and time that everyone agrees with on each week. We also got conflicts on GitHub, this was because we changed codes that another team member has already changed. We managed to solve this problem by undoing the commits. We also made sure that we inform each other whenever we are planning to make a change on the system. 

If I were to start the project again I would work better with my team members, this is because when we work as a group we are less likely to make any mistakes, likewise, by working closer with my team members I would avoid the problem of having GitHub conflicts.

## ScreenShots

### When user is not a member

![image](https://user-images.githubusercontent.com/15992710/40029032-2b32fd9c-57da-11e8-9d5d-a7ee925d9b89.png)

When the user is not a member and visits the website, they will be redirected to this homepage

![image](https://user-images.githubusercontent.com/15992710/40029151-d49e1c4a-57da-11e8-932d-34aa85cdf327.png)

The users have the option to visit the about page where they are able to read furhter information about the website

![image](https://user-images.githubusercontent.com/15992710/40029260-65617092-57db-11e8-81af-3c484796edaa.png)

When the user is not a member, he is only able to view the film page. On this page, the user is able to sort the order of Movies and the ratings of the movie as well. 

![image](https://user-images.githubusercontent.com/15992710/40029338-fea4c312-57db-11e8-8cdb-c4187117e1ee.png)

The user is able to search the name of the movie and also the genre names as well

![image](https://user-images.githubusercontent.com/15992710/40029424-7d0791f8-57dc-11e8-8ea4-c2114647f4a1.png)

The user is able to view the details of the movie, as well as the actors that are in the movie.

![image](https://user-images.githubusercontent.com/15992710/40029650-973f7e68-57dd-11e8-9980-5a1e66308ece.png)

The users are able to visit the actors page, on this page they can view the actors when they are not logged in

![image](https://user-images.githubusercontent.com/15992710/40029759-24d4feb0-57de-11e8-8879-37293aa5127e.png)

The users are able to visit the directors page, on this page they can view the directors when they are not logged in

![image](https://user-images.githubusercontent.com/15992710/40029916-20bfa41e-57df-11e8-9d1e-52bae904efea.png)

The users would need to be logged into the system to be able to view any reviews

![image](https://user-images.githubusercontent.com/15992710/40030052-2546d8a8-57e0-11e8-8808-ef0c4a9dde92.png)

The user could use this page to contact us

![image](https://user-images.githubusercontent.com/15992710/40030062-41b3c4ce-57e0-11e8-9bf0-cbb931d3d827.png)

The user would use this page to login to the system

![image](https://user-images.githubusercontent.com/15992710/40030136-cc53122e-57e0-11e8-8950-02db615115b8.png)

If the user is not a member of the system, he is able to register onto the system using this page

### When user is a member

![image](https://user-images.githubusercontent.com/15992710/40030351-0952dc6c-57e2-11e8-95f9-e581e5743cb0.png)

When the user is a member of the system, the navigation bar will display their email address

![image](https://user-images.githubusercontent.com/15992710/40030612-705a1618-57e3-11e8-8de9-45745c6c3e8d.png)

When the user is logged onto the system, the film page changes into this page where they are able to view more options

![image](https://user-images.githubusercontent.com/15992710/40030700-ff835f7a-57e3-11e8-909a-fe31569cf011.png)

On this page the user is able to add a new film onto the system

![image](https://user-images.githubusercontent.com/15992710/40030726-20890904-57e4-11e8-8b5f-088f11377291.png)

On this page the user is able to delete a film from the system

![image](https://user-images.githubusercontent.com/15992710/40030770-5661eb18-57e4-11e8-9458-0c6959ecb76d.png)

On this page the user is able to edit a film

![image](https://user-images.githubusercontent.com/15992710/40030790-6e872352-57e4-11e8-81c4-9c803e382b5d.png)

The is how the actor page will look once the user is logged onto the system

![image](https://user-images.githubusercontent.com/15992710/40030871-d08994d6-57e4-11e8-84dd-2a126ec71bb7.png)

The user is abe to add an actor onto the system using this page

![image](https://user-images.githubusercontent.com/15992710/40030884-e7f16cde-57e4-11e8-96ee-73014cd8a494.png)

This is how the director page will look like once the user is logged onto the system

![image](https://user-images.githubusercontent.com/15992710/40030919-08e3a1fa-57e5-11e8-9658-ffb51d376259.png)

The user is able to view movie reviews when the user is logged onto the system

![image](https://user-images.githubusercontent.com/15992710/40030957-3e964258-57e5-11e8-87b9-9b19e7854983.png)

The users are able to delete reviews on this page

![image](https://user-images.githubusercontent.com/15992710/40030997-77d9fc8a-57e5-11e8-94f1-6e0775cf812e.png)

On this page the user can manage his user account settings
