using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2_14
{
    /* Class: Friend
     * Author: Jonathan Karcher
     * Purpose: Define a friend
     */
    public class Friend
    {
        // friends name
        public string name;
        // friends greeting
        public string greeting;
        // friends birthday
        public DateTime birthdate;
        // friends address
        public string address;
        /* Constructor: Friend
         * Purpose: create a friend
         * Restrictions: None
         */
        public Friend()
        {
            // assign the name
            name = "Charlie Sheen";
            // assign the greeting
            greeting = "Dear Charlie";
            // assign the birthday
            birthdate = DateTime.Parse("1967-12-25");
            // assign the address
            address = "123 Any Street, NY NY 12202";
        }
        /* Method: MakeAnEnemy
         * Purpose: Assign the enemy values to a friend object
         * Restrictions: None
         */
        public Friend MakeAnEnemy()
        {
            // create a new friend
            Friend f = new Friend();
            // assign the name
            f.name = this.name;
            // assign the greeting
            f.greeting = "Sorry Charlie";
            // assign the birthdate
            f.birthdate = this.birthdate;
            // assign the address
            f.address = "Return to sender.  Address unknown.";
            // return the new enemy
            return f;
        }
    }
    /* Class: Program
     * Author: Jonathan Karcher
     * Purpose: Main entery class for the program
     */
    class Program
    {
        /* Method: Main
         * Purpose: Main entery point for the program
         * Restrictions: None
         */
        static void Main(string[] args)
        {
            // create a friend object
            Friend friend = new Friend();
            // create a friend reference
            Friend enemy;
            // assign the friend reference to the enemy values of friend
            enemy = friend.MakeAnEnemy();
            // output the two friend object
            Console.WriteLine($"friend.greeting => enemy.greeting: {friend.greeting} => {enemy.greeting}");
            Console.WriteLine($"friend.address => enemy.address: {friend.address} => {enemy.address}");
        }
    }

}
