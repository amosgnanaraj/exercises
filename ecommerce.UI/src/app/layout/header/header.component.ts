import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from "../../../environments/environment";

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  constructor(private client: HttpClient) { }

  ngOnInit(): void {
  }

  searchInput: string;
  result: string[];
  searchOutput: string;
  isResult = false;
  url = environment.apiurl;


  OnSearch(){
    this.result = [];
    this.searchOutput = "";
    this.isResult = false;
    if(this.searchInput!=undefined && this.searchInput!=null && this.searchInput.length>0){
      this.client.get(this.url + "Search/GetKeywords?input="+this.searchInput).subscribe((x:any[])=>{
        if(x!=undefined&&x!=null&&x.length>0)
        {
          x.forEach((y:any)=>{
            this.result.push(y.keyword);
            this.searchOutput+=y.keyword + "\n";
            
          });
          // alert(this.searchOutput);
          this.isResult = true;
        }
      });
    }    

  }

}
