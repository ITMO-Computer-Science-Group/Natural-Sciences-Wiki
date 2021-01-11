# Russian-Language-Studying

[Rules](#rules)
[背诵今日单词](https://www.ranying.xyz/apis/russianWord/getWord.html)  

### Rules

0. 一个文档的基本格式，通常包含以下部分，他们都是可选的：
  - Notice
  - Word
  - Expression

```
Content

- [Notice](#Notice)
- [Word](#word)
- [Expression](#expression)

### Notice
### Word
### Expression
```
1. 关于 `Word` 部分
  - 动词
    - 要求动词不定式，有两个体的，未完成体在完成体前面
    - 要求记录在原文中的接格关系或与原文中的接格关系更全面的接格关系
  - 名词组：
    - 具有以下特征的被称为“名词组”
      - 各部分高内聚的，整体与句子其他成分低耦合的
      - 整个词组在中文中有专有名词的
    - 名词组首先要单独记录，其次在可选的情况下，可以将里面的单词分别单独记录
  - 名词
    - 要求记录名词原型
    - 如果名词不在名词组中，直接记录
    - 如果名词在名词组中，可选的记录
  - 形容词
    - 要求记录形容词原型
    - 如果形容词在名词组中，可选的记录
    - 如果形容词有接格关系（这通常是由其动词决定的），要求写出形容词的接格关系
  - 副词
    - 副词有对应形容词的，只记录对应形容词
    - 副词没有对应形容词的，记录当前副词，例如“【副】жарко”
  - 其他词
    - 前置词请记录到[前置词语法](Russian%20Language%20Grammar/Grammar%20for%20Russian.md#前置词语法)中
    - 要求标注词性，例如“【代】он”

2. 关于 `Expression` 部分
  - 此部分用于记录俄文的中文表达，抑或称之为用普通高中课程标准解释的俄罗斯地域的解题格式，请参考[语言本地化 -Wikipedia](https://zh.wikipedia.org/zh-hans/%E8%AF%AD%E8%A8%80%E6%9C%AC%E5%9C%B0%E5%8C%96)和[翻译和产品本地化的区别是什么？](https://sspai.com/post/59945)
  - 推荐的完成范例是[俄文中的分数与小数在俄文中的表达](Math/Занятие-4-5-分数与小数.md#Expression)
  - 在Expression里的所有东西都要用无序列表表示其归属，例如
```
### Expression

- Word
|1|1|
|-|-|
|1|2|

- Jack

- Tom
```