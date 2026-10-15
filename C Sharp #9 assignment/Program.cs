namespace C_Sharp__9_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Question

            //Q1/ they both will hold the same reference
            //Q2/ no it doesn't create a new object since it will point to the same object since they both hold the same reference
            //Q3/ coping the object creates a new object that holds the same values but a different reference while copying the reference will point to the same object in memory

            #endregion

            #region Second Question

            //Q1/ shallow copy copies the values of the object and the references of the reference types
            //Q2/ deep copy copies the values of the object and creates new objects for the reference types
            //Q3/ it copies the references so it will point to the same object
            //Q4/ it creates new object for the references
            //Q5/ when dealing with an abject that has reference types so when the object is copied the new copy will hold new references for the reference types so when a change is required it will not affect the original object

            #endregion

            #region Third Question

            //Q1/ static field its values is shared among all instances while instance field its values is unique to each instance
            //Q2/ static methods is method that can be called without creating an instance of the class, no it cannot.
            //Q3/ static constructor is called once only before the call of any other constructor and only initializes static fields,it is excuted once creating an instance of the class for the first time
            //Q4/static class is a class that can't create an instance from it,no it is not possible

            #endregion
        }
    }
}
