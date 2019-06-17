$(function () {
    mini.parse();
});

$("body").keydown(function () {
    if (event.keyCode == "13") {//keyCode=13是回车键
        Login();
    }
});

function Login() {
    var username = $("#username").val();
    var password = $("#password").val();
    if (username == '' || password == '') {
        alert("请输入用户名或密码！");
    }
    $.ajax({
        url: '/Login/Login',
        type: 'post',
        dataType: 'json',
        data: { account: username, password: password},
        success: function (rs) {
            if (rs) {
                if (rs.Flag == "1") {
                    window.location.href = '/Home/Index';
                } else {
                    alert(rs.Msg);
                }
            }
        }, error (e) {
            alert(e);
        }
    });
}