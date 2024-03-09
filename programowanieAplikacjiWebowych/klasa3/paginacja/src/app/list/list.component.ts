import { Component, OnInit } from '@angular/core';
import { DataService } from '../data.service';
@Component({
	selector: 'app-list',
	templateUrl: './list.component.html',
	styleUrls: ['./list.component.css']
})
export class ListComponent implements OnInit {

	items: any;
	page: number = 1;
	searchText = '';
	itemsNames: string[] = [];
	selectedItem?: any;

	constructor(private dataService: DataService) { }

	ngOnInit(): void {
		this.dataService.getData().subscribe(data => {
			this.items = data;

			for(let i = 0; i < this.items.length; i++)
			{
				this.itemsNames[i] = this.items[i].car_model;
			}
		});
	}

	showDetails(itemName: string)
	{
		this.items.forEach((item: any) => {
			if (item.car_model == itemName)
			{
				this.selectedItem = item;
			}
		});
	}

}
