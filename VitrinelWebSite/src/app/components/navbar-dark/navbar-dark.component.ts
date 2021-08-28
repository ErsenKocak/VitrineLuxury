import { TranslateService } from '@ngx-translate/core';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-navbar-dark',
  templateUrl: './navbar-dark.component.html',
  styleUrls: ['./navbar-dark.component.scss']
})
export class NavbarDarkComponent implements OnInit {

  constructor(public translate: TranslateService) { }

  ngOnInit(): void {
  }


  changelanguage(lang: string){
    console.log(lang);
    this.translate.use(lang);
  }
}
