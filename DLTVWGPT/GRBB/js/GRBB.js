
//Grid++ Report的辅助JavaScrpt函数
//分解网址中的查询串变量，将其转换为对象的属性/值対方式
//where WHERExbs='男'ORDERBYxm
//xms 大专,本科,硕士,博士
    function getQVarObj()
    {
        var p,qVarObj = {};
        var qvars = window.location.search.substr(1).split('&');
        for (var i = 0; i < qvars.length; i++)
        {
            p = qvars[i].split('=');
            qVarObj[p[0]] = decodeURIComponent(p[1].replace(/\+/g,""));
        }
        return qVarObj;
    }