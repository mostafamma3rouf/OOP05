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

            #region Q2 Shallow Copy vs Deep Copy
            #region a) What is a Shallow Copy?
            // create a new object and copies all value type fields, references type: only the references are copied
            #endregion

            #region b) What is a Deep Copy?
            // create a new object and recursively copies all nested objects
            #endregion

            #region c) What happens to reference-type members when a Shallow Copy is created?
            /*
             * When a shallow copy is created, their references are copied
             * so both the original and copied object refer to the same referenced objects
             */
            #endregion

            #region d) What happens to reference-type members when a Deep Copy is created?
            // When a deep copy is created, new copies of the referenced objects are also created.
            #endregion

            #region e) Give one situation where Deep Copy would be safer than Shallow Copy.
            // when copying a object that contains a mutable address object
            #endregion
            #endregion

            #region Q3 Static Members
            #region a) What is a static field, and how is it different from an instance field?
            /*
             * a static field is a field that belongs to the class itself
             * an instance field belongs to a specific object of the class
             */
            #endregion

            #region b) What is a static method? Can a static method directly access instance members?
            /*
             * a static method is a method that belongs to the class itself.
             * No, cannot directly access instance fields or methods 
               because it does not belong to a particular object.
             */
            #endregion

            #region c) What is a static constructor, and when is it executed?
            /*
             * a static constructor is a special constructor used to initialize static fields 
               or other static data of a class.

             * is executed automatically once.
             */
            #endregion

            #region d) What is a static class? Can you create an object from a static class?
            /*
             * is a class that cannot be instantiated and is designed to contain only static members.
             * No, cannot create an object of a static class.
             */
            #endregion
            #endregion

            #region Q4 Extension Methods
            #region a) What is an Extension Method?
            // method that allows you to add new functionality to an existing type without modifying
            // its original source code or creating a derived class.
            #endregion
            #endregion
            #endregion
        }
    }
}
