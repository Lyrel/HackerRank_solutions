/*
 https://www.hackerrank.com/challenges/game-with-cells/problem

  Luke is daydreaming in Math class. He has a sheet of graph paper with n rows and m columns, 
  and he imagines that there is an army base in each cell for a total of n*m bases. He wants to 
  drop supplies at strategic points on the sheet, marking each drop point with a red dot.
  If a base contains at least one package inside or on top of its border fence, 
  then it's considered to be supplied. 

*/ 


function ArmyGame(m, n){

let rows = n + n % 2;
let columns = m + m % 2;

let result = (rows*columns)/4;
return (result);
}
