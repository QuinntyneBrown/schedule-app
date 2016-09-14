import { Component, ChangeDetectionStrategy, Input, OnInit } from "@angular/core";

@Component({
    template: require("./schedule-page.component.html"),
    styles: [require("./schedule-page.component.scss")],
    selector: "schedule-page",
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class SchedulePageComponent implements OnInit { 
    ngOnInit() {

    }
}
