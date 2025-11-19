// 1---------------------

using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System;

let shoppingList = [
  { name: "Хліб", qty: 1, bought: false },
  { name: "Молоко", qty: 2, bought: true },
  { name: "Яйця", qty: 10, bought: false }
];

function showList()
{
    for (let i = 0; i < shoppingList.length; i++)
    {
        if (!shoppingList[i].bought) console.log(shoppingList[i]);
    }
    for (let i = 0; i < shoppingList.length; i++)
    {
        if (shoppingList[i].bought) console.log(shoppingList[i]);
    }
}

function addItem(name, qty)
{
    let found = false;
    for (let i = 0; i < shoppingList.length; i++)
    {
        if (shoppingList[i].name === name)
        {
            shoppingList[i].qty += qty;
            found = true;
            break;
        }
    }
    if (!found) shoppingList.push({ name: name, qty: qty, bought: false });
}

function buyItem(name)
{
    for (let i = 0; i < shoppingList.length; i++)
    {
        if (shoppingList[i].name === name)
        {
            shoppingList[i].bought = true;
            break;
        }
    }
}

// 2---------------------

let receipt = [
  { name: "Хліб", qty: 1, price: 20 },
  { name: "Молоко", qty: 2, price: 35 },
  { name: "Сир", qty: 1, price: 90 }
];

function showReceipt()
{
    for (let i = 0; i < receipt.length; i++)
    {
        console.log(receipt[i].name, receipt[i].qty, receipt[i].price);
    }
}

function totalSum()
{
    let sum = 0;
    for (let i = 0; i < receipt.length; i++)
    {
        sum += receipt[i].qty * receipt[i].price;
    }
    return sum;
}

function mostExpensive()
{
    let max = receipt[0];
    for (let i = 1; i < receipt.length; i++)
    {
        if (receipt[i].price * receipt[i].qty > max.price * max.qty)
        {
            max = receipt[i];
        }
    }
    return max;
}

function averageItemCost()
{
    let totalItems = 0;
    for (let i = 0; i < receipt.length; i++)
    {
        totalItems += receipt[i].qty;
    }
    return totalSum() / totalItems;
}
