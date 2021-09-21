
using System.Collections.Generic;
using System;
using System.IO;


namespace PAwhitton2
{
    public class Character
    {
        public string Name{get;set;}
        public string FoodThrown{get;set;}
        public double Health{get;set;}
        public IThrow ThrowBehavior{get;set;}
        public int MaxPower{get;set;}
        public double DefensivePower{get;set;}
        public double ThrowPower{get;set;}

        public Character() {
            MaxPower = new Random().Next(1, 100);
            Health = 100;
            ThrowPower = new Random().Next(1, MaxPower);
            DefensivePower = new Random().Next(1, MaxPower);
            ThrowBehavior = new FryThrow();
        }

       

        public void SetThrowBehavior (IThrow x){
            ThrowBehavior =x;

        }
        //public void SetMaxandDefensivePower( ){
            //Random rand = new Random();
            //int MaxPower = rand.Next(0, 100);
            //int DefensivePower= rand.Next(0,MaxPower);      
        //}
             

        public void SetName(string x){
            Name =x;
        }

        
    }
}