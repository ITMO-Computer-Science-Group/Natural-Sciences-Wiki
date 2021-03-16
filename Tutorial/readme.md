# 官方文档 —— Russian Natural Science Wiki

## Wiki 如何工作？

我们将 Wiki 的内容完全开源至 [GitHub仓库](https://github.com/ITMO-Computer-Science-Group/Natural-Sciences-Wiki)，您可以通过修改仓库的内容来为此 Wiki 做出贡献。

此 Wiki 的内容范围是中国学生在俄罗斯留学时理工科学习的内容，GitHub 仓库实质上是一个文件夹，我们将所有专业的所有科目作为子文件夹，在索引中用专业来划分各个科目。

## 我如何增加或修改内容？

### 新增科目

在 GitHub 仓库根目录下新建一个目录即可

### 对科目新增页面

在对应科目的目录新建文件即可

### 添加内容

在目标页面中按照我们的 [标准](#本仓库的文件标准) 用 [Markdown](#markdown) 和 [LaTeX](#latex) 编写文件，并提交至此仓库。

### 您不了解代码或 GitHub

1. 注册 [GitHub 账号](https://github.com/)
2. 打开 [Wiki 仓库地址](https://github.com/ITMO-Computer-Science-Group/Natural-Sciences-Wiki)
3. 点击 Add file，在下拉选项中点击 Create new file
4. 此时您将会看到两个文本框：
   1. 目录文本框：“Natural-Science-Wiki/Name your file in ITMO-Computer-Science-Group:main”，此时将 `Name your file` 改成想要提交的目录位置（如果这个科目还没有被建立），或者在 [Wiki 仓库](https://github.com/ITMO-Computer-Science-Group/Natural-Sciences-Wiki)打开指定的目录，此处即可不用填写。
   2. 文件内容文本框：在这里用 Markdown 和 LaTeX 编写文件
5. 编写完成后可点击 Preview 预览
6. 点击下方的 Propose new file （绿色）保存文件
7. 点击 Create pull request （绿色）向 Wiki 创建提交请求
8. 在新的页面留下附言、评论或说明，然后点击 Create pull request （绿色）
9. 好！等待我们的审核即可！

## 我需要掌握哪些技术？

### 本仓库的文件标准

我们的标准很简单：
- 每个文件必须要有一个文件标题
- 内容标题从大标题到小标题，标题层级从二依次递减
- 内容使用无序列表表示其逻辑

我们给出一个模板：

```
# 文件标题

## 第一级内容标题

### 第二级内容标题

- 内容
    - 内容
        - 内容

```

### Markdown

这是一个 GitHub Flavored Markdown 的简单教程，只取了部分和 Wiki 编辑有关的内容。Markdown 不同于 Word 等软件，他没有太多的富文本格式。

- 换行：在一行的结尾加两个空格
- 文字高亮（反斜杠，在键盘左上角）：\`文字\`
- 斜体：\*斜体\*
- 粗体：\*\*粗体\*\*
- 删除线：\~\~删除线\~\~
-  标题
    ```
    # 一级标题
    ## 二级标题
    ### 三级标题
    #### 四级标题
    ##### 五级标题
    ###### 六级标题
    ```
- 表格
    - 标准 Markdown 语法：
        ```
        |表头|左对齐|居中|右对齐|
        |----|:----|:----:|----:|
        |内容|内容|内容|内容|
        ```
    - Excel 转换成 Markdown 表格：
        - 点击 [https://tableconvert.com/](https://tableconvert.com/)，在上方 import 选择并复制您的 Excel，在下方选择 Markdown 并复制转换得到的 Markdown 语法
- 块引用
    ```
    >
    >>
    >>>
    >>>>
    >>>>>
    >>>>>>
    ```
- 无序列表
    ```
    - 无序列表的顶级
        - 无序列表的下一级
            - ...
    ```
- 链接
    ```
    [文字](URL地址)
    ```


### LaTeX

这里给出了部分 LaTeX 的公式语法，我们使用 LaTeX 在网页上表示复杂公式。（搞理工的应该都知道 LaTeX）

- 一般公式：

    |名称|效果|源码|
    |-|-|-|
    | 分式  | $\frac{x}{y}$                      | \frac{x}{y}     |
    | 根号  | $\sqrt{x}$                           | \sqrt{x}        |
    | 多次根 | $\sqrt[b]{a}$                      | \sqrt[b]{a}     |
    | 多次方 | $a^{b}$                              | a^{b}           |
    | 积分  | $\int_{a}^{b}$                     | \int_{a}^{b}    |
    | 求和  | $\sum_{n=1}^{20}$               | \sum_{n=1}^{20} |
    | 极限  | $\underset{x\rightarrow\infty}{\lim}$  | \underset{x\rightarrow\infty}{\lim} |

- 运算符号

    |效果|源码|
    |-|-|
    | $\times$    | \times |
    | $\div$    | \div    |
    | $\cdot$  | \cdot   |
    | $\approx$ | \approx |
    | $\neq$    | \neq    |
    | $\equiv$  | \equiv  |

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
    ||$\underbrace{jack}_{4}$|\underbrace{jack}_{4}|