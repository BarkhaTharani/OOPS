using OOPSConcepts.Composition;

namespace OOPSConcepts {
    public class Project {
        private Manager mgr;

        private bool isSuccess;
        
        public Project (Manager mgr) {
            this.mgr = mgr;
        }

        public bool IsSuccess {
            get { return isSuccess; }
            set {
                isSuccess = value;
                if (value) {
                    this.mgr.salary++;
                    System.Console.WriteLine ("salary incremented " + this.mgr.salary);
                } else {
                    this.mgr.salary--;
                    System.Console.WriteLine ("salary decremented " + this.mgr.salary);
                }
            }
        }

    }
}