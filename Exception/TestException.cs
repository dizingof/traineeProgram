using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class TestException
    {
        public bool Divide(int x, int y)
        {
            var result = 1;
            try
            {
                result = x / y;
                Console.WriteLine($"Rezultat deleniya{result}" );
                return true;
                
            }
        
        catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                result = 0;
                return false;
            }

        catch (System.Exception ex)
            {
                string message = string.Format($"Nepredvidennaya oshibka:{0}", ex.Message);
                Console.WriteLine(message);
                result = 0;
                return false;
            }
            finally
            {
                Console.WriteLine("test");
                Console.WriteLine("Zavershenie programi");
            }
        }
    }
}
