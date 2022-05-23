This program is designed to calculate simple mathematical operations like addition subtract multiplication square root.
In program directory user should add a file named input.json to calculate. Result will be saved in the file output.txt in program directory.

Requirements to correct use a program:
-In JSON file subsequent operations will be added as an object. 
example: 
{
"obj1": {
 "operator": "add",
 "value1": 2,
 "value2": 3
},
"obj2": {
 "operator": "sqrt",
 "value1": 16
}
} 

-"operator" have one of four values add, sub, mul, sqrt;
-"value1" and "value2" should be Integer