const sidebar = document.getElementById('sidebar');
const sidebarToggle = document.getElementById('sidebarToggle');

function checkWindowSize() {
    if (window.innerWidth < 768) {
        sidebar.classList.add('collapse');
    }
    else {
        sidebar.classList.remove('collapse');
    }
}

sidebarToggle.addEventListener('click', function () {
    sidebar.classList.toggle('collapse');
});

checkWindowSize();

window.addEventListener('resize', checkWindowSize);