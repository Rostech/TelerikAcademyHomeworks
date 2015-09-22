namespace StatePattern.Models
{
    using System.Text;

    using StatePattern.States;

    internal class Person : IWesen
    {
        internal Person(string name)
        {
            this.Name = name;
            this.State = new NormalState(this);
        }

        internal string Name { get; private set; }

        internal State State { get; set; }
        
        internal double HitPower { get; set; }

        internal double RunSpeed { get; set; }

        internal void GetExited(double exitementLevel)
        {
            this.State.GetExited(exitementLevel);
        }

        public void Transform()
        {
            this.State.Transform();
        }

        public override string ToString()
        {
            StringBuilder personInfo = new StringBuilder();
            personInfo.AppendFormat("Name: " + this.Name);
            personInfo.AppendLine();
            personInfo.AppendFormat("State: " + this.State.GetType().Name);
            personInfo.AppendLine();
            personInfo.AppendFormat("Hit power: " + this.HitPower);
            personInfo.AppendLine();
            personInfo.AppendFormat("Run speed: " + this.RunSpeed);
            personInfo.AppendLine();
            return personInfo.ToString();
        }
    }
}
