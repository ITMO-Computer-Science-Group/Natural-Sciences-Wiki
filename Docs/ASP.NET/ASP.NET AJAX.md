# ASP.NET AJAX

- 服务器端控件
    
    | 控件            | 描述                                                                                                 |
    |---------------|----------------------------------------------------------------------------------------------------|
    | ScriptManager | 管理客户端组件的脚本资源，局部页面的绘制，本地化和全局文件，并且可以定制用户脚本。为了使用UpdatePanel、Updateprocess、Timer控件，ScriptManager控件是必须的 |
    | UpdatePanel   | 通过异步调用来刷新部分页面而不是刷新整个页面                                                                             |
    | Updateprocess | 提供UpdatePanel控件中部分页面更新的状态信息                                                                        |
    | Timer         | 定义执行回调的时间区间。可以使用Timer控件来发送整个页面，也可以把它和UpdatePanel控件一起使用在一个时间区间以执行局部页面刷新                             |

- AJAX核心控件
    - ScriptManager控件
        - ScriptManager控件是ASP.NET AJAX控件的核心，它提供处理页面上所有ASP.NET AJAX控件的支持，没有该控件的存在，其他ASP.NET AJAX就无法工作。在页面中，ScriptManager控件只能有一个，可以在ScriptManager中指定需要的脚本库，也可以通过注册JavaScript脚本来调用Web服务
        - ScriptManager控件的主要属性
            
            | 属性                        | 描述                                                                    |
            |---------------------------|-----------------------------------------------------------------------|
            | AllowCustomError          | 和Web.config中的自定义错误配置区<customError>相联系，是否使用自定义的错误处理，默认为true            |
            | AsyncPostBackErrorMessage | 获取或设置错误信息。当在一个异步回送过程中出现未处理的服务器异常时这个错误信息会被发送到客户端                       |
            | AsyncPostBackTimeout      | 异步回送超时限制，默认值为90，单位是秒                                                  |
            | EnablePartialRendering    | 布尔值，可读写，当值为true时表示可使用UpdatePanel控件进行部分页面刷新，当值为false时不可以               |
            | ScriptMode                | 指定ScriptManager发送到客户端的脚本的模式，共有四种模式：Auto、Inheit、Debug、Release，默认值为Auto |
            | ScriptPath                | 设置所有的脚本块的根目录，作为全局属性，包括自定义脚本块或者引用第三方的脚本块                               |
            | OnAsyncPostBackError      | 异步回传发生异常时的事件，用于指定一个服务器端的处理函数，在这里可以捕获异常信息并做相应处理                        |
            | OnResolveScriptReference  | 指定ResolveScriptReference事件的服务器端处理函数，在该函数中可以修改某一条脚本的相关信息，如路径、版本等       |

        - 一个ScriptManager控件的典型定义
            <asp:ScriptManager ID="ScriptManager1" runat="server">
                <Scripts>
                    <asp:ScriptReference Path="JavaScript文件的路径" />
                    <asp:ScriptReference Path="JavaScript文件的路径" />
                    <asp:ScriptReference Assembly="JavaScript文件的路径" Name="JavaScript文件" />
                </Scripts>
                <Services>
                    <asp:ServiceReference Path="Web Service程序的路径" />
                </Services>
                <ProfileService />
                <AuthenticationService />
            </asp:ScriptManager>
            
                | 标签                    | 描述                                            |
                |-----------------------|-----------------------------------------------|
                | Scripts               | 对脚本的调用，其中可以嵌套多个ScriptReference模板以实现对多个脚本文件的调用 |
                | ProfileService        | 表示提供个性化服务的路径                                  |
                | AuthenticationService | 用来表示提供验证服务的路径                                 |

    - UpdatePanel控件：刷新指定页面区域
        - 控件属性
            
            | 属性                 | 说明                                                                                 |
            |--------------------|------------------------------------------------------------------------------------|
            | ChildrenAsTriggers | 当属性UpdateMode为Condition时，UpdatePanel中的子控件的异步传送是否引发UpdatePanel控件的更新                 |
            | RenderMode         | 表示UpdatePanel控件最终呈现的HTML元素。其中值Block表示`<div>`，Inline表示`<span>`                          |
            | UpdateMode         | 表示UpdatePanel控件的更新模式。<br /> Always：不管有没有Trigger，其他控件都将更新该UpdatePanel控件 <br />Conditional：只有当前UpdatePanel控件的ChildrenTriggers属性为true时，当前才回送，或者服务器端调用Update()方法时回送 |

        - 控件子标签
            - ContentTemplate子标签：放置ASP.NET控件，实现无刷新的更新
            - Triggers子标签：表示局部更新的触发器，包括两种触发器：
                - AsyncPostBackTrigger：异步回传触发器，指定某个控件的某个事件引发异步回传，及部分更新
                    ◊ ControlID属性：设置为外部控件的ID
                    ◊ EventName属性：设置为外部控件的事件，若未指定则设为默认值
                - PostBackTrigger：不使用异步回传触发器，指定在UpdatePanel中的某个服务器端控件，引发传统的整夜回送
    - UpdateProcess控件：显示UpdatePanel控件刷新的过程信息
        - 例子：
            <asp:UpdateProgress runat="server">
                <ProgressTemplate>
            
                </ProgressTemplate>
            </asp:UpdateProgress>
        - 属性
            - AssociatedUpdatePanelID：默认值为空字符串，获取或设置显示其UpdatePanel控件状态的ID，不与特定的UpdatePanel控件关联，因此会导致显示任何UpdatePanel的回传过程的ProcessTemplate信息
            - DisplayAfter：获取或设置显示UpdateProcess控件之前所经过的时间值（以毫秒为单位）
            - DynamicLayout：布尔值，获取或设置是否动态呈现进度模板，默认值为true
            - ProgressTemplate：获取或设置定义UpdateProgress控件内容的模板，默认值为null，必须为其定义模板，可将模板添加到子元素中
            - Visible：是否可见
    - Timer控件：定时执行
        <asp:Timer ID="Timer1" runat="server" Interval="" Enabled="" OnTick="" >
        </asp:Timer>
        - Enabled：是否定时引发回传
        - Interval：获取回传时间间隔，单位是毫秒
- AJAX Control toolkit
