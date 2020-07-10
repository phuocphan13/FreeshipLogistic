import { NgModule } from '@angular/core';
import { MycurrencyPipe } from './my-currency-pipe';

@NgModule({
    declarations: [
        MycurrencyPipe
    ],
    providers: [
    ],
    exports: [
        MycurrencyPipe
    ]
})
export class PipeModule {}
