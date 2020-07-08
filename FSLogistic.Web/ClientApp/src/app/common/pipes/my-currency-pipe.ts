import { Pipe, PipeTransform } from '@angular/core';
import { formatCurrency, getCurrencySymbol } from '@angular/common';
import { registerLocaleData } from '@angular/common';
import localeVi from '@angular/common/locales/vi';
registerLocaleData(localeVi, 'vi');

@Pipe({
    name: 'mycurrency',
  })
  export class MycurrencyPipe implements PipeTransform {
    transform(
        value: number,
        currencyCode: string = 'VND',
        display:
            | 'code'
            | 'symbol'
            | 'symbol-narrow'
            | string
            | boolean = 'symbol',
        digitsInfo: string = '3.0',
        locale: string = 'vi',
    ): string | null {
        return formatCurrency(
          value,
          locale,
          getCurrencySymbol(currencyCode, 'wide'),
          currencyCode,
          digitsInfo,
        );
    }
}