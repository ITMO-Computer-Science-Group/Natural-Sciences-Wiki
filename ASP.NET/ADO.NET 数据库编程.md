# ADO.NET 数据库编程

- ADO.NET 数据提供程序

    | 数据提供程序             | 描述                                                                     |
    |--------------------|------------------------------------------------------------------------|
    | SQL Server 的数据提供程序 | 提供对 Microsoft SQL Server 7.0 或更高版本中的数据的访问，并使用System.Data.SqlClient命名空间 |
    | Oracle的数据提供程序      | 提供程序支持Oracle客户端软件8.1.7或更高版本中数据的访问，并使用System.Data.OracleClient命名空间      |
    | OLE DB的数据提供程序      | 提供对使用OLE DB公开的数据源中数据的访问，并使用 System.Data.OleDb命名空间                      |
    | ODBC的数据提供程序        | 提供对使用ODBC公开的数据源中数据的访问，并使用System.Data.Odbc命名空间                          |

- 数据提供程序的核心对象

    | 对象名称        | 描述                                                                                     |
    |-------------|----------------------------------------------------------------------------------------|
    | Connection  | 提供与数据源的连接                                                                              |
    | Command     | 用于返回数据、修改数据、运行存储过程以及发送或检索参数信息的数据库命令                                                    |
    | DataReader  | 从数据源中提供高性能的数据流                                                                         |
    | DataAdapter | 提供连接DataSet对象和数据源的桥梁，使用Command对象在数据源中执行SQL命令，以便将数据加载到DataSet中，并使对DataSet中数据的更改与数据源保持一致 |

