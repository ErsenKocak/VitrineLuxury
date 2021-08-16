import { TimerManager } from './../../Util/timer_manager';
import { Component, OnInit, NgZone } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { TranslateService } from '@ngx-translate/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  constructor(public translate : TranslateService, public router : Router , public timerManager: TimerManager, private _ngZone : NgZone){

  }

  ngOnInit(): void {
    this.subscribeToTimer();
  }


    changelanguage(lang: string){
      console.log();
      this.translate.use(lang);
    }

    navigate(url: string){
        if(url !== null)
      this.router.navigateByUrl(url);
    }

    isLoading: boolean = true;

    subscribeToTimer(){
      this.timerManager.startTimer(500);
      this.timerManager.receivedIsFinished.subscribe(data => {
        this._ngZone.run(() => {
          if(data === false ){
            this.isLoadingChange();
          }

        });
      })
    }
  isLoadingChange(){
    this.isLoading = !this.isLoading;
  }
}
