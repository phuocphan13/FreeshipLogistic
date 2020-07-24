import { NgModule } from '@angular/core';
import { MycurrencyPipe } from './my-currency-pipe';
import { PhonePipe } from './number-phone-pipe';
import { TruncatePipe } from './truncate.pipe';

@NgModule({
    declarations: [
        MycurrencyPipe,
        PhonePipe,
        TruncatePipe
    ],
    providers: [
    ],
    exports: [
        MycurrencyPipe,
        PhonePipe,
        TruncatePipe
    ]
})
export class PipeModule {}
