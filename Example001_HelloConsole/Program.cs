
Console.WriteLine("2Hello, World!");
//данная строка является инструкцией поэтому заканчивается обязятельно ;
//набор инструкций может объединяться в блок кода для этого блок объединяем {}

{
    Console.WriteLine("Hello, World");
    Console.WriteLine("Welcome to C#");
}
//одни блоки могут содержать другие блоки, например
{
    Console.WriteLine("First block");
    {
        Console.WriteLine("Second block");
    }
}
//язык с шарп является регистрозависимым.
//комментарии бывают однострочными например так как здесь
/*
а бывают 
многострочными
так как здесь
*/