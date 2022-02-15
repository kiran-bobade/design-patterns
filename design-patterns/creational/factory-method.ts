export interface IVehicle {
    
    run(): void;
}

export class Bike implements IVehicle {
    run(): void {
        console.log('Regular bike is running...')
    }
}

export class SuperBike implements IVehicle {
    run(): void {
        console.log('Supper bike is running...')
    }
}

export abstract class VehicleStore {
    public getVehicle(type: string): IVehicle {
        const vehicle = this.createVehicle(type);
        return vehicle;
    }

    protected abstract createVehicle(type: string): IVehicle;
}

export class BikeStore extends VehicleStore {
    protected createVehicle(type: string): IVehicle {
        if (type === 'superbike') {
            return new SuperBike();
        }
        return new Bike();
    }
}

export class Program {
    public main() {
        const store = new BikeStore();
        const bike = store.getVehicle('superbike');
        bike.run();
    }
}

new Program().main();