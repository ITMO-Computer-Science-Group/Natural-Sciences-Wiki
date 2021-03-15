# XML数据管理

- XML，eXtensible Markup Language，可拓展标记语言
- XML语法
    - XML的声明
        - <?xml version="1.0" encoding="GB2312"?>
        - 属性列表
            
            | 属性         | 常用值    | 说明                                                     |
            |------------|--------|--------------------------------------------------------|
            | Version    | 1.0    | 声明中必须包括此属性，而且必须放在第一位。它指定了文档所采用的XML版本号，现在XML的最新版本为1.0版本 |
            | Encoding   | GB2312 | 简体中文                                                   |
            |            | BIG5   | 繁体中文                                                   |
            |            | UTF-8  | 压缩的Unicode编码                                           |
            |            | UTF-16 | UCS编码                                                  |
            | Standalone | yes    | 文档是独立文档，没有DTD文档与之配套                                    |
            |            | no     | 表示可能有DTD文档为本文档进行位置声明                                   |

    - 处理指令PI
        - <? 处理指令名 处理指令信息?>
    - XML元素
        - <标记>内容</标记>
- DTD，Document Type Definition，文档类型定义
    - 向别人或XML的语法分析器解释XML文档标记集中每一个标记的含义
    - DTD必须包含所有将使用的词汇列表
- XSL，eXtensible Stylesheet Language，可拓展样式语言
- 操作XML数据
    - DOM概述
        - 命名空间
            - System.Xml
            - System.Xml.XmlDocument
        - 基础类
            - XmlNode类：表示文档树中的单个节点，它描述了XML文档中各种具体节点类型的共性，它是一个抽象类，在拓展类层次中有它的具体实现
            - XmlNodeList类：表示一个节点的有序集合，它提供了对迭代操作和索引器的支持
            - XmlNamedNodeMap类：表示一个节点的集合，该集合中的元素可以使用节点名或索引来访问，支持了使用节点名称和迭代器来对属性集合的访问，并且包含了对命名空间的支持
        - 拓展类：从XmlNode类派生出来的类
            
            | 类                      | 说明                                    |
            |------------------------|---------------------------------------|
            | XmlAttribute           | 表示一个属性。此属性的有效值和默认值在DTD或架构中进行定义        |
            | XmlAttributeCollection | 表示属性集合，这些属性的有效值和默认值在DTD或架构中进行定义       |
            | XmlComment             | 表示XML文档中的注释内容                         |
            | XmlDocument            | 表示XML文档                               |
            | XmlDocumentType        | 表示XML文档的DOCTYPE声明节点                   |
            | XmlElement             | 表示一个元素                                |
            | XmlEntity              | 表示XML文档中一个解析过或未解析过的实体                 |
            | XmlEntityReference     | 表示一个实体的引用                             |
            | XmlLinkedNode          | 获取靠近该节点（之前或之后）的节点                     |
            | XmlReader              | 表示提供对XML数据进行快速、非缓存、只进访问的读取器           |
            | XmlText                | 表示元素或属性的文本内容                          |
            | XmlTextReader          | 表示提供对XML数据进行快速、非缓存、只进访问的读取器           |
            | XmlTextWriter          | 表示提供快速、非缓存、只进方法的编写器，该方法生成包含XML数据的流或文件 |
            | XmlWriter              | 表示提供快速、非缓存、只进方法的编写器，该方法生成包含XML数据的流或文件 |

        - 创建XML文档
            - 创建不带参数的XmlDocument
                - XmlDocument doc = new XmlDocument()
            - 创建一个XmlDocument，并将XmlNameTable作为参数传递给它
                - XmlDocument doc = new XmlDocument(XmlNameTable)
        - 保存XML文档
            - XmlDocument doc = new XmlDocument()
            doc.Save(Server.MapPath("XML.xml"))
            
                | 方法                      | 说明                  |
                |-------------------------|---------------------|
                | Save(string filename)   | 将文档保存到文件filename的位置 |
                | Save(Stream outStream)  | 保存到流outStream中      |
                | Save(TextWriter writer) | 保存到TextWriter中      |
                | Save(XmlWriter w)       | 保存到XmlWriter中       |

        - 将XML读入文档
            - Load方法

                | 方法               | 说明                  |
                |------------------|---------------------|
                | Load(Stream)     | 从指定的流加载XML文档        |
                | Load(String)     | 从指定的URL加载XML文档      |
                | Load(TextReader) | 从指定的TextReader加载XML |
                | Load(XmlReader)  | 从指定的XmlReader加载XML  |

            - LoadXML方法
            LoadXML(string)：从字符串中读取XML
