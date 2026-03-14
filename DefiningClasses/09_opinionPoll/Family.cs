namespace DefiningClasses
{
    public class Family
    {
        private List<Person> members;

        public Family()
        {
            this.members = new List<Person>();
        }


        public List<Person> Members
        {
            get
            {
                return this.members;
            }
        }
        public void AddMembers(Person member)
        {
            this.Members.Add(member);
        }

        public string GetOldestPerson()
        {
            var oldest = this.Members.OrderByDescending(x => x.Age).FirstOrDefault();

            //if(oldest == null) return string.Empty;


            return oldest.Name + " " + oldest.Age;
        }
    }
}