//#region Legacy Customer Class
interface ILegacyCustomerData {
    firstName: string;
    lastName: string;
    phone: string;
    email: string;
    addressLine1: string;
    addressLine2: string;
    flatNo: string;
}
export class LegacyCutomer {

    get(): ILegacyCustomerData {
        return {
            firstName: 'Kiran',
            lastName: 'Bobade',
            phone: '4645895623',
            email: 'test@gmail.com',
            addressLine1: 'address line 1',
            addressLine2: 'address line 2',
            flatNo: 'E5-1156'
        }
    }
}

//#endregion

//#region New Customer Class

export interface CustomerData {
    firstName: string;
    lastName: string;
    contact: {
        email: string;
        phone: string;
    },
    address: {
        flatNo: string
        line1: string;
        line2: string;
    }
}
export class Cutomer {

    get(): ILegacyCustomerData {
        return {
            firstName: 'Kiran',
            lastName: 'Bobade',
            phone: '4645895623',
            email: 'test@gmail.com',
            addressLine1: 'address line 1',
            addressLine2: 'address line 2',
            flatNo: 'E5-1156'
        }
    }
}

//#endregion

export interface IAdapter {
    adapt(): any;
}

export class CustomerAdapter implements IAdapter {

    private _legacyCustomer: LegacyCutomer;

    constructor(legacyCustomer: LegacyCutomer) {
        this._legacyCustomer = legacyCustomer;
    }

    adapt(): CustomerData {
        const oldCustomer: ILegacyCustomerData = this._legacyCustomer.get();
        return {
            firstName: oldCustomer.firstName,
            lastName: oldCustomer.lastName,
            contact: {
                email: oldCustomer.email,
                phone: oldCustomer.phone
            },
            address: {
                flatNo: oldCustomer.flatNo,
                line1: oldCustomer.addressLine1,
                line2: oldCustomer.addressLine2
            }
        }
    }
}

export class Program {
    public main(): void {
        const adapter: IAdapter = new CustomerAdapter(new LegacyCutomer());
        const newCustomer = adapter.adapt();
        console.log('new Customer: ', newCustomer);
    }
}

new Program().main();