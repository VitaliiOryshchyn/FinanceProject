import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { MainPageComponent } from './main-page/main-page.component';

class RouteNames {
  public static HOME_PAGE = ""
}

const routes: Routes = [
  { path: RouteNames.HOME_PAGE, component: MainPageComponent, pathMatch: "full"},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

class AppRoutingModule { }

export {RouteNames, AppRoutingModule}
