

namespace DefiningClassesPart2
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Runtime.InteropServices;
    

    /*
     11. Version attribute

        Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods and holds a version in the format major.minor (e.g. 2.11).
        Apply the version attribute to a sample class and display its version at runtime.

    */
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface
        , AllowMultiple = true)]

    public class VersionAttribute : System.Attribute
    {
        private string version;
        private string subVersion;

        public VersionAttribute(string v, string sBv = null)
        {
            if(sBv != null)
            {
                this.SubVersion = sBv;
                this.Version = v;
            }
            else
            {
                this.Version = v;
                this.SubVersion = "0.0";
            }
        }

        public string Version
        {
            get
            {
                return this.version;
            }
            private set
            {
                this.version = value;
            }
        }

        public string SubVersion
        {
            get
            {
                return this.subVersion;
            }
            private set
            {
                this.subVersion = value;
            }
        }
    }
}
