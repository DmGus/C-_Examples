int dogspeed = 5,
    man1speed = 1,
    man2speed = 2,
    distance = 20000,
    mindist = 10,
    direct = 1,
    count = 0,
    time = 0;

while (distance > mindist)
{
    if (direct == 1)
    {
        time = distance / (man1speed + dogspeed);
        direct = 2;
    }
    else
    {
        time = distance / (man2speed + dogspeed);
        direct = 1;
    }
    distance = distance - (man1speed + man2speed) * time;
    count++;
}
Console.WriteLine (count);