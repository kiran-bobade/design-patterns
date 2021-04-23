export interface ILogger {
    debug(message: string): void;
    error(message: string): void;
    info(message: string): void;
    warn(message: string): void;
}
export class Logger implements ILogger {

    private static _instance: ILogger;

    private constructor() { }

    static getInstance() {
        if (this._instance) {
            return this._instance;
        } else {
            this._instance = new Logger();
        }
    }

    private _log(message: string, color: string) {
        console.log(`%C ${message}`, `color: ${color}; font-weight: bold`);
    }

    debug(message: string): void {
        this._log(message, 'green');
    }

    error(message: string): void {
        this._log(message, 'red');
    }

    info(message: string): void {
        this._log(message, 'blue');
    }

    warn(message: string): void {
        this._log(message, 'orange');
    }
}

export class Program {
    public main() {
        const logger: ILogger = Logger.getInstance();
        logger.debug('This is debug mesage');
        logger.error('This is error mesage');
        logger.info('This is information mesage');
        logger.warn('This is warning mesage');
    }
}