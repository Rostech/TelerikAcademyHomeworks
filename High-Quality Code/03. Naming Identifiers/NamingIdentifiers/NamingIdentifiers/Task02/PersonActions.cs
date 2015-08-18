namespace NamingIdentifiers.Task02
{
    internal class PersonActions
    {
        public void MakePerson(int yearsOld)
        {
            Person newPerson = new Person();
            newPerson.Age = yearsOld;
            if (yearsOld % 2 == 0)
            {
                newPerson.Name = "The big brother";
                newPerson.Gender = Gender.Man;
            }
            else
            {
                newPerson.Name = "THe chick";
                newPerson.Gender = Gender.Woman;
            }
        }
    }
}
