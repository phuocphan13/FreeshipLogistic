import { NgModule } from '@angular/core';
import { MycurrencyPipe } from './my-currency-pipe';
import { PhonePipe } from './number-phone-pipe';

@NgModule({
    declarations: [
        MycurrencyPipe,
        PhonePipe
    ],
    providers: [
    ],
    exports: [
        MycurrencyPipe,
        PhonePipe
    ]
})
export class PipeModule {}
