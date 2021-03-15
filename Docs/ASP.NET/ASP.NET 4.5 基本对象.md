# ASP.NET 4.5 基本对象

- Page类
    - 在项目中所有的Web页面都继承于System.Web.UI.Page类
    - ASP.NET页面的工作流程：
        - 客户端浏览器向Web应用程序进行一个页面的请求
        - 服务器端Web应用程序收到这个请求，先查看该页面是否被编译过，如果没有则先编译这个Web页面，然后对这个页面进行实例化，产生一个Page对象
        - Page对象根据客户请求，把信息返回给IIS，然后信息由IIS返回给客户端浏览器
        - 在这个过程中，每个页面都被编译成一个类，当有请求时就对这个类进行实例化
    - 页面生命周期：
        - 页面初始化：在这个阶段，页面及其控件被初始化。页面确定是新的请求还是回传请求。页面事件处理器Page_PreInit和PageInit被调用。另外，任何服务器控件的PreInit和Init被调用
        - 载入：如果是一个回传请求，控件属性使用从视图状态和控件状态的特殊页面状态容器中恢复的信息来载入。页面的Page_Load方法以及服务器控件的Page_Load方法事件被调用
        - 回传事件处理：如果是一个回传请求，任何控件的回传事件处理器被调用
        - 呈现：在页面呈现状态中，视图状态保存到页面，然后每个控件及页面都是把自己呈现给输出响应流，页面和控件的PreRender和Render方法先后被调用。最后，呈现的结果通过HTTP响应发送回客户机
        - 卸载：对页面使用过的资源进行最后的清除处理。控件或页面的Unload方法被调用
    - Page类的重要属性和方法

        | 属性和方法                   | 说明                                           |
        |-------------------------|----------------------------------------------|
        | Application             | 为当前Web请求获取HttpApplicationState对象             |
        | IsPostBack              | 指示该页是否正为响应客户端回发而加载，或者它是否正在首次加载和访问            |
        | IsValid                 | 指示页验证是否成功                                    |
        | Request                 | 获取请求页的HttpRequest对象                          |
        | Response                | 获取与该Page对象关联的HttpResponse对象                  |
        | Server                  | 获取Server对象，它是HttpServerUtility类的实例           |
        | Session                 | 获取ASP.NET提供的当前Session对象                      |
        | Validators              | 获取请求页上包含的全部验证控件的集合                           |
        | ViewState               | 获取状态信息的字典，这些信息使用户可以在同一页的多个请求间保存和还原服务器控件的视图状态 |
        | MapPath(virtualPath)    | 将virtualPath指定的虚拟路径转换成实际路径                   |
        | ResolveUrl(relativeUrl) | 将ralativeURL指定的路径转换为在请求客户端可用的URL             |
        | DataBind()              | 将数据源连接到网页上的服务器控件                             |
        | Dispose()               | 释放资源                                         |
        | FindControl(id)         | 在页面上搜索标识名称为id的控件                             |
        | Validate()              | 执行网页上的所有验证控件                                 |
        | HasControls()           | 判断Page对象是否包含控件                               |

    - Page类的主要事件

        | 事件名称         | 说明                         |
        |--------------|----------------------------|
        | PreInit      | 在页初始化开始前发生，是网页执行时第一个被触发的事件 |
        | PreLoad      | 在信息被写入到客户端前会触发此事件          |
        | Load         | 当网页被加载时会触发此事件              |
        | Init         | 在网页初始化开始时发生，回传时不会触发        |
        | PreRender    | 在信息被写入到客户端前会触发此事件          |
        | Unload       | 网页完成处理并且信息被写入到客户端后会触发此事件   |
        | InitComplete | 在页面初始化完成时发生                |
        | LoadComplete | 在页面生命周期的加载阶段结束时发生          |

    - Page类的使用
        - protected void Page_Load(){if(!IsPostBack)}  //是否回传
        - protected void Page_Init(){}  //只触发一次
