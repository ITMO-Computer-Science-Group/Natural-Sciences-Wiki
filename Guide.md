# 官方文档 —— Russian Natural Science Wiki

## Wiki 贡献方式？

我们将 Wiki 的内容完全开源至 [GitHub](https://github.com/ITMO-Computer-Science-Group/Natural-Sciences-Wiki)，您可以通过 GitHub 增添或修改仓库文件来为此 Wiki 做出贡献。

此 Wiki 的内容范围是中国学生在俄罗斯留学时理工科学习的内容，GitHub 仓库实质上相当于一个文件夹，我们将所有专业的所有科目作为其子文件夹，在索引中用专业来划分各个科目。

## 我如何增添或修改内容？

### 新增科目

在 GitHub 仓库根目录下新建一个子文件夹，以学科名称命名即可

### 对科目新增页面

在对应科目的文件夹下新建文件即可

### 编辑内容

在目标页面中按照我们的 [标准](#本仓库的文件标准) 用 [Markdown](#markdown) 和 [LaTeX](#latex) 编写文件即可

### 提交内容

当您完成内容的增添或后，点击 `Commit` 提交，之后交由我们审核即可

### 如果您不了解代码或 GitHub

1. 注册 [GitHub 账号](https://github.com/)
2. 打开 [Wiki 仓库地址](https://github.com/ITMO-Computer-Science-Group/Natural-Sciences-Wiki)
3. 点击 Add file，在下拉选项中点击 `Create new file`
4. 此时您将会看到两个文本框：
    1. 目录文本框：“Natural-Science-Wiki/Name your file in ITMO-Computer-Science-Group:main”，此时将  `Name your file` 改成想要提交的目录位置（如果这个科目还没有被建立），或者在 [Wiki 仓库](https://github.com/ITMO-Computer-Science-Group/Natural-Sciences-Wiki)打开指定的目录，此处即可不用填写。
    2. 文件内容文本框：在这里用 `Markdown` 和 `LaTeX` 编写文件
5. 编写完成后可点击 `Preview` 预览
6. 点击下方的 `Propose new file` （绿色）保存文件
7. 点击 `Create pull request` （绿色）向 Wiki 创建提交请求
8. 在新的页面留下附言、评论或说明，然后点击 `Create pull request` （绿色）
9. 好！接下来等待我们的审核即可！

## 您需要遵守哪些标准？

### 1. 文件标准

当您在创建以及编辑文档时，需要遵守我们的文件标准，我们的文件标准很简单：

- 每个文件必须要有一个文件标题作为文件名称，并以 `.md` 作为文件扩展名
- 文件标题应在文件中用`一级标题`置顶显示
- 内容标题从大标题到小标题，层级从`二级标题`开始依次递减
- 内容使用`无序列表`表示其逻辑，类似于思维导图

我们给出一个一般模板：

样式
># 文件标题
>
>## 第一级内容标题
>
>### 第二级内容标题
>
>- 主干内容
>    - 分支内容
>        - 次级分支内容

源码

    ```
    # 文件标题

    ## 第一级内容标题

    ### 第二级内容标题

    - 主干内容
        - 分支内容
            - 次级分支内容

    ```
标准的具体实现可以参考我们已经做出的文件

### 2. git message 标准

- 对于处于 `ICSG 任务系统` 中的任务提交，

## 您需要了解哪些技术？

### 本 Wiki 网页渲染流程（只需了解即可）

### 1. Markdown

`Markdown` 是一个轻量化的文本排版语言，不同于 Word 等文档排版，Markdown 没有太多的富文本格式，但其内容形式多样，语法简单，并且十分容易上手。  
以下是一个 `GitHub Flavored Markdown` 的简单教程，只收录了和本 Wiki 编辑有关的部分内容。如果想要了解更多，请自行查找 GitHub Flavored Markdown 的相关资料。

- 标题
    - 样例：
        ># 一级标题  
        >## 二级标题  
        >### 三级标题  
        >#### 四级标题  
        >##### 五级标题  
        >###### 六级标题  
    - 源码：
        ```
        # 一级标题  
        ## 二级标题  
        ### 三级标题  
        #### 四级标题  
        ##### 五级标题  
        ###### 六级标题  
        ```
- 正文：无任何语法结构，直接输入即可
- 换行：在一行的结尾加两个空格
- 文字高亮：
    - 样例：`文字`
    - 源码：``` `文字` ```
- 斜体：
    - 样例：*斜体*
    - 源码：`*斜体*`
- 粗体
    - 样例：  **粗体**
    - 源码：  `**粗体**`
- 分割线
    - 样例：
        ___
    - 源码：
        - `___`(为了避免与markdown其他语法重复，一般使用这种)
        - `---`
        
        - `***`
- 表格
    - 一般表格
        - 样例：
            |表头|左对齐|居中|右对齐|
            |----|:----|:----:|----:|
            |内容|内容|内容|内容|
        - 源码：
            ```
            |表头|左对齐|居中|右对齐|
            |----|:----|:----:|----:|
            |内容|内容|内容|内容|
            ```
    - 表格内换行
        - 样例：
            |表头|表头|
            |----|----|
            |内容|内容1 <br> 内容2|
            |内容|内容3 <br> 内容4|
        - 源码：
            ```
            |表头|表头|
            |----|----|
            |内容|内容1 <br> 内容2|
            |内容|内容3 <br> 内容4|
            ```

    - Excel 转换 Markdown 表格：
        - 点击 [https://tableconvert.com/](https://tableconvert.com/)，在上方 import 选择并复制您的 Excel，在下方选择 Markdown 并复制转换得到的 Markdown 语法
    

- 无序列表
    - 样例：本文档即为无序列表样例
    - 源码：
        ```
        - 无序列表的顶级
            - 无序列表的下一级
                - ...
        ```

- 链接
    - 样例：[文字](URL地址)
    - 源码：`[文字](URL地址)`

- 图片
    - 样例：  
        ![文本](img/../../img/example.png)
    - 源码：`![文本](图片地址)`

- 代码
    - 行内代码
        - 样例：`public stativ void main(String[] args) {}`
        - 源码：``` `public stativ void main(String[] args) {}` ```
    - 多行代码
        - 样例：
            ```java
            public class operate {
                public static void main(String[] args) {
                    System.out.println("Hello, World!");
                }
            }
            ```
        - 源码：

                ```java
                public class operate {
                    public static void main(String[] args) {
                        System.out.println("Hello, World!");
                    }
                }
                ```
        

### 2. $\LaTeX$

$\LaTeX$ 是基于 `Tex` 的一个十分强大的文字排版语言，其内容极为丰富，但是语法较为复杂，学习门槛较高，因此我们只取用其公式部分的语法，以弥补原生 Markdown 不支持公式显示的缺陷。  
这里给出了部分常用的 $\LaTeX$ 公式语法，我们使用这种方式在网页上表示公式及符号。

- 公式的插入
    - 行内公式：在正文文本中插入的公式
        - 样例：这是一个 $行内公式$
        - 源码：`这是一个 $行内公式$`
    - 独行公式：独占一行的公式
        - 样例：
        - $$这是一个独行公式$$
        - 源码：
        - `$$这是一个独行公式$$`
    - 多行公式：
        - 样例：
        $$
        \begin{aligned}
        a&=b\\
        &=b\\
        &=c\\
        \end{aligned}
        $$

- 公式中的空格分隔
    - 需要注意的是，在 $\LaTeX$ 源码中的空格不会在公式渲染后显示，一般来说，$\LaTeX$ 源码中的空格仅用于分割代码字段，例如这就是一个例子：
        - 源码：`$这是   一个    公  式$`
        - 效果：$这是   一个    公  式$
    - 如果要使用空格分隔公式内容，有以下写法：
        - 短空行：`\quad`
            - 源码：`$这是\quad一个\quad公\quad式$`
            - 效果：$这是\quad一个\quad公\quad式$
        - 长空行：`\qquad`
            - 源码：`$这是\qquad一个\qquad公\qquad式$`
            - 效果：$这是\qquad一个\qquad公\qquad式$
    - 规范：一般对于公式与其公式编号（如果有的话），之间用 `\qquad` 分隔，对于一般的公式见间隔，使用`\quad`即可，具体根据实际情况判断
    

- 一般公式：

    |名称|效果|源码|
    |-|-|-|
    | 分式 | $\frac{x}{y}$ | \frac{x}{y} |
    | 绝对值 | $\lvert a\rvert$ | \lvert a\rvert |
    | 根号  | $\sqrt{x}$ | \sqrt{x} |
    | 多次根 | $\sqrt[b]{a}$ | \sqrt[b]{a} |
    | 多次方 | $a^{b}$ | a^{b} |
    | 对数 |
    | 积分  | $\int_{a}^{b}$ | \int_{a}^{b} |
    | 求和  | $\sum_{n=1}^{20}$ | \sum_{n=1}^{20} |
    | 极限  | $\underset{x\rightarrow\infty}{\lim}$ | \underset{x\rightarrow\infty}{\lim} |

- 常用符号

    |名称|效果|源码|
    |-|-|-|
    | 无穷 | $\infty$ | \infty |
    | 正负号 | $\pm$ $\mp$ | \pm \mp |
    | 乘号 | $\times$ | \times |
    | 除号 | $\div$ | \div |
    | 点乘号 | $\cdot$ | \cdot |
    | 角度 | $\degree$ | \degree |
    | 单波浪线 | $\sim$ | \sim |
    | 约等于号 | $\approx$ | \approx |
    | 成比例 | $\propto$ | \propto |
    | 大于等于 & 小与等于| $\ge$ $\le$ | \ge \le |
    | 不等于号 | $\neq$ | \neq |
    | 同余号 | $\equiv$ | \equiv |
    | 向右单/双箭头 | $\rightarrow$ $\Rightarrow$ | \rightarrow \Rightarrow |
    | 左右单/双箭头 | $\leftrightarrow$ $\Leftrightarrow$ | \leftrightarrow \Leftrightarrow |
    | 包含于 & 包含 | $\in$ $\ni$ | \in \ni |
    | 任取 | $\forall$ | \forall |
    | 存在 & 不存在 | $\exists$ $\nexists$ | \exists \nexists |
    | 并集 | $\cup$ | \cup |
    | 交集 | $\cap$ | \cap |
    | 补集 | $\complement$ | \complement |

- 希腊字母

    |效果|源码|
    |-|-|
    | $\alpha$ | \alpha |
    | $\Alpha$ | \Alpha |

- 希腊字母名称

    |效果|源码|
    |-|-|
    | Α α    | Alpha  |
    | Β β    | Beta   |
    | Γ γ    | Gamma  |
    | Δ δ    | Delta  |
    | Λ λ    | Lambda |
    | Μ μ    | Mu     |
    | Η η    | Eta    |
    | Θ θ    | Theta  |
    | Ρ ρ    | Rho    |
    | Σ σ    | Sigma  |
    | Φ φ    | Phi    |
    | Ω ω    | Omega  |
    | Π π    | Pi     |

- 上下标

    |效果|源码|
    |-|-|
    | ${xxx}^{bbb}$ | {xxx}^{bbb}        |
    | ${xxx}_{bbb}$ | {xxx}_{bbb}        |
    | $_{bbb}^{ccc}xxx$ | _{bbb}^{ccc}xxx |
    | $_{bbb}xxx$      | _{bbb}xxx       |
    | $^{ccc}xxx$    | ^{ccc}xxx       |


- 在头顶的东西

    |名称|效果|源码|
    |-|-|-|
    || $\hat{x}$   |     \hat{x}     |
    || $\bar{x}$       | \bar{x}             |
    || $\widetilde{x}$ |  \widetilde{x}   |
    | 上划线   |  $\overline{x}$  | \overline{x}        |
    | 下划线   |  $\underline{x}$   | \underline{x}       |
    | 向量     |  $\vec{a}$   | \vec{a}             |
    | 向右向量 |  $\overrightarrow{AB}$      | \overrightarrow{AB} |
    | 向左向量 |  $\overleftarrow{DE}$       | \overleftarrow{DE}  |

- 括号

    |名称|效果|源码|
    |-|-|-|
    | |$\underbrace{jack}_{4}$|\underbrace{jack}_{4}|
    | 一般括号 | $(\frac{\frac{a}{b}}{c})$ | () |
    | 自适应括号 | $\left(\frac{\frac{a}{b}}{c}\right)$ | \left(\right) |

- 三角函数

    |名称|效果|源码|
    |-|-|-|
    | 正弦函数 |$\sin{x}$  | \sin{x} |
    | 余弦函数 | $\cos{x}$ | \cos{x} |
    | 正切函数 | $\tan{x}$ | \tan{x} |
    | 余切函数 | $\cot{x}$ | \cot{x} |
<!--

【信息】Excel 08 + [range]
File: Excel_Task_0.8-2021-03-27.doc
Range: all
Target knowledge File：Information/预科信息.md
target grammar file: ...

-->



## 内容生产规则：

- 一个文档的基本格式，通常包含以下部分，他们都是可选的：
    - Word
    - Grammar
- 文档模板

```
# Title

## Word

| русский                 | 中文              |
|-------------------------|-------------------|

```

- 关于 `Word` 部分
  - 总要求：
    - 记录词的原型
    - 非专有名词首字母不大写
    - 可信度排名：字典>千亿词霸>译酷>谷歌翻译
  - 动词
    - 要求动词不定式，有两个体的，未完成体在完成体前面
    - 要求记录在原文中的接格关系
  - 名词组
    - 具有以下特征的被称为“名词组”
      - 各部分高内聚的，整体与句子其他成分低耦合的
      - 整个词组在中文中有专有名词的
    - 名词组首先要单独记录，其次在可选的情况下，可以将里面的单词分别单独记录
  - 名词
    - 如果名词不在名词组中，直接记录
    - 如果名词在名词组中，可选的记录
  - 形容词
    - 如果形容词在名词组中，可选的记录
    - 如果形容词有接格关系（这通常是由其动词决定的），要求写出形容词的接格关系
  - 副词
    - ~~副词有对应形容词的，只记录对应形容词~~ 我相信没有人能遵守这一条，所以我们不要了
    - 副词没有对应形容词的，记录当前副词，例如“【副】жарко”
  - 其他词
    - 前置词请记录到[前置词语法](../Russian/Grammar%20for%20Russian.md#前置词语法)中
    - 要求标注词性，例如“【代】он”
  - 【】
  - （）