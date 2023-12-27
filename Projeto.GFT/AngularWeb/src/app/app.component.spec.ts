import { TestBed, ComponentFixture } from '@angular/core/testing';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

describe('AppComponent', () => {
  let component: AppComponent;
  let fixture: ComponentFixture<AppComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AppComponent],
      imports: [HttpClientModule, FormsModule]
    }).compileComponents();

    fixture = TestBed.createComponent(AppComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('Criar o app', () => {
    expect(component).toBeTruthy();
  });

  it('Limpar os resultados', () => {
    component.resultData = {
      resultadoBruto: 1000,
      resultadoLiquido: 800
    };
    component.texto1 = '1000';
    component.texto2 = '12';
    component.errorMessage = 'Alguma mensagem de erro';

    component.limparResultados();

    expect(component.resultData).toBeUndefined();
    expect(component.texto1).toBe('');
    expect(component.texto2).toBe('');
    expect(component.errorMessage).toBeUndefined();
  });


   it(`Deve localizar o titulo da pagina'`, () => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.componentInstance;
    expect(app.title).toEqual('Angular Projeto GFT');
  });

});