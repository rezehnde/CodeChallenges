function rotLeft($a, $d) {
    $i = 0;
    $m = $d;
    if ($d > sizeof($a)) {
        $m = ($d % sizeof($a));
    }
    while ($i < $m) { 
        $a[] = $a[$i];
        $i++;
    }
    array_splice($a, 0, $m);
    return implode(' ', $a);
}
echo rotLeft(array(1, 2, 3, 4, 5), 4);
