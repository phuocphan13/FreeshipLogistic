import { NgModule } from '@angular/core';
import { PipeModule } from './pipes/pipe.module';

@NgModule({
  declarations: [
  ],
  providers: [
    PipeModule,
  ],
  exports: [
    PipeModule,
  ]
})
export class AppCommonModule {}