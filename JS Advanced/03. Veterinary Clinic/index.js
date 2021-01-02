class VeterinaryClinic {
    constructor(clinicName, capacity) {
        this.clinicName = clinicName;
        this.capacity = capacity;
        this.clients = [];
        this.totalProfit = 0;
        this.currentCapacity = 0;
    }
    newCustomer(ownerName, petName, kind, procedure) {
        let ownerExists = this.clients.find(owner => owner.ownerName === ownerName);
        if(this.currentCapacity + 1 > this.capacity) {
            throw 'Sorry we are not able to accept more patients!';
        }
        else if(ownerExists !== undefined && ownerExists.pets.find(pet => pet.petName === petName) !== undefined && ownerExists.pets.find(pet => pet.petName === petName).procedures.length > 0) {
            throw `This pet is already registered under ${ownerName} name! ${petName} is on our lists, waiting for ${ownerExists.pets.find(pet => pet.petName === petName).procedures.join(', ')}`;
        }
        if(ownerExists === undefined) {
            this.clients.push({ownerName: ownerName, pets: []});
        }
        ownerExists = this.clients.find(owner => owner.ownerName === ownerName);
        ownerExists.pets.push({petName: petName, kind: kind, procedures: procedure});
        this.currentCapacity++;
        return `Welcome ${petName}!`;
    }
    onLeaving(ownerName, petName) {
        let ownerExists = this.clients.find(client => client.ownerName === ownerName);
        if(ownerExists === undefined) {
            throw `Sorry there is no such client!`;
        }
        else if(ownerExists.pets.find(pet => pet.petName === petName) !== undefined && ownerExists.pets.find(pet => pet.petName === petName).procedures.length < 1) {
            throw `Sorry there are no procedures for ${petName}!`;
        }
        ownerExists.pets.find(pet => pet.petName === petName).procedures.forEach(procedure => {
            this.totalProfit += 500;
        });
        ownerExists.pets.find(pet => pet.petName === petName).procedures = [];
        this.currentCapacity--;
        return `Goodbye ${petName}. Stay safe!`;
    }
    toString() {
        let print = ``;
        let totalProcedure = 0;

        this.clients.forEach(client => {
            client.pets.forEach(pet => {
                if(pet.procedures.length > 0) {
                    totalProcedure++;
                }
            });
        });
        print+= `${this.clinicName} is ${Math.floor(totalProcedure / this.capacity * 100)}% busy today!\n`;
        print+= `Total profit: ${this.totalProfit.toFixed(2)}$\n`;
        this.clients.sort((a, b) => a.ownerName.localeCompare(b.ownerName));
        this.clients.forEach(owner => {
            owner.pets.sort((a, b) => a.petName.localeCompare(b.petName));
        });
        this.clients.forEach(owner => {
            print+= `${owner.ownerName} with:\n`;
            owner.pets.forEach(pet => {
                print+= `---${pet.petName} - a ${pet.kind.toLowerCase()} that needs: ${pet.procedures.join(', ')}\n`;
            });
            print.trimEnd();
        });
        print = print.substr(0, print.length - 1);
        return print;
    }
}
let clinic = new VeterinaryClinic('SoftCare', 10);
console.log(clinic.newCustomer('Jim Jones', 'Tom', 'Cat', ['A154B', '2C32B', '12CDB']));
console.log(clinic.newCustomer('Anna Morgan', 'Max', 'Dog', ['SK456', 'DFG45', 'KS456']));
console.log(clinic.newCustomer('Jim Jones', 'Tiny', 'Cat', ['A154B']));
console.log(clinic.onLeaving('Jim Jones', 'Tiny'));
console.log(clinic.toString());
clinic.newCustomer('Jim Jones', 'Sara', 'Dog', ['A154B']);
console.log(clinic.toString());
