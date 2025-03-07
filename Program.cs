// task1 
// int n = int.Parse(System.Console.ReadLine());
// if (n < 100) {
//     System.Console.WriteLine(n + (n * 5 / 100));
// }
// else if (n > 100 && n < 200){
//     System.Console.WriteLine(n + (n * 7 / 100));
// }
// else if (n > 200){
//     System.Console.WriteLine(n + (n * 10 / 100));
// }
// task2
// int n = int.Parse(System.Console.ReadLine());
// int[] arr = new int[n];
// int sum = 1;
// for (int i = 0; i < n; i++){
//     arr[i] = int.Parse(System.Console.ReadLine());
// }
// for (int i = 0; i < n - 1; i++){
//     sum *= arr[i];
//     System.Console.Write(arr[i] + "*");
// }
// sum *= arr[n -1];
// System.Console.WriteLine(arr[n -1] + "=" + sum);

//task3
// int n = int.Parse(System.Console.ReadLine());
// int[] arr = new int[n];
// int mx = -999999;
// for (int i = 0; i < n; i++){
//     arr[i] = int.Parse(System.Console.ReadLine());
// }
// for (int i = 0; i < n; i++){
//     if (i > mx) mx = i;
// }
//   System.Console.WriteLine(mx);

//task4 
// int n;
// n = int.Parse(System.Console.ReadLine());
// int[] arr = new int[n];
// int cnt = 0;
// for (int i = 0; i < n; i++){
//     arr[i] = int.Parse(System.Console.ReadLine());
// }
// for (int i = 0; i < n; i++){
//     for (int j = i + 1; j < n; j++){
//         if (arr[i] != arr[j]){
//             cnt++;
//         }
//     }
// }
// System.Console.Write(cnt);

//task5
// int n = int.Parse(System.Console.ReadLine());
// int[] arr = new int[n];
// int mn = 999999;
// for (int i = 0; i < n; i++){
//     arr[i] = int.Parse(System.Console.ReadLine());
// }
// for (int i = 0; i < n; i++){
//     if (i < mn) mn = i;
// }
//   System.Console.WriteLine(mn);

// task 6
// int n = int.Parse(System.Console.ReadLine());
// int[] arr = new int[n];
// int cnt = 0;
// for (int i = 0; i < n; i++){
//     arr[i] = int.Parse(System.Console.ReadLine());
// }
// for (int i = 0; i < n - 1; i++){
//     if (arr[i - 1] < arr[i] && arr[i] < arr[i + 1]){
//         cnt++;
//     }
// }
// System.Console.WriteLine(cnt);

//task 8
// int n = int.Parse(System.Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++){
//     arr[i] = int.Parse(System.Console.ReadLine());
// }
// for (int i = 0; i < n; i++){
//     if (arr[i] % 2 != 0)
//     System.Console.WriteLine(i + " ");
// }
//task10
// int n = int.Parse(System.Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++){
//     arr[i] = int.Parse(System.Console.ReadLine());
// }
// for (int i = 0; i < n; i++){
//     if (arr[i] % 2 != 0){
//         System.Console.WriteLine(arr[i] * arr[i] + " ");
//     }
// }