int count = 0;
int distance = 1000;
int FirstFriendSpeed = 1;
int SecondFriendSpeed = 2;
int DogSpeed =5;

while (distance > 10)
{
    if (FirstFriendSpeed == 1);
    {
        Time = distance / (FirstFriendSpeed + DogSpeed);
        Friend = 2;
    

    else
        
        Time = distance / (SecondFriendSpeed + DogSpeed);
        Friend = 1;
    }

    distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * Time;
    Console.WriteLine(count);
    count++;
}