- Request对象
    - Request对象派生自HttpRequest类，用来捕获由客户端返回服务器端的数据
    - Request对象的属性和方法
        
        | 属性和方法                    | 说明                                                                          |
        |--------------------------|-----------------------------------------------------------------------------|
        | AcceptTypes              | 获取客户端支持的MIME接受类型的字符串数组                                                      |
        | ApplicationPath          | 获取服务器上ASP.NET应用程序的虚拟应用程序和路径                                                 |
        | Browser                  | 获取有关正在请求的客户端的浏览器功能的信息                                                       |
        | Cookies                  | 获取客户端发送的cookie的集合                                                           |
        | CurrentExceptionFilePath | 获取或设置输出流的HTTP字符集                                                            |
        | FilePath                 | 获取当前请求的虚拟目录                                                                 |
        | Files                    | 获取客户端上传的文件（多部件MIME格式）集合                                                     |
        | Form                     | 获取窗体变量集合                                                                    |
        | Headers                  | 获取HTTP头集合                                                                   |
        | InputStream              | 获取传入的HTTP实体主体的内容                                                            |
        | Item                     | 获取Cookie、Form、QueryString、ServerVariables集合中指定的对象。在C#中，该属性为HttpRequest类的索引器 |
        | Path                     | 获取当前请求的虚拟路径                                                                 |
        | PathInfo                 | 获取具有URL拓展名资源的附加路径信息                                                         |
        | PhysicalPath             | 获取与请求的URL相对应的物理文件系统路径                                                       |
        | QueryString              | 获取HTTP查询字符串变量集合（GET请求）                                                      |
        | RawUrl                   | 获取当前请求的原始URL                                                                |
        | ServerVariables          | 获取Wen服务器变量的集合                                                               |
        | BinaryRead               | 执行对当前输入流进行指定字节数的二进制读取                                                       |
        | MapImageCoordinates      | 将传入图像字段窗体参数映射为适当的xy坐标值                                                      |
        | MapPath                  | 为当前请求将请求的URL中的虚拟路径映射到服务器上的物理路径                                              |
        | SaveAs                   | 将HTTP请求保存到磁盘                                                                |
        | ValidateInput            | 验证由客户端浏览器提交的数据，如果存在具有潜在危险的数据，则引发一个异常                                        |
        | Url                      | 获取有关当前请求的URL的信息                                                             |

- Response对象
    - Response对象派生自HttpResponse类，用来决定何时或如何将输出由服务器端发送到客户端，它封装了Web服务器对客户端请求的响应
    - Response对象的属性
        
        | 属性                | 说明                                              |
        |-------------------|-------------------------------------------------|
        | Buffer            | 获取或设置一个值，该值指示是否缓冲输出，并在完成处理整个响应后将其发送             |
        | BufferOutput      | 获取或设置一个值，该值指示是否缓冲输出，并在完成处理整个页之后将其发送             |
        | Cache             | 获取Web页的缓存策略（过期时间、保密性、变化子句）                      |
        | CacheControl      | 将Cache-Control HTTP头设置为Public或Private           |
        | Charset           | 获取或设置输出流的HTTP字符集                                |
        | ContentEncoding   | 获取或设置实体主体的字符集                                   |
        | ContentType       | 获取或设置输出流的HTTP MIME类型                            |
        | Cookies           | 获取响应Cookie集合                                    |
        | Expires           | 获取或设置在浏览器上缓存的页过期之前的分钟数。如果用户在页过期之前返回同一页，则显示缓存的版本 |
        | ExpiresAbsolute   | 获取或设置将缓存信息从缓存中移除时的绝对日期和时间                       |
        | Filter            | 获取或设置一个包装筛选器对象，该对象用于在传输之前修改HTTP实体主体             |
        | IsClientConnected | 获取一个值，通过该值指示客户端是否仍连接在服务器上                       |
        | Output            | 启用到输出HTTP响应流的文本输出                               |
        | OutputStream      | 启用到输出HTTP内容主体的二进制输出                             |
        | RedirectLocation  | 获取或设置HTTP“位置”标头的值                               |
        | Status            | 设置返回到客户端的Status栏                                |
        | StatusCode        | 获取或设置返回给客户端的输出的HTTP状态代码                         |
        | StatusDescription | 获取或设置返回给客户端的输出的HTTP状态字符串                        |
        | SuppressContent   | 获取或设置一个值，该值指示是否将HTTP内容发送到客户端                    |

    - Response对象的方法
        - Redirect方法：将客户端重定向到新的URL，其语法定义如下所示：
            - public void Redirect(string url)
            - public void Redirect(string url, bool endResponse)
                - url：要重新定向的URL
                - endResponse：指示当前页的执行是否应终止
        - Write方法：将信息写入HTTP响应输出流，输出到客户端显示，其语法定义如下所示：
            - public void Write(char[], int, int);
            - public void Write(string)
            - public void Write(object)
            - public void Write(char)
        - WriteFile方法：将指定的文件直接写入HTTP响应输出流
            - public void WriteFile(string filename)
            - public void WriteFile(string filename, long offset, long size)
            - public void WriteFile(IntPtr fileHandle, long offset, long, size)
            - public void WriteFile(string filename, bool readIntoMemory)
                - filename：要写入的HTTP输出流的文件名
                - offset：文件将开始进行写入的字节位置
                - size：要写入的输出流的字节数，从开始位置计算
                - fileHandle：要写入HTTP输出流的文件的文件句柄
                - readIntoMemory：是否把文件写入内存块
        - BinaryWrite方法：将一个二进制字符串写入HTTP输出流
        - Clear方法：清除缓冲区流中的所有内容输出
        - ClearContent方法：清除缓冲区流中的所有内容
        - ClearHeaders方法：清除缓冲区流中的所有头信息
        - Close方法：关闭到客户端的套接字连接
        - End方法：将当前所有缓冲的输出发送到客户端，停止该页的执行，并引发Application_EndRequest事件
        - Flush方法：向客户端发送当前所有缓冲的输出。
        - Flush方法和End方法都可以将缓冲的内容发送到客户端显示，但Flush和End的不同之处在于，Flush不停止页面的执行
