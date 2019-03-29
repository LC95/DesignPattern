namespace DP.Mediators
{
    /// <summary>
    /// 用一个中介对象封装一系列的对象交互
    /// 中介者使各对象不需要显示地相互作用
    /// 从而使其耦合松散, 而且可以独立地2改变他们之间的交互
    /// </summary>
    public abstract class Mediator
    {
        public ColleagueA ColleagueA { private get; set; }
        public ColleagueB ColleagueB { private get; set; }

        public void Execute()
        {
            ColleagueA.ToString();
            ColleagueB.ToString();
        }
    }


    public abstract class Colleague
    {
        protected readonly Mediator Mediator;

        protected Colleague(Mediator mediator)
        {
            Mediator = mediator;
        }
    }

    public class ColleagueA : Colleague
    {
        public ColleagueA(Mediator mediator) : base(mediator)
        {
            mediator.ColleagueA = this;
        }

        public void DoSomething()
        {
            Mediator.Execute();
        }
    }

    public class ColleagueB : Colleague
    {
        public ColleagueB(Mediator mediator) : base(mediator)
        {
            mediator.ColleagueB = this;
        }

        public void DoSomething()
        {
            Mediator.Execute();
        }
    }
}