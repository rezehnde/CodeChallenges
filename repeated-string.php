<?php
function repeatedString($s, $n) {
    // check the number of occurrences of letter 'a' on given string $s
    $a_occurrences_in_s = substr_count($s, 'a');

    // check how many occurrences of string $s belongs to an repeated string $s of length of $n
    $s_occurrences_qty = floor($n / strlen($s));

    // get the $s occurrences left
    $s_occurrences_left = $n - ($s_occurrences_qty * strlen($s));

    // left string
    $s_left = substr($s, 0, $s_occurrences_left);

    // 'a' occurrences in left string
    $a_occurrences_in_s_left = substr_count($s_left, 'a');
    
    // occurrencies of 'a' on the entire repeated string of $s with a length of $n
    return ($a_occurrences_in_s * $s_occurrences_qty) + $a_occurrences_in_s_left;
}
// 16481469408
echo repeatedString('epsxyyflvrrrxzvnoenvpegvuonodjoxfwdmcvwctmekpsnamchznsoxaklzjgrqruyzavshfbmuhdwwmpbkwcuomqhiyvuztwvq', 549382313570);
