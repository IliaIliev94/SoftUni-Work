function tickets(data, criteria) {
    class Ticket {
        constructor(destination, price, status) {
            this.destination = destination;
            this.price = price;
            this.status = status;
        }
    }
    let tickets = [];
    let parsedData = data.map(element => element.split('|'));
    parsedData.forEach((element => {
        tickets.push(new Ticket(element[0], Number(element[1]), element[2]));
    }));
    tickets.sort((a, b) => {
        if(a[criteria] < b[criteria]) {
            return -1;
        }
        else {
            return 1;
        }
    });
    return tickets;
}

tickets(['Philadelphia|94.20|available',
'New York City|95.99|available',
'New York City|95.99|sold',
'Boston|126.20|departed'],
'destination')