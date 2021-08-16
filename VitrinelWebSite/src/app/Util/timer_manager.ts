import { EventEmitter } from "@angular/core";

export class TimerManager {
  timerPolling : any;
  receivedIsFinished = new EventEmitter<boolean>();
  startTimer(totalTime: number){

    this.timerPolling = setInterval(() => {
      this.stopTimer();
      this.receivedIsFinished.emit(false);
      }, totalTime)

  }
  stopTimer(){
    clearInterval(this.timerPolling);
  }
}
