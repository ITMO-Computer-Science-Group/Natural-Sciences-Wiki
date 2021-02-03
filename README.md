<!--
上标：º ¹ ² ³ ⁴ ⁵ ⁶ ⁷ ⁸ ⁹ ⁺ ⁻ ⁼ ⁽ ⁾ ⁿ ′ ½
下标：₀ ₁ ₂ ₃ ₄ ₅ ₆ ₇ ₈ ₉ ₊ ₋ ₌ ₍ ₎
重音：а́ о́ е́ и́ я́ у́ ю́ ы́ э́
-->
<img src="img/rls-bg.jpg" style="width:100%;cursor:none;"/>

### 索引
- 各学科
  - [俄语](Russian%20Language%20Grammar/Grammar%20for%20Russian.md)
  - [物理](Physics/readme.md)
  - [化学](Chemistry/readme.md)
  - [数学](Math/readme.md)
  - [信息学](Information/readme.md)
- 文档
  - [内容生产-消费模型](#内容生产-消费模型)
  - [内容生产规则](#内容生产规则)
  - [民主生活会](https://github.com/Ran-ying/Russian-Language-Studying/issues)
- 内容消费
  - [Daily Words](https://www.ranying.xyz/api/Daily-Words/)
  - [search](https://www.ranying.xyz/api/Daily-Words/search.html)

### 内容生产-消费模型

- 内容生产
  - contributing content
    - 双检验模式
    - 双冗余模式
    - 三冗余模式
  - history content
    - ~~待定~~
- 内容消费
  - Word 部分由 [Daily Words](https://www.ranying.xyz/api/Daily-Words/) 进行消费
  - Expression 的 形式部分 由 民主生活会 进行消费

### 内容生产规则

0. 一个文档的基本格式，通常包含以下部分，他们都是可选的：
  - Notice
  - Word
  - Expression

```
Content

- [Notice](#Notice)
- [Word](#Word)
- [Expression](#Expression)

### Notice

### Word

| русский                 | 中文              |
|-------------------------|-------------------|

### Expression
```
1. 关于 `Word` 部分
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
    - 副词有对应形容词的，只记录对应形容词
    - 副词没有对应形容词的，记录当前副词，例如“【副】жарко”
  - 其他词
    - 前置词请记录到[前置词语法](Russian%20Language%20Grammar/Grammar%20for%20Russian.md#前置词语法)中
    - 要求标注词性，例如“【代】он”

2. 关于 `Expression` 部分
  - 此部分用于记录中文的内容在俄语表达，或无法在 Word 里表示的内容。
  - 推荐的完成范例是[分数与小数](Math/Занятие-4-5-分数与小数.md#Expression)
  - 在Expression里的所有东西都要用无序列表表示其归属