- ADO.NET基本类库
    - 基于连接的对象
        - 他们是数据提供对象，如Connection、Command、DataReader和DataAdapter
        - 他们连接到数据库，执行特定的SQL语句和存储过程，遍历结果集或者填充数据集（DataSet）
        - 这类对象主要是针对具体数据源类型的，可以在数据提供程序指定的命名空间中找到
    - 基于内容的对象
        - 他们属于非连接的、断开的，主要包括DataSet、DataColumn、DataRow、DataRelation等。
        - 他们完全和数据源独立，可以在System.Data命名空间中找到他们
    - ADO.NET常用命名空间
        
        | 命名空间                     | 描述                                                                                                      |
        |--------------------------|---------------------------------------------------------------------------------------------------------|
        | System.Data              | 该命名空间提供对表示ADO.NET结构的类的访问                                                                                |
        | System.Data.Common       | 该命名空间包含由各种.NET数据提供器共享的类                                                                                 |
        | System.Data.OleDb        | 该命名空间用于OLE DB的.NET数据提供器                                                                                 |
        | System.Data.SqlClient    | 该命名空间用于SQL Server的.NET数据提供器                                                                             |
        | System.Data.SqlTypes     | 该命名空间为SQL Server 2005中的本机数据类型提供类，这些类为.NET公共语言运行库所提供的数据类型提供了一种更为安全和快速的替代项。使用此命名空间中的类有助于防止出现精度损失造成的类型转换错误 |
        | System.Data.OracleClient | 该命名空间用于Oracle的.NET数据提供器                                                                                 |
        | System.Data.Odbc         | 该命名空间用于ODBC的.NET数据提供器                                                                                   |

    - ADO.NET的对象：数据库连接、查询数据、插入数据、更新数据、删除数据
        - Connection对象
            - Connection对象用于建立和特定数据库的连接，所有Connection对象的基类都是DbConnection类
            - 连接字符串
                - 在ADO.NET中，无论连接什么数据源，总要先创建一个数据源的连接对象，即Connection对象。
                - 创建Connection对象时，必须需要提供一个连接字符串
                - 连接字符串的结构很简单，无论由什么数据提供程序，都需要在连接字符串中提供以下基本信息，这些基本信息使用分号;隔开
                    - 服务器地址（Data Source 或者 server）：服务器地址标识数据库服务器的地址，其值可以是IP地址、计算机名称、localhost。localhost通常用于数据库服务器和ASP.NET应用程序位于同一台计算机之上，也可以使用“Data Source =.”来代替“Data Source = localhost”
                    - 数据库名称（Initial Catalog 或者 database）：数据库名称标识ASP.NET应用程序所使用的数据库名称
                    - 如何通过数据库验证：在使用SQL Server或者Oracle数据提供程序时，可以选择提供验证身份或者以当前用户身份登录。一般情况下选择以当前用户身份登录，因为这样不需要在代码或配置文件中输入密码。各种数据提供程序的Windows身份验证语法：
                        
                        | 数据提供程序       | 语法                                                       |
                        |--------------|----------------------------------------------------------|
                        | SqlClient    | Integrated Security = true 或者 Integrated Security = SSPI |
                        | OleDb        | Integrated Security = SSPI                               |
                        |              | 如果将 Integrated Security = true 用于OleDb数据提供程序时会引发异常       |
                        | Odbc         | Trusted_Connection = yes                                 |
                        | OracleClient | Integrated Security = yes                                |

            - 连接字符串配置文件
                - 在Web.config文件中<connectionString>节点保存连接字符串
                    - <connectionStrings>
                        <add name="ConnectionString" ConnectionString="your code">
                    </conectionStrings>
                - 通过ConfigurationManager（属于System.Configuration命名空间）或者WebConfigurationManager（属于System.Web.Configuration命名空间）读取这些连接字符串
                    - string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString
                    - string connectionString = WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString
            - 打开与关闭连接：晚打开早释放
                - 使用Open方法打开连接
                - 使用Close方法或Dispose方法显式关闭连接
        - Command对象
            - Command对象主要可以用来对数据库发出一些命令，比如对数据库下达查询、更新、删除数据等命令，以及调用存在于数据库中的预存的程序等
            - Command对象是架构于Connection对象之上的，所以Command对象是通过连接到数据源的Connection对象来下达命令的。
            - 常用的SELECT、INSERT、UPDATE、DELETE等SQL命令都可以在Command对象中创建
            - 根据不同的数据源，Command对象可以分为4类
                - SqlCommand：用于对SQL Server数据库执行命令
                - OleDBCommand：用于对支持OleDB的数据库执行命令
                - OdbcCommand：用于支持Odbc的数据库执行命令
                - OracleCommand：用于对Oracle数据库执行命令
            - SqlCommand对象常用属性
                
                | 属性                     | 说明                               |
                |------------------------|----------------------------------|
                | CommandText            | 类型为string，命令对象包含的SQL语句、存储过程或表    |
                | CommandTimeOut         | 类型为int，终止执行命令并生成错误之前的等待时间        |
                | CommandType            | 类型为枚举类型，有三个值，默认是Text：  <br />Text值表示采用SQL语句      <br />StoredProcedure值表示使用存储过程              <br />TableDirect值表示要读取的表      |
                | Connection             | 获取SqlConnection实例，使用该对象对数据库通信    |
                | SqlParameterCollection | 提供给命令的参数                         |

            - SqlCommand对象的常用方法
                
                | 方法               | 说明                                                      |
                |------------------|---------------------------------------------------------|
                | Cancel           | 类型为void，取消命令的执行                                         |
                | CreateParameter  | 创建SqlParameter对象的实例                                     |
                | ExecuteNonQuery  | 类型为int，执行不返回结果的SQL语句，包括INSERT、UPDATE、DELETE以及不返回结果的存储过程 |
                | ExecuteReader    | 类型为SqlDataReader，执行SELECT等返回结果的SQL语句或有返回结果的存储过程         |
                | ExecuteScalar    | 类型为Object，执行返回单个值的SQL语句，例如Count(*) Sum() Avg等聚合函数       |
                | ExecuteXmlReader | 类型为XmlReader，执行返回Xml语句的SELECT语句                         |
                
            - 可以使用构造函数生成SqlCommand对象，也可以使用SqlConnection对象的CreateCommand()函数生成。SqlCommand的构造函数如下：
                
                | 构造函数                                                                    | 说明                               |
                |-------------------------------------------------------------------------|----------------------------------|
                | SqlCommand()                                                            | 不用参数创建SqlCommand对象               |
                | SqlCommand(string CommandText)                                          | 根据SQL语句创建SqlCommand对象            |
                | SqlCommand(string CommandText, SqlConnection conn)                      | 根据SQL语句和数据源连接创建SqlCommand对象      |
                | SqlCommand(string CommandText, SqlConnection conn, SqlTransaction tran) | 根据SQL语句、数据源连接、事务对象创建SqlCommand对象 |

            - 创建SqlCommand对象的两种方式
                - 创建一个Command对象、指定SQL命令、并设置可以利用的数据库连接
                    - SqlCommand myCommand = new SqlCommand();
                    myCommand.CommandText = "your SQL"
                    myCommand.Connection = connection
                - 创建Command对象时直接指定SQL命令和数据库连接
                    - SqlCommand myCommand = new SqlCommand("your SQL", connection)
        - DataReader对象
            - DataReader对象的作用是从数据库中检索只读、只进的数据流。所谓只读，是指在数据阅读器DataReader上不可更新、删除、增加记录。所谓只进，是指在记录的接收是顺序进行且不可后退的
            - 数据阅读器DataReader接收到的数据是以数据库的记录为单位的查询结果在查询执行时返回，并存储在客户端的网络缓冲区中，直到用户使用DataReader的Read方法对他们发出请求
            - 使用DataReader可以提高应用程序的性能，原因是他只要数据可用就立即检索数据，并且默认情况下一次只在内存中存储一行，减少了系统开销。
            - 根据不同的数据源，可以分成四类：
                - SqlDataReader：用于对SQL Server数据库读取行的只进流的方式
                - OleDBDataReader：用于对支持OleDB的数据库读取行的只进流的方式
                - OdbcDataReader：用于对支持Odbc的数据库读取行的只进流的方式
                - OracleDataReader：用于对支持Oracle的数据库读取行的只进流的方式
            - SqlDataReader对象的常用属性
                
                | 属性            | 说明                                  |
                |---------------|-------------------------------------|
                | HasMoreResult | 表示是否有多个结果                           |
                | FieldCount    | 获取当前行中的列数                           |
                | HasRows       | 获取一个值，该值指示SqlDataReader是否包含一行或多行    |
                | IsClosed      | 检索一个布尔值，该值指示是否已关闭指定的SqlDataReader实例 |
                | Item          | 获取以本机格式表示的列的值                       |
                | Connection    | 获取与SqlDataReader关联的SqlConnection    |

            - SqlDataReader的常用方法
                
                | 方法              | 说明                                          |
                |-----------------|---------------------------------------------|
                | Close           | 关闭SqlDataReader对象                           |
                | GetDataTypeName | 获取源数据类型的名称                                  |
                | GetName         | 获取指定列的名称                                    |
                | GetSqlValue     | 获取一个表示基础SqlDbType变量的Object                  |
                | GetSqlValues    | 获取当前行中的所有属性列                                |
                | IsDBNull        | 以重写。获取一个值，该值指示列中是否包含不存在或已丢失的值               |
                | NextResult      | 以重写。当读取批处理Transact-SQL语句的结果时，使数据读取器前进到下一个结果 |
                | Read            | 以重写。使SqlDataReader前进到下一条记录                  |

            - 在创建完Command对象的一个实例后，用户可以通过对命令调用ExecuteReader方法来创建DataReader，该方法从Command对象中指定的数据源检索一些行，这时DataReader就会被来自数据库的记录所填充
                - SqlDataReader sdr = CommandName.ExecuteReader();
            - 使用下标显示当前行的某列数据
        - DataSet对象
            - DataSet对象是支持ADO.NET的断开式、分布式数据方案的核心对象
            - DataSet对象从数据源中获取数据以后就断开了与数据库的连接。允许在DataSet对象中定义数据约束和表关系，增加、删除和编辑记录，还可以对DataSet中的数据进行查询、统计等。还可以把DataSet中的数据送回数据源
            - 创建DataSet
                - DataSet dataSet = new DataSet();
                - DataSet dataSet = new DataSet("table name")
            - DataSet对象常用的属性
                
                | 属性                 | 说明                                                      |
                |--------------------|---------------------------------------------------------|
                | CaseSensitive      | 获取或设置一个值，该值指示DataTable对象中的字符串比较是否区分大小写                  |
                | DataSetName        | 获取或设置当前DataSet的名称                                       |
                | DefaultViewManager | 获取DataSet所包含数据的自定义视图，以允许使用自定义的DataViewManager进行筛选、搜索和导航 |
                | EnforceConstraints | 获取或设置一个值，该值指示在尝试执行任何更新操作时是否遵循约束规则                       |
                | ExtendedProperties | 获取与DataSet相关的自定义用户信息的集合                                 |
                | HasErrors          | 获取一个值，指示在此DataSet中的任何DataTable对象是否存在错误                  |
                | Prefix             | 获取或设置一个XML前缀，该前缀是DataSet的命名空间的别名                        |
                | Relations          | 获取用于将表链接起来并允许从父表浏览的子表的关系的集合                             |
                | Tables             | 获取包含在DataSet中的表的集合                                      |

            - DataSet对象常用的方法
                
                | 方法             | 说明                                                         |
                |----------------|------------------------------------------------------------|
                | Clear          | 通过移除所有表中的所有行来清除任何数据的DataSet                                |
                | Copy           | 复制该DataSet的结构和数据                                           |
                | GetXml         | 返回存储在DataSet中数据的XML表示形式                                    |
                | HasChanges     | 获取一个值，该值指示DataSet是否有更改，包括新增行、已删除的行或已修改的行                   |
                | Merge          | 将指定的DataSet、DataTable或DataRow对象的数组合并到当前的DataSet或DataTable中 |
                | ReadXml        | 将XML架构和数据读入DataSet                                         |
                | ReadXmlSchema  | 将XML架构读入DataSet                                            |
                | WriteXml       | 从DataSet写XML数据，还可以选择写架构                                    |
                | WriteXmlSchema | 写XML架构形式的DataSet结构                                         |

            - DataSet对象中经常使用的对象包括DataTable、DataRow、DataColumn、DataRelation
                - DataTable对象
                    - DataTable对象用于表示内存中的数据库表，可以独立的创建和使用，也可以由其他对象创建和使用。通常情况下，DataTable对象都作为DataSet对象的成员存在，一个DataSet对象可以包含多个DataTable。每个DataTable包含多个行（DataRow）和列（DataColumn）。可以通过DataSet对象的Table属性来访问DataSet对象中的DataTable对象
                    - DataTable对象的常用属性
                        
                        | 属性                 | 说明                                     |
                        |--------------------|----------------------------------------|
                        | CaseSensitive      | 获取或设置一个值，该值指示DataTable对象中得字符串比较是否区分大小写 |
                        | ChildRelations     | 获取此DataTable的子关系的集合                    |
                        | Columns            | 获取属于该表列的集合                             |
                        | Constraints        | 获取或设置一个值，该值指示获取由该表维护的约束的集合             |
                        | DataSet            | 获取此表所属的DataSet                         |
                        | DefaultView        | 获取可能包括筛选视图或游标位置的表的自定义视图                |
                        | DisplayExpression  | 获取或设置一个XML前缀，该前缀是DataSet命名空间的别名        |
                        | ExtendedProperties | 获取自定义用户信息的集合                           |
                        | HasErrors          | 获取一个值，该值指示该表所属的DataSet的任何表的任何行中是否有错误   |
                        | ParentRelations    | 获取该DataTable的父关系的集合                    |
                        | PrimaryKey         | 获取或设置充当数据表主键的列的数组                      |
                        | Rows               | 获取属于该表的行的集合                            |
                        | TableName          | 获取或设置DataTable的名称                      |

                    - DataTable对象的常用方法
                        
                        | 方法             | 说明                                      |
                        |----------------|-----------------------------------------|
                        | Clear          | 清除所有数据的DataTable                        |
                        | Computer       | 计算用来传递筛选条件的当前行上的给定表达式                   |
                        | Copy           | 复制该DataTable的结构和数据                      |
                        | ImportRow      | 将DataRow复制到DataTable中，保留任何属性设置以及初始值和当前值 |
                        | LoadDataRow    | 查找和更新特定行。如果找不到任何匹配行，则使用给定值创建新行          |
                        | Merge          | 将指定的DataTable与当前的DataTable合并            |
                        | NewRow         | 创建于该表具有相同架构的新DataRow                    |
                        | ReadXml        | 将XML架构和数据读入DataTable                    |
                        | Select         | 获取DataRow对象的数组                          |
                        | WriteXml       | 将DataTable的当前内容以Xml格式写入                 |
                        | WriteXmlSchema | 将DataTable的当前数据结构以Xml架构形式写入             |

                    - 将DataTable对象添加到DataSet中的方法
                        ◊ 通过DataTable类的构造函数来创建
                            } DataTable table = new DataTable("数据表名")
                        ◊ 将DataTable对象添加到DataSet对象的Tables集合中去
                            } DataSet myset = new DataSet();
                            myset.Tables.Add(table)
                        ◊ 从DataSet中提取DataTable
                            } DataTable table = myset.数据表名
                - DataRow对象
                    - DataRow对象表示数据表里的行，是给定DataTable中的一行数据，或者说是一条记录
                    - DataRow对象的常用属性和方法
                        
                        | 属性和方法        | 说明                  |
                        |--------------|---------------------|
                        | Item         | 获取或设置存储在指定列中的数据     |
                        | ItemArray    | 通过一个数组来获取或设置此行的所有值  |
                        | Table        | 获取该行拥有其架构的DataTable |
                        | GetChildRows | 获取DataRow的子行        |
                        | IsNull       | 判断该行是否包含一个null值     |
                        | Delete       | 清除所有数据的DataTable    |

                    - 为表添加新行，即创建DataRow对象，可以调用DataTable对象的NewRow方法来实现，创建的DataRow对象与表具有相同的结构。之后，使用Add方法可以将新的DataRow对象添加到表的DataRow对象集合中：
                        DataTable table = new DataTable("yourTable");
                        DataRow row = table.NewRow();
                        row["id"] = "1";
                        table.Rows.Add(row)
                - DataColumn对象
                    - DataColumn对象表示数据表里的列，是给定DataTable中的一列数据，每个DataColumn对象都有一个DataType属性，定义了数据表中该行的数据类型
                    - DataColumn常用的属性和方法
                        
                        | 属性和方法        | 说明                                     |
                        |--------------|----------------------------------------|
                        | AllowDBNull  | 获取或设置一个值，该值指示DataTable对象中的字符串比较是否区分大小写 |
                        | Caption      | 获取此DataTable的子关系的集合                    |
                        | ColumnName   | 获取属于该表的列的集合                            |
                        | DefaultValue | 获取或设置一个值，该值指示获取由该表维护的约束的集合             |
                        | Table        | 获取此表所属的DataSet                         |
                        | SetOrdinal   | 将DataColumn的序号或位置更改为指定的序号或位置           |

                    - 要添加一个列，就需要创建一个DataColumn对象
                        ◊ 通过调用DataTable的Columns属性的Add方法实现在DataTable内创建DataColumn对象。通常，Add方法带有两个参数，分别是列名（ColumnName）和列的数据类型（DataType）
                            } DataTable dt = new DataTable(news)
                            dt.Columns.Add(new DataColumns("ID", typeof(string)))
                - DataRelation对象
                    - DataRelation对象通过DataColumn对象将两个DataTable对象相互关联，表示他们之间具有约束关系
                    - DataRelation的常用属性
                        
                        | 属性                  | 说明                                               |
                        |---|---|---|---|---|---|---------------------|--------------------------------------------------|
                        | ChildColumns        | 获取此关系的子DataColumn对象                              |
                        | ChildKeyConstraint  | 获取关系的外键约束                                        |
                        | ChildTable          | 获取此关系的子表                                         |
                        | DataSet             | 获取DataRelation所属的DataSet                         |
                        | ExtendedProperties  | 获取存储自定义属性的集合                                     |
                        | ParentColumns       | 获取作为此DataRelation的父列的DataColumn对象的数组             |
                        | ParentKeyConstraint | 获取聚集约束，他确保DataRelation的父列中的值是唯一的                 |
                        | ParentTable         | 获取此DataRelation的父级DataTable                      |
                        | RelationName        | 获取或设置用于从DataRelationCollection中检索DataRelation的名称 |

                    - 在创建DataRelation时，他首先验证是否可以建立关系。在将它添加到DataRelationCollection之后，通过禁止会使关系无效的任何更改来维持此关系。在创建DataRelation和将其添加到DataRelationCollection之间的这段时间，可以对父行或子行进行其他更改，如果这样会使关系不再有效，则会生成异常
                    - 建立表之间关系的示例代码：
                        DataColumn parent = DataSet1.Tables["Customers"].Columns["CustID"]
                        DataColumn child = DataSet1.Tables["Orders"].Columns["CustID"]
                        DataRelation roc = new DataRelation("CustomersOrders",parent,child)
                        DataSet1.Relations.Add(roc)
        - DataAdapter对象
            - DataAdapter对象充当数据库和ADO.NET对象模型中非连接对象之间的桥梁，能够用来保存和检索数据
            - DataAdapter对象类的Fill方法用于将查询结果引入DataSet或DataTable中，以便能够脱机处理数据
            - 有四类不同数据源的DataAdapter对象：
                - SqlDataAdapter：用于对SQL Server数据库执行命令
                - OleDBDataAdapter：用于对支持OleDB的数据库执行命令
                - OdbcDataAdapter：用于支持Odbc的数据库执行命令
                - OracleDataAdapter：用于对Oracle数据库执行命令
            - SqlDataAdapter对象的常用属性
                
                | 属性            | 说明                   |
                |---------------|----------------------|
                | SelectCommand | 从数据源中检索记录            |
                | InsertCommand | 从DataSet中把插入的记录写入数据源 |
                | UpdateCommand | 从DataSet中把修改的记录写入数据源 |
                | DeleteCommand | 从数据源中删除记录            |

            - SqlDataAdapter对象的常用方法

                | 方法                                      | 说明                                                       |
                |-----------------------------------------|----------------------------------------------------------|
                | Fill(DataSet dataSet)                   | 类型为int，通过添加或更新DataSet中的行填充一个DataTable对象。返回值是成功添加或更新的行的数量 |
                | Fill(DataSet dataSet, string dataTable) | 根据dataTable名填充DataSet                                    |
                | Update(DataSet dataSet)                 | 类型为int，更新DataSet中指定行的所有已修改行，返回成功更新的行的数量                  |

            - 可以使用SqlDataAdapter的构造函数生成对象
                
                | 构造函数                                                        | 说明                                                |
                |-------------------------------------------------------------|---------------------------------------------------|
                | SqlDataAdapter()                                            | 不用参数创建SqlDataAdapter对象                            |
                | SqlDataAdapter(SqlCommand cmd)                              | 根据SqlCommand语句创建SqlDataAdapter对象                  |
                | SqlDataAdapter(String SqlCommandText, SqlConnection conn)   | 根据SqlCommand语句和数据库连接源创建SqlDataAdapter对象           |
                | SqlDataAdapter(string SqlCommandText, string SqlConnection) | 根据SqlCommand语句和SqlConnection字符串创建SqlDataAdapter对象 |

            - 使用SqlDataAdapter的具体步骤如下所示：
                - 创建对象
                    - SqlDataAdapter sda = new SqlDataAdapter()
                - 把Command对象定义的操作赋给以上定义的对象sda
                    - sda.SelectCommand = "your SQL"
                - 将数据填入数据集DataSet
                    - sda.Fill(dataset, "tb_News")
