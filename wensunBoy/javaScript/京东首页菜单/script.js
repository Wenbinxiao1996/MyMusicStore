//id传入口的控件id,mode变换的属性值
function change(id,mode){
    document.getElementById(id).style.display=mode;
    
    if(mode=='block'){
        document.getElementById(id).style.border='1px solid #eee';
        document.getElementById(id).style.borderTop='none';
    //设置下拉菜单的边框
    
    //设置鼠标滑过li的效果
    document.getElementById(id).parentNode.style.backgroundColor='fff';
    document.getElementById(id).parentNode.style.border='1ox solid #eee';
    document.getElementById(id).parentNode.style.borderBottom='none';
}
else{
    //不显示下拉菜单的时候 鼠标划过li的效果
    document.getElementById(id).parentNode.style.backgroundColor='';
    document.getElementById(id).parentNode.style.border='';
}
}