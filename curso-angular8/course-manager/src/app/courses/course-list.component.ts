import {Component, OnInit} from '@angular/core';
import { Course } from './course';

@Component ({
    selector: 'app-course-list',
    templateUrl: './course-list.component.html'
})

export class CourseListComponent implements OnInit{
    courses: Course[] = [];

    ngOnInit(): void {
        this.courses = [
            {
                id: 1,
                name: 'Angular1',
                imageURL: 'https://google.com',
                price: 1000,
                code: 'course1',
                duration: 10,
                rate: 5
            },
            {
                id: 2,
                name: 'Angular2',
                imageURL: 'https://google.com',
                price: 900,
                code: 'course2',
                duration: 60,
                rate: 4.5
            }
        ]
    }
}
