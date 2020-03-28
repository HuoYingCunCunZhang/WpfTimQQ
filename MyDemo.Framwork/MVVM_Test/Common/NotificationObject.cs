using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo.Framwork.MVVM_Test.Common
{
    /// <summary>
    /// 传递数据
    /// </summary>
    class NotificationObject : INotifyPropertyChanged
    {
        /// <summary>
        /// 数据绑定要监听的事件
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 封装上面数据绑定监听的事件，便于调用
        /// </summary>
        /// <param name="propertyName"></param>
        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
        }
    }
}
