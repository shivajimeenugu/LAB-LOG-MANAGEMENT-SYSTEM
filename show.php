<?php include("auth.php"); ?>
<!DOCTYPE html>
<html>
<head>
<style>
@page {
  /*margin: 2mm*/
}

@media screen {
  div.divFooterms {
    display: none;
  }
}
@media print {
  div.divFooterms {
    position: fixed;
    bottom: 0;
  }
}
</style>
<meta charset="utf-8">
<link rel="stylesheet" href="w3.css">
<meta name="viewport" content="width=device-width, initial-scale=1">
<title><?php echo 'DATA-logs-'.date("Ymd") ; ?></title>

</head>
<body  >
     <div class="w3-sidebar w3-bar-block w3-card w3-animate-left" style="display:none" id="mySidebar">
                             <button onclick="w3_close()" class="w3-bar-item w3-button w3-large">Close &times;</button>
                                       <a class="w3-bar-item w3-button" href="index.php">HOME</a>
                                       <a class="w3-bar-item w3-button" href="dashboard.php">DASHBOARD</a>
                                       <a class="w3-bar-item w3-button" href="logout.php">LOGOUT</a>
            </div> 


<div class="w3-container w3-animate-right" id="main">
<?php include 'header.php';?>


<br/>
     



<?php
include 'db.php';

$query='';
$count=1;
$output = '';
//SELECT * FROM call_mgmt_table WHERE date BETWEEN #'$from_date'# AND #'$to_date'#
$query = "SELECT * FROM lablog_table order by id desc ";
$result = mysqli_query( $con, $query);
$row_count=mysqli_num_rows($result);
echo '
	


<br/>
	<table style="border-collapse: collapse; border: 1px solid black;" class="w3-responsive w3-table-all">
						<thead>
					<tr class="w3-indigo">						
<th>SI.NO</th>							

							

<th>ID</th>
							
<th>STUDENT NAME</th>
<th >STUDENT PIN</th>
<th >SYSTEM NAME</th>
<th >IP</th>
<th >LAB</th>
<th >NO OF PERIODS</th>
<th >START DATE</th>
<th >START TIME</th>
<th >END DATE</th>
<th >END TIME</th>
				</tr>
				
				</thead>
				<tbody>
				
				
				
				
				';
if(mysqli_num_rows($result) > 0)
	{
	
	echo '';
$row_span_flag=1;		
		
while($row = mysqli_fetch_array($result))
	{
		echo'
			<tr class="w3-hover-grey ">';
			
			?>
			
	
	
<td align="center"><?php echo $count; ?></td>
<td align="center"><?php echo $row["id"]; ?></td>
<td align="center"><?php echo $row["student_name"]; ?></td>
<td align="center"><?php echo $row["student_pin"]; ?></td>
<td align="center"><?php echo $row["system_name"]; ?></td>
<td align="center"><?php echo $row["ip"]; ?></td>
<td align="center"><?php echo $row["reason"]; ?></td>
<td align="center"><?php echo $row["period_count"]; ?></td>
<td align="center"><?php echo $row["log_date"]; ?></td>
<td align="center"><?php echo $row["log_time"]; ?></td>
<td align="center"><?php echo $row["end_date"]; ?></td>
<td align="center"><?php echo $row["end_time"]; ?></td>
		</tr>
		<?php
		$count++;
		
	}
	
}
else
{
	
	echo '<h1 class="w3-red">NO LOGS</h1>';
	
}


?>

</tbody>
</table>
<br/><br/>
<br/><br/>
<br/>



<!--<script>window.print();</script>-->
<center><button class="w3-button w3-red" onclick="window.print()">PRINT</button></center>




<?php include 'footer.php';?>
	   
	   </div>
<script>
function w3_open() {
  document.getElementById("main").style.marginLeft = "25%";
  document.getElementById("mySidebar").style.width = "25%";
  document.getElementById("mySidebar").style.display = "block";
  document.getElementById("openNav").style.display = 'none';
}
function w3_close() {
  document.getElementById("main").style.marginLeft = "0%";
  document.getElementById("mySidebar").style.display = "none";
  document.getElementById("openNav").style.display = "inline-block";
}
</script>
</div>
 </body>



</html>
