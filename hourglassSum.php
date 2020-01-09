<?php
function hourglassSum($arr)
{
    $sum = -72;
    $sum_arr = array();
    for ($line = 0; $line < 4; $line++) {
        for ($col = 0; $col < 4; $col++) {
            $top = $arr[$line][$col] + $arr[$line][$col + 1] + $arr[$line][$col + 2];
            $middle = $arr[$line + 1][$col + 1];
            $bottom = $arr[$line + 2][$col] + $arr[$line + 2][$col + 1] + $arr[$line + 2][$col + 2];   
            if (($top + $middle + $bottom) > $sum) {
                $sum = $top + $middle + $bottom;
            }
        }
    }
    return $sum;
}
echo hourglassSum(
    array(
        array(1, 1, 1, 0, 0, 0),
        array(0, 1, 0, 0, 0, 0),
        array(1, 1, 1, 0, 0, 0),
        array(0, 0, 2, 4, 4, 0),
        array(0, 0, 0, 2, 0, 0),
        array(0, 0, 1, 2, 4, 0),        
    )
) . PHP_EOL;

echo hourglassSum(
    array(
        array(-9, -9, -9, 1, 1, 1),
        array(0, -9, 0, 4, 3, 2),
        array(-9, -9, -9, 1, 2, 3),
        array(0, 0, 8, 6, 6, 0),
        array(0, 0, 0, -2, 0, 0),
        array(0, 0, 1, 2, 4, 0),        
    )
) . PHP_EOL;

// -6
echo hourglassSum(
    array(
        array(-1, -1, 0, -9, -2, -2),
        array(-2, -1, -6, -8, -2, -5),
        array(-1, -1, -1, -2, -3, -4),
        array(-1, -9, -2, -4, -4, -5),
        array(-7, -3, -3, -2, -9, -9),
        array(-1, -3, -1, -2, -4, -5)
    )
) . PHP_EOL;
// -19
echo hourglassSum(
    array(
        array(0, -4, -6, 0, -7, -6),
        array(-1, -2, -6, -8, -3, -1),
        array(-8, -4, -2, -8, -8, -6),
        array(-3, -1, -2, -5, -7, -4),
        array(-3, -5, -3, -6, -6, -6),
        array(-3, -6, 0, -8, -6, -7),
    )
).PHP_EOL;
