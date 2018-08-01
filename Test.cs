// Written by Mohanad Abu-Nayla
// Twitter: @mohanad_qaa
// License: Just do not remove my name from the code and it is all yours! 
// No warrnty of any kind ;) use it on your own!
// 01-Aug-2018


using UnityEngine;

public class Test : MonoBehaviour
{
    private void Awake()
    {
        bool isPrime = true;

        int number = 167;

        if(number >= 3)
        {
            for( int i = 3; i<= number; i+=2)
            {
                if(number != i)
                {
                    if(number % i == 0)
                    {
                        print("Number: " + number + " is NOT a prime number! It is devisable by: " + i);
                        isPrime = false;
                        break;
                    }
                }
            }

            if(isPrime == true)
            {
                print("Number: " + number + " is a PRIME number!");
            }
        }
        else
        {
            if(number == 2)
            {
                print("Number: " + number + " is a PRIME number!");
            }
        }
    }

}
