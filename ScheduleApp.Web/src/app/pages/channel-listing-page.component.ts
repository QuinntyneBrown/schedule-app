import { Component, ChangeDetectionStrategy, Input, OnInit } from "@angular/core";

@Component({
    template: require("./channel-listing-page.component.html"),
    styles: [require("./channel-listing-page.component.scss")],
    selector: "channel-listing-page",
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class ChannelListingPageComponent implements OnInit { 
    ngOnInit() {

    }
}
