namespace ControlStructures.Task02RefactoringIfStatements
{
    using System;

    class RefactoringIfStatements
    {
        public static int MIN_X { get; set; }

        public static int MAX_X { get; set; }

        public static int MIN_Y { get; set; }

        public static int MAX_Y { get; set; }

        public static bool notVisitedCell { get; set; }

        private static void Cook(Potato potato)
        {
            throw new NotImplementedException();
        }

        private static void VisitCell()
        {
            throw new NotImplementedException();
        }

        /* The name is named like this because the code inside it is 
        just for the pourpoces of the homework (nothing really meaningful)*/
        public static void SomeIncredibleLogic() 
        {
            Potato potato = new Potato();
            //... 
            if (potato != null)
            {
                if(potato.isPeeled && potato.IsNotRotten)
                {
                    Cook(potato);
                }
            }

            int x = 0;
            int y = 0;
            bool inBorders = (MIN_X <= x && x <= MAX_X) && (MIN_Y <= y && y <= MAX_Y);
            if (inBorders && notVisitedCell)
            {
                 VisitCell();
            }
        }
    }
}
