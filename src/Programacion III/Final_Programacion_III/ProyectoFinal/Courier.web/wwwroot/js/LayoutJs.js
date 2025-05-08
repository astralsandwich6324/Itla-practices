function Menu() {
    const div = document.getElementById("Midiv");
    const estilo = window.getComputedStyle(div);
    const ancho = parseFloat(estilo.width);

    const RightPanelOpen = document.getElementById("Open");
    const positionIconMenuOpen = window.getComputedStyle(RightPanelOpen);
    const changeIconMenuPositionOpen = parseFloat(positionIconMenuOpen.left);
    const OpasityOpen = parseFloat(positionIconMenuOpen.opacity)

    const LeftPanelClose = document.getElementById("Close");
    const positionIconMenuClose = window.getComputedStyle(LeftPanelClose);
    const changeIconMenuPositionClose = parseFloat(positionIconMenuClose.left);
    const OpasityClose = parseFloat(positionIconMenuClose.opacity)

    const main = document.querySelector("main");
    const sidebarHeaderH2 = document.querySelector(".h2-sidebar-header");
    const textMenu = document.querySelectorAll(".text-menu");

    const account = document.getElementById("accountspan");
    const accountDiv = document.getElementById("accountId");





    if (ancho === 200 &&
        changeIconMenuPositionOpen === 160
        && changeIconMenuPositionClose === 160
        && OpasityOpen == 1
        && OpasityClose == 0) {

        div.style.width = "60px";
        RightPanelOpen.style.left = "15px";
        LeftPanelClose.style.left = "15px";
        LeftPanelClose.style.opacity = "1";
        RightPanelOpen.style.opacity = "0";
        main.classList.remove("body-con-sidebar");
        main.classList.add("body-sin-sidebar");
        sidebarHeaderH2.innerHTML = "DD";
        sidebarHeaderH2.style.opacity = "0";
        textMenu.forEach(el => el.hidden = true);
        account.style.display = "none";
        accountDiv.style.left = "-1px";


    } else {
        div.style.width = "200px";
        RightPanelOpen.style.left = "160px";
        LeftPanelClose.style.left = "160px";
        LeftPanelClose.style.opacity = "0";
        RightPanelOpen.style.opacity = "1";
        main.classList.remove("body-sin-sidebar");
        main.classList.add("body-con-sidebar");
        sidebarHeaderH2.innerHTML = "Diario de vivencias";
        sidebarHeaderH2.style.opacity = "1";
        textMenu.forEach(el => el.hidden = false);
        account.style.display = "inline-block";
        accountDiv.style.left = "15px";
    }


    const ulAccount = document.getElementById("ulAccountId");

    if (ulAccount.hidden === false) {
        ulAccount.hidden = true;
    }
}

function login() {
    const ulAccountclick = document.getElementById("ulAccountId");

    if (ulAccountclick.hidden === true) {
        ulAccountclick.hidden = false;
    } else {
        ulAccountclick.hidden = true;
    }
}