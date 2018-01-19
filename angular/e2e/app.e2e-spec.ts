import { fruitShopTemplatePage } from './app.po';

describe('fruitShop App', function() {
  let page: fruitShopTemplatePage;

  beforeEach(() => {
    page = new fruitShopTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
