import { Component, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { MatDialog } from '@angular/material';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { ProductDto, ProductServiceProxy, ProductDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { CreateProductDialogComponent } from './create-product-dialog/create-product-dialog.component';
import { EditProductDialogComponent } from './edit-product-dialog/edit-product-dialog.component';
import { finalize } from 'rxjs/operators';

class PagedProductsRequestDto extends PagedRequestDto {
  keyword: string;
  isActive: boolean | null;
}

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css'],
  animations: [appModuleAnimation()],
    styles: [
        `
          mat-form-field {
            padding: 10px;
          }
        `
    ]
})
export class ProductsComponent extends PagedListingComponentBase<ProductDto> {
  products: ProductDto[] = [];
  keyword = '';
  isActive: boolean | null
  constructor(
    injector: Injector,
    private _productService: ProductServiceProxy,
    private _dialog: MatDialog
  ) {
      super(injector);
  }
  createProduct(): void {
    this.showCreateOrEditProductDialog();
  }

  editProduct(product: ProductDto): void {
    this.showCreateOrEditProductDialog(product.id);
  }

  protected list(
    request: PagedProductsRequestDto,
    pageNumber: number,
    finishedCallback: Function
): void {

    request.keyword = this.keyword;
    request.isActive = this.isActive;

    this._productService
        .getAll(request.keyword, request.isActive, request.skipCount, request.maxResultCount)
        .pipe(
            finalize(() => {
                finishedCallback();
            })
        )
        .subscribe((result: ProductDtoPagedResultDto) => {
            this.products = result.items;
            this.showPaging(result, pageNumber);
        });
}

protected delete(user: ProductDto): void {
    abp.message.confirm(
        this.l('ProductDeleteWarningMessage', user.productName),
        undefined,
        (result: boolean) => {
            if (result) {
                this._productService.delete(user.id).subscribe(() => {
                    abp.notify.success(this.l('SuccessfullyDeleted'));
                    this.refresh();
                });
            }
        }
    );
}

private showCreateOrEditProductDialog(id?: number): void {
    let createOrEditProductDialog;
    if (id === undefined || id <= 0) {
        createOrEditProductDialog = this._dialog.open(CreateProductDialogComponent);
    } else {
        createOrEditProductDialog = this._dialog.open(EditProductDialogComponent, {
            data: id
        });
    }

    createOrEditProductDialog.afterClosed().subscribe(result => {
        if (result) {
            this.refresh();
        }
    });
}
}
