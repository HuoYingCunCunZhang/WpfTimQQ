using Microsoft.Win32;
using MyDemo.Framwork.MVVM_Test.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo.Framwork.MVVM_Test.ViewModels
{
	/// <summary>
	/// 对应页面上的每一个值都有一个对应的ViewModel
	/// </summary>
    class Window1ViewModel:NotificationObject
    {
		private double input1;

		public double Input1
		{
			get { return input1; }
			set
			{
				input1 = value;
				this.RaisePropertyChanged("Input1");
			}
		}

		private double input2;

		public double Input2
		{
			get { return input2; }
			set
			{
				input2 = value;
				this.RaisePropertyChanged("Input2");
			}
		}
		private double input3;

		public double Input3
		{
			get { return input3; }
			set
			{
				input3 = value;
				this.RaisePropertyChanged("Input3");
			}
		}

		#region 相加操作命令
		/// <summary>
		///	命令属性
		/// </summary>
		public DelegeteCommand AddCommand { get; set; } = new DelegeteCommand();

		private void Add(object paramers)
		{
			this.Input3 = this.input1 + this.input2;
		}
		#endregion

		#region 保存操作命令

		/// <summary>
		/// 命令属性，与界面绑定
		/// </summary>
		public DelegeteCommand SaveCommand { get; set; } = new DelegeteCommand();
		private void Save(object obj)
		{
			SaveFileDialog fd = new SaveFileDialog();
			fd.ShowDialog();
		}
		#endregion
		public Window1ViewModel()
		{
			AddCommand.ExecuteAction += Add;
			SaveCommand.ExecuteAction += Save;
		}

	}
}
