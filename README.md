# SimpleCalculator
simple calculator which apply the main four operations


the structure of the programs

        1.	The controller: responsible for the requests we send the numbers and get results through it
        2.	The services:  contains the logic part of the four operations.
        3.	The models:  there are the obj that I send and receive result using it.

How to run the program:
       I used the postman app the send and retrieve the JSON data
       
       
The steps:

      1.	Use the post request to send the data via 
      your localhost/Controller’s name/function name 
      http://localhost:28416/SimpleCalculator/GetCalResult
      2.	Use JSON format from body section , enter strings or numbers it’s okay
       ex)
      {
          "Num1": 100, // this is part could be string or number 
          "Num2":  100
      }
      {
          "Num1": "100",
          "Num2": 1000
      }
      3.	Send the request and you will get the results at body section

