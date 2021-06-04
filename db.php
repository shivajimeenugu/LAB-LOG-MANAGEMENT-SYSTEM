<?php




$con = mysqli_connect("localhost","root","","lablog");
// Check connection
if (mysqli_connect_errno())
  {
  echo "Failed to connect to MySQL: " . mysqli_connect_error();
  }
?>