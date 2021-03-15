# ASP.NET 4.5 服务器控件

- HTML服务器控件
    + runat="server"
    + id=""
- Web服务器控件
    + 基本属性
        * 外观属性
            - BackColor：背景色，#RRGGBB
            - ForeColor：前景色，#RRGGBB
            - Border边框属性
                + BorderWidth：边框宽度
                + BorderColor：边框颜色，#RRGGBB
                + BorderStyle：边框样式，有以下取值：
                    * Notset：默认值
                    * None：没有边框
                    * Dotted：边框为虚线，点较小
                    * Dashed：边框为虚线，点较大
                    * Solid：边框为实线
                    * Double：边框为实线，但厚度是Solid的两倍
                    * Groove：在对象四周出现3D凹陷式的边框
                    * Ridge：在对象四周出现3D突起式的边框
                    * Inset：控件呈陷入状
                    * Outset：控件呈凸起状
            - Font字体属性
                + Font-Bold：如果设置为true，则会变成粗体
                + Font-Italic：如果设置为true，则会变成斜体
                + Font-Names：设置字体的名字
                + Font-Size：设置字体的大小，有九种取值：
                    * Smaller
                    * Larger
                    * XX-Small
                    * X-Small
                    * Small
                    * Medium
                    * Large
                    * X-Large
                    * XX-Large
                + Font-Strikeout：如果设置为true，则会显示删除线
                + Font-Underline：如果设置为true，则会显示下划线
        * 行为属性
            - Enabled：设置为true时，控件可用
            - ToolTip：设置控件的提示信息
            - Visible：设置控件是否可见
        * 可访问性
            - AccessKey：为控件指定快捷键，如果设置为“A”，那么按下alt+A时控件将获得焦点
            - TabIndex：设置按下Tab键后控件获得焦点的顺序
        * 布局属性
            - Height：设置高度
            - Width：设置宽度
    + 事件模型

        | 事件                         | 支持的控件                                             | 功能     |
        |------------------------------|---------------------------------------------------|--------|
        | Click                        | Button|ImageButton                                | 单击事件   |
        | TextChanged                  | TextBox                                           | 输入焦点变化 |
        | SelectedIndexChanged         | DropDownList|ListBox|CheckBoxList|RadioButtonList | 选择项变化  |

- 文本服务器控件
    + Label控件
        * Text属性：显示的内容
    + Literal控件
        * Text属性：显示的文本
        * Mode属性：设置文本的显示方式，支持以下值：
            - Transform：转换以适应请求浏览器的协议
            - PassThrough：按原样呈现在浏览器中
            - Encode：使用HtmlEncode的方法进行编码，将HTML编码转换为文本表现形式
    + TextBox控件
        * AutoPostBack属性：文本修改后是否回传回服务器，默认false不回传
        * Columns属性：获取或设置文本框的宽度（以字符为单位）
        * MaxLength属性：获取或设置文本框中最多允许的字符数
        * ReadOnly属性：获取或设定是否允许更改文本内容，true表示只读，false表示可以修改
        * TextMode属性：用于设置文本的显示模式，该属性有以下选项：

            | 选项名称        | 说明             |
            |---------------|----------------|
            | Color         | 表示颜色项模式        |
            | Date          | 表示日期输入模式       |
            | DateTime      | 表示datetime模式   |
            | DateTimeLocal | 表示本地datetime模式 |
            | Email         | 表示电子邮件模式       |
            | Month         | 表示月份项模式        |
            | MultiLine     | 表示多行输入模式       |
            | Number        | 表示数字项模式        |
            | Password      | 表示密码输入模式       |
            | Phone         | 表示电话号码项模式      |
            | Range         | 表示数值范围模式       |
            | Search        | 表示搜索字符串模式      |
            | SingleLine    | 表示单行输入模式       |
            | Time          | 表示时间输入模式       |
            | Url           | 表示URL模式        |
            | Week          | 表示输入年-周模式      |

        * Text属性：设置和读取TextBox中的文字
        * Row属性：获取或设置多行文本框中显示的行数，默认为0表示单行文本框，该属性当TextMode属性为MultiLine时才有效
        * Focus()方法：获取焦点
    + HyperLink控件
        * Text属性：设置链接文本
        * NavigateURL属性：设置URL目标
        * Target属性：设置目标链接的呈现方式，有以下四种：
            - _parent：显示在父框架中
            - _blank：在新窗口中打开
            - _self：显示在当前框架中
            - _top：显示在全窗口中
        * ImageUrl：获取或设置超链接的图像
