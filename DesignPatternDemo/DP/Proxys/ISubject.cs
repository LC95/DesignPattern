namespace DP.Proxys
{
    public interface ISubject
    {
        void DoSomething();
    }

    public class RealSubject : ISubject
    {
        public void DoSomething()
        {
            //DO SOMETHING
        }
    }

    public class ProxySubject : ISubject
    {
        private readonly ISubject _subject;

        public ProxySubject(ISubject subject)
        {
            _subject = subject;
        }

        public void DoSomething()
        {
            _subject.DoSomething();
        }
    }
}