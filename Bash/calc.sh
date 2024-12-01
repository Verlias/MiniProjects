#!/bin/bash
#Shabang: Actual interpreter to run Scripts
#Purpose: Takes in 3 arguments; two numbers and one mathematical operators

#Main Function
#Learn error handling syntax development conditionals and variable assignment. I also learned more about wild cards and
#how they operate when compling scripts I also learned how certain development should go about in scripts
#this is just a general fun practice

main() {
   #Conditionals to see which operators
   if [ "$3" == "+" ]; then #-eq -lt numerical comparisons
      echo "You are adding $1 and $2"
      add $1 $2
   elif [ "$3" == "-" ]; then
      echo "You are subtracting $1 and $2 together"
      subtract $1 $2
   elif [ "$3" == "*" ]; then
      echo "You are multiplying $1 and $2 together"
      mult $1 $2
   elif [ "$3" == "/" ]; then
      echo "You are dividing $1 by $2"
      divide $1 $2
   else
      echo "You did not pass in a correct mathematical operator, it should be  +-*/ not $3"
   fi

   return 0 #Sucess
}



#Add Function

add() {
   #Prac Variables
   result=$(($1 + $2))
   echo "Addition: $result"
   return 0
}


#Subtract Function

subtract() {
   result=$(($1 - $2))
   echo "Subtraction: $result"
   return 0

}




#Multiplication Function

mult() {
   result=$(($1 * $2))
   echo "Multiplication: $result"
   return 0
}



#Division Function

divide() {
   if [ $2 -eq 0 ]; then
      echo "Divsor cannot be Zero"
   else
      result=$(($1 / $2))
      echo "Division: $result"
   fi
   return 0
}




#Main Script to detect the three arguments being passed into the program


if [ $# -eq 3 ]; then #Need spaces between the brackets
   main $1 $2 "$3"
else
   echo "You passed in $# arguments there must be 3 arguments total"
fi
