var n = [1, 2, 3, 4, 9, 37, 97, 51, -3, 0];
var prime = false;

for (var i = 0; i < n.length; i += 1)
{
    prime = false;
    if(n[i] > 1)
    {
        prime = true;
        for(var j = 2; j <= Math.sqrt(n[i]); j+=1)
        {
            if(n[i] % j === 0)
            {
                prime = false;
                break;
            }
        }
        
    }
    console.log("n: " + n[i] + "  Prime? -> " + prime);
}