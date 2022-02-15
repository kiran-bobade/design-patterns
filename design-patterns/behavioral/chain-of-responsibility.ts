export interface IMiddleware {
  handle(request: any): any;
}

export abstract class BaseMiddleware implements IMiddleware {
  protected nextHandler: any;

  abstract handle(request: any): any;

  public setNext(middleware: IMiddleware) {
    this.nextHandler = middleware;
  };
}

export class AuthenticationMiddleware extends BaseMiddleware {
  handle(request: any): any {
    console.log('AuthenticationMiddleware');
    return this.nextHandler || 'terminate response';
  }
}

export class AuthorizationMiddleware extends BaseMiddleware {
  handle(request: any): any {
    console.log('AuthorizationMiddleware');
    return this.nextHandler || 'terminate response 1';
  }
}

export class ExceptionMiddleware extends BaseMiddleware {
  handle(request: any): any {
    console.log('ExceptionMiddleware');
    return this.nextHandler || 'exception response 1';
  }
}

export class StaticFileMiddleware extends BaseMiddleware {
  handle(request: any): any {
    console.log('StaticFileMiddleware');
    return 'terminate response 2';
  }
}


export class Pipeline {
  private _middlewares: BaseMiddleware[] = [];

  use(middleware: BaseMiddleware): any {
    if (this._middlewares.length > 0) {
      const previousMiddleware = this._middlewares[this._middlewares.length - 1];
      this._middlewares.push(middleware);
      previousMiddleware.setNext(middleware);
    } else {
      this._middlewares.push(middleware);
    }
  }

  execute() {
    if (this._middlewares) {
      const request = null;
      this._handle(this._middlewares[0].handle(request), request);
    }
  }

  private _handle(response: any, request: any) {
    if (response instanceof BaseMiddleware) {
        this._handle(response.handle(request), request);
      } else {
        console.log(response);
      }
  }
}


  const pipeline = new Pipeline();
  pipeline.use(new AuthenticationMiddleware());
  pipeline.use(new AuthorizationMiddleware());
  pipeline.use(new StaticFileMiddleware());
  pipeline.execute();
