const { Builder, Browser, By, Key, until } = require('selenium-webdriver')

const fs = require('fs');
const path = require('path');


async function tomarCaptura(driver, nombre) {
    const image = await driver.takeScreenshot();
    const ruta = path.join(__dirname, 'screenshots');
    if (!fs.existsSync(ruta)) fs.mkdirSync(ruta);
    fs.writeFileSync(path.join(ruta, `${nombre}.png`), image, 'base64');
}


describe("Login", () => {
    it('Login with standar_user credentials', async () => {
        let driver = new Builder().forBrowser(Browser.EDGE).build();

        //‼️‼️‼️‼️‼️‼️‼️‼️‼️‼️‼️⚠️⚠️⚠️⚠️
        //Una vez que se haga dotnet run, colocar la direccion aqui, si es la misma dejar asi, si no
        //reemplazar http://localhost:5178/ por la direccion de su ordenador y listo.
        //lo mismo si en vez de hacer dotnet un corre la solucion en visual studio


        //await tomarCaptura(driver, '01-pagina-principal');

        async function accepAlert() {
            await driver.wait(until.alertIsPresent(), 5000);
            let alert = await driver.switchTo().alert();
            await alert.accept();
        }


        await driver.get('http://localhost:5178/')
        await driver.sleep(3000);

        //Se redirige a login
        await driver.findElement(By.id('username')).sendKeys('jose');
        await driver.findElement(By.id('password')).sendKeys('1234');
        await driver.findElement(By.id('botoniniciar')).click();
        await driver.sleep(2000);
        accepAlert();
        await driver.sleep(5000);
        //Pagina prealerta

        //primer registro 1

        await driver.findElement(By.id('crearpre_alerta')).click();
        await driver.sleep(5000);
        await driver.findElement(By.id('transportista')).sendKeys('USPS');
        await driver.findElement(By.id('tracking')).sendKeys('00088844562452');
        //await driver.findElement(By.id('entrega_estimada')).sendKeys('2025-04-25');
        await driver.executeScript(`
            document.getElementById('entrega_estimada').value = '2025-04-25';
        `);
        await driver.findElement(By.id('proveedor')).sendKeys('Amazon');
        await driver.findElement(By.id('valor')).sendKeys('120');
        await driver.findElement(By.id('contenido')).sendKeys('Ropa deportiva');

        //boton de guardar los datos en le formulario


        await driver.findElement(By.id('guardar_form')).click();
        await driver.sleep(3000);
        accepAlert();
        await driver.sleep(2000);
        await driver.findElement(By.id('cancelar_boton')).click();
        await driver.sleep(2000);
        await driver.findElement(By.id('no45456')).click();
        await driver.sleep(2000);
        await driver.findElement(By.id('cancelar_boton')).click();
        await driver.sleep(2000);
        await driver.findElement(By.id('si45456')).click();
        await driver.sleep(5000);

        //Editar Registro
        const botonesEditar = await driver.findElements(By.css('.btn.btn-warning'));
        await botonesEditar[botonesEditar.length - 1].click();
        //await driver.findElement(By.id(`boton_editar_${3}`)).click();
        await driver.sleep(6000);
        await driver.findElement(By.id('transportista')).clear();
        await driver.findElement(By.id('transportista')).sendKeys('UPS');

        await driver.findElement(By.id('proveedor')).clear();
        await driver.findElement(By.id('proveedor')).sendKeys('Aliexpress');
        await driver.findElement(By.id('guardar_form')).click();
        await driver.sleep(3000);
        accepAlert();
        await driver.sleep(3000);
        //y cuando se guarda el formulario
        await driver.findElement(By.id('cancelar_boton')).click();
        await driver.sleep(2000);
        await driver.findElement(By.id('si45456')).click();
        await driver.sleep(6000);
        //crear devuevo

        //segundo registro 2

        await driver.findElement(By.id('crearpre_alerta')).click();
        await driver.sleep(5000);
        await driver.findElement(By.id('transportista')).sendKeys('UPS');
        await driver.findElement(By.id('tracking')).sendKeys('008578541545');
        //await driver.findElement(By.id('entrega_estimada')).sendKeys('2025-04-22');
        await driver.executeScript(`
            document.getElementById('entrega_estimada').value = '2025-04-22';
        `);
        await driver.findElement(By.id('proveedor')).sendKeys('Ebay');
        await driver.findElement(By.id('valor')).sendKeys('800');
        await driver.findElement(By.id('contenido')).sendKeys('Iphone 16');
        await driver.findElement(By.id('guardar_form')).click();
        await driver.sleep(2000);
        accepAlert();
        await driver.sleep(3000);
        await driver.findElement(By.id('cancelar_boton')).click();
        await driver.sleep(2000);
        await driver.findElement(By.id('si45456')).click();
        await driver.sleep(5000);
        //Borrar

        //tercer registro 3

        await driver.findElement(By.id('crearpre_alerta')).click();
        await driver.sleep(5000);
        await driver.findElement(By.id('transportista')).sendKeys('Otros');
        await driver.findElement(By.id('tracking')).sendKeys('989786545343');
        // await driver.findElement(By.id('entrega_estimada')).sendKeys('2025-04-19');
        await driver.executeScript(`
            document.getElementById('entrega_estimada').value = '2025-04-19';
        `);
        await driver.findElement(By.id('proveedor')).sendKeys('Temu');
        await driver.findElement(By.id('valor')).sendKeys('100');
        await driver.findElement(By.id('contenido')).sendKeys('Mouse');
        await driver.findElement(By.id('guardar_form')).click();
        await driver.sleep(2000);
        accepAlert();
        await driver.sleep(3000);
        await driver.findElement(By.id('cancelar_boton')).click();
        await driver.sleep(2000);
        await driver.findElement(By.id('si45456')).click();
        await driver.sleep(5000);


        const botonesBorrar = await driver.findElements(By.css('.btn.btn-danger'));
        await botonesBorrar[botonesEditar.length - 1].click();
        //await driver.findElement(By.id(`boton_eliminar_${5}`)).click();
        await driver.sleep(2000);





        /*await driver.findElement(By.id('crearcuenta')).click();
        await driver.sleep(4000);
        await driver.findElement(By.id('username')).sendKeys('kelyn');
        await driver.findElement(By.id('mail')).sendKeys('ktejada@itla.edu.do');
        await driver.findElement(By.id('password')).sendKeys('1234');
        await driver.sleep(3000);
        await driver.findElement(By.id('botoncrearcuenta')).click();
        //await driver.sleep(3000);
        await driver.wait(until.alertIsPresent(), 5000);
        let alert = await driver.switchTo().alert();
        await alert.accept();
        await driver.sleep(6000);*/

        await driver.quit();



    });
});
