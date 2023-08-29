//Goal

//Create back end for blog site
//create front end for blog site
//deploy to azure
//learn about devops and scrum

create an api for blog 
api must handle all crud functions

in this app user should be able to login
blog page to view all published items
dashboard(user profile page for them to edit,delete and add blog items)

controller//folders
      userController
      login//endpoints
      add a user//endpoints
      update a user
      delete a user
blogController//file
      AddBlogItems//endpoint C
      getAllBLogItems//endpoint R
      get blog items by category
      get blog items by tag
      get blog items by date
      updateBlogItems//endpoint U
      DeleteBlogItems//endpoint D

model//folders
      usermodel
          int id
          string username
          string salt
          string hash 256 characters
      blogitemmodel
          int id
          int userid
          string publishername
          string title
          string image
          string description
          string date
          string category
          bool ispublished
          bool isdeleted


 loginmodel
     string username
     string password
 createaccountmodel
     int id = 0
     string username
     string password
 passwordmodel
     string salt
     string hash

"Server Admin log in: academyblogAdmin           Password: AcademyBlogPassword!"