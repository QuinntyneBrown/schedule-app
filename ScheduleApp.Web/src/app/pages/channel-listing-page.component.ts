import { Component, ChangeDetectionStrategy, Input, OnInit } from "@angular/core";
import { ContentActions } from "../actions";
import { AppStore } from "../store";

@Component({
    template: require("./channel-listing-page.component.html"),
    styles: [require("./channel-listing-page.component.scss")],
    selector: "channel-listing-page",
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class ChannelListingPageComponent implements OnInit { 

    constructor(private _store: AppStore, private _contentActions: ContentActions) { }

    ngOnInit() {
        this._contentActions.getByType({ type: "channellistingpage" });
    }

    public get channelListingPageContent$() {
        return null;
    }
}
