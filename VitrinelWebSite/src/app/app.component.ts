import { Component } from '@angular/core';
import {TranslateService} from '@ngx-translate/core';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
constructor(public translate: TranslateService){
translate.addLangs(['en','tr']);
translate.setDefaultLang('en');
const browserLanguage = translate.getBrowserLang();
translate.use(browserLanguage.match(/en|tr/) ? browserLanguage : 'en');

}

}
