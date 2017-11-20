using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyObj5
{
    class Archer//template used for modelling and making archer objects
    {
        //normally we count arrows as 2,3,4 not 3.458
        private int arrowCount; //instance variable for storing numbers of arrows in quiver
        public Archer(int count) => arrowCount = count; //set value of instance variable for each archer object we make
        //public means accessible anywhere 
        //int means that it returns a value
        //this method returns the number of arrows LEFT in the quiver after each shot
        public int Shoot()
        {
            //--arrowCount first the value of the arrow count is reduced by 1 and that new updated value is return
            //the new value of arrow count is returned to the place where the Shoot method is called
            if (arrowCount <= 0)//if the value of arrow count is 0 or less, return 0 and stop
                return 0;
            return --arrowCount;
        }
        //1.add a new method called ReloadQuiver
        //2.make sure you add a button that actually reloads the quiver
        public void ReloadQuiver()
        {
            arrowCount = 10; //simply assign a new value to the arrow Count variable
        }
    }
}
