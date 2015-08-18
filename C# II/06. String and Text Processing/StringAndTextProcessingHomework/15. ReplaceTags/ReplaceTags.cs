using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ReplaceTags
{
    class ReplaceTags
    {
        /*
          15. Replace tags

            Write a program that replaces in a HTML document given as 
            string all the tags <a href="…">…</a> with corresponding
            tags [URL=…]…/URL].

          
          Example:
            input 	                                                      output
            <p>Please visit <a href="http://academy.telerik. com">      <p>Please visit [URL=http://academy.telerik. com]                                                          
            our site</a> to choose a training course.                   our site[/URL] to choose a training course. 
            Also visit <a href="www.devbg.org">our forum</a>            Also visit [URL=www.devbg.org]our forum[/URL] to
             to discuss the courses.</p> 	                            discuss the courses.</p>    
        */
        static void Main(string[] args)
        {
            string text = 
@"<p>Please visit <a href=""http://academy.telerik. com"">
our site</a> to choose a training course.             
Also visit <a href=""www.devbg.org"">our forum</a>      
to discuss the courses.</p> ";
            Console.WriteLine("INPUT:");
            Console.WriteLine(text);
            text = text.Replace("<a href=\"", "[URL=");
            text = text.Replace("</a>", "[/URL]");
            text = text.Replace("\">", "]");
            Console.WriteLine("\nOUTPUT:");
            Console.WriteLine(text);
        }   
    }       
}           
