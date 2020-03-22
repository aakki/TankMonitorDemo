import { Component, OnInit, Optional, Injector, Inject } from '@angular/core';
import {
  MAT_DIALOG_DATA,
  MatDialogRef,
  MatCheckboxChange
} from '@angular/material';
import { AppComponentBase } from '@shared/app-component-base';
import { ProductDto, ProductServiceProxy, RoleDto, CreateProductDto } from '@shared/service-proxies/service-proxies';
import { finalize } from 'rxjs/operators';
import * as _ from 'lodash';

@Component({
  selector: 'app-edit-product-dialog',
  templateUrl: './edit-product-dialog.component.html',
  styleUrls: ['./edit-product-dialog.component.css']
})
export class EditProductDialogComponent extends AppComponentBase implements OnInit {
  saving = false;
  product: ProductDto = new ProductDto();
  roles: RoleDto[] = [];
  checkedRolesMap: { [key: string]: boolean } = {};

  constructor(injector: Injector,
    public _productService: ProductServiceProxy,
    private _dialogRef: MatDialogRef<EditProductDialogComponent>,
    @Optional() @Inject(MAT_DIALOG_DATA) private _id: number
  ) {
    super(injector);
  }

  ngOnInit() {
    this._productService.get(this._id).subscribe(result => {
      this.product = result;
    });
  }

  save(): void {
    this.saving = true;

    this._productService
      .update(this.product)
      .pipe(
        finalize(() => {
          this.saving = false;
        })
      )
      .subscribe(() => {
        this.notify.info(this.l('SavedSuccessfully'));
        this.close(true);
      });
  }

  close(result: any): void {
    this._dialogRef.close(result);
  }
}
