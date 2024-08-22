 //Tallest Mountain
 interface Mountain {
    name: string;
    height: number;
}
const mountains: Mountain [] = [
    {name: "Kilimanjaro", height: 19341},
    {name: "Everest", height: 29029},
    {name: "Denali", height:20310 }
];

function findNameOfTallestMountain(mountains: Mountain[]): string {
    let tallestMountain = mountains[0];
    for (const mountain of mountains) {
        if (mountain.height > tallestMountain.height) {
            tallestMountain = mountain;
        }
    }
    return tallestMountain.name;
}
const tallestMountainName = findNameOfTallestMountain(mountains);

console.log(tallestMountainName);

//Products
interface Product {
    name: string;
    price: number;
}

const products: Product[] = [
    { name: "Laptop", price: 999.99 },
    { name: "Smartphone", price: 499.99 },
    { name: "Keyboard", price: 29.99 },
    { name: "Mouse", price: 19.99 }
];
function calcAverageProductPrice(products: Product[]): number {
    const totalPrice = products.reduce((sum, product) => sum + product.price, 0);
    return totalPrice / products.length;
}

console.log(`The average product price is: $${calcAverageProductPrice(products).toFixed(2)}`);

//Inventory
interface InventoryItem {
    product: Product;
    quantity: number;
}

const inventory: InventoryItem[] = [
    { product: { name: "motor", price: 10.00 }, quantity: 10 },
    { product: { name: "sensor", price: 12.50 }, quantity: 4 },
    { product: { name: "LED", price: 1.00 }, quantity: 20 }
];

function calcInventoryValue(inventory: InventoryItem[]): number {
    return inventory.reduce((total, item) => total + item.product.price * item.quantity, 0);
}

const inventoryValue = calcInventoryValue(inventory);
console.log(`The total inventory value is: $${inventoryValue.toFixed(2)}`);
