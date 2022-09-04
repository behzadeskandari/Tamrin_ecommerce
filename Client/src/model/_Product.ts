interface Product{
  description: string;
  id: number;
  name: string;
  pictureUrl: string;
  price: number;
  productBrand: {
    id: number;
    name: string;
  },
  productBrandId: number;
  productType: {
    id: number;
    name: string;
  }
  productTypeId: number;
}
