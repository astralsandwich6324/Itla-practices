window.GenerarPDF = async () => {

    var pdf = new jsPDF();
    pdf.text(30, 30, 'Hello world!, Hello Blazor wasm');
    pdf.save('hello_world.pdf');