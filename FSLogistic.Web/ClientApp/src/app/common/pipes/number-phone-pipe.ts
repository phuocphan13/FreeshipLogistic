import { Pipe } from "@angular/core";

@Pipe({
    name: "phone"
})
export class PhonePipe {
    transform(rawNum) {
        rawNum = rawNum.charAt(0) != 0 ? "0" + rawNum : "" + rawNum;

        let newStr = "";
        let i = 0;

        for (; i < Math.floor(rawNum.length / 3) - 1; i++) {
            newStr = newStr + rawNum.substr(i * 3, 3) + " ";
        }

        return newStr + rawNum.substr(i * 3);
    }
}