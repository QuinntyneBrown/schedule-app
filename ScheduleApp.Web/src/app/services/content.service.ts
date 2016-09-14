import { Injectable } from "@angular/core";
import { Http } from "@angular/http";
import { Observable } from "rxjs";
import { extractData } from "../utilities";

import { apiCofiguration } from "../configuration";


@Injectable()
export class ContentService {
    constructor(private _http: Http) { }

    public get() {
        return this._http
            .get(`${apiCofiguration.baseUrl}/api/content/get`)
            .map(data => data.json())
            .catch(err => {
                return Observable.of(false);
            });
    }

    public getByType(options: { type: string }) {

        let uri: string;
        switch (options.type.toLocaleLowerCase()) {
            case "appshell":
                uri = `${apiCofiguration.baseUrl}/api/content/appshell`;
                break;
            case "landingpage":
                uri = `${apiCofiguration.baseUrl}/api/content/landing`;
                break;
            case "schedulepage":
                uri = `${apiCofiguration.baseUrl}/api/content/schedule`;
                break;
            case "channellistingpage":
                uri = `${apiCofiguration.baseUrl}/api/content/channellisting`;
                break;
        }

        return this._http
            .get(uri)
            .map(data => data.json())
            .catch(err => {
                return Observable.of(false);
            });
    }
    
    public get baseUrl() { return apiCofiguration.baseUrl; }

}
