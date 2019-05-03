 imports localpackage;
imports System;

main()
{
	let arr be { 100, -1, 5, 75, 92, 12, 115, -96};
	let arr be new int[];
	let str be new string();

	str = "The Smallest is: {0}";

	let n be arr.Lenght();
	let biggest be arr.first(); // way of getting the first element
	let smallest be arr[0]; // way of getting the first element

	for index = 0 to n - 1 repeat
	{
		if(biggest < arr[index+1])
		{
			biggest = arr[index + 1];
		}
		else if(smallest > arr[index + 1])
			smallest = arr[index + 1];
	}
	
	println(str, smallest);
	println("Bigest: {0}", biggest);
	print("{0} + {1} = {2}\n", smallest, biggest, smallest + biggest);	

}

// program that takes an array of ints and prints 
// The biggest and smallest numbers
// and print their sum.