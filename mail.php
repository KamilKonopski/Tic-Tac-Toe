<?php

$to = 'Kamil.Konopski.2000@gmail.com';
$name = $_POST['name'];
$email = $_POST['email'];
$subject = 'Nowy email od ' . $name . ' < ' . $email . ' >';
$message = $_POST['message'];
$headers = 'From: ' . $name . ' < ' . $email . ' >';
$header .= "Content-Type: text/html; charset=utf-8\r\n";

mail($to, $subject, $message, $headers);
?>
