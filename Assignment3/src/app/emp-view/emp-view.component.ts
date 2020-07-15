import { Component, OnInit } from '@angular/core';
import { Employee } from '../employee';

@Component({
  selector: 'app-emp-view',
  templateUrl: './emp-view.component.html',
  styleUrls: ['./emp-view.component.css']
})
export class EmpViewComponent implements OnInit {
list:Employee[];
  constructor() {
    this.list=[
      {eid:1,ename:"Ram",desig:"Software developer",doj:new Date(2018,9,10),salary:20000},
      {eid:2,ename:"Sham",desig:"Software Tester",doj:new Date(2018,8,10),salary:30000},
      {eid:3,ename:"Kram",desig:"Software Production",doj:new Date(2018,7,10),salary:10000},
    ];
   }

  ngOnInit(): void {
  }

}
