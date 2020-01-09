<?php
function jumpingOnClouds($c) 
{
    $jumps = 0;
    $pos = 0;
    while ($pos < sizeof($c) - 1) {
        if ($c[$pos + 2] == 0) {
            $pos = $pos + 2;
            $jumps++;
         } else if ($c[$pos + 1] == 0) {
            $pos = $pos + 1;
            $jumps++;
        } else {
            break;
        }
    }
    return $jumps;
}