- 按钮服务器控件
    + Button控件
        * Text属性：获取或设置文本内容
        * CommandName属性：获取或设置按钮将要触发事件的名称
        * CommandArgument属性：用于指示命令传递的参数，提供有关要执行命令的附加信息以便在事件中进行判断
        * OnClick属性：当用户单击按钮时要执行的事件处理方法
        * Command属性：单击时发生的服务器端事件
        * PostBackUrl属性：获取或设置单击Button时从当前页发送到的URL
        * OnClientClick属性：单击时发生的客户端事件，JS函数
    + LinkButton控件
        * Text属性：获取或设置文本内容
        * CommandName属性：获取或设置按钮将要触发事件的名称
        * CommandArgument属性：用于指示命令传递的参数，提供有关要执行命令的附加信息以便在事件中进行判断
        * OnClick属性：当用户单击按钮时要执行的事件处理方法
        * Command属性：单击时发生的服务器端事件
        * PostBackUrl属性：获取或设置单击Button时从当前页发送到的URL
        * OnClientClick属性：单击时发生的客户端事件，JS函数
    + ImageButton控件
        * Text属性：获取或设置文本内容
        * CommandName属性：获取或设置按钮将要触发事件的名称
        * CommandArgument属性：用于指示命令传递的参数，提供有关要执行命令的附加信息以便在事件中进行判断
        * OnClick属性：当用户单击按钮时要执行的事件处理方法
        * Command属性：单击时发生的服务器端事件
        * PostBackUrl属性：获取或设置单击Button时从当前页发送到的URL
        * OnClientClick属性：单击时发生的客户端事件，JS函数
        * ImageUrl属性：图片的URL
        * AlternateText属性：图像无法显示时替换文字
- 图像服务器控件
    + Image控件
        * ImageUrl属性：图片的URL
        * AlternateText属性：图像无法显示时替换文字
        * GenerateEmptyAlternateText属性：如果将此项设置为true，则呈现图片的alt属性
        * DescriptionUrl属性：指向该图片详细描述的页面链接
        * ImageAlign属性：控件相对于其他元素的对齐方式，有以下值：
            - Left：图像沿网页的左边缘对齐，文字在图像右边换行
            - Right：图像沿网页的右边缘对齐，文字在图像左边换行
            - BaseLine：图像的下边缘与第一行文本的下边缘对齐
            - Top：图像的上边缘与同一行上最高元素的上边缘对齐
            - Middle：图像的中间与第一行文本的下边缘对齐
            - Bottom：图像的下边缘与第一行文本的下边缘对齐
            - AbsBottom：图像的下边缘与同一行中最大元素的下边缘对齐
            - AbsMiddle：图像的中间与同一行中最大元素的中间对齐
            - TextTop：图像的上边缘与同一行上最高文本的上边缘对齐
    + ImageMap控件
        * ImageUrl属性：图片的URL
        * AlternateText属性：图像无法显示时替换文字
        * ImageAlign属性：控件相对于其他元素的对齐方式，有以下值：
            - Left：图像沿网页的左边缘对齐，文字在图像右边换行
            - Right：图像沿网页的右边缘对齐，文字在图像左边换行
            - BaseLine：图像的下边缘与第一行文本的下边缘对齐
            - Top：图像的上边缘与同一行上最高元素的上边缘对齐
            - Middle：图像的中间与第一行文本的下边缘对齐
            - Bottom：图像的下边缘与第一行文本的下边缘对齐
            - AbsBottom：图像的下边缘与同一行中最大元素的下边缘对齐
            - AbsMiddle：图像的中间与同一行中最大元素的中间对齐
            - TextTop：图像的上边缘与同一行上最高文本的上边缘对齐
        * HotSpotMode属性：获取或设置图像上热点区域的类型，对应枚举类型 System.Web.UI.WebControls.HotSpotMode，它有四个枚举值：
            - NotSet：默认值，定向到用户指定的URL地址
            - PostBack：回传操作，单击后执行后部的Click事件
            - Inactive：无任何操作
            - Navigate：定向到指定的URL地址
        * HotSpot属性：该属性对应 System.Web.UI.WebControls.HotSpot 对象集合
            - CircleHotSpot：圆形热点
            - RectangleHotSpot：矩形热点
            - PolygonHotSpot：多边形热点
        * Click事件
        * Focus()方法
