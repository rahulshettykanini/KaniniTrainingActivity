
function  billCalculation() {
    

    var vegadult = document.getElementById('vegAdult').value;
    var vegkids = document.getElementById('vegKids').value;
    var nonvegadult = document.getElementById('nonVegAdult').value;
    var nonvegkids = document.getElementById('nonVegKids').value;  
   var total = parseInt(vegadult) + parseInt(vegkids) + parseInt(nonvegadult) + parseInt(nonvegkids);
    var totalcost = (599 * vegadult) + (249 * vegkids) + (699 * nonvegadult) + (349 * nonvegkids);
    var gst= (totalcost *12)/100;
   
    var netcost = totalcost + gst;
    if(total >= 10)
    {
       var discount  = (netcost * 10)/100;
       var net = netcost -discount;
    }
    else
    {
       var net = netcost;
    }
   
    var custname = document.getElementById('customerName').value;
   
    document.getElementById('result').innerHTML ='Hai ' + custname+', You have to pay Rs. '+net +'. Thanks for coming!!!';
   return false;
   }
   