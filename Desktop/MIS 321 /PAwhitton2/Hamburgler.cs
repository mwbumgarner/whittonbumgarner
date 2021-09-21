using System; 

namespace PAwhitton2
{
    public class Hamburgler :Character
    {
        
        public Hamburgler(){
            Name = "Hamburgler";
            ThrowBehavior = new HamburgerThrow();
        }

        
        
    }
}