using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concepts.MethodParameters;

namespace Concepts
{
class Program
{
static void Main(string[] args)
{
Console.WriteLine("Hello!");
Animal cat = new Animal();
Animal dog = new Animal();
cat.weight = 30;
dog.weight = 60;
changePrimitiveWeight(cat.weight);
changeReferenceWeight(dog);
Console.WriteLine("Cat: "+cat.weight+", Dog: "+dog.weight);

changeReferenceWithRef(ref dog);
Console.WriteLine(dog.weight);

int number = 8;
changePrimitiveWithRef(ref number);
Console.WriteLine(number);

Console.ReadLine();
}
    //This method will not change the current weight outside its scope.
static void changePrimitiveWeight(double currentWeight)
{ currentWeight = 8; }
static void changeReferenceWeight(Animal animalObject) 
{
    Animal penguin = new Animal();
    penguin.weight = 20;
    animalObject = penguin;
}

static void changeReferenceWithRef(ref Animal animalObject) 
{
Animal frog = new Animal();
frog.weight = 2;
animalObject = frog;
}
static void changePrimitiveWithRef(ref int number) 
{number = 54;}
}}