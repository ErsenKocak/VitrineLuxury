import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { TranslateService } from '@ngx-translate/core';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent implements OnInit {


  constructor(public translate : TranslateService){

  }

  ngOnInit(): void {
  }

    changelanguage(lang: string){
      console.log();
      this.translate.use(lang);
    }


}
