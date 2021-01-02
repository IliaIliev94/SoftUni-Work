function heroicInventory(data) {
    data = data.map(element => element.split(" / "));
    let heroes = [];
    data.forEach(element => heroes.push(createHero(element)));
    console.log(JSON.stringify(heroes));

    function createHero(heroData) {
        let hero = {};
        hero.name = heroData[0];
        hero.level = parseFloat(heroData[1]);
        hero.items = [];
        if(heroData.length > 2) {
            let items = heroData[2].split(", ");
            for(let i = 0; i < items.length; i++) {
                hero.items.push(items[i]);
            }
        }

        return hero;
    }
}

heroicInventory(['Jake / 1000 / Gauss, HolidayGrenade'])