- ViewState对象
    - ViewState对象又称为“视图状态”，用于维护自身窗体的状态。当用户请求ASP.NET网页时，ASP.NET将ViewState封装为一个或多个隐藏的表单域传递到客户端
    - ViewState中的键值对
        - ViewState["count"] = 88;
        - int count = (int)ViewState["count"]
    - ViewState中的安全机制
        - 采用哈希编码技术，默认开启，在Web.config文件的<Pages>元素的enableViewStateMac属性中设置false使其失效
        - ViewState加密
            - 单独某一页采用加密：<%Page ViewStateEncryptionMode="Always"%>
            - 整个网站加密：Web.config: <pages viewStateEncryptionMode="Always"></pages>
    - 存储自定义对象
        - 在类定义之前加一个Serializable属性：
            - [Serializable]
            public class jack{}
        - 从ViewState中取回数据：
            - jack e;
            e = (jack)ViewState["e"]
- Server对象
    - Server对象派生自HttpServerUtility类，它提供了服务器端最基本的方法和属性。比如，获得最新的错误信息、对HTML文本进行编码和解码、访问和读写服务器端的文件等功能
    - Server对象的属性和方法

        | 方法和属性         | 说明                                               |
        |---------------|--------------------------------------------------|
        | Execute       | 在当前请求的上下文中执行指定的虚拟路径的处理程序                         |
        | GetLastError  | 返回前一个异常                                          |
        | HtmlDecode    | 对HTML编码的字符串进行解码，并将解码输出发送到System.IO.TextWriter输出流 |
        | HtmlEncode    | 对字符串进行HTML编码，并将编码输出发送到System.IO.TextWriter输出流    |
        | MapPath       | 返回与Web服务器上的指定虚拟路径相对应的物理文件路径                      |
        | Transfer      | 终止当前页的执行，并为当前请求开始执行新页                            |
        | UrlDecode     | 对字符串进行解码，该字符串为了进行HTTP传输而进行编码并在URL中发送到服务器         |
        | UrlEncode     | 编码字符串，以便通过URL从Web服务器到客户端进行可靠的HTTP传输              |
        | UrlPathEncode | 对URL字符串的路径部分进行URL编码，并返回已编码的字符串                   |
        | ScriptTimeout | 获取和设置请求超时（以秒计）                                   |
        | MachineName   | 获取服务器的计算机名称                                      |

    - Server方法的使用
        - GetLastError方法：获得前一个异常，当发生错误时可以通过该方法访问错误信息
            - Exception LastError = Server.GetLastError()
        - Transfer方法：终止当前页的执行，并为当前请求开始执行新页
            - public void Transfer(string path)
            - Public void Transfer(string path, bool preserveForm)
                - Path：服务器上要执行的新页的URL路径
                - preserveForm：默认为false，清除QueryString和Form集合。如果为true，则保存
        - MapPath方法：返回与Web服务器上的指定虚拟路径相对应的物理文件路径
            - public string MapPath(string path)
                - Path：Web服务器上的虚拟路径
                - return：与Path相对应的物理文件路径
        - HtmlEncode方法：对要在浏览器中显示的字符串进行编码
            - public string HtmlEncode(string s)
            - public void HtmlEncode(string s, TextWriter output)
        - HtmlDecode方法：对已进行HTML编码的字符串进行解码，是上一个方法的反操作
            - public string HtmlDecode(string s)
            - public void HtmlDecode(string s, TextWriter output)
        - UrlEncode方法：编码字符串，以便通过URL从Web服务器到客户端进行可靠的HTTP传输
            - public string UrlEncode(string s)
            - public void UrlEncode(string s, TextWriter output)
        - UrlDecode方法：对通过URL传输来的字符串解码，是上一个操作的逆操作
            - public string UrlDecode(string s)
            - public void UrlDecode(string s, TextWriter output)
