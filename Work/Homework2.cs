// 1 --------------------------------

function compare(a, b)
{
    if (a < b) return -1;
    if (a > b) return 1;
    return 0;
}

// 2 --------------------------------
function factorial(n)
{
    let r = 1;
    for (let i = 1; i <= n; i++) r *= i;
    return r;
}

// 3 --------------------------------
function makeNumber(a, b, c)
{
    return +(`${ a}${ b}${ c}`);
}

// 4 --------------------------------
function area(a, b)
{
    return b === undefined ? a * a : a * b;
}

// 5 --------------------------------
function isPerfect(n)
{
    let s = 0;
    for (let i = 1; i < n; i++) if (n % i === 0) s += i;
    return s === n;
}
