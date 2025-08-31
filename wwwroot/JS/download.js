// wwwroot/js/download.js
export async function downloadFileFromStream(fileName, contentStreamRef) {
    const arrayBuffer = await contentStreamRef.arrayBuffer();
    const blob = new Blob([arrayBuffer], { type: "text/csv;charset=utf-8;" });
    const url = URL.createObjectURL(blob);

    const a = document.createElement("a");
    a.href = url;
    a.download = fileName;
    a.style.display = "none";
    document.body.appendChild(a);
    a.click();

    URL.revokeObjectURL(url);
    a.remove();
}
