﻿String[] OrderIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach(String orderID in OrderIDs) {
    if(orderID.StartsWith("B")) {
        Console.WriteLine(orderID);
    }
}