# Pizza App
## This is the final project of my Application Development II class at JU. It uses windows forms and object oriented programming structure.

The objective for this application was to create a pizza ordering app. The user is able to order multiple pizzas
and sides with their choice of toppings, totaling up at the end in a receipt. They are able to modify this sub total before
accepting the transaction, and the form will ask for the users information including an email address. It will send a mock
email to the email address they provide that contains a receipt as well as an estimated time of arrival for the delivery man.

The bugs that were there at the time of submission for the grade are still there. They are:
  1. Rapid clicks of the topping selections causes the events to overlap and cancel. This causes the price
     to not be removed when clicking off, and the pizza total will continue to increase until the rapid
     clicking stops
  2. I used the wrong protocol for sending out the receipt as the dummy email created for this was using
     outlook. This causes the program to soft crash at the end once you submit the pizza order
