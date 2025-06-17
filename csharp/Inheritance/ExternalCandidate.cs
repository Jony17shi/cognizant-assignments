using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    public class ExternalCandidate
    {
        private string cCandidatecode;
        private string vFirstname;
        private string vLastname;
        private int sitestscore;

        public ExternalCandidate()
        {

            vFirstname = "NotGiven";
            vLastname = "NotGiven";
            cCandidatecode = "NotGiven";
            sitestscore = 0;
        }

        public ExternalCandidate(string c, string f, string l, int m)
        {
            this.vFirstname = c;
            this.vLastname = f;
            this.cCandidatecode = l;
            this.sitestscore = m;
        }

        public virtual void Accept()
        {
            Console.WriteLine("Enter cCandidatecode:-");
            cCandidatecode = Console.ReadLine();
            Console.WriteLine("Enter vfirstname:-");
            vFirstname = Console.ReadLine();
            Console.WriteLine("Enter vLastname:-");
            vLastname = Console.ReadLine();
            Console.WriteLine("Enter Sitestscore:-");
            sitestscore = int.Parse(Console.ReadLine());

        }

        public virtual void Accept(string c, string f, string l, int m)
        {
            vFirstname = c;
            vLastname = f;
            cCandidatecode = l;
            sitestscore = m;
        }

        public virtual void Display()
        {

            Console.WriteLine("cCandidatecode:- {0}", cCandidatecode);
            Console.WriteLine("vFirstname:- {0}", vFirstname);
            Console.WriteLine("vLastname:- {0}", vLastname);
            Console.WriteLine("sitestscore:- {0}", sitestscore);
        }
        public string Code
        {
            get { return cCandidatecode; }
            set { cCandidatecode = value; }
        }

        public string FName
        {
            get { return vFirstname; }
            set { vFirstname = value; }
        }

        public string LName
        {
            get { return vLastname; }
            set { vLastname = value; }
        }

        public int TestScore
        {
            get { return sitestscore; }
            set { sitestscore = (byte)value; }
        }

        ~ExternalCandidate()
        {
            cCandidatecode = "";
            vFirstname = "";
            vLastname = "";
            sitestscore = 0;
        }
    }




}