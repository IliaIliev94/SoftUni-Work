function solution() {
    let ingredients = {
        protein: 0,
        carbohydrate: 0,
        fat: 0,
        flavour: 0
    }
    const commands = {
        restock: (microelement, quantity) => {ingredients[microelement] += quantity; return 'Success'},
        prepare: (recipe, quantity) => {
            let requiredIngredients = {};
            if(recipe === 'apple') {
                requiredIngredients.carbohydrate = 1;
                requiredIngredients.flavour = 2;
            }
            else if(recipe === 'lemonade') {
                requiredIngredients.carbohydrate = 10;
                requiredIngredients.flavour = 20;
            }
            else if(recipe === 'burger') {
                requiredIngredients.carbohydrate = 5;
                requiredIngredients.fat = 7;
                requiredIngredients.flavour = 3;
            }
            else if(recipe === 'eggs') {
                requiredIngredients.protein = 5;
                requiredIngredients.fat = 1;
                requiredIngredients.flavour = 1;
            }
            else {
                requiredIngredients.protein = 10;
                requiredIngredients.carbohydrate = 10;
                requiredIngredients.fat = 10;
                requiredIngredients.flavour = 10;
            }
            for(let i = 0; i < quantity; i++) {
                for(let key of Object.keys(requiredIngredients)) {
                    if(requiredIngredients[key] > ingredients[key]) {
                        return `Error: not enough ${key} in stock`;
                    }
                }
            }
            for(let i = 0; i < quantity; i++) {
                Object.keys(requiredIngredients).forEach(element => ingredients[element] -= requiredIngredients[element]);
            }
            return 'Success';
        },
        report: () => `protein=${ingredients.protein} carbohydrate=${ingredients.carbohydrate} fat=${ingredients.fat} flavour=${ingredients.flavour}`
    }
    return function(arguments) {
        let data = arguments.split(' ');
        if(data[0] === 'restock') {
            return commands[data[0]](data[1], Number(data[2]));
        }
        else if(data[0] === 'prepare') {
            return commands[data[0]](data[1], Number(data[2]));
        }
        else {
            return commands[data[0]]();
        }
    }
}

let manager = solution();
console.log(manager("prepare turkey 1"));
console.log(manager("restock protein 10"));
console.log(manager("prepare turkey 1"));
console.log(manager("restock carbohydrate 10"));
console.log(manager("prepare turkey 1"));
console.log(manager("restock fat 10"));
console.log(manager("prepare turkey 1"));