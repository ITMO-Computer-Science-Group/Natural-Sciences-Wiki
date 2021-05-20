# Java

## 2021年5月20日

- Java 文件的基本结构

```Java
import java.lang.System;  //导入 java 库

public class App {        //主方法所在的类
    public static void main(String[] args) {//主方法
        //你的代码在这里开始
    }
}
```

- 代码中可能出现的所有字符
    （建议自己打一下）
    ```
    abcdefghijklmnopqrstuvwxyz?:;><,.'"{}()`+-*/!@$%^&|\
    ```
- 注释

```Java
int num;//有两种注释，这是第一种，这种注释只能出现在一行代码的末尾
int num;/*这一种注释可以出现在行的末尾，也可以分为多行，就像下面那样*/ 
/*
注释不影响程序的执行
同时，注释里的程序无法执行
*/
```
- 分号
    - 在 Java 中，每一条语句后面要跟一个分号，即 `;`
- 创建变量
    - 基本结构是：`变量类型 变量名`  
    - 我们给出两种变量类型
        - int （存储`整数`，范围是 -2^31 ~ 2^31-1）
        - boolean （存储[布尔值](https://baike.baidu.com/item/%E5%B8%83%E5%B0%94%E5%80%BC)，即 `真` 或 `假`）
    - 示例：

        ```Java
        int num;
        boolean isNum;
        ```
- 给变量赋值
    - 我们只能给已经创建的变量赋值，并且赋的值要在变量的数据类型范围中
    - 每次给变量赋值时，变量的值都会改变
    - `=` 运算符的含义是把左边表达式的值赋给右边的变量
    - 我们根据已经学的两种数据类型给他们赋值：
        
        ```Java
        num   = 10;
        isNum = true;   //此时 isNum 是 true
        isNum = false;  //此时 isNum 是 false
        num   = 10/2;   //此时 num   是 5
        ```
- 使用变量
    - 使用一个变量的前提是经历上面的`创建变量`和`给变量赋值`两步

- 二元运算符
    - 顾名思义，就是有两个值参与运算的符号，包括加减乘除和取余数
    - 这两个值可以是变量，也可以是普通的数字
    - 在运算时，先算 `乘`，`除`，`取余数`，后算 `加`，`减`，遇到同一级运算符时，从左到右依次计算

```Java
//创建变量
int a;
int b;
int c;

//给变量赋值
a = 10;
b = 3;

//运算
c = a + b;   //此时 c 是 13
c = a - b;   //此时 c 是 7
c = a * b;   //此时 c 是 30
c = a / b;   //理论上 c 是 3.33...，但是 c 是 int 类型，只能储存整数，所以 c 的值向下取整，此时 c 是 3
c = a % b;   //此时 c 是 1，为什么？因为这个符号是 a 除以 b 的余数
c = a / 5    //此时 c 是 2
c = a+a * b; //此时 c 是 40
c = a%5*3-b+a*b%5+3; //此时 c 是 0
```

- 括号
    - 运算符有计算顺序，但是括号可以强行改变运算顺序
    - 括号中的变量会优先计算

```Java
int a;
int b;
int c;

//给变量赋值
a = 10;
b = 3;

//运算
c = a%5*3-b+a*b%5+3;        //此时 c 是 0
c = a%5*(3-b+a)*b%5+3;      //此时 c 是 3
c = (a%5*3-b+a)*b%5+3;      //此时 c 是 4
c = a%5*(3-(b+a)*b)%5+3;    //此时 c 是 3
```

- 输入一个变量的值
```Java
import java.util.Scanner;//在文件的最开始导入 java.util.Scanner 这个包，才能使用后面的读取功能

public class operate{
    //...
    public static void main(String[] args) {
        //...
        Scanner sc = new Scanner(System.in);//定义扫描器 sc，记住语法即可，目前无需深究
        int a = sc.nextInt();//使用扫描器 sc 的读取整数这个功能，并且赋值给 a，这个功能也只需记住语法即可，无需深究
        //...
    }
    //...
}

```

- 输出一个变量的值

```Java
int a;
a = 10;
System.out.println(a);  //这一行很关键！
```