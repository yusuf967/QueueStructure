// See https://aka.ms/new-console-template for more information
Queue<String> name=new Queue<string>(){};

name.Enqueue("Y");
name.Enqueue("u");
name.Enqueue("s");
name.Enqueue("u");
name.Enqueue("f");


if(name.Count>0)// kuyrukun boş olup olmadığı için  kontrolu yapılmalı yoksa InvalidOperation istisnası alır.
  Console.WriteLine(name.Dequeue());// ilk elemanı önce kaldırır sonra döndürür.


if (name.Count > 0)
    Console.WriteLine(name.Peek()); //ilk elemanı kuyruktan kaldırmadan döndürür.

bool b1 = name.Contains("u"); //kuyruğun içinde böyle bir eleman varmı diye kontrol eder.
Console.WriteLine(b1);