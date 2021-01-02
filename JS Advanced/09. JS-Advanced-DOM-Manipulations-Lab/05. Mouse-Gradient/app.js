function attachGradientEvents() {
    console.log('TODO:...');
    let gradient = document.getElementById("gradient");
    gradient.addEventListener("mousemove", function (event) {
        let percent =  Math.floor(event.offsetX / gradient.clientWidth * 100);
        document.getElementById("result").textContent = `${percent}%`;
    });
}