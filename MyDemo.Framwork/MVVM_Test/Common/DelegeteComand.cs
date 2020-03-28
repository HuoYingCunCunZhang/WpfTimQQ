using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyDemo.Framwork.MVVM_Test.Common
{
    /// <summary>
    /// 传递操作命令
    /// </summary>
    class DelegeteCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            
            return CanExcuteFun == null? true:CanExcuteFun.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            ExecuteAction?.Invoke(parameter);
        }

        public Action<object> ExecuteAction { get; set; }
        public Func<object,bool> CanExcuteFun { get; set; }

    }
}