- Cookies对象
    - Cookies对象派生自HttpCookie类。Cookie对象为Web应用程序保存用户相关信息提供了一种有效的方法。当用户访问某个站点时，该站点可以利用Cookie保存用户首选项或其他信息，这样当用户下次再访问该站点时，应用程序就可以检索以前保存的信息了
    - Cookie对象的优点
        - 可配置到期规则。Cookies可以在浏览器会话结束时到期，或者可以在客户端计算机上无限期存在，这取决于客户端的到期规则
        - 不需要任何服务器资源。Cookies存储在客户端并在发送后由服务器读取
        - 简单性。Cookies是一种基于文本的轻量结构，包含简单的键值对
        - 数据持久性。虽然客户端计算机上Cookies的持续时间取决于客户端上的Cookies过期处理和用户干预，Cookies通常是客户端上持续时间最长的数据保留形式
    - Cookies对象的属性和方法

        | 属性和方法   | 说明                                                                   |
        |---------|----------------------------------------------------------------------|
        | Expires | 获取或设置此Cookie的过期日期和时间                                                 |
        | Item    | HttpCookie.Value的快捷方式。此属性是为了与以前的ASP版本兼容而提供的。在C#中，该属性为HttpCookie类的索引器 |
        | Name    | 获取或设置Cookies的名称                                                      |
        | Path    | 获取或设置输出流的HTTP字符集                                                     |
        | Add     | 添加一个Cookies变量                                                        |
        | Clear   | 清除Cookies集合中的变量                                                      |
        | Get     | 通过索引或变量名得到Cookies变量值                                                 |
        | GetKey  | 以索引值获取Cookies变量名称                                                    |
        | Remove  | 通过Cookies变量名称来删除Cookies变量                                            |
        | Value   | 获取或设置单个Cookies值                                                      |
        | Values  | 获取在单个Cookies对象中包含的键值对的集合                                             |

    - Cookies对象的常用属性和方法
        - 先引用System.Web命名空间
        - 可以利用Response对象设置Cookies
        - 可以利用Request对象获取Cookies
        - 设置一个Cookie：
            - 创建一个System.Web.HttpCookie的实例，把信息赋予该实例，然后把它添加到当前页面的Response对象里面
            - HttpCookie cookie = new HttpCookie("Login")
            cookie.Values.Add("name", "jack")
            cookie.Expires = DateTime.Now.AddYear(1);  //设置一年的生命周期，若无则保持到浏览器关闭
            Response.Cookies.Add(cookie)
        - 取得Cookie
            - HttpCookie cookie= Request.Cookies["Login"]
            string name = cookie.Values["name"]
        - 修改Cookie
            - Response.Cookies("name").Value="tom"
            - Response.Cookies("name").Expires=DateTime.Now.AddDays(1)
        - 删除Cookie：用一个过期的Cookie来代替
            - Response.Cookies("name").Expires=DateTime.Now.AddDays(-1)
- Session对象
    - Session对象派生自HttpSessionState类，是Page类的子类，用来存储跨网页程序的变量或对象。Session对象只针对单一的用户，即各个连接的客户端有各自的Session对象变量，而不能被其他用户共享
    - Session对象的属性和方法
        
        | 属性和方法     | 说明                  |
        |-----------|---------------------|
        | Count     | 获取对话状态下Session对象的个数 |
        | TimeOut   | Session对象的生命周期      |
        | SessionID | 用于标识会话的唯一编号         |
        | Abandon   | 取消当前会话              |
        | Add       | 向当前会话状态集合中添加一个新项    |
        | Clear     | 清空当前会话状态集合中的所有键和值   |
        | Remove    | 删除会话状态集合中的项         |
        | RemoveAll | 删除所有会话状态值           |
        | RemoveAt  | 删除指定索引处的项           |

    - Session对象的事件
        - Session_OnStart事件：创建Session时触发
        - Session_OnEnd事件：Session结束时触发
        - 在Global.asax文件中为这两个事件增加处理代码
    - Session对象的存储
        - 在客户端的存储
            - 默认使用Cookie存储
            - 通过URL存储：
                - 在Web.config中的sessionState节点中把cookieless改为true
        - 在服务器端的存储
            - 存储在进程内
                - 在Web.config中的sessionState节点中的mode="InProc"表示默认存储在进程内
            - 存储在进程外
                - 控制面板—管理工具—服务—启动“ASP.NET State Service”服务
                - 在Web.config中的sessionState节点中的mode设置为StateServer
            - 存储在SQL Server中
    - Session对象的使用
        - 设置Session
            - Session["login"] = "jack"
        - 获取Session
            - string x = Session["login"]
