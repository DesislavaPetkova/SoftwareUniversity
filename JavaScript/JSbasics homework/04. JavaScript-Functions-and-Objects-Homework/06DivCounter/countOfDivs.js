// Write a JavaScript function countDivs(html) to count the number of all DIVs in given HTML fragment passed as string. Write a JS program countOfDivs.js that invokes your function and prints the output at the console.
function countOfDivs(html){
  var result = 0;
    var index = 0;
    while (html.indexOf('<div', index) != -1) {
        result++;
        index = html.indexOf('<div', index) + 1;
    }
    console.log(result);
}
countOfDivs('<!DOCTYPE html>' +
                        '<html>' +
                        '<head lang="en">' +
                            '<meta charset="UTF-8">' +
                                '<title>index</title>' +
                                '<script src="/yourScript.js" defer></script>' +
                            '</head>' +
                            '<body>' +
                                '<div id="outerDiv">' +
                                   '<div' +
                                    'class="first">' +
                                       '<div><div>hello</div></div>' +
                                    '</div>' +
                                    '<div>hi<div></div></div>' +
                                    '<div>I am a div</div>' +
                                '</div>' +
                            '</body>' +
                        '</html>');