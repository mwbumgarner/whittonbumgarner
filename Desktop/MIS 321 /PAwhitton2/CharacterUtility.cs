namespace PAwhitton2
{
    public class CharacterUtility
    {
        // get random number 
        public static double GetBonus(Character playerOne, Character playerTwo){
            double bonus;
            if(playerOne.Name == "Hamburgler" && playerTwo.Name == "Ronald McDonald"|| playerOne.Name == "Ronald McDonald" && playerTwo.Name == "FryKid" || playerOne.Name == "FryKid" && playerTwo.Name == "Hamburgler"){
                bonus = 1.2;
            }
            else{
                bonus =1;
            }
            return bonus;
        }
            
        

        

        
    }
}