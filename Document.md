<img src="img/rls-bg.jpg" style="width:100%;"/>

### 本仓库贡献人员

[Ranying](https://github.com/Ran-ying)  
[Tolia-GH](https://github.com/Tolia-GH)  
[GreatTyron](https://github.com/GreatTyron)  
[D-benlala](https://github.com/D-benlala)  

### 索引
  - [俄语](Russian%20Language%20Grammar/Grammar%20for%20Russian.md)
  - [物理](Physics/README.md)
  - [化学](Chemistry/README.md)
  - [数学](Math/README.md)
  - [信息](Information/README.md)
  - [历史](History/README.md)
  - [工程制图](Engineering%20graphics/README.md)

### RLS Client

[在此下载 RLS Client](https://github.com/ITMO-Computer-Science-Group/Russian-Language-Studying/releases)

### 内容生产规则

- 一个文档的基本格式，通常包含以下部分，他们都是可选的：
  - Word
  - Grammar
- 文档模板

  ```
  # Title

  - [Grammar](#grammar)
  - [Word](#word)

  ### Grammar

  ### Word

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
    - 前置词请记录到[前置词语法](Russian%20Language%20Grammar/Grammar%20for%20Russian.md#前置词语法)中
    - 要求标注词性，例如“【代】он”