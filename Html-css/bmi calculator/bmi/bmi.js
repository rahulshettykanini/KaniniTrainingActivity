function bmicalculator()
{
    var height = document.getElementById('height').value;
    var weight = document.getElementById('weight').value;

    var bmi = weight/ (height*height);
    document.getElementById('bmi').innerHTML = bmi;

    if(bmi < 18.5)
    {
        document.getElementById('result').innerHTML = 'Underweight'
    }
else
    if(bmi < 25)
    {
        document.getElementById('result').innerHTML = 'Healthy'
    }
else 
     if(bmi < 30)
    {
        document.getElementById('result').innerHTML = 'overweight'
    }
else 
    if(bmi > 30)
    {
        document.getElementById('result').innerHTML = 'Obesity'
    }
}