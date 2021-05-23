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
    abcdefghijklmnopqrstuvwxyz?:;><,.'"{}()`+-*/!@$%^&|\[]
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

## 2021年5月21日

- 将创建变量和变量赋值合并
    - 以下两种方式是等价的
```Java
int a;
a = 10;

int b = 10;
```

- 用于比较的二元逻辑运算符
    - 符号
        - 大于 >
        - 小于 <
        - 等于 ==
        - 大于等于 >=
        - 小于等于 <=
        - 不等于 !=
    - 表达式的返回结果
        - 真 true
        - 假 false
    - 示例代码
    ```Java
    int num = 10;
    boolean a = 5 > 2;      // true
    boolean b = 5 < 2;      // false
    boolean c = 11 >= num;  // true
    boolean d = 10 != num;  // false
    boolean e = 3 <= num;   // true
    boolean f = 7 == 7;     // true
    boolean g = (3 > 5) == false;// true
    ```

- if 判断语句和变量的作用域
    - if 语句用于程序的分支执行
    - 单个的 if 语句
        ```Java
        boolean isNum;
        if(3 > 5){
            //如果 3 > 5 这个表达式的值是 true，则执行这个代码块里的代码
            //如果 3 > 5 这个表达式的值是 false，则不执行
        }
        ```
    - if-else 语句
        ```Java
        if(3 > 5){
            //如果 3 > 5 这个表达式的值是 true，则执行这个代码块里的代码
        }
        else {
            //如果 3 > 5 这个表达式的值是 false，则执行这个代码块里的代码
        }

        //以上语句等价于：
        if(3 > 5){
            //如果 3 > 5 这个表达式的值是 true，则执行这个代码块里的代码
        }
        if(3 <= 5){
            //如果 3 <= 5 这个表达式的值是 true，则执行这个代码块里的代码
        }
        ```
    - if-elseif-else
        ```Java
        if(3 > 5){
            //如果 3 > 5 这个表达式的值是 true，则执行这个代码块里的代码
        }
        else if(4 == 5){
            //如果 4 == 5 这个表达式的值是 true，则执行这个代码块里的代码
        }
        else{
            //如果 3 > 5 和 4 == 5 这两个个表达式的值都是 false，则执行这个代码块里的代码
        }
        ```
    - 分支的原则
        - 必须以 if 开头
        - if 后面可以跟 0 个或多个 elseif
        - else 必须在最后面，并且只能有 0 ~ 1 个 else 语句
    - 代码块
        - 我们认为 {   } 包括其之间的内容是一个代码块
        - if elseif else 语句后面的代码块，表示是 语句的表达式值为真时 要执行的一组语句
    - 变量的作用域
        - 被创建的变量只有在它的作用域中才可以被赋值或者参与运算
        - 我们现阶段认为变量的作用域是他所在的代码块

        ```Java
        public class App {        //主方法所在的类
            public static void main(String[] args) {//这里是主方法所在的代码块的开始
                int a = 10;
                {          //这里是一个奇怪的代码块的开始
                    int b = 20;
                    //在这里 a b 两个变量均可使用
                }          //这里是一个奇怪的代码块的结束

                //在这里只能使用 a 变量，b 变量只能在奇怪的代码块之间使用

                if(1 > 0){
                    int c = 10;
                }
                //无法使用 c 变量！
            }//这里是主方法所在的代码块的结束
        }
        ```

## 时间待定
- while 循环
    1. 判断 while 的表达式是否为真，若为假则终止执行
    2. 执行代码块里的代码
    3. 回到第一步

    ```Java
    num = 10;
    while(num < 13){
        num = num + 2;
        System.out.println(num);
    }
    ```
- for 循环
    - for(expr1 ; expr2 ; expr3)
        1. 首先在 for 循环前执行 expr1 的代码
        2. 判断 expr2 是否为真，若为真执行 for 的语句块，若为假则终止执行
        3. 执行 expr3
        4. 回到第二步
   
    ```Java
    for(int i = 0; i <10; i++){
        System.out.println(i*i-i+1);
    }
    ```
- while 循环与 for 循环是等价的，可以相互转化。
- 一元运算符

```Java
int num = 10;

//以下等价
num++;
++num;
num = num + 1;

//以下等价
num--;
--num;
num = num - 1;

//++num 和 num++ 的不同
int ppnum = ++num;
int numpp = num++

//以下等价
num = 0 + num;
num = + num;
num = num;

//以下等价
num = 0 - num;
num = - num;
```
- 循环控制语句
    - continue;
    - break;
- 用于逻辑运算的运算符
    - 逻辑与 &&
        - 格式： 表达式1 && 表达式2
        - 两个数都为真时，返回真

        |       | true  | false |
        |-------|-------|-------|
        | true  | true  | false |
        | false | false | false |

    - 逻辑或 ||
        - 格式：表达式1 || 表达式2
        - 两个数都不为假时，返回真

        |       | true  | false |
        |-------|-------|-------|
        | true  | true  | true  |
        | false | true  | false |

    - 逻辑非 !
        - 格式：!表达式
        - 返回一个与表达式相反的布尔值
        
        |   | true  | false |
        |---|-------|-------|
        | ! | false | true  |

    ```Java
    boolean a = true && true;
    boolean b = true || false;
    boolean c = !false
    ```
- 数组
    - 数组是把某种数据类型相同的值组合起来的一种高级形式
    - 通过以下方式创建数组：

    ```Java
    boolean[] b;
    int[] a;
    ```

    - 通过以下方式为数组赋值

    ```Java
    b = new int[3];
    int[] b = {1, 2, 3};
    int[] b = new int[3]{1, 2, 3};
    ```

    - 使用下标访问数组的元素
        - 第一个元素的下标是 0

    ```Java
    int x = b[0];
    ```

    - 获得数组的长度

    ```Java
    int x = b.length;
    ```