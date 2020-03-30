namespace DrawShapes
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            // SHAPE A (10 stars in a single row)
            //
            // **********
            //

            for (int number = 1; number < 11; number++)
            {
                DrawingTool.DrawOneStar();
            }

            // SHAPE B (5 stars in a single row, separated by spaces)
            //
            // * * * * * 
            //
            System.Console.WriteLine();

            for (int number = 1; number < 6; number++)
            {
                DrawingTool.DrawOneStar();
                DrawingTool.DrawOneSpace();
            }

            // SHAPE C  (10 rows of 10 stars each)
            //
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            //
            System.Console.WriteLine();
            for (int number = 1; number < 11; number++)
            {
                for (int number2 = 1; number2 < 11; number2++)
                {
                DrawingTool.DrawOneStar();
                }
                for (int number3 = 0; number3 < 1; number3++)
                {
                    DrawingTool.StartNewLine();
                }               
            }


            // SHAPE D (a triangle, I guess...)
            //
            // *
            // **
            // ***
            // ****
            // *****
            // ******
            // *******
            // ********
            // *********
            // **********
            //
            System.Console.WriteLine();
            for (int number = 1; number < 11; number++)
            {
                for (int number2 = 1; number2 < number; number2++)
                {
                DrawingTool.DrawOneStar();
                }
                    for (int number3 = 0; number3 < 1; number3++)
                    {
                    DrawingTool.StartNewLine();
                    }  
            }

            // SHAPE E (X)
            //
            // *        *
            //  *      * 
            //   *    *   
            //    *  *    
            //     **     
            //     **     
            //    *  *    
            //   *    *   
            //  *      * 
            // *        *

            System.Console.WriteLine();
            for (int column = 0; column < 10; column++)
            {
                for (int row = 0; row < 10; row++)
                {
                    if(column == row || column+row == 9)
                        {
                        DrawingTool.DrawOneStar();
                        }
                    else
                        {
                        DrawingTool.DrawOneSpace();
                        }
                    }
                    DrawingTool.StartNewLine();
            }
            // The LAST line of code should be ABOVE this line

        }
    }
}