<?php
header('Content-Type: application/json');

// Database connection
$serverName = "sql.bsite.net\\MSSQL2016";
$connectionOptions = [
    "Database" => "waayo69_Clients",
    "Uid" => "waayo69_Clients",
    "PWD" => "kris123asd"
];

$conn = sqlsrv_connect($serverName, $connectionOptions);
if (!$conn) {
    echo json_encode(["error" => "Connection failed."]);
    exit;
}

// Fetch payments with new columns
$sql = "SELECT PaymentName, Amount, DueDate, Status, IsRecurring, RecurrenceFrequency, Category 
        FROM Payments 
        WHERE IsArchived = 0 
        ORDER BY DueDate ASC";

$stmt = sqlsrv_query($conn, $sql);
$payments = [];

if ($stmt) {
    while ($row = sqlsrv_fetch_array($stmt, SQLSRV_FETCH_ASSOC)) {
        $payments[] = [
            'PaymentName' => $row['PaymentName'],
            'Amount' => number_format($row['Amount'], 2),
            'DueDate' => $row['DueDate']->format('Y-m-d'),
            'Status' => $row['Status'],
            'RecurrenceFrequency' => $row['RecurrenceFrequency'] ?? 'None',
            'Category' => $row['Category'] ?? 'Uncategorized'
        ];
    }
    echo json_encode($payments);
} else {
    echo json_encode(["error" => "Error fetching data."]);
}
?>
