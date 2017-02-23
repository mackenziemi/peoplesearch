"use strict";
var testing_1 = require("@angular/router/testing");
var app_component_1 = require("./app.component");
var testing_2 = require("@angular/core/testing");
var platform_browser_1 = require("@angular/platform-browser");
describe('AppComponent', function () {
    var de;
    var comp;
    var fixture;
    beforeEach(testing_2.async(function () {
        testing_2.TestBed.configureTestingModule({
            declarations: [app_component_1.AppComponent],
            imports: [testing_1.RouterTestingModule]
        })
            .compileComponents();
    }));
    beforeEach(function () {
        fixture = testing_2.TestBed.createComponent(app_component_1.AppComponent);
        comp = fixture.componentInstance;
        de = fixture.debugElement.query(platform_browser_1.By.css('h1'));
    });
    it('should create component', function () { return expect(comp).toBeDefined(); });
    it('should have expected <h1> text', function () {
        fixture.detectChanges();
        var h1 = de.nativeElement;
        expect(h1.innerText).toContain('People Search');
    });
    it('should have a navbar', function () {
        fixture.detectChanges();
        var elem = fixture.nativeElement;
        var nav = elem.querySelector('a');
        expect(nav.innerText).toContain('Search');
    });
});
//# sourceMappingURL=app.component.spec.js.map