- 选择服务器控件
    + RadioButton控件
        * AutoPostBack属性：获取或设定一个值，指定是否回传
        * Checked属性：获取或设定一个值，指示是否已经选中
        * GroupName属性：获取或设置单选按钮所属的组名
        * TextAlign属性：获取或设置文本标签在单选框的左边还是右边，默认为Right，可以是Left
        * Text属性：获取或设置与单选框关联的文本标签
        * CheckedChanged事件：当Checked属性值改变时发生
    + RadioButtonList控件
        * RepeatColumns属性：获取或设置要在RadioButtonList控件中显示的列数
        * RepeatDirection属性：获取或设置控件是垂直显示还是水平显示
            - Vertical：默认
            - Horizontal
        * RepeatLayout属性：获取或设置组内单选按钮的布局
        * SelectedIndex属性：获取或设置列表中选定项的最低序号索引
        * SelectedItem属性：获取列表控件中索引最小的选定项
        * SelectedValue属性：获取列表控件中的选定项的值，或选择列表控件中包含指定项的值
        * SelectedIndexChanged事件：选定项变化时发生
        * DataBinding：当服务器控件绑定到数据源时发生
        * Items集合：与列表中的每项对应，基本属性：
            - Text：每个选项的文本
            - Value：每个选项的值
            - Selected：选项的状态，True表示默认选中
    + CheckBox控件
        * AutoPostBack属性：获取或设定是否回传
        * Checked属性：获取或设置是否选中，True或False
        * Text属性：获取或设置文本标签
        * TextAlign属性：获取或设置文本标签显示在复选框的Right还是Left，默认是Right
        * CheckedChanged事件：选中状态改变时发生
    + CheckedBoxList控件
        * AutoPostBack属性：获取或设定是否回传
        * CellPadding属性：获取或设置单元格的边框和内容之间的距离
        * DataSource属性：获取或设置对象，数据绑定控件从该对象中检索其数据项列表
        * DataTextField属性：获取或设置为列表项提供文本内容的数据源字段
        * DataValueField属性：获取或设置为各列表项提供值的数据源字段
        * Items集合：与列表中的每项对应，基本属性：
            - Text：每个选项的文本
            - Value：每个选项的值
            - Selected：选项的状态，True表示默认选中
        * RepeatColumns属性：获取或设置要在CheckedBoxList控件中显示的列数
        * RepeatDirection属性：获取或设置控件是垂直显示还是水平显示
            - Vertical：默认
            - Horizontal
        * RepeatLayout属性：获取或设置组内元素的布局，是Table排列还是直接排列
        * SelectedIndex属性：获取或设置列表中选定项的最低序号索引
        * SelectedItem属性：获取列表控件中索引最小的选定项
        * SelectedValue属性：获取列表控件中的选定项的值，或选择列表控件中包含指定项的值
        * SelectedIndexChanged事件：选定项变化时发生
        * TextAlign属性：获取或设置文本标签显示在复选框的Right还是Left，默认是Right
        * Checked属性：是否选中