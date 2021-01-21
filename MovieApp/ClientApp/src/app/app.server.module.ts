import { NgModule } from '@angular/core';
import { ServerModule } from '@angular/platform-server';
import { ModuleMapLoaderModule } from '@nguniversal/module-map-ngfactory-loader';
import { AdminModule } from './admin/admin.module';
import { AppComponent } from './app.component';
import { AppModule } from './app.module';
import { AuthenticationModule } from './authentication/authentication.module';

@NgModule({
  imports: [AppModule, ServerModule, ModuleMapLoaderModule, AuthenticationModule, AdminModule],
  bootstrap: [AppComponent]
})
export class AppServerModule { }
