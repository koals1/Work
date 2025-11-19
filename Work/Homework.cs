//// 1 -----------------------------
//let a = +prompt("Перше число");
//let b = +prompt("Друге число");
//let sum = 0;
//for (let i = Math.min(a, b); i <= Math.max(a, b); i++) sum += i;
//alert("Сума діапазону: " + sum);

//// 2 -----------------------------
//let x = +prompt("Число 1");
//let y = +prompt("Число 2");
//while (y !== 0)
//{
//    let t = y;
//    y = x % y;
//    x = t;
//}
//alert("НСД: " + x);

//// 3 -----------------------------
//let n = +prompt("Число");
//let s = "";
//for (let i = 1; i <= n; i++) if (n % i === 0) s += i + " ";
//alert("Дільники: " + s);

//// 4 -----------------------------
//let k = prompt("Число");
//alert("Кількість цифр: " + k.replace("-", "").length);

//// 5 -----------------------------
//let pos = 0, neg = 0, zero = 0, even = 0, odd = 0;
//for (let i = 0; i < 10; i++)
//{
//    let v = +prompt("Число");
//    if (v > 0) pos++;
//    else if (v < 0) neg++;
//    else zero++;
//    if (v % 2 === 0) even++;
//    else odd++;
//}
//alert(
//  "Додатні: " + pos +
//  "\nВід'ємні: " + neg +
//  "\nНулі: " + zero +
//  "\nПарні: " + even +
//  "\nНепарні: " + odd
//);
