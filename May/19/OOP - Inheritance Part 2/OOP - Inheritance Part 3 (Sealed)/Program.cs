namespace OOP___Inheritance_Part_3__Sealed_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             object => Person =>
                                    Employee
                                    Teacher X
                                    Student X
             */

            #region Protected access modifier
            /*
             public: istər proyektin içindən və ya kənarından obyekti əlçatan edir.
             private: bir member'i private təyin etdiyimiz zaman ancaq olduğu class daxilində istifadə edə bilərik.
             protected: protected normalda private kimi davranır. Bir memberi protected etdiyim zaman, onu ancaq
                        olduğu class daxilində istifadə edə bilərəm. Ancaq həmin class'dan bir başqa class miras
                        alarsa o zaman miras alan class üçün public kimi davranacaq.
             NOT: bir class nə private nə də protected təyin edilə bilməz.
             */
            
            Person p2 = new Person();
            p2.ReachProtectedMethod();

            Student st2 = new Student();
            st2.ReachProtectedMethod();
            #endregion
        }
    }
}
