namespace OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            #region Q1 Object Copying
            #region a) What happens when you assign one object variable to another object variable?
            /*
             * It takes a copy of it, and the difference lies in the type of data 
             * because some will take the value and others will point to the reference.
             */
            #endregion

            #region b) Does assigning one object to another create a new object? Explain.
            // No. Assigning one object to another usually does not create a new object.
            // Instead, both variables refer to the same object.
            #endregion

            #region c) What is the difference between copying an object and copying its reference?
            /*
             * * copying   => take a copy of the value, and when you modify it, 
                              only the copy is modified, and the original remains as is.

             * * reference => You take a copy of the reference, and when making changes, 
                              the changes are made to both the copy and the original.
             */
            #endregion
            #endregion
            #endregion
        }
    }
}
