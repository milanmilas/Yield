using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr= new Program();
            //pr.CalcAsyn();
        }

        //public async Task<int> CalcAsyn()
        //{
        //    return await Calculate();
        //}

        //public Task<int> Calculate()
        //{
        //    Thread.Sleep(1000);
        //    return Task.Factory.StartNew<int>(() => {return 1;});
        //}

        public IEnumerable<int> GetResult()
        {
            for (int i = 0; i < 2; i++)
            {
                yield return i;
            }

            for (int i = 0; i < 3; i++)
            {
                yield return i;
            }


        }

        //public IEnumerable<int> GetFibonachiSequence()
        //{
        //    yield return 1;
        //    yield return 2;
        //}

    }


//namespace Yield
//{
//    internal class Program
//    {
//        [CompilerGenerated]
//        [StructLayout(LayoutKind.Auto)]
//        private struct CalcAsyn_d__0 : IAsyncStateMachine
//        {
//            public int s1__state;
//            public AsyncTaskMethodBuilder<int> t__builder;
//            public Program p4__this;
//            private TaskAwaiter<int> u__awaiter1;
//            private object t__stack;
//            void IAsyncStateMachine.MoveNext()
//            {
//                int result;
//                try
//                {
//                    int num = this.s1__state;
//                    TaskAwaiter<int> taskAwaiter;
//                    if (num != 0)
//                    {
//                        taskAwaiter = this.p4__this.Calculate().GetAwaiter();
//                        if (!taskAwaiter.IsCompleted)
//                        {
//                            this.s1__state = 0;
//                            this.u__awaiter1 = taskAwaiter;
//                            this.t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, Program.CalcAsyn_d__0>(ref taskAwaiter, ref this);
//                            return;
//                        }
//                    }
//                    else
//                    {
//                        taskAwaiter = this.u__awaiter1;
//                        this.u__awaiter1 = default(TaskAwaiter<int>);
//                        this.s1__state = -1;
//                    }
//                    int arg_77_0 = taskAwaiter.GetResult();
//                    taskAwaiter = default(TaskAwaiter<int>);
//                    result = arg_77_0;
//                }
//                catch (Exception exception)
//                {
//                    this.s1__state = -2;
//                    this.t__builder.SetException(exception);
//                    return;
//                }
//                this.s1__state = -2;
//                this.t__builder.SetResult(result);
//            }
//            [DebuggerHidden]
//            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine param0)
//            {
//                this.t__builder.SetStateMachine(param0);
//            }
//        }
//        private static void Main(string[] args)
//        {
//            Program pr = new Program();
//            pr.Calculate();
//        }
//        [DebuggerStepThrough, AsyncStateMachine(typeof(Program.CalcAsyn_d__0))]
//        public Task<int> CalcAsyn()
//        {
//            Program.CalcAsyn_d__0 CalcAsyn_d = new CalcAsyn_d__0();
//            CalcAsyn_d.p4__this = this;
//            CalcAsyn_d.t__builder = AsyncTaskMethodBuilder<int>.Create();
//            CalcAsyn_d.s1__state = -1;
//            AsyncTaskMethodBuilder<int> t__builder = CalcAsyn_d.t__builder;
//            t__builder.Start<Program.CalcAsyn_d__0>(ref CalcAsyn_d);
//            return CalcAsyn_d.t__builder.Task;
//        }
//        public Task<int> Calculate()
//        {
//            Thread.Sleep(1000);
//            return Task.Factory.StartNew<int>(() => 1);
//        }
//    }
//}

}
