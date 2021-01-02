function attachEventsListeners() {
    console.log('TODO:...');
    const convertBtn = document.getElementById("convert");
    convertBtn.addEventListener("click", function () {
       const valueToConvert = Number(document.getElementById("inputDistance").value);
       const distanceMeasurement = document.getElementById("inputUnits").value;
       let valueMeters;
       switch(distanceMeasurement) {
           case "km":
               valueMeters = valueToConvert * 1000;
               break;
           case "m":
               valueMeters = valueToConvert;
               break;
           case "cm":
               valueMeters = valueToConvert / 100;
               break;
           case "mm":
               valueMeters = valueToConvert / 1000;
               break;
           case "mi":
               valueMeters = valueToConvert * 1609.34;
               break;
           case "yrd":
               valueMeters = valueToConvert * 0.9144;
               break;
           case "ft":
               valueMeters = valueToConvert * 0.3048;
               break;
           case "in":
               valueMeters = valueToConvert * 0.0254;
       }
       const convertedDistance = document.getElementById("outputUnits").value;
       let convertedValue;
       switch(convertedDistance) {
           case "km":
               convertedValue = valueMeters / 1000;
               break;
           case "m":
               convertedValue = valueMeters;
               break;
           case "cm":
               convertedValue = valueMeters * 100;
               break;
           case "mm":
               convertedValue = valueMeters * 1000;
               break;
           case "mi":
               convertedValue = valueMeters / 1609.34;
               break;
           case "yrd":
               convertedValue = valueMeters / 0.9144;
               break;
           case "ft":
               convertedValue = valueMeters / 0.3048;
               break;
           case "in":
               convertedValue = valueMeters / 0.0254;
       }
       document.getElementById("outputDistance").value = convertedValue;
    });
}