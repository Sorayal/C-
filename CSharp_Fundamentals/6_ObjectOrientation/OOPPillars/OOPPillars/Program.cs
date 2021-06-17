/*
 * First pillar: Abstraction: The user of an object don´t need to know
 * how the methods are implemented or how the structure of the object is.
 * 
 * Second pillar: Inheritance: Methods and attributes can be inheritanced from a
 * base class. It helps much to reuse the code and to minimize code dublicates
 * 
 * Third pillar: Polymorphism: At runtime the Runtime Enviroment can call the right method
 * for the child object which are always also parent objects. So they can be defined at compile
 * time as parent , but at runtime they appear properly as child. 
 * 
 * Fourth pillar: Encapsulation: This principle protects the data within an object from direct access.
 * Unless the attributes are public, they can be only changed and read via calling properties, which are
 * a combination of a method and a (hidden) attribute. 
*/
using System;

namespace OOPPillars
{
    class Program
    {
        static void Main()
        {
            Enemy enemy = new();
            // Abstraction: The user doesn´t know how the method SayEnemyType is implemented
            enemy.SayEnemyType();

            // Inheriance: Both classes Gladiator and Zenturion inherited from class Enemy
            // One method in Enemy is overridden by specific methods. 
            Gladiator gladiator = new();
            Zenturion zenturion = new();

            // The can call the property which is inherited from Enemy
            Console.WriteLine($"Health for Zenturion: {zenturion.Health} ");
            Console.WriteLine($"Health for Gladiator: {gladiator.Health} ");

            // Polymorphism: This calls the right method for this child objects
            Enemy[] enemies = new Enemy[] { gladiator, zenturion };
            foreach (var enemyInstance in enemies)
            {
                enemyInstance.SayEnemyType();
            }
            Console.WriteLine("\nChanging health of zenturion to -10: ");
            // Encapsulation: Trying to set the health for the zenturion object below 0,
            // which will not work

            zenturion.Health = -10;
        }
    }
}