- Application对象
    - Application对象派生自HttpApplicationState类，它可以生成一个全部的Web应用程序都能存取的状态变量，此变量是建立在服务器内存中的，可以涵盖所有使用者，用来记录整个网站的信息
    - Application对象的属性和方法
        - HttpApplicationState类是由用户在global.asax文件中定义的应用程序的基类。此类的实例Application对象是在ASP.NET基础结构中创建的，而不是由用户直接创建的。一个实例在其生存期内被用于处理多个请求，但它一次只能处理一个请求。这样，成员变量才可用于存储针对每个请求的数据。
        - Application对象有如下特点：
            - 数据可以在Application对象内部共享
            - 一个Application对象包含事件，可以触发某些Application对象脚本
            - 个别Application对象可以用Internet Service Manager来设置而获得不同属性
            - 单独的Application对象可以隔离出来再他们自己的内存中运行
            - 可以停止一个Application对象（将其所有组件从内存中驱除）而不会影响到其他应用程序
            - 一个网站可以有不止一个Application对象。典型情况下，可以针对个别任务的一些文件创建个别的Application对象。例如，可以建立一个Application对象来适用于全部共用用户，而在创建另外一个只适用于网络管理员的Application对象
            - Application对象成员在服务器运行期间持久的保存数据。Application对象成员的生命周期止于关闭IIS或使用Clear方法清除
            - 因为多个用户可以共享一个Application对象，所以必须要有Lock和Unlock方法，以确保多个用户无法同时改变某一属性
        - Application的原理是在服务器端建立一个状态变量，来存储所需的信息。要注意的是，首先，这个状态变量是建立在内存中，其次是这个状态变量是可以被网页的所有页面访问的
        - Application对象用来存储变量或对象，以便在网页再次被访问时（不管是不是同一个连接者或访问者），所存储的变量或对象的内容还可以被重新调出来使用，也就是说Application对于同一网站来说是公用的，可以在各个用户间共享。
        - 利用Application对象存取变量时需要注意以下几点
            - Application对象变量应该是经常使用的数据，如果只是偶尔使用，可以把信息存储在磁盘的文件中或数据库中
            - Application对象是一个集合对象，他除了包含文本信息外，还可以存储对象
            - 如果站点开始就有很大的通信量，则建议使用Web.config文件进行处理，不要用Application对象变量
        - 访问Application对象变量：
            - Application["key"] = value
            - string x = Application["变量名"]
            - <%=Application["key"]>  //在web页面中使用
        - 常用的属性和方法
            
            | 方法和属性     | 说明                            |
            |-----------|-------------------------------|
            | AllKeys   | 获取HttpApplicationState集合中的访问键 |
            | Count     | 获取HttpApplicationState集合中的对象数 |
            | Add       | 新加一个Application对象的变量          |
            | Clear     | 清除全部Application对象的变量          |
            | Get       | 使用索引或变量名称获取变量值                |
            | GetKey    | 使用索引获取变量名称                    |
            | Lock      | 锁定全部变量                        |
            | UnLock    | 解锁Application对象的变量            |
            | Remove    | 使用变量名删除一个Application对象的变量     |
            | RemoveAll | 删除Application对象的所有变量          |
            | Set       | 使用变量名更新Application变量的内容       |

        - Lock和Unlock
            - 如果需要修改变量，则需要先lock Application对象，防止其他用户修改，修改完之后再Unlock Application对象：
            - Application.Lock();
            Application["key"] = value;
            Application.UnLock();
        - 事件
            - Application_OnStart事件：在执行时被触发
            - Application_OnEnd事件：在结束时被触发
            - 在Global.asax文件中对这两个事件进行处理
