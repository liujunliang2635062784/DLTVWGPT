//test.js,JavaScript函数库，德鲁泰科技2016

/*urlSearch ?where=WHERE+xbs+%3d+%27%e7%94%b7%27+ORDER+BY+xm&xms=%e5%a4%a7%e4%b8%93%2c%e6%9c%ac%e7%a7%91%2c%e7%a1%95%e5%a3%ab%2c%e5%8d%9a%e5%a3%ab
zy 程序员 xing 张 ming 三 dz 济南      
xing 张
ming 三
dz 济南
zy 程序员*/
function testLiteralObject() {
    person = { xing: "张", ming: "三" };
    person.dz = "济南";
    person["zy"] = "程序员";
    console.log("zy", person.zy, "xing", person.xing, "ming", person["ming"], "dz", person.dz);
    for (var prop in person) {
        console.log(prop, person[prop]);
    }
}
/*where=WHERE+xbs+%3d+%27%e7%94%b7%27+ORDER+BY+xm
xms=%e5%a4%a7%e4%b8%93%2c%e6%9c%ac%e7%a7%91%2c%e7%a1%95%e5%a3%ab%2c%e5%8d%9a%e5%a3%ab*/
function testSplit() {
    var qvars = window.location.search.substr(1).split('&');
    for (var i = 0; i < qvars.length; i++) {
        console.log(qvars[i]);
    }
}