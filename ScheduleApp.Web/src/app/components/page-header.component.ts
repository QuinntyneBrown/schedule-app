import { Component, ChangeDetectionStrategy, Input, OnInit } from "@angular/core";

@Component({
    template: require("./page-header.component.html"),
    styles: [require("./page-header.component.scss")],
    selector: "page-header",
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class PageHeaderComponent implements OnInit { }
