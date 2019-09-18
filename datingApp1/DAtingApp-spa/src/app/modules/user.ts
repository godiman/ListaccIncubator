import { PathLocationStrategy } from '@angular/common';
import { Photo } from './Photo';

export interface User {
    id: number;
    username: string;
    knownAs: string;
    age: number;
    gender: string;
    created: Date;
    photoUrl: string;
    lastActive: Date;
    city: string;
    country: string;
    interests?: string;
    introduction?: string;
    lookingFor?: string;
    photos?: Photo[];
    roles: string[];
}
