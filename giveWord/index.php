<?php
    $wordlist = fopen("wordlist","r");
    $wordArray = array();
    while(!feof($wordlist))
    {
        $str = fgets($wordlist);
        if(strlen($str)>0)
        {
            $line = explode("\t",$str);
            $wordArray[$line[0]] = array($line[1],$line[2]);
        }
    }
    fclose($wordlist);
    //一天有86400s，+1s！
    $unixTime = time();
    $unixStart = 1609286400;  //2020-12-30
    $day = (($unixTime-$unixStart)-($unixTime-$unixStart)%86400)/86400;
    //echo $day;
    $nowWords = array();
    $nowWords["day"] = $day;
    if($day*15-45>=0){
        for($i=$day*15-45;$i<$day*15-40;$i++){
            $nowWords[$i] = $wordArray[$i];
        }
    }
    if($day*15-25>=0){
        for($i=$day*15-25;$i<$day*15-20;$i++){
            $nowWords[$i] = $wordArray[$i];
        }
    }
    if($day*15-5>=0){
        for($i=$day*15-5;$i<$day*15;$i++){
            $nowWords[$i] = $wordArray[$i];
        }
    }
    for($i=$day*15;$i<$day*15+15;$i++){
        $nowWords[$i] = $wordArray[$i];
    }
    for($i=$day*15+15;$i<$day*15+20;$i++){
        $nowWords[$i] = $wordArray[$i];
    }
    for($i=$day*15+35;$i<$day*15+40;$i++){
        $nowWords[$i] = $wordArray[$i];
    }
    for($i=$day*15+55;$i<$day*15+60;$i++){
        $nowWords[$i] = $wordArray[$i];
    }
    echo json_encode($nowWords);
?>