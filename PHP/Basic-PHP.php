<?php
// Defining variables
$x = 16;
$y = -3.5;

// Square root
$squareRoot = sqrt($x);
echo "Square root of $x = $squareRoot\n";

// Absolute value
$absoluteValue = abs($y);
echo "Absolute value of $y = $absoluteValue\n";

// Sine (angle in radians)
$angle = pi() / 6; // 30 degrees
$sinValue = sin($angle);
echo "Sine of 30 degrees (pi/6 radians) = $sinValue\n";

// Cosine (angle in radians)
$cosValue = cos($angle);
echo "Cosine of 30 degrees (pi/6 radians) = $cosValue\n";

// Tangent (angle in radians)
$tangentValue = tan($angle);
echo "Tangent of 30 degrees (pi/6 radians) = $tangentValue\n";

// Natural logarithm
$logValue = log($x); // By default, natural logarithm (base e)
echo "Natural logarithm of $x = $logValue\n";

// Logarithm base 10
$log10Value = log10($x);
echo "Base 10 logarithm of $x = $log10Value\n";

// Generating a random integer in a range
$min = 1;
$max = 100;
$randomValue = rand($min, $max);
echo "Random integer from $min to $max = $randomValue\n";

// Rounding up
$ceilValue = ceil($y);
echo "Rounding $y up = $ceilValue\n";

// Rounding down
$floorValue = floor($y);
echo "Rounding $y down = $floorValue\n";

// Rounding to the nearest integer
$roundValue = round($y);
echo "Rounding $y to the nearest integer = $roundValue\n";
?>
