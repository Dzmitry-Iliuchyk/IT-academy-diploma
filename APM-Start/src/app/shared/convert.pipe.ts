import { Pipe, PipeTransform } from "@angular/core";


@Pipe({
    name : "ConvertToStar"
})
export class ConvertPipe implements PipeTransform{
    transform(value: string, char:string):string {
        value = value.replace(char,'*');
        console.log("replaced :"+char+"on *");
        return value;
    }
}