export class AddProduct {
  public name: string;
  public categoryId: number;

  constructor(name: string, categoryId: number) {
    this.name = name;
    this.categoryId = categoryId;
  }
}
