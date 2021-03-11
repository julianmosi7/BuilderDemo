using System;

var builder = new Product.Builder("AAA", "BBB")
    .OptionalC(666)
    .OptionalD("DDDDDDD");

var product = builder.Build();
//product.RequiredA = "kldjfj";

var product2 = builder.OptionalC(123).Build();

Console.WriteLine(product);
Console.WriteLine(product2);

Console.ReadKey();
