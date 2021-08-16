import { TimerManager } from './../../Util/timer_manager';
import { Component, EventEmitter, NgZone, OnInit } from '@angular/core';


@Component({
  selector: 'app-about',
  templateUrl: './about.component.html',
  styleUrls: ['./about.component.scss']
})
export class AboutComponent implements OnInit {


  constructor(public timerManager: TimerManager,  private _ngZone: NgZone,) {

  }

  ngOnInit(): void {
    this.subscribeToTimer();

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
