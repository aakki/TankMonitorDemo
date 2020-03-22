import { TankMonitorDemoTemplatePage } from './app.po';

describe('TankMonitorDemo App', function() {
  let page: TankMonitorDemoTemplatePage;

  beforeEach(() => {
    page = new TankMonitorDemoTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
